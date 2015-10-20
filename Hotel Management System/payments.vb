Imports System.Data.OleDb
Public Class Payments
    Dim myConnection As OleDbConnection
    Dim myCommand As OleDbCommand
    Dim dr As OleDbDataReader
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PaySet.PAYMENT' table. You can move, or remove it, as needed.
        Me.PAYMENTTableAdapter.Fill(Me.PaySet.PAYMENT)
        myConnection = New OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=scott;password=tiger;")
        myConnection.Open()
    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Me.Hide()
        Dim m As New Menu
        m.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (txtPid.Text = "") Then
            MsgBox("Please enter value!")
        Else
            myCommand = New OleDbCommand("Delete from payment where PID='" & txtPid.Text & "'", myConnection)
            dr = myCommand.ExecuteReader()
            If (dr.RecordsAffected()) Then
                MsgBox("Payment Record Deleted!")
                Me.Refresh()
            Else
                MsgBox("Not found!!")
            End If
        End If
    End Sub
End Class