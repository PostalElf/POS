Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class fileParser
    Private Const pathInventoryItems As String = "inventory.csv"
    Private Const pathTransactionDetails As String = "transactions.csv"
    Private Const pathTableTransactions As String = "tabletrans.csv"
    Private Const pathHall As String = "hall.txt"

    Private Shared Function GetNextID(ByVal pathname As String) As Integer
        Select Case pathname
            Case pathInventoryItems
                My.Settings.lastInventoryId += 1
                Return My.Settings.lastInventoryId
            Case pathTransactionDetails
                My.Settings.lastTransactionId += 1
                Return My.Settings.lastTransactionId
            Case pathTableTransactions
                My.Settings.lastTableId += 1
                Return My.Settings.lastTableId
            Case Else : Return 0
        End Select
    End Function
    Private Shared Function ReadBracketTextAll(ByVal pathname As String) As List(Of Queue(Of String))
        Dim total As New List(Of Queue(Of String))
        Try
            Dim line As String
            Using sr As New StreamReader(pathname)
                Dim current As New Queue(Of String)
                While sr.Peek <> -1
                    line = sr.ReadLine

                    'ignore blank lines and lines that start with -
                    If line = "" Then Continue While
                    If line.StartsWith("-") Then Continue While

                    If line.StartsWith("[") Then
                        'remove brackets
                        line = line.Remove(0, 1)
                        line = line.Remove(line.Length - 1, 1)

                        'if current is filled, add to total
                        If current.Count > 0 Then total.Add(current)

                        'start new current with bracketstring as header
                        current = New Queue(Of String)
                        current.Enqueue(line)
                    Else
                        If line <> "" Then current.Enqueue(line)
                    End If
                End While

                'add last entry
                If current.Count > 0 Then total.Add(current)
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return Nothing
        End Try
        Return total
    End Function
    Private Shared Function ReadCsvRange(ByVal pathname As String, ByVal idMin As Integer, ByVal idMax As Integer) As List(Of String())
        Dim total As New List(Of String())

        Using p As New TextFieldParser(pathname)
            p.SetDelimiters(",")
            p.HasFieldsEnclosedInQuotes = False

            p.ReadLine()

            While p.EndOfData = False
                Dim currentLine As String() = p.ReadFields
                Dim currentId As Integer = CInt(currentLine(0))
                If currentId >= idMin Then
                    total.Add(currentLine)
                    If currentId = idMax Then Return total
                End If
            End While
        End Using

        Return Nothing
    End Function
    Private Shared Function ReadCsvAll(ByVal pathname As String) As List(Of String())
        Dim total As New List(Of String())
        Using p As New TextFieldParser(pathname)
            p.SetDelimiters(",")
            p.HasFieldsEnclosedInQuotes = False

            p.ReadLine()

            While p.EndOfData = False
                total.Add(p.ReadFields)
            End While
        End Using
        Return total
    End Function
    Private Shared Function ReadCsvLast(ByVal pathname As String, ByVal size As Integer) As List(Of String())
        Dim rawAll As List(Of String()) = ReadCsvAll(pathname)

        Dim total As New List(Of String())
        Dim cap As Integer = rawAll.Count - size
        If cap < 0 Then cap = 0
        For n = cap To rawAll.Count - 1
            total.Add(rawAll(n))
        Next
        Return total
    End Function
    Private Shared Sub WriteBracketText(ByVal pathname As String, ByVal datalist As List(Of Queue(Of String)))
        Using p As New StreamWriter(pathname)
            For Each q As Queue(Of String) In datalist
                'first line is always bracket text
                p.WriteLine("[" & q.Dequeue & "]")

                'write in rest of the lines
                While q.Count > 0
                    p.WriteLine(q.Dequeue)
                End While

                'write in linebreak
                p.WriteLine()
            Next
        End Using
    End Sub
    Private Shared Sub AppendCSV(ByVal pathname As String, ByVal rawstr As String())
        Using w As New StreamWriter(pathname, True)
            For n = 0 To rawstr.Count - 1
                Dim field As String = rawstr(n)
                w.Write(field)
                If n <> rawstr.Count - 1 Then w.Write(",") Else w.WriteLine()
            Next
        End Using
    End Sub
    Private Shared Sub AppendCSV(ByVal pathname As String, ByVal rawstrs As List(Of String()))
        Using w As New StreamWriter(pathname, True)
            For Each rawstr As String() In rawstrs
                For n = 0 To rawstr.Count - 1
                    Dim field As String = rawstr(n)
                    w.Write(field)
                    If n <> rawstr.Count - 1 Then w.Write(",") Else w.WriteLine()
                Next
            Next
        End Using
    End Sub

    Friend Shared Function GetInventory() As List(Of InventoryItem)
        Dim total As New List(Of InventoryItem)
        Dim rawAll As List(Of String()) = ReadCsvAll(pathInventoryItems)
        For Each ln In rawAll
            Dim item As New InventoryItem
            With item
                .id = CInt(ln(0))
                .name = ln(1)
                .description = ln(2)
                .price = CDbl(ln(3))
                .hourly = CBool(ln(4))
            End With
            total.Add(item)
        Next
        Return total
    End Function
    Friend Shared Sub AddTableTransaction(ByVal orders As List(Of Order), ByVal paymentMethod As paymentMethod)
        Dim str(4) As String
        str(0) = GetNextID(pathTableTransactions)
        str(1) = orders(0).dateTimeStamp.ToString("yyyy-MM-dd HH:mm")
        str(2) = orders(0).table.number

        Dim orderStrings As New List(Of String())
        Dim firstId As Integer
        Dim lastId As Integer
        For n = 0 To orders.Count - 1
            Dim order As Order = orders(n)
            Dim orderString As String() = ParseTransaction(order, paymentMethod)
            orderStrings.Add(orderString)

            Dim id As Integer = CInt(orderString(0))
            If n = 0 Then
                firstId = id
            ElseIf n = orders.Count - 1 Then
                lastId = id
            End If
        Next
        If lastId = 0 Then lastId = firstId
        str(3) = firstId & "-" & lastId
        str(4) = paymentMethod.ToString

        AppendCSV(pathTableTransactions, str)
        AppendCSV(pathTransactionDetails, orderStrings)
    End Sub
    Friend Shared Function GetTableTransactions() As List(Of String())
        Return ReadCsvAll(pathTableTransactions)
    End Function
    Private Shared Function ParseTransaction(ByVal order As Order, ByVal paymentMethod As PaymentMethod) As String()
        Dim id As Integer = GetNextID(pathTransactionDetails)
        Dim str As String() = order.FileParse
        str(0) = id
        str(8) = paymentMethod.ToString
        Return str
    End Function
    Friend Shared Function GetTransactionDetails(ByVal idMin As Integer, ByVal idMax As Integer) As List(Of String())
        Return ReadCsvRange(pathTransactionDetails, idMin, idMax)
    End Function
    Friend Shared Function GetTables() As List(Of Table)
        Dim total As New List(Of Table)

        Dim hall As List(Of Queue(Of String)) = ReadBracketTextAll(pathHall)
        For Each q As Queue(Of String) In hall
            Dim table As Table = ParseTable(q)
            total.Add(table)
        Next

        Return total
    End Function
    Friend Shared Sub SaveTables(ByVal tables As Table())
        Dim parsedTables As New List(Of Queue(Of String))
        For n = 1 To tables.Count - 1
            Dim table As Table = tables(n)
            Dim parsedTable As Queue(Of String)
            If table Is Nothing Then
                parsedTable = New Queue(Of String)
                parsedTable.Enqueue(n)
            Else : parsedTable = ParseTable(table)
            End If
            parsedTables.Add(parsedTable)
        Next
        WriteBracketText(pathHall, parsedTables)
    End Sub
    Private Shared Function ParseTable(ByVal table As Table) As Queue(Of String)
        Dim total As New Queue(Of String)
        With total
            .Enqueue(table.number)
            For Each Order In table.orders
                .Enqueue(ParseOrder(Order))
            Next
        End With
        Return total
    End Function
    Private Shared Function ParseTable(ByVal rawstr As Queue(Of String)) As Table
        Dim table As New Table(0)
        table.number = CInt(rawstr.Dequeue)
        While rawstr.Count > 0
            Dim order As Order = ParseOrder(rawstr.Dequeue)
            order.table = table
            table.orders.Add(order)
        End While
        Return table
    End Function
    Private Shared Function ParseOrder(ByVal order As Order) As String
        Dim total As String = order.name
        With order
            total &= "|" & .dateTimeStamp.ToString
            total &= "|" & .qty
            total &= "|" & .price
            total &= "|" & .hourly
        End With
        Return total
    End Function
    Private Shared Function ParseOrder(ByVal rawstr As String) As Order
        Dim rawsplit As String() = rawstr.Split("|")
        Dim name As String = rawsplit(0)
        Dim dateTimeStamp As DateTime = DateTime.Parse(rawsplit(1))
        Dim qty As Integer = CInt(rawsplit(2))
        Dim price As Double = CDbl(rawsplit(3))
        Dim hourly As Boolean = CBool(rawsplit(4))

        Dim order As New Order(Nothing)
        With order
            .name = name
            .dateTimeStamp = dateTimeStamp
            .qty = qty
            .price = price
            .hourly = hourly
        End With
        Return order
    End Function
End Class
