<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class allUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(allUser))
        Me.btn_back = New System.Windows.Forms.Button()
        Me.States = New System.Windows.Forms.RichTextBox()
        Me.CUSTOMERDETAILBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlluserSet = New Hotel_Management_System.alluserSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.phone = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gendercb = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.company = New System.Windows.Forms.RichTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.idcb = New System.Windows.Forms.ComboBox()
        Me.idnum = New System.Windows.Forms.RichTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.RichTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.fax = New System.Windows.Forms.RichTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.nationality = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mobno = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pcode = New System.Windows.Forms.RichTextBox()
        Me.city = New System.Windows.Forms.RichTextBox()
        Me.address = New System.Windows.Forms.RichTextBox()
        Me.glname = New System.Windows.Forms.RichTextBox()
        Me.gname = New System.Windows.Forms.RichTextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CUSTOMERDETAILTableAdapter = New Hotel_Management_System.alluserSetTableAdapters.CUSTOMERDETAILTableAdapter()
        CType(Me.CUSTOMERDETAILBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlluserSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.YellowGreen
        Me.btn_back.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.Location = New System.Drawing.Point(0, 476)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(740, 31)
        Me.btn_back.TabIndex = 0
        Me.btn_back.Text = "CLOSE"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'States
        '
        Me.States.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERDETAILBindingSource, "STATE", True))
        Me.States.Location = New System.Drawing.Point(107, 235)
        Me.States.Name = "States"
        Me.States.Size = New System.Drawing.Size(121, 23)
        Me.States.TabIndex = 52
        Me.States.Text = ""
        '
        'CUSTOMERDETAILBindingSource
        '
        Me.CUSTOMERDETAILBindingSource.DataMember = "CUSTOMERDETAIL"
        Me.CUSTOMERDETAILBindingSource.DataSource = Me.AlluserSet
        '
        'AlluserSet
        '
        Me.AlluserSet.DataSetName = "alluserSet"
        Me.AlluserSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Country of Residence*"
        '
        'phone
        '
        Me.phone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERDETAILBindingSource, "PHONE", True))
        Me.phone.Location = New System.Drawing.Point(107, 298)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(121, 23)
        Me.phone.TabIndex = 56
        Me.phone.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 301)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Telephone"
        '
        'gendercb
        '
        Me.gendercb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERDETAILBindingSource, "GENDER", True))
        Me.gendercb.FormattingEnabled = True
        Me.gendercb.Items.AddRange(New Object() {"Male", "Female"})
        Me.gendercb.Location = New System.Drawing.Point(107, 80)
        Me.gendercb.Name = "gendercb"
        Me.gendercb.Size = New System.Drawing.Size(78, 21)
        Me.gendercb.TabIndex = 47
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(14, 79)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 13)
        Me.Label19.TabIndex = 74
        Me.Label19.Text = "gender"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(314, 395)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 13)
        Me.Label18.TabIndex = 73
        Me.Label18.Text = "ID Number"
        '
        'company
        '
        Me.company.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERDETAILBindingSource, "COMPANY", True))
        Me.company.Location = New System.Drawing.Point(107, 111)
        Me.company.Name = "company"
        Me.company.Size = New System.Drawing.Size(152, 23)
        Me.company.TabIndex = 49
        Me.company.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(14, 112)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 13)
        Me.Label15.TabIndex = 71
        Me.Label15.Text = "Company"
        '
        'idcb
        '
        Me.idcb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERDETAILBindingSource, "IDPROOF", True))
        Me.idcb.FormattingEnabled = True
        Me.idcb.Items.AddRange(New Object() {"Passport", "Driving License", "PAN card", "Govt Employee ID", "Other..."})
        Me.idcb.Location = New System.Drawing.Point(107, 392)
        Me.idcb.Name = "idcb"
        Me.idcb.Size = New System.Drawing.Size(121, 21)
        Me.idcb.TabIndex = 64
        Me.idcb.Text = "--Select--"
        '
        'idnum
        '
        Me.idnum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERDETAILBindingSource, "IDNUM", True))
        Me.idnum.Location = New System.Drawing.Point(378, 390)
        Me.idnum.Name = "idnum"
        Me.idnum.Size = New System.Drawing.Size(121, 23)
        Me.idnum.TabIndex = 66
        Me.idnum.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(325, 333)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 13)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "Fax"
        '
        'email
        '
        Me.email.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERDETAILBindingSource, "EMAIL", True))
        Me.email.Location = New System.Drawing.Point(107, 359)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(172, 23)
        Me.email.TabIndex = 62
        Me.email.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(323, 270)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 69
        Me.Label13.Text = "Pin code*"
        '
        'fax
        '
        Me.fax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERDETAILBindingSource, "CFAX", True))
        Me.fax.Location = New System.Drawing.Point(378, 330)
        Me.fax.Name = "fax"
        Me.fax.Size = New System.Drawing.Size(121, 23)
        Me.fax.TabIndex = 60
        Me.fax.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 359)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "E Mail"
        '
        'nationality
        '
        Me.nationality.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.nationality.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.nationality.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERDETAILBindingSource, "CRESIDENCE", True))
        Me.nationality.FormattingEnabled = True
        Me.nationality.Items.AddRange(New Object() {"Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas, The", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei ", "Bulgaria", "Burkina Faso", "Burma", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros ", "Congo, Democratic Republic of the", "Congo, Republic of the ", "Costa Rica", "Cote d'Ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor ", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia, The", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Holy See", "Honduras", "Hong Kong", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, North", "Korea, South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macau", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Namibia", "Nauru", "Nepal", "Netherlands", "Netherlands Antilles", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Korea", "Norway", "Oman", "Pakistan", "Palau", "Palestinian Territories", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa ", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Korea", "South Sudan", "Spain ", "Sri Lanka", "Sudan", "Suriname", "Swaziland ", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand ", "Timor-Leste", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "Uruguay", "Uzbekistan", "Vanuatu", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe"})
        Me.nationality.Location = New System.Drawing.Point(138, 208)
        Me.nationality.Name = "nationality"
        Me.nationality.Size = New System.Drawing.Size(121, 21)
        Me.nationality.TabIndex = 51
        Me.nationality.Text = "--Country--"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 333)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Mobile Number*"
        '
        'mobno
        '
        Me.mobno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERDETAILBindingSource, "MOBILE", True))
        Me.mobno.Location = New System.Drawing.Point(107, 330)
        Me.mobno.Name = "mobno"
        Me.mobno.Size = New System.Drawing.Size(121, 23)
        Me.mobno.TabIndex = 58
        Me.mobno.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 241)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "State"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "City*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 395)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "ID Proof*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Address*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(285, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Guest Last name*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Guest First Name*"
        '
        'pcode
        '
        Me.pcode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERDETAILBindingSource, "PIN_CODE", True))
        Me.pcode.Location = New System.Drawing.Point(378, 267)
        Me.pcode.Name = "pcode"
        Me.pcode.Size = New System.Drawing.Size(121, 23)
        Me.pcode.TabIndex = 54
        Me.pcode.Text = ""
        '
        'city
        '
        Me.city.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERDETAILBindingSource, "CITY", True))
        Me.city.Location = New System.Drawing.Point(107, 267)
        Me.city.Name = "city"
        Me.city.Size = New System.Drawing.Size(121, 23)
        Me.city.TabIndex = 53
        Me.city.Text = ""
        '
        'address
        '
        Me.address.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERDETAILBindingSource, "ADDRESS", True))
        Me.address.Location = New System.Drawing.Point(107, 143)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(152, 59)
        Me.address.TabIndex = 50
        Me.address.Text = ""
        '
        'glname
        '
        Me.glname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERDETAILBindingSource, "CLNAME", True))
        Me.glname.Location = New System.Drawing.Point(378, 51)
        Me.glname.Name = "glname"
        Me.glname.Size = New System.Drawing.Size(121, 23)
        Me.glname.TabIndex = 46
        Me.glname.Text = ""
        '
        'gname
        '
        Me.gname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERDETAILBindingSource, "CNAME", True))
        Me.gname.Location = New System.Drawing.Point(107, 51)
        Me.gname.Name = "gname"
        Me.gname.Size = New System.Drawing.Size(121, 23)
        Me.gname.TabIndex = 45
        Me.gname.Text = ""
        '
        'txtId
        '
        Me.txtId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERDETAILBindingSource, "CID", True))
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(401, 143)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(63, 20)
        Me.txtId.TabIndex = 77
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(377, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 13)
        Me.Label10.TabIndex = 78
        Me.Label10.Text = "ID"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.CUSTOMERDETAILBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(740, 25)
        Me.BindingNavigator1.TabIndex = 80
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CUSTOMERDETAILTableAdapter
        '
        Me.CUSTOMERDETAILTableAdapter.ClearBeforeFill = True
        '
        'allUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 507)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtId)
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
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.Label13)
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
        Me.Controls.Add(Me.btn_back)
        Me.Name = "allUser"
        Me.Text = "Users"
        CType(Me.CUSTOMERDETAILBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlluserSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents States As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents phone As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gendercb As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents company As System.Windows.Forms.RichTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents idcb As System.Windows.Forms.ComboBox
    Friend WithEvents idnum As System.Windows.Forms.RichTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents email As System.Windows.Forms.RichTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents fax As System.Windows.Forms.RichTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents nationality As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents mobno As System.Windows.Forms.RichTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pcode As System.Windows.Forms.RichTextBox
    Friend WithEvents city As System.Windows.Forms.RichTextBox
    Friend WithEvents address As System.Windows.Forms.RichTextBox
    Friend WithEvents glname As System.Windows.Forms.RichTextBox
    Friend WithEvents gname As System.Windows.Forms.RichTextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AlluserSet As Hotel_Management_System.alluserSet
    Friend WithEvents CUSTOMERDETAILBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CUSTOMERDETAILTableAdapter As Hotel_Management_System.alluserSetTableAdapters.CUSTOMERDETAILTableAdapter
End Class
