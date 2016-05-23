Public Class formMain
    Private Const tableNumberMax As Integer = 2
    Dim tables(tableNumberMax) As Table
    Private tableButtons As New List(Of Button)
    Private activeTable As Table
    Friend updatedTable As Table
    Friend Property cashbox As Double
        Get
            Return My.Settings.cashbox
        End Get
        Set(ByVal value As Double)
            My.Settings.cashbox = value
            lblCashbox.Text = cashbox.ToString("$0.00")
        End Set
    End Property

    Private inventory As New List(Of InventoryItem)
    Private orderButtons As New List(Of Button)
    Private orderButtonBack As Button
    Private orderButtonForward As Button
    Private orderButtonPage As Integer = 1
    Private Const orderButtonsPerPage As Integer = 23
    Private Function orderButtonPageMax() As Integer
        Return Math.Ceiling(inventory.Count / orderButtonsPerPage)
    End Function

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'init tables
        For n = 1 To tableNumberMax
            Dim table As New Table(n)
            tables(n) = table

            Dim tableButtonName As String = "TableButton" & n
            Dim tableButton As Button = tabpageHall.Controls(tableButtonName)
            tableButton.Tag = n
            tableButtons.Add(tableButton)
        Next


        'restore tables from hall.txt
        For Each Table In fileParser.GetTables()
            tables(Table.number) = Table
        Next
        LoadHall()


        'init inventory & orderButtons
        inventory = fileParser.GetInventory
        For y = 0 To 4
            For x = 0 To 4
                CreateOrderButton(x, y)
            Next
        Next
        LoadOrderButtons()


        'set activeTable default
        activeTable = tables(1)
        LoadActiveTable()


        'update labels and other cosmetics
        cashbox += 0
        dgvOrders.Font = New Font("Arial", 9)
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If TabControl1.SelectedTab.Equals(tabpageTable) = False Then Exit Sub
        If dgvOrders.SelectedCells Is Nothing OrElse dgvOrders.SelectedCells(0) Is Nothing Then Exit Sub

        Select Case e.KeyCode
            Case Keys.F1 : ButtonQty_Click(Nothing, Nothing)
            Case Keys.F2 : ButtonPrice_Click(Nothing, Nothing)
            Case Keys.F3 : ButtonTime_Click(Nothing, Nothing)
        End Select
    End Sub
    Private Sub LoadOrderButtons()
        Dim min As Integer = (orderButtonPage - 1) * orderButtonsPerPage
        Dim max As Integer = Math.Min(min + 23, inventory.Count - 1)
        Dim itemIndex As Integer = min
        For n = 0 To orderButtons.Count - 1
            Dim button As Button = orderButtons(n)
            If itemIndex <= max Then
                Dim item As InventoryItem = inventory(itemIndex)
                button.Text = item.name
                button.Enabled = True
                button.BackColor = Color.WhiteSmoke
                button.Tag = item
                tt.SetToolTip(button, item.description)
                itemIndex += 1
            Else
                button.Text = ""
                button.Enabled = False
                button.BackColor = Color.LightGray
                button.Tag = Nothing
            End If
        Next

        'dis/enable forward and back buttons
        If orderButtonPage = orderButtonPageMax() Then
            orderButtonForward.Enabled = False
            orderButtonForward.BackColor = Color.LightGray
        Else
            orderButtonForward.Enabled = True
            orderButtonForward.BackColor = Color.WhiteSmoke
        End If
        If orderButtonPage = 1 Then
            orderButtonBack.Enabled = False
            orderButtonBack.BackColor = Color.LightGray
        Else
            orderButtonBack.Enabled = True
            orderButtonBack.BackColor = Color.WhiteSmoke
        End If
    End Sub
    Private Function CreateOrderButton(ByVal x As Integer, ByVal y As Integer) As Button
        Const xOffset As Integer = 15
        Const yOffset As Integer = 15
        Const width As Integer = 90
        Const height As Integer = 50

        Dim xCoord As Integer = xOffset + (x * (width + 6))
        Dim yCoord As Integer = yOffset + (y * (height + 6))

        Dim button As New Button
        With button
            .Size = New Size(width, height)
            .Location = New Point(xCoord, yCoord)
            .Text = ""
            .BackColor = Color.WhiteSmoke
            .FlatStyle = FlatStyle.Flat

            If y = 4 AndAlso (x = 3 OrElse x = 4) Then
                If x = 3 Then
                    orderButtonBack = button
                    AddHandler .Click, AddressOf OrderButtonBack_Click
                    .Text = "<<"
                Else
                    orderButtonForward = button
                    AddHandler .Click, AddressOf OrderButtonForward_Click
                    .Text = ">>"
                End If
            Else
                AddHandler .Click, AddressOf OrderButton_Click
                orderButtons.Add(button)
            End If
        End With

        panelOrderButtons.Controls.Add(button)

        Return button
    End Function

    Private Sub TableButton_Click(ByVal sender As Button, ByVal e As System.EventArgs) Handles TableButton1.Click, TableButton2.Click
        Dim table As Table = tables(CInt(sender.Tag))
        activeTable = table
        TabControl1.SelectedTab = tabpageTable
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case TabControl1.SelectedIndex
            Case 0
                LoadHall()
            Case 1
                LoadActiveTable()
            Case 3
                LoadTableTransactions()
        End Select
    End Sub
    Private Sub lblTableNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTableNumber.Click
        SwapTable()
    End Sub
    Private Sub OrderButton_Click(ByVal sender As Button, ByVal e As System.EventArgs)
        If sender.Tag Is Nothing Then Exit Sub
        Dim item As InventoryItem = CType(sender.Tag, InventoryItem)
        AddOrder(item)
        LoadActiveTable()
    End Sub
    Private Sub OrderButtonBack_Click(ByVal sender As Button, ByVal e As System.EventArgs)
        If orderButtonPage <= 1 Then Exit Sub

        orderButtonPage -= 1
        LoadOrderButtons()
    End Sub
    Private Sub OrderButtonForward_Click(ByVal sender As Button, ByVal e As System.EventArgs)
        If orderButtonPage + 1 > orderButtonPageMax() Then Exit Sub

        orderButtonPage += 1
        LoadOrderButtons()
    End Sub
    Private Sub ButtonQty_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonQty.Click
        Dim activeOrder As Order = GetActiveOrder()
        If activeOrder Is Nothing Then Exit Sub

        Dim input As String = "a"
        While IsNumeric(input) = False
            input = InputBox("New quantity?", "Quantity", activeOrder.qty)
        End While
        Dim newQty As Integer = CInt(input)
        activeOrder.qty = newQty
        LoadActiveTable()
        fileParser.SaveTables(tables)
    End Sub
    Private Sub ButtonPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPrice.Click
        Dim activeOrder As Order = GetActiveOrder()
        If activeOrder Is Nothing Then Exit Sub

        Dim input As String = "a"
        While IsNumeric(input) = False
            input = InputBox("New price?", "Price", activeOrder.price)
        End While
        Dim newPrice As Double = CDbl(input)
        activeOrder.price = newPrice
        LoadActiveTable()
        fileParser.SaveTables(tables)
    End Sub
    Private Sub ButtonTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTime.Click
        Dim activeOrder As Order = GetActiveOrder()
        If activeOrder Is Nothing Then Exit Sub

        Dim input As String = "a"
        While input.Count <> 5 AndAlso IsNumeric(input) = False
            input = InputBox("New Start Time?", "Time Stamp", activeOrder.dateTimeStamp.ToString("HH.mm"))
        End While
        Dim hour As Integer = input.Substring(0, 2)
        Dim minute As Integer = input.Substring(3, 2)
        With activeOrder.dateTimeStamp
            activeOrder.dateTimeStamp = New DateTime(.Year, .Month, .Day, hour, minute, 0)
        End With
        LoadActiveTable()
        fileParser.SaveTables(tables)
    End Sub
    Private Sub buttonPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonPay.Click
        activeTable.Close()
        Dim formPay As New formPay(activeTable)
        Select Case formPay.ShowDialog(Me)
            Case Windows.Forms.DialogResult.OK
                UpdateTable()
                fileParser.SaveTables(tables)
        End Select
        formPay.Dispose()
        activeTable.Open()
    End Sub
    Private Sub lblCashbox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCashbox.Click
        Dim input As String = "a"
        While IsNumeric(input) = False
            input = InputBox("How much is in the cashbox now?", "Cashbox Manual Reset", cashbox.ToString("0.00"))
        End While

        Dim value As Double = CDbl(input)
        If MsgBox("Setting cashbox to " & value.ToString("$0.00") & "." & vbCrLf & vbCrLf & "Are you sure?", _
                  MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Cashbox Manual Reset") = MsgBoxResult.No Then Exit Sub
        cashbox = value
    End Sub
    Private Sub dgvTableTransactions_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTableTransactions.CellClick
        Dim choice As DataGridViewCell = dgvTableTransactions.SelectedCells(0)
        Dim row As DataGridViewRow = dgvTableTransactions.Rows(choice.RowIndex)
        Dim orderCell As DataGridViewCell = row.Cells(3)
        Dim orderCellString As String = orderCell.Value

        Dim rawStr As String() = orderCellString.Split("-")
        Dim min As Integer = CInt(rawStr(0))
        Dim max As Integer = CInt(rawStr(1))
        LoadTransactionDetails(min, max)
    End Sub
    Private Sub buttonCoB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonCoB.Click
        CloseOfBusiness()
    End Sub

    Private Sub LoadHall()
        For Each tableButton In tableButtons
            Dim table As Table = tables(CInt(tableButton.Tag))
            If table.orders.Count > 0 Then
                tableButton.BackColor = Color.Green
            Else
                tableButton.BackColor = Color.White
            End If
        Next
    End Sub
    Private Sub LoadActiveTable()
        If activeTable Is Nothing Then Exit Sub
        lblTableNumber.Text = "Table #" & activeTable.number

        With dgvOrders
            .Rows.Clear()
            For n = 0 To activeTable.orders.Count - 1
                .Rows.Add()
                Dim order As Order = activeTable.orders(n)
                .Rows(n).Cells(0).Value = order.name
                .Rows(n).Cells(1).Value = order.qty
                .Rows(n).Cells(2).Value = order.totalPrice.ToString("$0.00")
                .Rows(n).Tag = order
            Next
        End With

        lblTableTotalPrice.Text = activeTable.totalPrice.ToString("$0.00")
    End Sub
    Private Sub UpdateTable()
        If updatedTable Is Nothing Then Exit Sub

        tables(activeTable.number) = updatedTable
        activeTable = updatedTable
        updatedTable = Nothing

        TabControl1.SelectedTab = tabpageHall
    End Sub
    Private Sub AddOrder(ByVal item As InventoryItem)
        Dim order As New Order(activeTable)
        With order
            .name = item.name
            .description = item.description
            .price = item.price
            .hourly = item.hourly
            .qty = 1
        End With
        activeTable.orders.Add(order)

        fileParser.SaveTables(tables)
    End Sub
    Private Function GetActiveOrder() As Order
        Dim selectedCell As DataGridViewCell = dgvOrders.SelectedCells(0)
        Dim selectedRow As DataGridViewRow = dgvOrders.Rows(selectedCell.RowIndex)
        Dim activeOrder As Order = CType(selectedRow.Tag, Order)
        Return activeOrder
    End Function
    Private Sub SwapTable()
        If activeTable Is Nothing Then Exit Sub
        Dim oldNumber As Integer = activeTable.number

        Dim input As String = "a"
        While IsNumeric(input) = False
            input = InputBox("New table number?", "Table Number", oldNumber)
        End While
        Dim newNumber As Integer = CInt(input)
        If newNumber > tableNumberMax Then Exit Sub


        Dim holder As Table = tables(newNumber)
        holder.number = oldNumber
        activeTable.number = newNumber
        tables(newNumber) = activeTable
        tables(oldNumber) = holder

        LoadActiveTable()
        fileParser.SaveTables(tables)
    End Sub
    Private Sub LoadTableTransactions()
        dgvTableTransactions.Rows.Clear()

        Dim datalist As List(Of String()) = fileParser.GetTableTransactions
        For n = 0 To datalist.Count - 1
            Dim ln As String() = datalist(n)
            dgvTableTransactions.Rows.Add()
            For p = 0 To ln.Count - 1
                dgvTableTransactions.Rows(n).Cells(p).Value = ln(p)
            Next
        Next

        dgvTableTransactions.CurrentCell = dgvTableTransactions.Rows(dgvTableTransactions.Rows.Count - 1).Cells(0)
        dgvTableTransactions_CellClick(dgvTableTransactions, Nothing)
    End Sub
    Private Sub LoadTransactionDetails(ByVal min As Integer, ByVal max As Integer)
        Dim dataList As List(Of String()) = fileParser.GetTransactionDetails(min, max)

        dgvTransactionDetails.Rows.Clear()
        For n = 0 To dataList.Count - 1
            dgvTransactionDetails.Rows.Add()
            Dim ln As String() = dataList(n)
            For p = 0 To ln.Count - 1
                dgvTransactionDetails.Rows(n).Cells(p).Value = ln(p)
            Next
        Next
    End Sub
    Private Sub CloseOfBusiness()
        'check to ensure that all tables are empty
        For n = 1 To tableNumberMax
            Dim table As Table = tables(n)
            If table.orders.Count > 1 Then
                MsgBox("Table #" & n & " is still occupied!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Tables Not Cleared")
                Exit Sub
            End If
        Next

        'move transaction.csv to archive, renamed with date in file name as prefix
        'move tabletrans.csv ditto
        'create new transaction.csv in root folder
        'create tabletrans.csv ditto
    End Sub
End Class
