Public Class formPay
    Friend cashboxChange As Double = 0
    Private xButtonClicked As Boolean = True
    Private table As Table
    Public Sub New(ByVal pTable As Table)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        table = pTable
    End Sub

    Private Sub formPay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim f As New Font("Arial", 9)
        lblTableNumber.Text &= table.number
        dgvOutstanding.Font = f
        dgvPaying.Font = f

        AddItemToDgv(dgvPaying, table.orders)
        UpdateTotal()
    End Sub
    Private Sub formPay_Closing(ByVal sender As System.Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If xButtonClicked = True Then DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
    Private Sub ButtonCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonCard.Click
        PayBill(PaymentMethod.Card)
        ClickOKButton()
    End Sub
    Private Sub buttonNets_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonNets.Click
        PayBill(PaymentMethod.NETS)
        ClickOKButton()
    End Sub
    Private Sub buttonCash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonCash.Click
        Dim total As Double = CDbl(lblTotal.Tag)
        Dim formCash As New formCash(total)
        If formCash.ShowDialog(Me) = Windows.Forms.DialogResult.Cancel Then Exit Sub 'cancel result from closing cash dialog at $0

        PayBill(PaymentMethod.Cash)
        formMain.cashbox += total
        ClickOKButton()
    End Sub
    Private Sub buttonTransferRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonTransferRight.Click
        TransferItems(dgvOutstanding, dgvPaying)
    End Sub
    Private Sub ButtonTransferRightAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTransferRightAll.Click
        TransferItemsAll(dgvOutstanding, dgvPaying)
    End Sub
    Private Sub buttonTransferLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonTransferLeft.Click
        TransferItems(dgvPaying, dgvOutstanding)
    End Sub
    Private Sub buttonTransferLeftAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonTransferLeftAll.Click
        TransferItemsAll(dgvPaying, dgvOutstanding)
    End Sub

    Private Sub TransferItems(ByRef parent As DataGridView, ByRef target As DataGridView)
        If parent.SelectedRows.Count = 0 Then Exit Sub

        Dim activeOrders As New List(Of Order)
        For Each row As DataGridViewRow In parent.SelectedRows
            activeOrders.Add(CType(row.Tag, Order))
        Next

        parent.ClearSelection()
        AddItemToDgv(target, activeOrders)
        RemoveItemFromDgv(parent, activeOrders)

        UpdateTotal()
    End Sub
    Private Sub TransferItemsAll(ByRef parent As DataGridView, ByRef target As DataGridView)
        AddItemToDgv(target, table.orders)
        RemoveItemFromDgv(parent, table.orders)

        parent.ClearSelection()
        target.ClearSelection()

        UpdateTotal()
    End Sub
    Private Sub AddItemToDgv(ByRef dgv As DataGridView, ByVal order As Order)
        dgv.Rows.Add()

        Dim i As Integer = dgv.Rows.Count - 1
        With dgv.Rows(i)
            .Cells(0).Value = order.name
            .Cells(1).Value = order.qty
            .Cells(2).Value = order.totalPrice.ToString("$0.00")
            .Tag = order
        End With
    End Sub
    Private Sub AddItemToDgv(ByRef dgv As DataGridView, ByVal orders As List(Of Order))
        For Each Order In orders
            AddItemToDgv(dgv, Order)
        Next
    End Sub
    Private Sub RemoveItemFromDgv(ByRef dgv As DataGridView, ByRef order As Order)
        Dim chop As Integer = -1
        For Each row As DataGridViewRow In dgv.Rows
            Dim rowOrder As Order = CType(row.Tag, Order)
            If order.Equals(rowOrder) Then chop = row.Index
        Next

        If chop <> -1 Then dgv.Rows.RemoveAt(chop)
    End Sub
    Private Sub RemoveItemFromDgv(ByRef dgv As DataGridView, ByVal orders As List(Of Order))
        Dim chop As New List(Of Integer)
        For Each row As DataGridViewRow In dgv.Rows
            Dim rowOrder As Order = CType(row.Tag, Order)
            If orders.Contains(rowOrder) Then chop.Add(row.Index)
        Next

        For n = dgv.Rows.Count - 1 To 0 Step -1
            If chop.Contains(n) Then dgv.Rows.RemoveAt(n)
        Next
    End Sub
    Private Sub UpdateTotal()
        Dim total As Double = 0
        For Each row As DataGridViewRow In dgvPaying.Rows
            Dim order As Order = CType(row.Tag, Order)
            total += order.totalPrice
        Next
        lblTotal.Text = total.ToString("$0.00")
        lblTotal.Tag = total
    End Sub
    Private Sub PayBill(ByVal paymentMethod As PaymentMethod)
        Dim paidOrders As New List(Of Order)
        For Each row As DataGridViewRow In dgvPaying.Rows
            Dim order As Order = CType(row.Tag, Order)
            table.orders.Remove(order)
            paidOrders.Add(order)
        Next

        fileParser.AddTableTransaction(paidOrders, paymentMethod)
        formMain.updatedTable = table
    End Sub
    Private Sub ClickOKButton()
        DialogResult = Windows.Forms.DialogResult.OK
        xButtonClicked = False
        Me.Close()
    End Sub
End Class