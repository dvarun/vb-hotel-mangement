Imports System.Data.OleDb
Public Class bookings
    Dim myConnection As OleDbConnection
    Dim myCommand As OleDbCommand
    Dim dr As OleDbDataReader
    Private Sub bookings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bookz.BOOKING' table. You can move, or remove it, as needed.
        Me.BOOKINGTableAdapter.Fill(Me.Bookz.BOOKING)
        myConnection = New OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=scott;password=tiger;")
        myConnection.Open()
    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Hide()
        Dim m As New Menu
        m.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (txtBid.Text = "") Then
            MsgBox("Please enter value!")
        Else
            myCommand = New OleDbCommand("Delete from BookingDetail where BID='" & txtBid.Text & "'", myConnection)
            dr = myCommand.ExecuteReader()
            If (dr.RecordsAffected()) Then
                Dim mycmd As OleDbCommand
                Dim dr1 As OleDbDataReader
                mycmd = New OleDbCommand("Delete from Booking where BID='" & txtBid.Text & "'", myConnection)
                dr1 = mycmd.ExecuteReader()
                If (dr.RecordsAffected) Then
                    MsgBox("Booking Deleted!")
                End If
            Else
                MsgBox("Error!")
            End If
            End If
    End Sub
End Class