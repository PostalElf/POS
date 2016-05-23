<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblReceived = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button50 = New System.Windows.Forms.Button()
        Me.Button100 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.buttonClear = New System.Windows.Forms.Button()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblReceived
        '
        Me.lblReceived.AutoSize = True
        Me.lblReceived.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceived.Location = New System.Drawing.Point(90, 17)
        Me.lblReceived.Name = "lblReceived"
        Me.lblReceived.Size = New System.Drawing.Size(77, 31)
        Me.lblReceived.TabIndex = 12
        Me.lblReceived.Text = "-------"
        Me.lblReceived.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(95, 58)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 54)
        Me.Button5.TabIndex = 13
        Me.Button5.Tag = "5"
        Me.Button5.Text = "$5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(176, 58)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 54)
        Me.Button10.TabIndex = 14
        Me.Button10.Tag = "10"
        Me.Button10.Text = "$10"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.Location = New System.Drawing.Point(14, 118)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(75, 54)
        Me.Button20.TabIndex = 15
        Me.Button20.Tag = "20"
        Me.Button20.Text = "$20"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button50
        '
        Me.Button50.Location = New System.Drawing.Point(95, 118)
        Me.Button50.Name = "Button50"
        Me.Button50.Size = New System.Drawing.Size(75, 54)
        Me.Button50.TabIndex = 16
        Me.Button50.Tag = "50"
        Me.Button50.Text = "$50"
        Me.Button50.UseVisualStyleBackColor = True
        '
        'Button100
        '
        Me.Button100.Location = New System.Drawing.Point(176, 118)
        Me.Button100.Name = "Button100"
        Me.Button100.Size = New System.Drawing.Size(75, 54)
        Me.Button100.TabIndex = 17
        Me.Button100.Tag = "100"
        Me.Button100.Text = "$100"
        Me.Button100.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(14, 58)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 54)
        Me.Button2.TabIndex = 18
        Me.Button2.Tag = "2"
        Me.Button2.Text = "$2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(80, 184)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(71, 26)
        Me.TextBox1.TabIndex = 19
        '
        'buttonClear
        '
        Me.buttonClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonClear.Location = New System.Drawing.Point(157, 181)
        Me.buttonClear.Name = "buttonClear"
        Me.buttonClear.Size = New System.Drawing.Size(44, 33)
        Me.buttonClear.TabIndex = 20
        Me.buttonClear.Text = "CLR"
        Me.buttonClear.UseVisualStyleBackColor = True
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(96, 9)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(77, 31)
        Me.lblChange.TabIndex = 21
        Me.lblChange.Text = "-------"
        Me.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Change:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblChange)
        Me.Panel1.Location = New System.Drawing.Point(28, 245)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(198, 55)
        Me.Panel1.TabIndex = 23
        '
        'formCash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 323)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.buttonClear)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button100)
        Me.Controls.Add(Me.Button50)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.lblReceived)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "formCash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cash Payment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button50 As System.Windows.Forms.Button
    Friend WithEvents Button100 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents buttonClear As System.Windows.Forms.Button
    Friend WithEvents lblChange As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblReceived As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
