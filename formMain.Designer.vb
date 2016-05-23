<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
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
        Me.components = New System.ComponentModel.Container()
        Me.TableButton1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabpageHall = New System.Windows.Forms.TabPage()
        Me.TableButton2 = New System.Windows.Forms.Button()
        Me.tabpageTable = New System.Windows.Forms.TabPage()
        Me.dgvOrders = New System.Windows.Forms.DataGridView()
        Me.colTableOrderName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTableOrderQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTableSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonTime = New System.Windows.Forms.Button()
        Me.ButtonPrice = New System.Windows.Forms.Button()
        Me.ButtonQty = New System.Windows.Forms.Button()
        Me.buttonPay = New System.Windows.Forms.Button()
        Me.lblTableTotalPrice = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelOrderButtons = New System.Windows.Forms.Panel()
        Me.lblTableNumber = New System.Windows.Forms.Label()
        Me.tabpageCustomers = New System.Windows.Forms.TabPage()
        Me.tabpageReview = New System.Windows.Forms.TabPage()
        Me.buttonCoB = New System.Windows.Forms.Button()
        Me.grpTransactionDetails = New System.Windows.Forms.GroupBox()
        Me.dgvTransactionDetails = New System.Windows.Forms.DataGridView()
        Me.colIdT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDateT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTableT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOrderName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQtyT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOrderPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPayment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpTransactions = New System.Windows.Forms.GroupBox()
        Me.dgvTableTransactions = New System.Windows.Forms.DataGridView()
        Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDateTimeStamp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTableNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOrderIds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPayT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.groupCashbox = New System.Windows.Forms.GroupBox()
        Me.lblCashbox = New System.Windows.Forms.Label()
        Me.tt = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.tabpageHall.SuspendLayout()
        Me.tabpageTable.SuspendLayout()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpageReview.SuspendLayout()
        Me.grpTransactionDetails.SuspendLayout()
        CType(Me.dgvTransactionDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTransactions.SuspendLayout()
        CType(Me.dgvTableTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupCashbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableButton1
        '
        Me.TableButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TableButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableButton1.Location = New System.Drawing.Point(22, 186)
        Me.TableButton1.Name = "TableButton1"
        Me.TableButton1.Size = New System.Drawing.Size(51, 47)
        Me.TableButton1.TabIndex = 0
        Me.TableButton1.Tag = "1"
        Me.TableButton1.Text = "Table 1"
        Me.TableButton1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabpageHall)
        Me.TabControl1.Controls.Add(Me.tabpageTable)
        Me.TabControl1.Controls.Add(Me.tabpageCustomers)
        Me.TabControl1.Controls.Add(Me.tabpageReview)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 49)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(746, 484)
        Me.TabControl1.TabIndex = 1
        '
        'tabpageHall
        '
        Me.tabpageHall.Controls.Add(Me.TableButton2)
        Me.tabpageHall.Controls.Add(Me.TableButton1)
        Me.tabpageHall.Location = New System.Drawing.Point(4, 29)
        Me.tabpageHall.Name = "tabpageHall"
        Me.tabpageHall.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageHall.Size = New System.Drawing.Size(738, 451)
        Me.tabpageHall.TabIndex = 0
        Me.tabpageHall.Text = "Hall"
        Me.tabpageHall.UseVisualStyleBackColor = True
        '
        'TableButton2
        '
        Me.TableButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TableButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableButton2.Location = New System.Drawing.Point(22, 251)
        Me.TableButton2.Name = "TableButton2"
        Me.TableButton2.Size = New System.Drawing.Size(51, 47)
        Me.TableButton2.TabIndex = 1
        Me.TableButton2.Tag = "2"
        Me.TableButton2.Text = "Table 2"
        Me.TableButton2.UseVisualStyleBackColor = True
        '
        'tabpageTable
        '
        Me.tabpageTable.Controls.Add(Me.dgvOrders)
        Me.tabpageTable.Controls.Add(Me.ButtonTime)
        Me.tabpageTable.Controls.Add(Me.ButtonPrice)
        Me.tabpageTable.Controls.Add(Me.ButtonQty)
        Me.tabpageTable.Controls.Add(Me.buttonPay)
        Me.tabpageTable.Controls.Add(Me.lblTableTotalPrice)
        Me.tabpageTable.Controls.Add(Me.Label1)
        Me.tabpageTable.Controls.Add(Me.panelOrderButtons)
        Me.tabpageTable.Controls.Add(Me.lblTableNumber)
        Me.tabpageTable.Location = New System.Drawing.Point(4, 29)
        Me.tabpageTable.Name = "tabpageTable"
        Me.tabpageTable.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageTable.Size = New System.Drawing.Size(738, 451)
        Me.tabpageTable.TabIndex = 1
        Me.tabpageTable.Text = "Table"
        Me.tabpageTable.UseVisualStyleBackColor = True
        '
        'dgvOrders
        '
        Me.dgvOrders.AllowUserToAddRows = False
        Me.dgvOrders.AllowUserToDeleteRows = False
        Me.dgvOrders.AllowUserToResizeColumns = False
        Me.dgvOrders.AllowUserToResizeRows = False
        Me.dgvOrders.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTableOrderName, Me.colTableOrderQty, Me.colTableSubtotal})
        Me.dgvOrders.Location = New System.Drawing.Point(11, 58)
        Me.dgvOrders.MultiSelect = False
        Me.dgvOrders.Name = "dgvOrders"
        Me.dgvOrders.ReadOnly = True
        Me.dgvOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvOrders.RowHeadersVisible = False
        Me.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrders.Size = New System.Drawing.Size(207, 368)
        Me.dgvOrders.TabIndex = 9
        '
        'colTableOrderName
        '
        Me.colTableOrderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colTableOrderName.HeaderText = "Name"
        Me.colTableOrderName.Name = "colTableOrderName"
        Me.colTableOrderName.ReadOnly = True
        Me.colTableOrderName.Width = 76
        '
        'colTableOrderQty
        '
        Me.colTableOrderQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colTableOrderQty.HeaderText = "Qty"
        Me.colTableOrderQty.Name = "colTableOrderQty"
        Me.colTableOrderQty.ReadOnly = True
        Me.colTableOrderQty.Width = 58
        '
        'colTableSubtotal
        '
        Me.colTableSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colTableSubtotal.HeaderText = "Sub"
        Me.colTableSubtotal.Name = "colTableSubtotal"
        Me.colTableSubtotal.ReadOnly = True
        Me.colTableSubtotal.Width = 63
        '
        'ButtonTime
        '
        Me.ButtonTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTime.Location = New System.Drawing.Point(306, 391)
        Me.ButtonTime.Name = "ButtonTime"
        Me.ButtonTime.Size = New System.Drawing.Size(35, 35)
        Me.ButtonTime.TabIndex = 8
        Me.ButtonTime.Text = "Time"
        Me.ButtonTime.UseVisualStyleBackColor = True
        '
        'ButtonPrice
        '
        Me.ButtonPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrice.Location = New System.Drawing.Point(265, 391)
        Me.ButtonPrice.Name = "ButtonPrice"
        Me.ButtonPrice.Size = New System.Drawing.Size(35, 35)
        Me.ButtonPrice.TabIndex = 7
        Me.ButtonPrice.Text = "$$$"
        Me.ButtonPrice.UseVisualStyleBackColor = True
        '
        'ButtonQty
        '
        Me.ButtonQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonQty.Location = New System.Drawing.Point(224, 391)
        Me.ButtonQty.Name = "ButtonQty"
        Me.ButtonQty.Size = New System.Drawing.Size(35, 35)
        Me.ButtonQty.TabIndex = 6
        Me.ButtonQty.Text = "QTY"
        Me.ButtonQty.UseVisualStyleBackColor = True
        '
        'buttonPay
        '
        Me.buttonPay.Location = New System.Drawing.Point(635, 391)
        Me.buttonPay.Name = "buttonPay"
        Me.buttonPay.Size = New System.Drawing.Size(92, 48)
        Me.buttonPay.TabIndex = 5
        Me.buttonPay.Text = "Ka-Ching!"
        Me.buttonPay.UseVisualStyleBackColor = True
        '
        'lblTableTotalPrice
        '
        Me.lblTableTotalPrice.AutoSize = True
        Me.lblTableTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableTotalPrice.Location = New System.Drawing.Point(535, 401)
        Me.lblTableTotalPrice.Name = "lblTableTotalPrice"
        Me.lblTableTotalPrice.Size = New System.Drawing.Size(33, 25)
        Me.lblTableTotalPrice.TabIndex = 4
        Me.lblTableTotalPrice.Text = "---"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(435, 401)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Subtotal: "
        '
        'panelOrderButtons
        '
        Me.panelOrderButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelOrderButtons.Location = New System.Drawing.Point(224, 58)
        Me.panelOrderButtons.Name = "panelOrderButtons"
        Me.panelOrderButtons.Size = New System.Drawing.Size(508, 324)
        Me.panelOrderButtons.TabIndex = 2
        '
        'lblTableNumber
        '
        Me.lblTableNumber.AutoSize = True
        Me.lblTableNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableNumber.Location = New System.Drawing.Point(6, 12)
        Me.lblTableNumber.Name = "lblTableNumber"
        Me.lblTableNumber.Size = New System.Drawing.Size(66, 25)
        Me.lblTableNumber.TabIndex = 1
        Me.lblTableNumber.Text = "Table"
        '
        'tabpageCustomers
        '
        Me.tabpageCustomers.Location = New System.Drawing.Point(4, 29)
        Me.tabpageCustomers.Name = "tabpageCustomers"
        Me.tabpageCustomers.Size = New System.Drawing.Size(738, 451)
        Me.tabpageCustomers.TabIndex = 2
        Me.tabpageCustomers.Text = "Customers"
        Me.tabpageCustomers.UseVisualStyleBackColor = True
        '
        'tabpageReview
        '
        Me.tabpageReview.Controls.Add(Me.buttonCoB)
        Me.tabpageReview.Controls.Add(Me.grpTransactionDetails)
        Me.tabpageReview.Controls.Add(Me.grpTransactions)
        Me.tabpageReview.Controls.Add(Me.groupCashbox)
        Me.tabpageReview.Location = New System.Drawing.Point(4, 29)
        Me.tabpageReview.Name = "tabpageReview"
        Me.tabpageReview.Size = New System.Drawing.Size(738, 451)
        Me.tabpageReview.TabIndex = 3
        Me.tabpageReview.Text = "Review"
        Me.tabpageReview.UseVisualStyleBackColor = True
        '
        'buttonCoB
        '
        Me.buttonCoB.Location = New System.Drawing.Point(614, 117)
        Me.buttonCoB.Name = "buttonCoB"
        Me.buttonCoB.Size = New System.Drawing.Size(107, 60)
        Me.buttonCoB.TabIndex = 5
        Me.buttonCoB.Text = "Close of Business"
        Me.buttonCoB.UseVisualStyleBackColor = True
        '
        'grpTransactionDetails
        '
        Me.grpTransactionDetails.Controls.Add(Me.dgvTransactionDetails)
        Me.grpTransactionDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTransactionDetails.Location = New System.Drawing.Point(18, 213)
        Me.grpTransactionDetails.Name = "grpTransactionDetails"
        Me.grpTransactionDetails.Size = New System.Drawing.Size(602, 191)
        Me.grpTransactionDetails.TabIndex = 4
        Me.grpTransactionDetails.TabStop = False
        Me.grpTransactionDetails.Text = "Details"
        '
        'dgvTransactionDetails
        '
        Me.dgvTransactionDetails.AllowUserToAddRows = False
        Me.dgvTransactionDetails.AllowUserToDeleteRows = False
        Me.dgvTransactionDetails.AllowUserToResizeRows = False
        Me.dgvTransactionDetails.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvTransactionDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTransactionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactionDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdT, Me.colDateT, Me.colTableT, Me.colOrderName, Me.colQtyT, Me.colOrderPrice, Me.colHours, Me.colTotal, Me.colPayment})
        Me.dgvTransactionDetails.Location = New System.Drawing.Point(12, 23)
        Me.dgvTransactionDetails.Name = "dgvTransactionDetails"
        Me.dgvTransactionDetails.ReadOnly = True
        Me.dgvTransactionDetails.RowHeadersVisible = False
        Me.dgvTransactionDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTransactionDetails.Size = New System.Drawing.Size(573, 143)
        Me.dgvTransactionDetails.TabIndex = 2
        '
        'colIdT
        '
        Me.colIdT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colIdT.HeaderText = "ID"
        Me.colIdT.Name = "colIdT"
        Me.colIdT.ReadOnly = True
        Me.colIdT.Width = 46
        '
        'colDateT
        '
        Me.colDateT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDateT.HeaderText = "Date"
        Me.colDateT.Name = "colDateT"
        Me.colDateT.ReadOnly = True
        Me.colDateT.Width = 62
        '
        'colTableT
        '
        Me.colTableT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colTableT.HeaderText = "T#"
        Me.colTableT.Name = "colTableT"
        Me.colTableT.ReadOnly = True
        Me.colTableT.Width = 49
        '
        'colOrderName
        '
        Me.colOrderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colOrderName.HeaderText = "Name"
        Me.colOrderName.Name = "colOrderName"
        Me.colOrderName.ReadOnly = True
        Me.colOrderName.Width = 70
        '
        'colQtyT
        '
        Me.colQtyT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colQtyT.HeaderText = "Qty"
        Me.colQtyT.Name = "colQtyT"
        Me.colQtyT.ReadOnly = True
        Me.colQtyT.Width = 53
        '
        'colOrderPrice
        '
        Me.colOrderPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colOrderPrice.HeaderText = "Price"
        Me.colOrderPrice.Name = "colOrderPrice"
        Me.colOrderPrice.ReadOnly = True
        Me.colOrderPrice.Width = 64
        '
        'colHours
        '
        Me.colHours.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colHours.HeaderText = "Hrs"
        Me.colHours.Name = "colHours"
        Me.colHours.ReadOnly = True
        Me.colHours.Width = 54
        '
        'colTotal
        '
        Me.colTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colTotal.HeaderText = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.ReadOnly = True
        Me.colTotal.Width = 64
        '
        'colPayment
        '
        Me.colPayment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colPayment.HeaderText = "Pay"
        Me.colPayment.Name = "colPayment"
        Me.colPayment.ReadOnly = True
        Me.colPayment.Width = 57
        '
        'grpTransactions
        '
        Me.grpTransactions.Controls.Add(Me.dgvTableTransactions)
        Me.grpTransactions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTransactions.Location = New System.Drawing.Point(18, 16)
        Me.grpTransactions.Name = "grpTransactions"
        Me.grpTransactions.Size = New System.Drawing.Size(364, 191)
        Me.grpTransactions.TabIndex = 3
        Me.grpTransactions.TabStop = False
        Me.grpTransactions.Text = "Transactions"
        '
        'dgvTableTransactions
        '
        Me.dgvTableTransactions.AllowUserToAddRows = False
        Me.dgvTableTransactions.AllowUserToDeleteRows = False
        Me.dgvTableTransactions.AllowUserToResizeRows = False
        Me.dgvTableTransactions.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvTableTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTableTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTableTransactions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colId, Me.colDateTimeStamp, Me.colTableNumber, Me.colOrderIds, Me.colPayT})
        Me.dgvTableTransactions.Location = New System.Drawing.Point(12, 23)
        Me.dgvTableTransactions.MultiSelect = False
        Me.dgvTableTransactions.Name = "dgvTableTransactions"
        Me.dgvTableTransactions.ReadOnly = True
        Me.dgvTableTransactions.RowHeadersVisible = False
        Me.dgvTableTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTableTransactions.Size = New System.Drawing.Size(337, 143)
        Me.dgvTableTransactions.TabIndex = 2
        '
        'colId
        '
        Me.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colId.HeaderText = "ID"
        Me.colId.Name = "colId"
        Me.colId.ReadOnly = True
        Me.colId.Width = 46
        '
        'colDateTimeStamp
        '
        Me.colDateTimeStamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDateTimeStamp.HeaderText = "Date"
        Me.colDateTimeStamp.Name = "colDateTimeStamp"
        Me.colDateTimeStamp.ReadOnly = True
        Me.colDateTimeStamp.Width = 62
        '
        'colTableNumber
        '
        Me.colTableNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colTableNumber.HeaderText = "T#"
        Me.colTableNumber.Name = "colTableNumber"
        Me.colTableNumber.ReadOnly = True
        Me.colTableNumber.Width = 49
        '
        'colOrderIds
        '
        Me.colOrderIds.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colOrderIds.HeaderText = "Orders"
        Me.colOrderIds.Name = "colOrderIds"
        Me.colOrderIds.ReadOnly = True
        Me.colOrderIds.Width = 74
        '
        'colPayT
        '
        Me.colPayT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colPayT.HeaderText = "Pay"
        Me.colPayT.Name = "colPayT"
        Me.colPayT.ReadOnly = True
        Me.colPayT.Width = 57
        '
        'groupCashbox
        '
        Me.groupCashbox.Controls.Add(Me.lblCashbox)
        Me.groupCashbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupCashbox.Location = New System.Drawing.Point(614, 16)
        Me.groupCashbox.Name = "groupCashbox"
        Me.groupCashbox.Size = New System.Drawing.Size(107, 86)
        Me.groupCashbox.TabIndex = 1
        Me.groupCashbox.TabStop = False
        Me.groupCashbox.Text = "Cashbox"
        '
        'lblCashbox
        '
        Me.lblCashbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCashbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashbox.Location = New System.Drawing.Point(6, 20)
        Me.lblCashbox.Name = "lblCashbox"
        Me.lblCashbox.Size = New System.Drawing.Size(95, 53)
        Me.lblCashbox.TabIndex = 0
        Me.lblCashbox.Text = "-----"
        Me.lblCashbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 545)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "formMain"
        Me.Text = "Experience Point of Sale"
        Me.TabControl1.ResumeLayout(False)
        Me.tabpageHall.ResumeLayout(False)
        Me.tabpageTable.ResumeLayout(False)
        Me.tabpageTable.PerformLayout()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpageReview.ResumeLayout(False)
        Me.grpTransactionDetails.ResumeLayout(False)
        CType(Me.dgvTransactionDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTransactions.ResumeLayout(False)
        CType(Me.dgvTableTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupCashbox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableButton1 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabpageHall As System.Windows.Forms.TabPage
    Friend WithEvents tabpageTable As System.Windows.Forms.TabPage
    Friend WithEvents panelOrderButtons As System.Windows.Forms.Panel
    Friend WithEvents lblTableNumber As System.Windows.Forms.Label
    Friend WithEvents tabpageCustomers As System.Windows.Forms.TabPage
    Friend WithEvents lblTableTotalPrice As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents buttonPay As System.Windows.Forms.Button
    Friend WithEvents ButtonQty As System.Windows.Forms.Button
    Friend WithEvents TableButton2 As System.Windows.Forms.Button
    Friend WithEvents ButtonPrice As System.Windows.Forms.Button
    Friend WithEvents ButtonTime As System.Windows.Forms.Button
    Friend WithEvents tabpageReview As System.Windows.Forms.TabPage
    Friend WithEvents groupCashbox As System.Windows.Forms.GroupBox
    Friend WithEvents lblCashbox As System.Windows.Forms.Label
    Friend WithEvents grpTransactions As System.Windows.Forms.GroupBox
    Friend WithEvents dgvTableTransactions As System.Windows.Forms.DataGridView
    Friend WithEvents grpTransactionDetails As System.Windows.Forms.GroupBox
    Friend WithEvents dgvTransactionDetails As System.Windows.Forms.DataGridView
    Friend WithEvents buttonCoB As System.Windows.Forms.Button
    Friend WithEvents tt As System.Windows.Forms.ToolTip
    Friend WithEvents dgvOrders As System.Windows.Forms.DataGridView
    Friend WithEvents colTableOrderName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTableOrderQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTableSubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIdT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDateT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTableT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOrderName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQtyT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOrderPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHours As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPayment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDateTimeStamp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTableNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOrderIds As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPayT As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
