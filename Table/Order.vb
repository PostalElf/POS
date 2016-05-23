Public Class Order
    Public name As String
    Public description As String
    Public table As Table
    Public dateTimeStamp As DateTime
    Private _price As Double
    Public Property price As Double
        Get
            If hourly = True Then
                Return _price * getTimeDifference()
            Else
                Return _price
            End If
        End Get
        Set(ByVal value As Double)
            _price = value
        End Set
    End Property
    Public qty As Double
    Public hourly As Boolean = False
    Public ReadOnly Property totalPrice As Double
        Get
            Return qty * price
        End Get
    End Property
    Private timeDifference As Double = 0
    Private isClosed As Boolean = False

    Public Sub New(ByRef pTable As Table)
        table = pTable
        dateTimeStamp = DateTime.Now
    End Sub
    Public Overrides Function ToString() As String
        Return name
    End Function
    Private Function getTimeDifference() As Double
        Dim td As TimeSpan = DateTime.Now - dateTimeStamp
        Dim hours As Double = td.TotalHours
        Return Math.Round(hours, 1)
    End Function
    Public Sub Close()
        isClosed = True
        timeDifference = getTimeDifference
    End Sub
    Public Sub Open()
        timeDifference = 0
        isClosed = False
    End Sub

    Public Function FileParse() As String()
        Dim str(8) As String
        str(1) = dateTimeStamp.ToString("yyyy-MM-dd HH:mm")
        str(2) = table.number
        str(3) = name
        str(4) = qty
        str(5) = price.ToString("0.00")
        If hourly = True Then str(6) = timeDifference.ToString("0.0") Else str(6) = 0
        str(7) = totalPrice.ToString("0.00")
        Return str
    End Function
End Class
