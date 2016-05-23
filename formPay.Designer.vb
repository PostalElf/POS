<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPay
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
        Me.buttonCard = New System.Windows.Forms.Button()
        Me.buttonTransferRight = New System.Windows.Forms.Button()
        Me.lblTableNumber = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonTransferRightAll = New System.Windows.Forms.Button()
        Me.buttonTransferLeft = New System.Windows.Forms.Button()
        Me.buttonTransferLeftAll = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.buttonCash = New System.Windows.Forms.Button()
        Me.buttonNets = New System.Windows.Forms.Button()
        Me.dgvOutstanding = New System.Windows.Forms.DataGridView()
        Me.colOutstandingName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQtyOutstanding = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSubOutstanding = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPaying = New System.Windows.Forms.DataGridView()
        Me.colNamePaying = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQtyPaying = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSubPaying = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvOutstanding, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPaying, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonCard
        '
        Me.buttonCard.Location = New System.Drawing.Point(137, 422)
        Me.buttonCard.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonCard.Name = "buttonCard"
        Me.buttonCard.Size = New System.Drawing.Size(136, 48)
        Me.buttonCard.TabIndex = 0
        Me.buttonCard.Text = "Visa/Master"
        Me.buttonCard.UseVisualStyleBackColor = True
        '
        'buttonTransferRight
        '
        Me.buttonTransferRight.Location = New System.Drawing.Point(256, 78)
        Me.buttonTransferRight.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonTransferRight.Name = "buttonTransferRight"
        Me.buttonTransferRight.Size = New System.Drawing.Size(47, 48)
        Me.buttonTransferRight.TabIndex = 3
        Me.buttonTransferRight.Text = "->"
        Me.buttonTransferRight.UseVisualStyleBackColor = True
        '
        'lblTableNumber
        '
        Me.lblTableNumber.AutoSize = True
        Me.lblTableNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableNumber.Location = New System.Drawing.Point(8, 9)
        Me.lblTableNumber.Name = "lblTableNumber"
        Me.lblTableNumber.Size = New System.Drawing.Size(68, 20)
        Me.lblTableNumber.TabIndex = 4
        Me.lblTableNumber.Text = "Table #"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Outstanding"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(409, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Paying"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonTransferRightAll
        '
        Me.ButtonTransferRightAll.Location = New System.Drawing.Point(256, 134)
        Me.ButtonTransferRightAll.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonTransferRightAll.Name = "ButtonTransferRightAll"
        Me.ButtonTransferRightAll.Size = New System.Drawing.Size(47, 48)
        Me.ButtonTransferRightAll.TabIndex = 7
        Me.ButtonTransferRightAll.Text = "==>"
        Me.ButtonTransferRightAll.UseVisualStyleBackColor = True
        '
        'buttonTransferLeft
        '
        Me.buttonTransferLeft.Location = New System.Drawing.Point(256, 207)
        Me.buttonTransferLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonTransferLeft.Name = "buttonTransferLeft"
        Me.buttonTransferLeft.Size = New System.Drawing.Size(47, 48)
        Me.buttonTransferLeft.TabIndex = 8
        Me.buttonTransferLeft.Text = "<-"
        Me.buttonTransferLeft.UseVisualStyleBackColor = True
        '
        'buttonTransferLeftAll
        '
        Me.buttonTransferLeftAll.Location = New System.Drawing.Point(256, 263)
        Me.buttonTransferLeftAll.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonTransferLeftAll.Name = "buttonTransferLeftAll"
        Me.buttonTransferLeftAll.Size = New System.Drawing.Size(47, 48)
        Me.buttonTransferLeftAll.TabIndex = 9
        Me.buttonTransferLeftAll.Text = "<=="
        Me.buttonTransferLeftAll.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(24, 430)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(77, 31)
        Me.lblTotal.TabIndex = 11
        Me.lblTotal.Text = "-------"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'buttonCash
        '
        Me.buttonCash.Location = New System.Drawing.Point(425, 422)
        Me.buttonCash.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonCash.Name = "buttonCash"
        Me.buttonCash.Size = New System.Drawing.Size(136, 48)
        Me.buttonCash.TabIndex = 14
        Me.buttonCash.Text = "Cash"
        Me.buttonCash.UseVisualStyleBackColor = True
        '
        'buttonNets
        '
        Me.buttonNets.Location = New System.Drawing.Point(281, 422)
        Me.buttonNets.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonNets.Name = "buttonNets"
        Me.buttonNets.Size = New System.Drawing.Size(136, 48)
        Me.buttonNets.TabIndex = 15
        Me.buttonNets.Text = "NETS"
        Me.buttonNets.UseVisualStyleBackColor = True
        '
        'dgvOutstanding
        '
        Me.dgvOutstanding.AllowUserToAddRows = False
        Me.dgvOutstanding.AllowUserToDeleteRows = False
        Me.dgvOutstanding.AllowUserToResizeRows = False
        Me.dgvOutstanding.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvOutstanding.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvOutstanding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOutstanding.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colOutstandingName, Me.colQtyOutstanding, Me.colSubOutstanding})
        Me.dgvOutstanding.Location = New System.Drawing.Point(12, 78)
        Me.dgvOutstanding.Name = "dgvOutstanding"
        Me.dgvOutstanding.ReadOnly = True
        Me.dgvOutstanding.RowHeadersVisible = False
        Me.dgvOutstanding.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOutstanding.Size = New System.Drawing.Size(223, 286)
        Me.dgvOutstanding.TabIndex = 16
        '
        'colOutstandingName
        '
        Me.colOutstandingName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colOutstandingName.HeaderText = "Name"
        Me.colOutstandingName.Name = "colOutstandingName"
        Me.colOutstandingName.ReadOnly = True
        Me.colOutstandingName.Width = 70
        '
        'colQtyOutstanding
        '
        Me.colQtyOutstanding.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colQtyOutstanding.HeaderText = "Qty"
        Me.colQtyOutstanding.Name = "colQtyOutstanding"
        Me.colQtyOutstanding.ReadOnly = True
        Me.colQtyOutstanding.Width = 53
        '
        'colSubOutstanding
        '
        Me.colSubOutstanding.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSubOutstanding.HeaderText = "Sub"
        Me.colSubOutstanding.Name = "colSubOutstanding"
        Me.colSubOutstanding.ReadOnly = True
        Me.colSubOutstanding.Width = 57
        '
        'dgvPaying
        '
        Me.dgvPaying.AllowUserToAddRows = False
        Me.dgvPaying.AllowUserToDeleteRows = False
        Me.dgvPaying.AllowUserToResizeRows = False
        Me.dgvPaying.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPaying.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvPaying.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPaying.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNamePaying, Me.colQtyPaying, Me.colSubPaying})
        Me.dgvPaying.Location = New System.Drawing.Point(324, 78)
        Me.dgvPaying.Name = "dgvPaying"
        Me.dgvPaying.ReadOnly = True
        Me.dgvPaying.RowHeadersVisible = False
        Me.dgvPaying.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPaying.Size = New System.Drawing.Size(223, 286)
        Me.dgvPaying.TabIndex = 17
        '
        'colNamePaying
        '
        Me.colNamePaying.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colNamePaying.HeaderText = "Name"
        Me.colNamePaying.Name = "colNamePaying"
        Me.colNamePaying.ReadOnly = True
        Me.colNamePaying.Width = 70
        '
        'colQtyPaying
        '
        Me.colQtyPaying.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colQtyPaying.HeaderText = "Qty"
        Me.colQtyPaying.Name = "colQtyPaying"
        Me.colQtyPaying.ReadOnly = True
        Me.colQtyPaying.Width = 53
        '
        'colSubPaying
        '
        Me.colSubPaying.HeaderText = "Sub"
        Me.colSubPaying.Name = "colSubPaying"
        Me.colSubPaying.ReadOnly = True
        Me.colSubPaying.Width = 57
        '
        'formPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 483)
        Me.Controls.Add(Me.dgvPaying)
        Me.Controls.Add(Me.dgvOutstanding)
        Me.Controls.Add(Me.buttonNets)
        Me.Controls.Add(Me.buttonCash)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.buttonTransferLeftAll)
        Me.Controls.Add(Me.buttonTransferLeft)
        Me.Controls.Add(Me.ButtonTransferRightAll)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTableNumber)
        Me.Controls.Add(Me.buttonTransferRight)
        Me.Controls.Add(Me.buttonCard)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "formPay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Payment"
        CType(Me.dgvOutstanding, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPaying, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonCard As System.Windows.Forms.Button
    Friend WithEvents buttonTransferRight As System.Windows.Forms.Button
    Friend WithEvents lblTableNumber As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonTransferRightAll As System.Windows.Forms.Button
    Friend WithEvents buttonTransferLeft As System.Windows.Forms.Button
    Friend WithEvents buttonTransferLeftAll As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents buttonCash As System.Windows.Forms.Button
    Friend WithEvents buttonNets As System.Windows.Forms.Button
    Friend WithEvents dgvOutstanding As System.Windows.Forms.DataGridView
    Friend WithEvents dgvPaying As System.Windows.Forms.DataGridView
    Friend WithEvents colOutstandingName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQtyOutstanding As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSubOutstanding As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNamePaying As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQtyPaying As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSubPaying As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
