Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class Guest_Info
    Dim myConnection As OleDbConnection
    Dim myCommand As OleDbCommand
    Dim dr As OleDbDataReader
    Dim com1 As OleDbCommand
    Dim dr1 As OleDbDataReader
    Dim ToolTip As String
    Dim ran As New Random
    Dim n As New Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''idnum.Hide()
        n = ran.Next(1, 999)
        txtGid.Text = n
        Reservation.txtGid.Text = Me.txtGid.Text
        lbl_valid.Hide()
        idnum.Hide()
    End Sub
    Private Sub pax_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 _
            AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("ENTER ONLY NUMBERS!")
            e.Handled = True
        End If
    End Sub
    Private Sub phone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles phone.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 _
            AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("ENTER ONLY NUMBERS!")
            e.Handled = True
        End If
    End Sub

    Private Sub pcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pcode.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 _
            AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("ENTER ONLY NUMBERS!")
            e.Handled = True
        End If
    End Sub

    Private Sub mobno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mobno.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 _
            AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("ENTER ONLY NUMBER!!!!")
            e.Handled = True
        End If
    End Sub

    Private Sub fax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fax.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 _
            AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("ENTER ONLY NUMBERS!")
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles idcb.SelectedIndexChanged
        If (idcb.SelectedIndex = 0 Or 1 Or 2 Or 3) Then
            idnum.Show()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkin.Click
        If (gname.Text = "" Or glname.Text = "" Or address.Text = "" Or idcb.SelectedItem = Nothing Or city.Text = "" Or idnum.Text = "" Or pcode.Text = "" Or mobno.Text = "" Or email.Text = "") Then
            MsgBox("Please fill in required fields")
        ElseIf (pcode.TextLength <> 5 And pcode.TextLength <> 6) Then
            MsgBox("Please enter Valid Pincode.")

        ElseIf mobno.TextLength <> 10 Then
            MsgBox("Please enter valid Mobile number.")

        Else
            myConnection = New OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=scott;password=tiger;")
            myConnection.Open()
            myCommand = New OleDbCommand("insert into customerDetail values('" & txtGid.Text & "','" & gname.Text & "','" & glname.Text & "','" & gendercb.SelectedItem & "','" & company.Text & "','" & address.Text & "','" & nationality.SelectedItem & "','" & States.Text & "','" & city.Text & "','" & pcode.Text & "','" & phone.Text & "','" & mobno.Text & "','" & fax.Text & "','" & email.Text & "','" & idcb.SelectedItem & "','" & idnum.Text & "')", myConnection)
            dr = myCommand.ExecuteReader()
            If (dr.RecordsAffected) Then
                MsgBox("Detail Added!")
            Else
                MsgBox("Failed Adding data!")
            End If
            Dim f2 As New Reservation
            f2.Show()
            f2.txtGid.Text = Me.txtGid.Text
            Hide()
        End If
    End Sub

    Private Sub StatusBar1_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles StatusBar1.VisibleChanged
        StatusBar1.Panels(0).Text = "Today : " & Now
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Hide()
        Dim m As New Menu
        m.Show()
    End Sub

    Private Sub email_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles email.TextChanged
        email.BackColor = Color.White
        Dim temp As String
        temp = email.Text
        'Dim conditon As Boolean = False
        If emailaddresscheck(temp) = True Then
            ': If emailaddresscheck(conditon) = True Then
            email.BackColor = Color.Green
            email.ForeColor = Color.White
            lbl_valid.Show()
            lbl_NotValid.Hide()
        Else
            email.BackColor = Color.Yellow
            lbl_NotValid.Show()
        End If
    End Sub

    Private Sub company_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles company.TextChanged
        If (company.TextLength > 10) Then
            MsgBox("Value too large!")
            company.Text = ""
        End If
    End Sub
    Private Function emailaddresscheck(ByVal emailaddress As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailaddress, pattern)
        If emailAddressMatch.Success Then
            emailaddresscheck = True
        Else
            emailaddresscheck = False
        End If
    End Function
End Class
