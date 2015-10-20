Imports System.Data.OleDb
Public Class Login
    Dim myConnection As OleDbConnection
    Dim myCommand As OleDbCommand
    Dim myAuthCommand As OleDbCommand
    Dim dr As OleDbDataReader
    Dim dr1 As OleDbDataReader
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub txtLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLog.Click
        If (txtUser.Text = "" Or txtPass.Text = "") Then
            MsgBox("Please Enter Username and Password!")
        ElseIf (txtUser.Text.Length > 6 Or txtUser.Text.Length < 4 Or txtPass.Text.Length > 6 Or txtPass.Text.Length < 4) Then
            MsgBox("Username and Password is not available!")
        Else
            myConnection = New OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=scott;password=tiger;")
            myConnection.Open()
            myAuthCommand = New OleDbCommand("select * from employee where EMP_USER ='" & txtUser.Text & "' and PASSWORD ='" & txtPass.Text & "'", myConnection)
            dr1 = myAuthCommand.ExecuteReader()
            If (dr1.HasRows) Then
                Dim m As New Menu
                m.Show()
                Hide()
            Else
                MsgBox("Username and Password is not available!")
            End If
        End If
    End Sub
    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        txtUser.Text = ""
        txtPass.Text = ""
    End Sub
End Class
