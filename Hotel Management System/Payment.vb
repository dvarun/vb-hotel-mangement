Imports System.Data.OleDb
Public Class Payment
    Dim myConnection As OleDbConnection
    Dim myCommand As OleDbCommand
    Dim dr As OleDbDataReader
    Dim myCommand1 As OleDbCommand
    Dim dr1 As OleDbDataReader
    Dim myCommand2 As OleDbCommand
    Dim dr2 As OleDbDataReader
    Dim myCommand3 As OleDbCommand
    Dim dr3 As OleDbDataReader
    Dim myCommand4 As OleDbCommand
    Dim dr4 As OleDbDataReader
    Dim myChk As OleDbCommand
    Dim dr5 As OleDbDataReader
    Dim myChk1 As OleDbCommand
    Dim dr6 As OleDbDataReader
    Dim myCommand7 As OleDbCommand
    Dim dr7 As OleDbDataReader
    Dim manu As Menu

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load        
        GB2.Hide()
        GB3.Hide()
        ''Month Items
        mm.Items.Add(1)
        mm.Items.Add(2)
        mm.Items.Add(3)
        mm.Items.Add(4)
        mm.Items.Add(5)
        mm.Items.Add(7)
        mm.Items.Add(8)
        mm.Items.Add(9)
        mm.Items.Add(10)
        mm.Items.Add(11)
        mm.Items.Add(12)
        ''Year Items
        YY.Items.Add(13)
        YY.Items.Add(14)
        YY.Items.Add(15)
        YY.Items.Add(16)
        YY.Items.Add(17)
        YY.Items.Add(18)
        YY.Items.Add(19)
        YY.Items.Add(20)
        YY.Items.Add(21)
        ''Done Items
        mm.SelectedIndex = 0
        YY.SelectedIndex = 0
        ''Default Set
        Dim StandardDate As Date = Today
        Dim MyFormat As String = StandardDate.ToString("dd-MM-yy")
        txtCdate.Text = MyFormat
        txtDate.Text = MyFormat
        myConnection = New OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=scott;password=tiger;")
        myConnection.Open()
        myCommand7 = New OleDbCommand("select CUS_ID,PAY_STATUS from booking where PAY_STATUS=0", myConnection)
        dr7 = myCommand7.ExecuteReader()
        If (dr7.HasRows) Then
            While dr7.Read
                cb1.Items.Add(dr7(0))
            End While
        Else
            MsgBox("No customer Has due!")
        End If
    End Sub

    Private Sub btn_Cash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cash.Click
        GB2.Show()
        GB3.Hide()
    End Sub

    Private Sub btn_card_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_card.Click
        GB3.Show()
        GB2.Hide()
    End Sub

    Private Sub btn_proceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_proceed.Click
        If (txtAmt.Text = "") Then
            MsgBox("Please Enter Amount!")
        Else
            Dim ran As New Random
            Dim n As Integer
            n = ran.Next(1, 100)
            myCommand3 = New OleDbCommand("insert into payment values('" & n & "','" & txtId.Text & "','" & txtDate.Text & "','" & txtAmt.Text & "','CASH','0')", myConnection)
            dr3 = myCommand3.ExecuteReader()
            If (dr3.RecordsAffected) Then
                myCommand4 = New OleDbCommand("update booking set pay_status=1 where CUS_ID='" & txtId.Text & "'", myConnection)
                dr4 = myCommand4.ExecuteReader()
                If (dr4.RecordsAffected) Then
                    MsgBox("Payment Complete")
                    Me.Hide()
                    Dim m As New Menu
                    m.Show()
                End If
            End If
        End If
    End Sub

    Private Sub txtDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDate.TextChanged

    End Sub

    Private Sub txtCamt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCamt.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 _
         AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Only Numbers")
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (txtCamt.Text = "" Or txtCrd.Text = "" Or txtCv.Text = "" Or mm.Text = "" Or YY.Text = "") Then
            MsgBox("Please fill all the field")
        ElseIf (txtCv.Text.Length <> 3) Then
            MsgBox("CCV code should have 3 digit")
        ElseIf (txtCrd.Text.Length <> 16) Then
            MsgBox("Invalid Credit Card Number!")
        Else
            Dim slash As String
            slash = "/"
            
            myCommand = New OleDbCommand("insert into cardDetail values('" & txtCrd.Text & "','" & txtName.Text & "','" & txtCv.Text & "','" & mm.Text + slash + YY.Text & "')", myConnection)
            dr = myCommand.ExecuteReader()
            If (dr.RecordsAffected) Then
                Dim ran As New Random
                Dim n As Integer
                n = ran.Next(1, 100)
                myCommand1 = New OleDbCommand("insert into payment values('" & n & "','" & txtId.Text & "','" & txtDate.Text & "','" & txtCamt.Text & "','CARD','" & txtCrd.Text & "')", myConnection)
                dr1 = myCommand1.ExecuteReader()
                If (dr1.RecordsAffected) Then
                    myCommand2 = New OleDbCommand("update booking set pay_status=1 where CUS_ID='" & txtId.Text & "'", myConnection)
                    dr2 = myCommand2.ExecuteReader()
                    If (dr2.RecordsAffected) Then
                        MsgBox("Payment Complete")
                    End If
                End If
                Dim men As New Menu
                Hide()
                men.Show()
            Else
                MsgBox("Can't proceed the transaction!")
            End If

        End If
    End Sub
    Private Sub txtCrd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCrd.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 _
         AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Only Numbers")
            e.Handled = True
        End If
    End Sub

    Private Sub txtCv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCv.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 _
         AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Only Numbers")
            e.Handled = True
        End If
    End Sub
    Private Sub txtAmt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmt.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 _
         AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Only Numbers")
            e.Handled = True
        End If
    End Sub

    Private Sub btn_bck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bck.Click
        Dim m As New Menu
        Hide()
        m.Show()
    End Sub

    Private Sub txtId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtId.TextChanged
        'Dim suggestions As New AutoCompleteStringCollection()
        'Dim mysug As OleDbCommand
        'Dim suges As OleDbDataReader
        'mysug = New OleDbCommand("select CID from customerDetail", myConnection)
        'suges = mysug.ExecuteReader()
        'While suges.Read()
        '    suggestions.Add(suges(0).ToString)
        'End While
        'txtId.AutoCompleteMode = AutoCompleteMode.Suggest
        'txtId.AutoCompleteSource = AutoCompleteSource.CustomSource
        'txtId.AutoCompleteCustomSource = suggestions
    End Sub

    Private Sub btn_chk_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_chk.Click
        If (cb1.Text = "" And txtId.Text = "") Then
            MsgBox("Please choose Customer ID")
        ElseIf (cb1.Text <> "") Then
            txtId.Text = cb1.Text
            myChk = New OleDbCommand("select CUS_ID,TOTALPRICE,PAY_STATUS from booking where CUS_ID='" & txtId.Text & "'and PAY_STATUS = 0", myConnection)
            dr5 = myChk.ExecuteReader()
            If (dr5.HasRows) Then
                While dr5.Read
                    txtAmt.Text = dr5(1)
                    txtCamt.Text = dr5(1)
                End While
                myChk1 = New OleDbCommand("select CNAME from customerDetail where CID='" & txtId.Text & "'", myConnection)
                dr6 = myChk1.ExecuteReader()
                While dr6.Read()
                    txtName.Text = dr6(0).ToString
                End While
            Else
                MsgBox("No Guest Found or payment has been made already!")
            End If
        ElseIf (txtId.Text <> "") Then
            cb1.Text = txtId.Text
            myChk = New OleDbCommand("select CUS_ID,TOTALPRICE,PAY_STATUS from booking where CUS_ID='" & txtId.Text & "'and PAY_STATUS = 0", myConnection)
            dr5 = myChk.ExecuteReader()
            If (dr5.HasRows) Then
                While dr5.Read
                    txtAmt.Text = dr5(1)
                    txtCamt.Text = dr5(1)
                End While
                myChk1 = New OleDbCommand("select CNAME from customerDetail where CID='" & txtId.Text & "'", myConnection)
                dr6 = myChk1.ExecuteReader()
                While dr6.Read()
                    txtName.Text = dr6(0).ToString
                End While
            Else
                MsgBox("No Guest Found or payment has been made already!")
            End If
        End If
    End Sub

End Class
