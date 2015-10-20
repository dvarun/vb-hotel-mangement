<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.btn_reserve = New System.Windows.Forms.Button()
        Me.btn_chk = New System.Windows.Forms.Button()
        Me.btn_allu = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_pay = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btn_se2 = New System.Windows.Forms.Button()
        Me.lbl_search = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.btn_payment = New System.Windows.Forms.Button()
        Me.passId = New System.Windows.Forms.TextBox()
        Me.passName = New System.Windows.Forms.TextBox()
        Me.btn_bill = New System.Windows.Forms.Button()
        Me.tariff = New System.Windows.Forms.DataGridView()
        Me.ROOMCATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RPRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ROOMCATEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Hotel_Management_System.DataSet1()
        Me.ROOM_CATETableAdapter = New Hotel_Management_System.DataSet1TableAdapters.ROOM_CATETableAdapter()
        Me.btn_admin = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_cls = New System.Windows.Forms.Button()
        Me.Btn_payments = New System.Windows.Forms.Button()
        CType(Me.tariff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ROOMCATEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_reserve
        '
        Me.btn_reserve.Location = New System.Drawing.Point(175, 150)
        Me.btn_reserve.Name = "btn_reserve"
        Me.btn_reserve.Size = New System.Drawing.Size(155, 72)
        Me.btn_reserve.TabIndex = 1
        Me.btn_reserve.Text = "CHECK IN"
        Me.btn_reserve.UseVisualStyleBackColor = True
        '
        'btn_chk
        '
        Me.btn_chk.Location = New System.Drawing.Point(175, 55)
        Me.btn_chk.Name = "btn_chk"
        Me.btn_chk.Size = New System.Drawing.Size(155, 72)
        Me.btn_chk.TabIndex = 3
        Me.btn_chk.Text = "CHECK AVAILABILITY"
        Me.btn_chk.UseVisualStyleBackColor = True
        '
        'btn_allu
        '
        Me.btn_allu.Location = New System.Drawing.Point(14, 150)
        Me.btn_allu.Name = "btn_allu"
        Me.btn_allu.Size = New System.Drawing.Size(155, 72)
        Me.btn_allu.TabIndex = 4
        Me.btn_allu.Text = "ALL GUESTS"
        Me.btn_allu.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(237, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(215, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Hotel Mangement System"
        '
        'btn_pay
        '
        Me.btn_pay.Location = New System.Drawing.Point(14, 55)
        Me.btn_pay.Name = "btn_pay"
        Me.btn_pay.Size = New System.Drawing.Size(155, 72)
        Me.btn_pay.TabIndex = 7
        Me.btn_pay.Text = "CHECK OUT"
        Me.btn_pay.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(15, 247)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(263, 22)
        Me.txtSearch.TabIndex = 8
        '
        'btn_se2
        '
        Me.btn_se2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_se2.Location = New System.Drawing.Point(284, 246)
        Me.btn_se2.Name = "btn_se2"
        Me.btn_se2.Size = New System.Drawing.Size(118, 23)
        Me.btn_se2.TabIndex = 9
        Me.btn_se2.Text = "Search By Name"
        Me.btn_se2.UseVisualStyleBackColor = True
        '
        'lbl_search
        '
        Me.lbl_search.AutoSize = True
        Me.lbl_search.BackColor = System.Drawing.Color.Teal
        Me.lbl_search.ForeColor = System.Drawing.Color.White
        Me.lbl_search.Location = New System.Drawing.Point(53, 287)
        Me.lbl_search.Name = "lbl_search"
        Me.lbl_search.Size = New System.Drawing.Size(0, 13)
        Me.lbl_search.TabIndex = 10
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Maroon
        Me.lbl_id.ForeColor = System.Drawing.Color.White
        Me.lbl_id.Location = New System.Drawing.Point(12, 287)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(0, 13)
        Me.lbl_id.TabIndex = 11
        '
        'btn_payment
        '
        Me.btn_payment.BackColor = System.Drawing.Color.YellowGreen
        Me.btn_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_payment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_payment.ForeColor = System.Drawing.Color.White
        Me.btn_payment.Location = New System.Drawing.Point(155, 280)
        Me.btn_payment.Name = "btn_payment"
        Me.btn_payment.Size = New System.Drawing.Size(78, 28)
        Me.btn_payment.TabIndex = 12
        Me.btn_payment.Text = "Check Out" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_payment.UseVisualStyleBackColor = False
        '
        'passId
        '
        Me.passId.Location = New System.Drawing.Point(302, 288)
        Me.passId.Name = "passId"
        Me.passId.Size = New System.Drawing.Size(100, 20)
        Me.passId.TabIndex = 13
        '
        'passName
        '
        Me.passName.Location = New System.Drawing.Point(302, 326)
        Me.passName.Name = "passName"
        Me.passName.Size = New System.Drawing.Size(100, 20)
        Me.passName.TabIndex = 14
        '
        'btn_bill
        '
        Me.btn_bill.Location = New System.Drawing.Point(336, 55)
        Me.btn_bill.Name = "btn_bill"
        Me.btn_bill.Size = New System.Drawing.Size(75, 167)
        Me.btn_bill.TabIndex = 15
        Me.btn_bill.Text = "BILLS"
        Me.btn_bill.UseVisualStyleBackColor = True
        '
        'tariff
        '
        Me.tariff.AllowUserToAddRows = False
        Me.tariff.AllowUserToDeleteRows = False
        Me.tariff.AutoGenerateColumns = False
        Me.tariff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tariff.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ROOMCATEDataGridViewTextBoxColumn, Me.RPRICEDataGridViewTextBoxColumn})
        Me.tariff.DataSource = Me.ROOMCATEBindingSource
        Me.tariff.Location = New System.Drawing.Point(417, 55)
        Me.tariff.Name = "tariff"
        Me.tariff.ReadOnly = True
        Me.tariff.Size = New System.Drawing.Size(245, 90)
        Me.tariff.TabIndex = 16
        '
        'ROOMCATEDataGridViewTextBoxColumn
        '
        Me.ROOMCATEDataGridViewTextBoxColumn.DataPropertyName = "ROOM_CATE"
        Me.ROOMCATEDataGridViewTextBoxColumn.HeaderText = "ROOM_CATE"
        Me.ROOMCATEDataGridViewTextBoxColumn.Name = "ROOMCATEDataGridViewTextBoxColumn"
        Me.ROOMCATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RPRICEDataGridViewTextBoxColumn
        '
        Me.RPRICEDataGridViewTextBoxColumn.DataPropertyName = "RPRICE"
        Me.RPRICEDataGridViewTextBoxColumn.HeaderText = "RPRICE"
        Me.RPRICEDataGridViewTextBoxColumn.Name = "RPRICEDataGridViewTextBoxColumn"
        Me.RPRICEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ROOMCATEBindingSource
        '
        Me.ROOMCATEBindingSource.DataMember = "ROOM_CATE"
        Me.ROOMCATEBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ROOM_CATETableAdapter
        '
        Me.ROOM_CATETableAdapter.ClearBeforeFill = True
        '
        'btn_admin
        '
        Me.btn_admin.Location = New System.Drawing.Point(418, 154)
        Me.btn_admin.Name = "btn_admin"
        Me.btn_admin.Size = New System.Drawing.Size(244, 65)
        Me.btn_admin.TabIndex = 17
        Me.btn_admin.Text = "Employee Detail"
        Me.btn_admin.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(417, 225)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(244, 64)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "BOOKING DETAILS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_cls
        '
        Me.btn_cls.BackColor = System.Drawing.Color.DarkRed
        Me.btn_cls.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cls.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cls.ForeColor = System.Drawing.Color.White
        Me.btn_cls.Location = New System.Drawing.Point(586, 6)
        Me.btn_cls.Name = "btn_cls"
        Me.btn_cls.Size = New System.Drawing.Size(75, 31)
        Me.btn_cls.TabIndex = 19
        Me.btn_cls.Text = "CLOSE"
        Me.btn_cls.UseVisualStyleBackColor = False
        '
        'Btn_payments
        '
        Me.Btn_payments.Location = New System.Drawing.Point(417, 295)
        Me.Btn_payments.Name = "Btn_payments"
        Me.Btn_payments.Size = New System.Drawing.Size(244, 64)
        Me.Btn_payments.TabIndex = 20
        Me.Btn_payments.Text = "PAYMENTS"
        Me.Btn_payments.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 377)
        Me.Controls.Add(Me.Btn_payments)
        Me.Controls.Add(Me.btn_cls)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_admin)
        Me.Controls.Add(Me.tariff)
        Me.Controls.Add(Me.btn_bill)
        Me.Controls.Add(Me.passName)
        Me.Controls.Add(Me.passId)
        Me.Controls.Add(Me.btn_payment)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_search)
        Me.Controls.Add(Me.btn_se2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btn_pay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_allu)
        Me.Controls.Add(Me.btn_chk)
        Me.Controls.Add(Me.btn_reserve)
        Me.Name = "Menu"
        Me.Text = "Menu"
        CType(Me.tariff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ROOMCATEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_reserve As System.Windows.Forms.Button
    Friend WithEvents btn_chk As System.Windows.Forms.Button
    Friend WithEvents btn_allu As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_pay As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btn_se2 As System.Windows.Forms.Button
    Friend WithEvents lbl_search As System.Windows.Forms.Label
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents btn_payment As System.Windows.Forms.Button
    Friend WithEvents btn_bill As System.Windows.Forms.Button
    Public WithEvents passId As System.Windows.Forms.TextBox
    Public WithEvents passName As System.Windows.Forms.TextBox
    Friend WithEvents tariff As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As Hotel_Management_System.DataSet1
    Friend WithEvents ROOMCATEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ROOM_CATETableAdapter As Hotel_Management_System.DataSet1TableAdapters.ROOM_CATETableAdapter
    Friend WithEvents ROOMCATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RPRICEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_admin As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_cls As System.Windows.Forms.Button
    Friend WithEvents Btn_payments As System.Windows.Forms.Button
End Class
