<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservation
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Dbook = New System.Windows.Forms.RadioButton()
        Me.Abook = New System.Windows.Forms.RadioButton()
        Me.bookfrom = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bookfromdate = New System.Windows.Forms.DateTimePicker()
        Me.booktilldate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.adult = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.child = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.roomtype = New System.Windows.Forms.ComboBox()
        Me.nofrooms = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.nofdays = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.osamt = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btn_book = New System.Windows.Forms.Button()
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.sysdateandtime = New System.Windows.Forms.StatusBarPanel()
        Me.txtGid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtChkBy = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.sysdateandtime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reservation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Booking Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(104, 61)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(119, 20)
        Me.DateTimePicker1.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Booking Type"
        '
        'Dbook
        '
        Me.Dbook.AutoSize = True
        Me.Dbook.Location = New System.Drawing.Point(106, 92)
        Me.Dbook.Name = "Dbook"
        Me.Dbook.Size = New System.Drawing.Size(94, 17)
        Me.Dbook.TabIndex = 8
        Me.Dbook.TabStop = True
        Me.Dbook.Text = "Direct booking"
        Me.Dbook.UseVisualStyleBackColor = True
        '
        'Abook
        '
        Me.Abook.AutoSize = True
        Me.Abook.Location = New System.Drawing.Point(202, 92)
        Me.Abook.Name = "Abook"
        Me.Abook.Size = New System.Drawing.Size(94, 17)
        Me.Abook.TabIndex = 9
        Me.Abook.TabStop = True
        Me.Abook.Text = "Agent booking"
        Me.Abook.UseVisualStyleBackColor = True
        '
        'bookfrom
        '
        Me.bookfrom.AutoSize = True
        Me.bookfrom.Location = New System.Drawing.Point(23, 190)
        Me.bookfrom.Name = "bookfrom"
        Me.bookfrom.Size = New System.Drawing.Size(69, 13)
        Me.bookfrom.TabIndex = 10
        Me.bookfrom.Text = "Booking from"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(225, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Booking till"
        '
        'bookfromdate
        '
        Me.bookfromdate.Location = New System.Drawing.Point(19, 210)
        Me.bookfromdate.Name = "bookfromdate"
        Me.bookfromdate.Size = New System.Drawing.Size(180, 20)
        Me.bookfromdate.TabIndex = 12
        '
        'booktilldate
        '
        Me.booktilldate.Location = New System.Drawing.Point(228, 208)
        Me.booktilldate.Name = "booktilldate"
        Me.booktilldate.Size = New System.Drawing.Size(184, 20)
        Me.booktilldate.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "No of Adults"
        '
        'adult
        '
        Me.adult.Location = New System.Drawing.Point(155, 242)
        Me.adult.Name = "adult"
        Me.adult.Size = New System.Drawing.Size(44, 20)
        Me.adult.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(264, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "No of children"
        '
        'child
        '
        Me.child.Location = New System.Drawing.Point(404, 243)
        Me.child.Name = "child"
        Me.child.Size = New System.Drawing.Size(44, 20)
        Me.child.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 282)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Room type"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(236, 282)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "No of rooms" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'roomtype
        '
        Me.roomtype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.roomtype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.roomtype.FormattingEnabled = True
        Me.roomtype.Items.AddRange(New Object() {"Normal", "Deluxe", "Executive"})
        Me.roomtype.Location = New System.Drawing.Point(104, 279)
        Me.roomtype.Name = "roomtype"
        Me.roomtype.Size = New System.Drawing.Size(107, 21)
        Me.roomtype.TabIndex = 22
        '
        'nofrooms
        '
        Me.nofrooms.FormattingEnabled = True
        Me.nofrooms.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.nofrooms.Location = New System.Drawing.Point(329, 279)
        Me.nofrooms.Name = "nofrooms"
        Me.nofrooms.Size = New System.Drawing.Size(52, 21)
        Me.nofrooms.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "CHECK IN BY"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(2, 426)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Label12"
        '
        'nofdays
        '
        Me.nofdays.Enabled = False
        Me.nofdays.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nofdays.Location = New System.Drawing.Point(508, 208)
        Me.nofdays.Name = "nofdays"
        Me.nofdays.Size = New System.Drawing.Size(41, 21)
        Me.nofdays.TabIndex = 34
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(353, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(454, 242)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 23)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = ">"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(205, 240)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(43, 23)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = ">"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(106, 240)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(43, 23)
        Me.Button4.TabIndex = 37
        Me.Button4.Text = "<"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(439, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "No of days"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.osamt)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Location = New System.Drawing.Point(353, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(212, 48)
        Me.Panel1.TabIndex = 40
        '
        'osamt
        '
        Me.osamt.Enabled = False
        Me.osamt.Location = New System.Drawing.Point(89, 15)
        Me.osamt.Name = "osamt"
        Me.osamt.Size = New System.Drawing.Size(95, 20)
        Me.osamt.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = " Amount"
        '
        'btn_book
        '
        Me.btn_book.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_book.Location = New System.Drawing.Point(395, 326)
        Me.btn_book.Name = "btn_book"
        Me.btn_book.Size = New System.Drawing.Size(102, 46)
        Me.btn_book.TabIndex = 41
        Me.btn_book.Text = "Confirm"
        Me.btn_book.UseVisualStyleBackColor = True
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 378)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.sysdateandtime})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(577, 22)
        Me.StatusBar1.TabIndex = 42
        Me.StatusBar1.Text = "StatusBar1"
        '
        'sysdateandtime
        '
        Me.sysdateandtime.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.sysdateandtime.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.sysdateandtime.Name = "sysdateandtime"
        Me.sysdateandtime.Text = "time"
        Me.sysdateandtime.Width = 560
        '
        'txtGid
        '
        Me.txtGid.Enabled = False
        Me.txtGid.Location = New System.Drawing.Point(106, 130)
        Me.txtGid.Name = "txtGid"
        Me.txtGid.Size = New System.Drawing.Size(100, 20)
        Me.txtGid.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Guest ID:"
        '
        'txtChkBy
        '
        Me.txtChkBy.Enabled = False
        Me.txtChkBy.Location = New System.Drawing.Point(107, 157)
        Me.txtChkBy.Name = "txtChkBy"
        Me.txtChkBy.Size = New System.Drawing.Size(100, 20)
        Me.txtChkBy.TabIndex = 45
        '
        'Reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 400)
        Me.Controls.Add(Me.txtChkBy)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtGid)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.btn_book)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.nofdays)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.nofrooms)
        Me.Controls.Add(Me.roomtype)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.child)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.adult)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.booktilldate)
        Me.Controls.Add(Me.bookfromdate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.bookfrom)
        Me.Controls.Add(Me.Abook)
        Me.Controls.Add(Me.Dbook)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Reservation"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.sysdateandtime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Dbook As System.Windows.Forms.RadioButton
    Friend WithEvents Abook As System.Windows.Forms.RadioButton
    Friend WithEvents bookfrom As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents bookfromdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents booktilldate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents adult As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents child As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents roomtype As System.Windows.Forms.ComboBox
    Friend WithEvents nofrooms As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents nofdays As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btn_book As System.Windows.Forms.Button
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents sysdateandtime As System.Windows.Forms.StatusBarPanel
    Friend WithEvents txtGid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents osamt As System.Windows.Forms.TextBox
    Friend WithEvents txtChkBy As System.Windows.Forms.TextBox
End Class
