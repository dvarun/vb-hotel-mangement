Imports System.Data.OleDb
Public Class allUser
    Dim myConnection As OleDbConnection
    Dim myCommand As OleDbCommand
    Dim myAuthCommand As OleDbCommand
    Dim dr As OleDbDataReader
    Dim myCommand1 As OleDbCommand
    Dim dr1 As OleDbDataReader
    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Hide()
        Dim m As New Menu
        m.Show()
    End Sub

    Private Sub lbl_Data_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub allUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AlluserSet.CUSTOMERDETAIL' table. You can move, or remove it, as needed.
        Me.CUSTOMERDETAILTableAdapter.Fill(Me.AlluserSet.CUSTOMERDETAIL)
        'TODO: This line of code loads data into the 'DataSet4.CUSTOMERDETAIL' table. You can move, or remove it, as needed.
        myConnection = New OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=scott;password=tiger;")
        myConnection.Open()
    End Sub
    Private Sub BindingNavigatorDeleteItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        myCommand1 = New OleDbCommand("Delete customerDetail where CID='" & txtId.Text & "'", myConnection)
        Try
            dr1 = myCommand1.ExecuteReader()

            If (dr1.RecordsAffected()) Then
                MsgBox("Customer Deleted!")
            Else
                MsgBox("Error!")
            End If
        Catch ex As Exception
            MsgBox("Sub record found for the current user,Data will not be deleted!")
            Me.Refresh()
        End Try
    End Sub
End Class