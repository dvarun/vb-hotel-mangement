Imports System.Data.OleDb
Public Class Reservation
    Dim myConnection As OleDbConnection
    Dim myCommand As OleDbCommand
    Dim myCmd2 As OleDbCommand
    Dim myCmd3 As OleDbCommand
    Dim dr As OleDbDataReader
    Dim dr2 As OleDbDataReader
    Dim dr3 As OleDbDataReader
    Dim int As Integer
    Dim RCID As Integer
    Private Function changetext()
        Dim date1 As Date
        Dim date2 As Date
        date1 = Convert.ToDateTime(bookfromdate.Value)
        date2 = Convert.ToDateTime(booktilldate.Value)
        Dim diff As System.TimeSpan
        diff = date2 - date1
        nofdays.Text = diff.Days + 1
        Return nofdays
    End Function

    Private Sub booktilldate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles booktilldate.ValueChanged
        If booktilldate.Value < bookfromdate.Value Then
            MessageBox.Show("Invalid!", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            changetext()
        End If
    End Sub

    Private Sub adult_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adult.TextChanged
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Integer.TryParse(adult.Text, int)
        adult.Text = (int + 1)
        nofrooms.Enabled = True
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        Integer.TryParse(adult.Text, int)
        adult.Text = (int - 1)
        If (int < 2) Then
            MsgBox("INVALID")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Integer.TryParse(child.Text, int)
        child.Text = (int - 1)
        If int < 1 Then
            child.Text = 0
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Integer.TryParse(child.Text, int)
        child.Text = (int + 1)
        nofrooms.Enabled = True
    End Sub

    Private Sub roomtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles roomtype.SelectedIndexChanged

        If roomtype.SelectedItem = "Normal" Then
            osamt.Text = (3500 * nofdays.Text) * nofrooms.SelectedItem
            RCID = 1
        ElseIf roomtype.SelectedItem = "Deluxe" Then
            osamt.Text = (5000 * nofdays.Text) * nofrooms.SelectedItem

            RCID = 2
        ElseIf roomtype.SelectedItem = "Executive" Then
            osamt.Text = (6500 * nofdays.Text) * nofrooms.SelectedItem
            RCID = 3
        End If
    End Sub

    Private Sub StatusBar1_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles StatusBar1.VisibleChanged
        StatusBar1.Panels(0).Text = "Today : " & Now
    End Sub

    Private Sub Book_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_book.Click
        If (nofdays.Text > 30) Then
            MsgBox("Booking can't be made more than 30 days")
            bookfromdate.Text = ""
            booktilldate.Text = ""
        Else
            Dim ran As New Random
            Dim Bid As Integer
            Dim Rid As Integer
            Dim Rno As Integer
            Bid = ran.Next(1, 999)
            Rno = ran.Next(1, 250)
            Rid = ran.Next(1, 200)
            myConnection = New OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=scott;password=tiger;")
            myConnection.Open()
            myCommand = New OleDbCommand("insert into booking values('" & Bid & "','" & txtGid.Text & "','" & Rno & "','" & bookfromdate.Text & "','" & booktilldate.Text & "','" & nofrooms.Text & "','" & osamt.Text & "','0')", myConnection)
            dr = myCommand.ExecuteReader()
            If (dr.RecordsAffected()) Then
                myCmd2 = New OleDbCommand("insert into room values('" & Rid & "','" & RCID & "','" & Rno & "')", myConnection)
                dr2 = myCmd2.ExecuteReader()
                If (dr2.RecordsAffected()) Then
                    myCmd3 = New OleDbCommand("insert into bookingDetail values('" & Bid + 1 & "','" & Bid & "','" & RCID & "','" & Abook.Text & "','" & bookfromdate.Text & "','" & booktilldate.Text & "','" & nofdays.Text & "','" & osamt.Text & "','" & adult.Text & "','" & child.Text & "')", myConnection)
                    dr3 = myCmd3.ExecuteReader()
                    If (dr3.RecordsAffected()) Then
                        MsgBox("Reservation has been made!")
                        Dim m As New Menu
                        Hide()
                        m.Show()
                    Else
                        MsgBox("Error")
                    End If
                Else
                    MsgBox("Error")
                End If
            Else
                MsgBox("Error!")
            End If

        End If
        '' Hide()
        ''Dim m As New Menu
        ''m.Show()
    End Sub

    Private Sub Reservation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtChkBy.Text = Login.txtUser.Text
        Me.txtGid.Text = Guest_Info.txtGid.Text
        nofrooms.Enabled = False
    End Sub
End Class