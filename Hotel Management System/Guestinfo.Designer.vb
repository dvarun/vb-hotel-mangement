<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guest_Info
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
        Me.gname = New System.Windows.Forms.RichTextBox()
        Me.glname = New System.Windows.Forms.RichTextBox()
        Me.address = New System.Windows.Forms.RichTextBox()
        Me.city = New System.Windows.Forms.RichTextBox()
        Me.pcode = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mobno = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.nationality = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.fax = New System.Windows.Forms.RichTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.RichTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.checkin = New System.Windows.Forms.Button()
        Me.idnum = New System.Windows.Forms.RichTextBox()
        Me.idcb = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.company = New System.Windows.Forms.RichTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.gendercb = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.phone = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.States = New System.Windows.Forms.RichTextBox()
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtGid = New System.Windows.Forms.TextBox()
        Me.lbl_valid = New System.Windows.Forms.Label()
        Me.lbl_NotValid = New System.Windows.Forms.Label()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gname
        '
        Me.gname.Location = New System.Drawing.Point(145, 75)
        Me.gname.Name = "gname"
        Me.gname.Size = New System.Drawing.Size(121, 23)
        Me.gname.TabIndex = 1
        Me.gname.Text = ""
        '
        'glname
        '
        Me.glname.Location = New System.Drawing.Point(416, 75)
        Me.glname.Name = "glname"
        Me.glname.Size = New System.Drawing.Size(121, 23)
        Me.glname.TabIndex = 2
        Me.glname.Text = ""
        '
        'address
        '
        Me.address.Location = New System.Drawing.Point(145, 164)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(152, 59)
        Me.address.TabIndex = 6
        Me.address.Text = ""
        '
        'city
        '
        Me.city.Location = New System.Drawing.Point(145, 288)
        Me.city.Name = "city"
        Me.city.Size = New System.Drawing.Size(121, 23)
        Me.city.TabIndex = 9
        Me.city.Text = ""
        '
        'pcode
        '
        Me.pcode.Location = New System.Drawing.Point(416, 288)
        Me.pcode.Name = "pcode"
        Me.pcode.Size = New System.Drawing.Size(121, 23)
        Me.pcode.TabIndex = 10
        Me.pcode.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Guest First Name*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(323, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Guest Last name*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Address*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 416)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "ID Proof*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "City*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(52, 262)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "State"
        '
        'mobno
        '
        Me.mobno.Location = New System.Drawing.Point(145, 351)
        Me.mobno.Name = "mobno"
        Me.mobno.Size = New System.Drawing.Size(121, 23)
        Me.mobno.TabIndex = 12
        Me.mobno.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(52, 354)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Mobile Number*"
        '
        'nationality
        '
        Me.nationality.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.nationality.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.nationality.FormattingEnabled = True
        Me.nationality.Items.AddRange(New Object() {"Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas, The", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei ", "Bulgaria", "Burkina Faso", "Burma", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros ", "Congo, Democratic Republic of the", "Congo, Republic of the ", "Costa Rica", "Cote d'Ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor ", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia, The", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Holy See", "Honduras", "Hong Kong", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, North", "Korea, South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macau", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Namibia", "Nauru", "Nepal", "Netherlands", "Netherlands Antilles", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Korea", "Norway", "Oman", "Pakistan", "Palau", "Palestinian Territories", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa ", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Korea", "South Sudan", "Spain ", "Sri Lanka", "Sudan", "Suriname", "Swaziland ", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand ", "Timor-Leste", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "Uruguay", "Uzbekistan", "Vanuatu", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe"})
        Me.nationality.Location = New System.Drawing.Point(176, 229)
        Me.nationality.Name = "nationality"
        Me.nationality.Size = New System.Drawing.Size(121, 21)
        Me.nationality.TabIndex = 7
        Me.nationality.Text = "--Country--"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(52, 380)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "E Mail*"
        '
        'fax
        '
        Me.fax.Location = New System.Drawing.Point(416, 351)
        Me.fax.Name = "fax"
        Me.fax.Size = New System.Drawing.Size(121, 23)
        Me.fax.TabIndex = 13
        Me.fax.Text = ""
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(158, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(283, 42)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Guest Information"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(361, 291)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Pin code*"
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(145, 380)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(121, 23)
        Me.email.TabIndex = 14
        Me.email.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(363, 354)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Fax"
        '
        'checkin
        '
        Me.checkin.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkin.Location = New System.Drawing.Point(145, 447)
        Me.checkin.Name = "checkin"
        Me.checkin.Size = New System.Drawing.Size(135, 25)
        Me.checkin.TabIndex = 28
        Me.checkin.Text = "Reserve"
        Me.checkin.UseVisualStyleBackColor = True
        '
        'idnum
        '
        Me.idnum.Location = New System.Drawing.Point(416, 411)
        Me.idnum.Name = "idnum"
        Me.idnum.Size = New System.Drawing.Size(121, 23)
        Me.idnum.TabIndex = 16
        Me.idnum.Text = ""
        '
        'idcb
        '
        Me.idcb.FormattingEnabled = True
        Me.idcb.Items.AddRange(New Object() {"Passport", "Driving License", "PAN card", "Govt Employee ID", "Other..."})
        Me.idcb.Location = New System.Drawing.Point(145, 413)
        Me.idcb.Name = "idcb"
        Me.idcb.Size = New System.Drawing.Size(121, 21)
        Me.idcb.TabIndex = 15
        Me.idcb.Text = "--Select--"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(52, 133)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 13)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Company"
        '
        'company
        '
        Me.company.Location = New System.Drawing.Point(145, 132)
        Me.company.Name = "company"
        Me.company.Size = New System.Drawing.Size(152, 23)
        Me.company.TabIndex = 5
        Me.company.Text = ""
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(352, 416)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 13)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "ID Number"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(52, 103)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 13)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "gender"
        '
        'gendercb
        '
        Me.gendercb.FormattingEnabled = True
        Me.gendercb.Items.AddRange(New Object() {"Male", "Female"})
        Me.gendercb.Location = New System.Drawing.Point(145, 104)
        Me.gendercb.Name = "gendercb"
        Me.gendercb.Size = New System.Drawing.Size(78, 21)
        Me.gendercb.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 322)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Telephone"
        '
        'phone
        '
        Me.phone.Location = New System.Drawing.Point(145, 319)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(121, 23)
        Me.phone.TabIndex = 11
        Me.phone.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Country of Residence*"
        '
        'States
        '
        Me.States.Location = New System.Drawing.Point(145, 256)
        Me.States.Name = "States"
        Me.States.Size = New System.Drawing.Size(121, 23)
        Me.States.TabIndex = 8
        Me.States.Text = ""
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 503)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(590, 22)
        Me.StatusBar1.TabIndex = 47
        Me.StatusBar1.Text = "StatusBar1"
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Text = "time"
        Me.StatusBarPanel1.Width = 573
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(318, 447)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 25)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtGid
        '
        Me.txtGid.Enabled = False
        Me.txtGid.Location = New System.Drawing.Point(44, 12)
        Me.txtGid.Name = "txtGid"
        Me.txtGid.Size = New System.Drawing.Size(100, 20)
        Me.txtGid.TabIndex = 49
        '
        'lbl_valid
        '
        Me.lbl_valid.AutoSize = True
        Me.lbl_valid.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_valid.Location = New System.Drawing.Point(272, 383)
        Me.lbl_valid.Name = "lbl_valid"
        Me.lbl_valid.Size = New System.Drawing.Size(30, 13)
        Me.lbl_valid.TabIndex = 50
        Me.lbl_valid.Text = "Valid"
        '
        'lbl_NotValid
        '
        Me.lbl_NotValid.AutoSize = True
        Me.lbl_NotValid.ForeColor = System.Drawing.Color.DarkRed
        Me.lbl_NotValid.Location = New System.Drawing.Point(272, 383)
        Me.lbl_NotValid.Name = "lbl_NotValid"
        Me.lbl_NotValid.Size = New System.Drawing.Size(50, 13)
        Me.lbl_NotValid.TabIndex = 51
        Me.lbl_NotValid.Text = "Not Valid"
        '
        'Guest_Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 525)
        Me.Controls.Add(Me.lbl_NotValid)
        Me.Controls.Add(Me.lbl_valid)
        Me.Controls.Add(Me.txtGid)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.States)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gendercb)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.company)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.idcb)
        Me.Controls.Add(Me.idnum)
        Me.Controls.Add(Me.checkin)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.fax)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.nationality)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.mobno)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pcode)
        Me.Controls.Add(Me.city)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.glname)
        Me.Controls.Add(Me.gname)
        Me.Name = "Guest_Info"
        Me.Text = "Guest Info"
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gname As System.Windows.Forms.RichTextBox
    Friend WithEvents glname As System.Windows.Forms.RichTextBox
    Friend WithEvents address As System.Windows.Forms.RichTextBox
    Friend WithEvents city As System.Windows.Forms.RichTextBox
    Friend WithEvents pcode As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents mobno As System.Windows.Forms.RichTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents nationality As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents fax As System.Windows.Forms.RichTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents email As System.Windows.Forms.RichTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents checkin As System.Windows.Forms.Button
    Friend WithEvents idnum As System.Windows.Forms.RichTextBox
    Friend WithEvents idcb As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents company As System.Windows.Forms.RichTextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents gendercb As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents phone As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents States As System.Windows.Forms.RichTextBox
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents txtGid As System.Windows.Forms.TextBox
    Friend WithEvents lbl_valid As System.Windows.Forms.Label
    Friend WithEvents lbl_NotValid As System.Windows.Forms.Label

End Class
