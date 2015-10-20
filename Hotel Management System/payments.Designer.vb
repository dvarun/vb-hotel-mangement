<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payments
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
        Me.PAYMENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaySet = New Hotel_Management_System.PaySet()
        Me.PAYMENTTableAdapter = New Hotel_Management_System.PaySetTableAdapters.PAYMENTTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPid = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.PIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAYDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALAMTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAYMODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PAYMENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaySet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PIDDataGridViewTextBoxColumn, Me.CIDDataGridViewTextBoxColumn, Me.PAYDATEDataGridViewTextBoxColumn, Me.TOTALAMTDataGridViewTextBoxColumn, Me.PAYMODEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PAYMENTBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(543, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'PAYMENTBindingSource
        '
        Me.PAYMENTBindingSource.DataMember = "PAYMENT"
        Me.PAYMENTBindingSource.DataSource = Me.PaySet
        '
        'PaySet
        '
        Me.PaySet.DataSetName = "PaySet"
        Me.PaySet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PAYMENTTableAdapter
        '
        Me.PAYMENTTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Enter PID: "
        '
        'txtPid
        '
        Me.txtPid.Location = New System.Drawing.Point(108, 165)
        Me.txtPid.Name = "txtPid"
        Me.txtPid.Size = New System.Drawing.Size(100, 20)
        Me.txtPid.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(214, 163)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.YellowGreen
        Me.btn_back.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.Location = New System.Drawing.Point(0, 297)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(543, 31)
        Me.btn_back.TabIndex = 5
        Me.btn_back.Text = "CLOSE"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'PIDDataGridViewTextBoxColumn
        '
        Me.PIDDataGridViewTextBoxColumn.DataPropertyName = "PID"
        Me.PIDDataGridViewTextBoxColumn.HeaderText = "PID"
        Me.PIDDataGridViewTextBoxColumn.Name = "PIDDataGridViewTextBoxColumn"
        Me.PIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CIDDataGridViewTextBoxColumn
        '
        Me.CIDDataGridViewTextBoxColumn.DataPropertyName = "CID"
        Me.CIDDataGridViewTextBoxColumn.HeaderText = "CID"
        Me.CIDDataGridViewTextBoxColumn.Name = "CIDDataGridViewTextBoxColumn"
        Me.CIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PAYDATEDataGridViewTextBoxColumn
        '
        Me.PAYDATEDataGridViewTextBoxColumn.DataPropertyName = "PAY_DATE"
        Me.PAYDATEDataGridViewTextBoxColumn.HeaderText = "PAY_DATE"
        Me.PAYDATEDataGridViewTextBoxColumn.Name = "PAYDATEDataGridViewTextBoxColumn"
        Me.PAYDATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TOTALAMTDataGridViewTextBoxColumn
        '
        Me.TOTALAMTDataGridViewTextBoxColumn.DataPropertyName = "TOTALAMT"
        Me.TOTALAMTDataGridViewTextBoxColumn.HeaderText = "TOTALAMT"
        Me.TOTALAMTDataGridViewTextBoxColumn.Name = "TOTALAMTDataGridViewTextBoxColumn"
        Me.TOTALAMTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PAYMODEDataGridViewTextBoxColumn
        '
        Me.PAYMODEDataGridViewTextBoxColumn.DataPropertyName = "PAY_MODE"
        Me.PAYMODEDataGridViewTextBoxColumn.HeaderText = "PAY_MODE"
        Me.PAYMODEDataGridViewTextBoxColumn.Name = "PAYMODEDataGridViewTextBoxColumn"
        Me.PAYMODEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Payments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 328)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPid)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Payments"
        Me.Text = "Payments"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PAYMENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaySet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PaySet As Hotel_Management_System.PaySet
    Friend WithEvents PAYMENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PAYMENTTableAdapter As Hotel_Management_System.PaySetTableAdapters.PAYMENTTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPid As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents PIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PAYDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALAMTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PAYMODEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
