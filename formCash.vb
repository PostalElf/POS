Public Class formCash
    Private total As Double
    Private _cashReceived As Double
    Private Property cashReceived As Double
        Get
            Return _cashReceived
        End Get
        Set(ByVal value As Double)
            _cashReceived = value
            lblReceived.Text = _cashReceived.ToString("$0.00")
            UpdateChange()
        End Set
    End Property
    Private ReadOnly Property change As Double
        Get
            Return cashReceived - total
        End Get
    End Property

    Public Sub New(ByVal pTotal As Double)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        total = pTotal
    End Sub

    Private Sub formCash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Select()
        Me.Text &= " - " & total.ToString("$0.00")
        cashReceived = 0
        UpdateChange()
    End Sub
    Private Sub formCash_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If cashReceived = 0 Then
            DialogResult = Windows.Forms.DialogResult.Cancel
            Exit Sub
        ElseIf change < 0 Then
            MsgBox("Error! Insufficient cash received.", MsgBoxStyle.OkOnly, "Error")
            e.Cancel = True
            Exit Sub
        End If

        DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub button_Click(ByVal sender As Button, ByVal e As System.EventArgs) Handles Button2.Click, Button5.Click, Button10.Click, Button20.Click, Button50.Click, Button100.Click
        cashReceived += CDbl(sender.Tag)
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If IsNumeric(TextBox1.Text) = False Then
                TextBox1.Clear()
                Exit Sub
            End If

            cashReceived += CDbl(TextBox1.Text)
            TextBox1.Clear()
        End If
    End Sub
    Private Sub buttonClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonClear.Click
        cashReceived = 0
    End Sub
    Private Sub lblChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblChange.Click
        Me.Close()
    End Sub
    Private Sub lblReceived_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblReceived.Click
        buttonClear_Click(lblReceived, Nothing)
    End Sub

    Private Sub UpdateChange()
        If change < 0 Then lblChange.ForeColor = Color.Red Else lblChange.ForeColor = Color.Black
        lblChange.Text = change.ToString("$0.00")
    End Sub
End Class