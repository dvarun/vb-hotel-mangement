Imports System.Data.OleDb
Public Class Avail
    Dim myConnection As OleDbConnection
    Dim myCommand As OleDbCommand
    Dim dr As OleDbDataReader
    Dim myCommand1 As OleDbCommand
    Dim dr1 As OleDbDataReader
    Dim myCommand2 As OleDbCommand
    Dim dr2 As OleDbDataReader
    Private Sub Avail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myConnection = New OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=scott;password=tiger;")
        myConnection.Open()
        myCommand = New OleDbCommand("select count(rcid) from room where rcid=1", myConnection)
        dr = myCommand.ExecuteReader()
        While dr.Read()
            lbl_Normal.Text = "Normal Room Available:" & 70 - dr(0)
        End While
        myCommand1 = New OleDbCommand("select count(rcid) from room where rcid=2", myConnection)
        dr1 = myCommand1.ExecuteReader()
        While dr1.Read()
            lbl_del.Text = "Deluxe Room Available:" & 50 - dr1(0)
        End While
        myCommand2 = New OleDbCommand("select count(rcid) from room where rcid=3", myConnection)
        dr2 = myCommand2.ExecuteReader()
        While dr2.Read()
            lbl_exec.Text = "Executive Room Available:" & 30 - dr2(0)
        End While
    End Sub

    Private Sub btn_BACK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BACK.Click
        Hide()
        Dim men As New Menu
        men.Show()
    End Sub
End Class