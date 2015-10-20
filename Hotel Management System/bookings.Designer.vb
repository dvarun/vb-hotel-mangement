<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bookings
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ROOMNUMBERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHECKINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHECKOUTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALROOMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALPRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAYSTATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BOOKINGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bookz = New Hotel_Management_System.bookz()
        Me.BOOKINGTableAdapter = New Hotel_Management_System.bookzTableAdapters.BOOKINGTableAdapter()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtBid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOKINGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bookz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BIDDataGridViewTextBoxColumn, Me.CUSIDDataGridViewTextBoxColumn, Me.ROOMNUMBERDataGridViewTextBoxColumn, Me.CHECKINDataGridViewTextBoxColumn, Me.CHECKOUTDataGridViewTextBoxColumn, Me.TOTALROOMDataGridViewTextBoxColumn, Me.TOTALPRICEDataGridViewTextBoxColumn, Me.PAYSTATUSDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BOOKINGBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(832, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'BIDDataGridViewTextBoxColumn
        '
        Me.BIDDataGridViewTextBoxColumn.DataPropertyName = "BID"
        Me.BIDDataGridViewTextBoxColumn.HeaderText = "BID"
        Me.BIDDataGridViewTextBoxColumn.Name = "BIDDataGridViewTextBoxColumn"
        '
        'CUSIDDataGridViewTextBoxColumn
        '
        Me.CUSIDDataGridViewTextBoxColumn.DataPropertyName = "CUS_ID"
        Me.CUSIDDataGridViewTextBoxColumn.HeaderText = "CUS_ID"
        Me.CUSIDDataGridViewTextBoxColumn.Name = "CUSIDDataGridViewTextBoxColumn"
        '
        'ROOMNUMBERDataGridViewTextBoxColumn
        '
        Me.ROOMNUMBERDataGridViewTextBoxColumn.DataPropertyName = "ROOM_NUMBER"
        Me.ROOMNUMBERDataGridViewTextBoxColumn.HeaderText = "ROOM_NUMBER"
        Me.ROOMNUMBERDataGridViewTextBoxColumn.Name = "ROOMNUMBERDataGridViewTextBoxColumn"
        '
        'CHECKINDataGridViewTextBoxColumn
        '
        Me.CHECKINDataGridViewTextBoxColumn.DataPropertyName = "CHECKIN"
        Me.CHECKINDataGridViewTextBoxColumn.HeaderText = "CHECKIN"
        Me.CHECKINDataGridViewTextBoxColumn.Name = "CHECKINDataGridViewTextBoxColumn"
        '
        'CHECKOUTDataGridViewTextBoxColumn
        '
        Me.CHECKOUTDataGridViewTextBoxColumn.DataPropertyName = "CHECKOUT"
        Me.CHECKOUTDataGridViewTextBoxColumn.HeaderText = "CHECKOUT"
        Me.CHECKOUTDataGridViewTextBoxColumn.Name = "CHECKOUTDataGridViewTextBoxColumn"
        '
        'TOTALROOMDataGridViewTextBoxColumn
        '
        Me.TOTALROOMDataGridViewTextBoxColumn.DataPropertyName = "TOTALROOM"
        Me.TOTALROOMDataGridViewTextBoxColumn.HeaderText = "TOTALROOM"
        Me.TOTALROOMDataGridViewTextBoxColumn.Name = "TOTALROOMDataGridViewTextBoxColumn"
        '
        'TOTALPRICEDataGridViewTextBoxColumn
        '
        Me.TOTALPRICEDataGridViewTextBoxColumn.DataPropertyName = "TOTALPRICE"
        Me.TOTALPRICEDataGridViewTextBoxColumn.HeaderText = "TOTALPRICE"
        Me.TOTALPRICEDataGridViewTextBoxColumn.Name = "TOTALPRICEDataGridViewTextBoxColumn"
        '
        'PAYSTATUSDataGridViewTextBoxColumn
        '
        Me.PAYSTATUSDataGridViewTextBoxColumn.DataPropertyName = "PAY_STATUS"
        Me.PAYSTATUSDataGridViewTextBoxColumn.HeaderText = "PAY_STATUS"
        Me.PAYSTATUSDataGridViewTextBoxColumn.Name = "PAYSTATUSDataGridViewTextBoxColumn"
        '
        'BOOKINGBindingSource
        '
        Me.BOOKINGBindingSource.DataMember = "BOOKING"
        Me.BOOKINGBindingSource.DataSource = Me.Bookz
        '
        'Bookz
        '
        Me.Bookz.DataSetName = "bookz"
        Me.Bookz.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BOOKINGTableAdapter
        '
        Me.BOOKINGTableAdapter.ClearBeforeFill = True
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.YellowGreen
        Me.btn_back.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.Location = New System.Drawing.Point(0, 231)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(832, 31)
        Me.btn_back.TabIndex = 1
        Me.btn_back.Text = "CLOSE"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(218, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtBid
        '
        Me.txtBid.Location = New System.Drawing.Point(112, 174)
        Me.txtBid.Name = "txtBid"
        Me.txtBid.Size = New System.Drawing.Size(100, 20)
        Me.txtBid.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter Booking ID: "
        '
        'bookings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 262)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBid)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "bookings"
        Me.Text = "Bookings"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOKINGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bookz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Bookz As Hotel_Management_System.bookz
    Friend WithEvents BOOKINGBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BOOKINGTableAdapter As Hotel_Management_System.bookzTableAdapters.BOOKINGTableAdapter
    Friend WithEvents BIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUSIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ROOMNUMBERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHECKINDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHECKOUTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALROOMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALPRICEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PAYSTATUSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtBid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
