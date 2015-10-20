<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bills
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
        Me.Btn_Bill = New System.Windows.Forms.Button()
        Me.lbl_cus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lbl_Cid = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lbl_country = New System.Windows.Forms.Label()
        Me.lbl_city = New System.Windows.Forms.Label()
        Me.lbl_phone = New System.Windows.Forms.Label()
        Me.chkin = New System.Windows.Forms.Label()
        Me.chkOut = New System.Windows.Forms.Label()
        Me.amt = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Btn_Bill
        '
        Me.Btn_Bill.Location = New System.Drawing.Point(0, 20)
        Me.Btn_Bill.Name = "Btn_Bill"
        Me.Btn_Bill.Size = New System.Drawing.Size(406, 23)
        Me.Btn_Bill.TabIndex = 1
        Me.Btn_Bill.Text = "Select Customer Id To Generate BILL"
        Me.Btn_Bill.UseVisualStyleBackColor = True
        '
        'lbl_cus
        '
        Me.lbl_cus.AutoSize = True
        Me.lbl_cus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cus.Location = New System.Drawing.Point(13, 50)
        Me.lbl_cus.Name = "lbl_cus"
        Me.lbl_cus.Size = New System.Drawing.Size(86, 15)
        Me.lbl_cus.TabIndex = 2
        Me.lbl_cus.Text = "Customer ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(197, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Country"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(276, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "City"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Phone:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Check In:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Check Out:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(215, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Total Amount"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(406, 394)
        Me.ShapeContainer1.TabIndex = 10
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape5
        '
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = -1
        Me.LineShape5.X2 = 405
        Me.LineShape5.Y1 = 108
        Me.LineShape5.Y2 = 108
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 260
        Me.LineShape4.X2 = 260
        Me.LineShape4.Y1 = 41
        Me.LineShape4.Y2 = 107
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 183
        Me.LineShape3.X2 = 183
        Me.LineShape3.Y1 = 41
        Me.LineShape3.Y2 = 107
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 107
        Me.LineShape2.X2 = 107
        Me.LineShape2.Y1 = 41
        Me.LineShape2.Y2 = 107
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -1
        Me.LineShape1.X2 = 408
        Me.LineShape1.Y1 = 76
        Me.LineShape1.Y2 = 76
        '
        'lbl_Cid
        '
        Me.lbl_Cid.AutoSize = True
        Me.lbl_Cid.Location = New System.Drawing.Point(26, 86)
        Me.lbl_Cid.Name = "lbl_Cid"
        Me.lbl_Cid.Size = New System.Drawing.Size(21, 13)
        Me.lbl_Cid.TabIndex = 11
        Me.lbl_Cid.Text = "cid"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(108, 86)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 12
        Me.lblName.Text = "Name"
        '
        'lbl_country
        '
        Me.lbl_country.AutoSize = True
        Me.lbl_country.Location = New System.Drawing.Point(190, 86)
        Me.lbl_country.Name = "lbl_country"
        Me.lbl_country.Size = New System.Drawing.Size(42, 13)
        Me.lbl_country.TabIndex = 13
        Me.lbl_country.Text = "country"
        '
        'lbl_city
        '
        Me.lbl_city.AutoSize = True
        Me.lbl_city.Location = New System.Drawing.Point(276, 86)
        Me.lbl_city.Name = "lbl_city"
        Me.lbl_city.Size = New System.Drawing.Size(23, 13)
        Me.lbl_city.TabIndex = 14
        Me.lbl_city.Text = "city"
        '
        'lbl_phone
        '
        Me.lbl_phone.AutoSize = True
        Me.lbl_phone.Location = New System.Drawing.Point(80, 133)
        Me.lbl_phone.Name = "lbl_phone"
        Me.lbl_phone.Size = New System.Drawing.Size(44, 13)
        Me.lbl_phone.TabIndex = 15
        Me.lbl_phone.Text = "Number"
        '
        'chkin
        '
        Me.chkin.AutoSize = True
        Me.chkin.Location = New System.Drawing.Point(85, 183)
        Me.chkin.Name = "chkin"
        Me.chkin.Size = New System.Drawing.Size(49, 13)
        Me.chkin.TabIndex = 16
        Me.chkin.Text = "Check in"
        '
        'chkOut
        '
        Me.chkOut.AutoSize = True
        Me.chkOut.Location = New System.Drawing.Point(85, 217)
        Me.chkOut.Name = "chkOut"
        Me.chkOut.Size = New System.Drawing.Size(58, 13)
        Me.chkOut.TabIndex = 17
        Me.chkOut.Text = "Check Out"
        '
        'amt
        '
        Me.amt.AutoSize = True
        Me.amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amt.Location = New System.Drawing.Point(248, 330)
        Me.amt.Name = "amt"
        Me.amt.Size = New System.Drawing.Size(53, 16)
        Me.amt.TabIndex = 18
        Me.amt.Text = "Amount"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.YellowGreen
        Me.btn_back.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.Location = New System.Drawing.Point(0, 363)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(406, 31)
        Me.btn_back.TabIndex = 19
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'cb1
        '
        Me.cb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.cb1.FormattingEnabled = True
        Me.cb1.Location = New System.Drawing.Point(0, 0)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(406, 21)
        Me.cb1.TabIndex = 20
        '
        'Bills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(406, 394)
        Me.Controls.Add(Me.cb1)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.amt)
        Me.Controls.Add(Me.chkOut)
        Me.Controls.Add(Me.chkin)
        Me.Controls.Add(Me.lbl_phone)
        Me.Controls.Add(Me.lbl_city)
        Me.Controls.Add(Me.lbl_country)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lbl_Cid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_cus)
        Me.Controls.Add(Me.Btn_Bill)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Bills"
        Me.Text = "Bills"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Bill As System.Windows.Forms.Button
    Friend WithEvents lbl_cus As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lbl_Cid As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lbl_country As System.Windows.Forms.Label
    Friend WithEvents lbl_city As System.Windows.Forms.Label
    Friend WithEvents lbl_phone As System.Windows.Forms.Label
    Friend WithEvents chkin As System.Windows.Forms.Label
    Friend WithEvents chkOut As System.Windows.Forms.Label
    Friend WithEvents amt As System.Windows.Forms.Label
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents cb1 As System.Windows.Forms.ComboBox
End Class
