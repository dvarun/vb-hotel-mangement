<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Me.GB1 = New System.Windows.Forms.GroupBox()
        Me.btn_card = New System.Windows.Forms.Button()
        Me.btn_Cash = New System.Windows.Forms.Button()
        Me.GB2 = New System.Windows.Forms.GroupBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.btn_proceed = New System.Windows.Forms.Button()
        Me.txtAmt = New System.Windows.Forms.TextBox()
        Me.lbl_amt = New System.Windows.Forms.Label()
        Me.GB3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.YY = New System.Windows.Forms.ComboBox()
        Me.mm = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCv = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCrd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCdate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtCamt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_bck = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btn_chk = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.GB1.SuspendLayout()
        Me.GB2.SuspendLayout()
        Me.GB3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB1
        '
        Me.GB1.Controls.Add(Me.btn_card)
        Me.GB1.Controls.Add(Me.btn_Cash)
        Me.GB1.Location = New System.Drawing.Point(12, 12)
        Me.GB1.Name = "GB1"
        Me.GB1.Size = New System.Drawing.Size(393, 102)
        Me.GB1.TabIndex = 0
        Me.GB1.TabStop = False
        Me.GB1.Text = "MODE OF PAYMENT:"
        '
        'btn_card
        '
        Me.btn_card.Location = New System.Drawing.Point(195, 19)
        Me.btn_card.Name = "btn_card"
        Me.btn_card.Size = New System.Drawing.Size(175, 53)
        Me.btn_card.TabIndex = 1
        Me.btn_card.Text = "Card"
        Me.btn_card.UseVisualStyleBackColor = True
        '
        'btn_Cash
        '
        Me.btn_Cash.Location = New System.Drawing.Point(6, 19)
        Me.btn_Cash.Name = "btn_Cash"
        Me.btn_Cash.Size = New System.Drawing.Size(175, 53)
        Me.btn_Cash.TabIndex = 0
        Me.btn_Cash.Text = "Cash"
        Me.btn_Cash.UseVisualStyleBackColor = True
        '
        'GB2
        '
        Me.GB2.Controls.Add(Me.txtDate)
        Me.GB2.Controls.Add(Me.lbl_date)
        Me.GB2.Controls.Add(Me.btn_proceed)
        Me.GB2.Controls.Add(Me.txtAmt)
        Me.GB2.Controls.Add(Me.lbl_amt)
        Me.GB2.Location = New System.Drawing.Point(19, 201)
        Me.GB2.Name = "GB2"
        Me.GB2.Size = New System.Drawing.Size(167, 139)
        Me.GB2.TabIndex = 1
        Me.GB2.TabStop = False
        Me.GB2.Text = "Cash"
        '
        'txtDate
        '
        Me.txtDate.Enabled = False
        Me.txtDate.Location = New System.Drawing.Point(58, 61)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 20)
        Me.txtDate.TabIndex = 4
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Location = New System.Drawing.Point(21, 61)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(34, 13)
        Me.lbl_date.TabIndex = 3
        Me.lbl_date.Text = "Date*"
        '
        'btn_proceed
        '
        Me.btn_proceed.Location = New System.Drawing.Point(11, 91)
        Me.btn_proceed.Name = "btn_proceed"
        Me.btn_proceed.Size = New System.Drawing.Size(75, 23)
        Me.btn_proceed.TabIndex = 2
        Me.btn_proceed.Text = "Proceed"
        Me.btn_proceed.UseVisualStyleBackColor = True
        '
        'txtAmt
        '
        Me.txtAmt.Location = New System.Drawing.Point(58, 25)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.Size = New System.Drawing.Size(100, 20)
        Me.txtAmt.TabIndex = 1
        '
        'lbl_amt
        '
        Me.lbl_amt.AutoSize = True
        Me.lbl_amt.Location = New System.Drawing.Point(8, 25)
        Me.lbl_amt.Name = "lbl_amt"
        Me.lbl_amt.Size = New System.Drawing.Size(47, 13)
        Me.lbl_amt.TabIndex = 0
        Me.lbl_amt.Text = "Amount*"
        '
        'GB3
        '
        Me.GB3.Controls.Add(Me.Label6)
        Me.GB3.Controls.Add(Me.YY)
        Me.GB3.Controls.Add(Me.mm)
        Me.GB3.Controls.Add(Me.Label5)
        Me.GB3.Controls.Add(Me.txtCv)
        Me.GB3.Controls.Add(Me.Label4)
        Me.GB3.Controls.Add(Me.txtCrd)
        Me.GB3.Controls.Add(Me.Label3)
        Me.GB3.Controls.Add(Me.txtCdate)
        Me.GB3.Controls.Add(Me.Label1)
        Me.GB3.Controls.Add(Me.Button1)
        Me.GB3.Controls.Add(Me.txtCamt)
        Me.GB3.Controls.Add(Me.Label2)
        Me.GB3.Location = New System.Drawing.Point(192, 201)
        Me.GB3.Name = "GB3"
        Me.GB3.Size = New System.Drawing.Size(214, 235)
        Me.GB3.TabIndex = 5
        Me.GB3.TabStop = False
        Me.GB3.Text = "Card"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(133, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "/"
        '
        'YY
        '
        Me.YY.FormattingEnabled = True
        Me.YY.Location = New System.Drawing.Point(151, 150)
        Me.YY.Name = "YY"
        Me.YY.Size = New System.Drawing.Size(37, 21)
        Me.YY.TabIndex = 11
        '
        'mm
        '
        Me.mm.FormattingEnabled = True
        Me.mm.Location = New System.Drawing.Point(92, 150)
        Me.mm.Name = "mm"
        Me.mm.Size = New System.Drawing.Size(37, 21)
        Me.mm.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Expiry*"
        '
        'txtCv
        '
        Me.txtCv.Location = New System.Drawing.Point(92, 123)
        Me.txtCv.Name = "txtCv"
        Me.txtCv.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCv.Size = New System.Drawing.Size(53, 20)
        Me.txtCv.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "CVV  Number*"
        '
        'txtCrd
        '
        Me.txtCrd.Location = New System.Drawing.Point(92, 92)
        Me.txtCrd.Name = "txtCrd"
        Me.txtCrd.Size = New System.Drawing.Size(117, 20)
        Me.txtCrd.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Card Number*"
        '
        'txtCdate
        '
        Me.txtCdate.Enabled = False
        Me.txtCdate.Location = New System.Drawing.Point(92, 57)
        Me.txtCdate.Name = "txtCdate"
        Me.txtCdate.Size = New System.Drawing.Size(117, 20)
        Me.txtCdate.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Date*"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(10, 193)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Proceed"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtCamt
        '
        Me.txtCamt.Location = New System.Drawing.Point(92, 21)
        Me.txtCamt.Name = "txtCamt"
        Me.txtCamt.Size = New System.Drawing.Size(117, 20)
        Me.txtCamt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Amount*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label7.Location = New System.Drawing.Point(91, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Customer Id:"
        '
        'btn_bck
        '
        Me.btn_bck.Location = New System.Drawing.Point(19, 380)
        Me.btn_bck.Name = "btn_bck"
        Me.btn_bck.Size = New System.Drawing.Size(118, 50)
        Me.btn_bck.TabIndex = 8
        Me.btn_bck.Text = "BACK"
        Me.btn_bck.UseVisualStyleBackColor = True
        '
        'txtId
        '
        Me.txtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(164, 145)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(121, 20)
        Me.txtId.TabIndex = 9
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_name.Location = New System.Drawing.Point(72, 176)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(85, 13)
        Me.lbl_name.TabIndex = 6
        Me.lbl_name.Text = "Customer Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(164, 171)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(121, 20)
        Me.txtName.TabIndex = 10
        '
        'btn_chk
        '
        Me.btn_chk.Location = New System.Drawing.Point(305, 143)
        Me.btn_chk.Name = "btn_chk"
        Me.btn_chk.Size = New System.Drawing.Size(75, 23)
        Me.btn_chk.TabIndex = 11
        Me.btn_chk.Text = "Check"
        Me.btn_chk.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label8.Location = New System.Drawing.Point(91, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Customer Id:"
        '
        'cb1
        '
        Me.cb1.FormattingEnabled = True
        Me.cb1.Location = New System.Drawing.Point(164, 119)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(121, 21)
        Me.cb1.TabIndex = 13
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 478)
        Me.Controls.Add(Me.cb1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_chk)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.btn_bck)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.GB3)
        Me.Controls.Add(Me.GB2)
        Me.Controls.Add(Me.GB1)
        Me.Name = "Payment"
        Me.Text = "Payment"
        Me.GB1.ResumeLayout(False)
        Me.GB2.ResumeLayout(False)
        Me.GB2.PerformLayout()
        Me.GB3.ResumeLayout(False)
        Me.GB3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GB1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_card As System.Windows.Forms.Button
    Friend WithEvents btn_Cash As System.Windows.Forms.Button
    Friend WithEvents GB2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_amt As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents btn_proceed As System.Windows.Forms.Button
    Friend WithEvents txtAmt As System.Windows.Forms.TextBox
    Friend WithEvents GB3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents YY As System.Windows.Forms.ComboBox
    Friend WithEvents mm As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCv As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCrd As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCdate As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtCamt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_bck As System.Windows.Forms.Button
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btn_chk As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cb1 As System.Windows.Forms.ComboBox

End Class
