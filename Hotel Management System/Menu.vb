Imports System.Data.OleDb
Public Class Menu
    Dim myConnection As OleDbConnection
    Dim myCommand As OleDbCommand
    Dim dr As OleDbDataReader
    Public UserId As String
    Public Username As String
    Public manu As Menu
    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.ROOM_CATE' table. You can move, or remove it, as needed.
        Me.ROOM_CATETableAdapter.Fill(Me.DataSet1.ROOM_CATE)
        Dim l As New Login
        l.Hide()
        btn_payment.Hide()
        passId.Hide()
        passName.Hide()
    End Sub

    Private Sub btn_pay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pay.Click
        Hide()
        Dim p As New Payment
        p.Show()
    End Sub

    Private Sub btn_chk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_chk.Click
        Hide()
        Dim aval As New Avail
        aval.Show()
    End Sub

    Private Sub btn_reserve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reserve.Click
        Hide()
        Dim g As New Guest_Info
        g.Show()
    End Sub

    Private Sub btn_allu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_allu.Click
        Hide()
        Dim u As New allUser
        u.Show()
    End Sub

    Private Sub btn_se2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_se2.Click
        Dim sig As Boolean = False
        myConnection = New OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=scott;password=tiger;")
        myConnection.Open()
        myCommand = New OleDbCommand("select * from customerDetail where CNAME='" & txtSearch.Text & "'", myConnection)
        dr = myCommand.ExecuteReader()
        While dr.Read()
            If (dr.HasRows()) Then
                btn_payment.Show()
                Dim Clname As String
                sig = True
                UserId = dr(0).ToString()
                Username = dr(1).ToString()
                Clname = dr(2).ToString()
                passId.Text = dr(0).ToString
                passName.Text = dr(1).ToString
                lbl_id.Text = "ID:" & UserId
                lbl_search.Text = "Name: " & Username & " " & Clname
                txtSearch.Text = ""
            Else
                sig = False
            End If
        End While
        If (sig = False) Then
            MsgBox("Not Found!!")
        End If
    End Sub

    Private Sub btn_payment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_payment.Click
        Dim p As New Payment
        p.Show()
        p.txtId.Text = Me.passId.Text
        Hide()
    End Sub

    Private Sub btn_bill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bill.Click
        Hide()
        Dim b As New Bills
        b.Show()
    End Sub

    Private Sub btn_admin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_admin.Click
        Hide()
        Dim emp As New Emp_detail
        emp.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Hide()
        Dim bookingDe As New Bookings
        bookingDe.Show()
    End Sub

    Private Sub btn_cls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cls.Click
        End
    End Sub

    Private Sub Btn_payments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_payments.Click
        Me.Hide()
        Dim payz As New Payments
        payz.Show()
    End Sub
End Class