Public Class Table
    Public Property number As Integer
    Public Property orders As New List(Of Order)
    Public ReadOnly Property totalPrice As Double
        Get
            Dim total As Double
            For Each Order In orders
                total += Order.totalPrice
            Next
            Return total
        End Get
    End Property


    Public Sub New(ByVal pNumber As Integer)
        number = pNumber
    End Sub
    Public Sub Close()
        For Each Order In orders
            Order.Close()
        Next
    End Sub
    Public Sub Open()
        For Each Order In orders
            Order.open()
        Next
    End Sub
End Class
