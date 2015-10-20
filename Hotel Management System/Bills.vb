Imports System.Data.OleDb
Public Class Bills
    Dim myConnection As OleDbConnection
    Private Sub Bills_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myConnection = New OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=scott;password=tiger;")
        myConnection.Open()
        Dim myCommand As OleDbCommand
        Dim dr As OleDbDataReader
        myCommand = New OleDbCommand("select CUS_ID from Booking where PAY_STATUS = 1", myConnection)
        dr = myCommand.ExecuteReader
        If (dr.HasRows) Then
            While dr.Read()
                cb1.Items.Add(dr(0))
            End While
        Else
            MsgBox("No Rows found!")
        End If
    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Hide()
        Dim men As New Menu
        men.Show()
    End Sub

    Private Sub Btn_Bill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Bill.Click
        Dim myCommand As OleDbCommand
        Dim dr As OleDbDataReader
        Dim spc As String
        myCommand = New OleDbCommand("select CID,CNAME,CLNAME,CRESIDENCE,CITY,MOBILE,CUS_ID,CHECKIN,CHECKOUT,TOTALPRICE from customerDetail,Booking where customerDetail.CID = Booking.CUS_ID and customerDetail.CID = '" & cb1.Text & "'", myConnection)
        dr = myCommand.ExecuteReader
        spc = " "
        If (dr.HasRows) Then
            While dr.Read()
                lbl_Cid.Text = dr(0)
                lblName.Text = dr(1).ToString + spc + dr(2).ToString
                lbl_country.Text = dr(3).ToString
                lbl_city.Text = dr(4).ToString
                lbl_phone.Text = dr(5).ToString
                chkin.Text = dr(7).ToString
                chkOut.Text = dr(8).ToString
                amt.Text = dr(9).ToString
            End While
        Else
            MsgBox("No Rows found!")
        End If
    End Sub

    Private Sub txtId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim suggestions As New AutoCompleteStringCollection()
        'Dim mysug As OleDbCommand
        'Dim suges As OleDbDataReader
        'mysug = New OleDbCommand("select CUS_ID from booking", myConnection)
        'suges = mysug.ExecuteReader()
        'While suges.Read()
        '    suggestions.Add(suges(0).ToString)
        'End While
        'txtId.AutoCompleteMode = AutoCompleteMode.Suggest
        'txtId.AutoCompleteSource = AutoCompleteSource.CustomSource
        'txtId.AutoCompleteCustomSource = suggestions
    End Sub

    Private Sub btn_back_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Hide()
        Dim m As New Menu
        m.Show()
    End Sub
End Class