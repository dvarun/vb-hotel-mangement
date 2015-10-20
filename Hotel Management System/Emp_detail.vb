Imports System.Data.OleDb
Public Class Emp_detail
    Dim myConnection As OleDbConnection
    Dim myCommand As OleDbCommand
    Dim dr As OleDbDataReader
    Dim myCommand1 As OleDbCommand
    Dim dr1 As OleDbDataReader
    Dim myCommand2 As OleDbCommand
    Dim dr2 As OleDbDataReader
    Private Sub Emp_detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet3.EMPLOYEE' table. You can move, or remove it, as needed.
        Me.EMPLOYEETableAdapter.Fill(Me.DataSet3.EMPLOYEE)
        myConnection = New OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=scott;password=tiger;")
        myConnection.Open()
        Btn_sub.Hide()
    End Sub

    Private Sub Btn_sub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_sub.Click
        If (txtId.Text = "" Or txtName.Text = "" Or txtLname.Text = "" Or txtUser.Text = "" Or txtPass.Text = "") Then
            MsgBox("Please fill all the fields!")
        Else
            myCommand = New OleDbCommand("insert into employee values('" & txtId.Text & "','" & txtName.Text & "','" & txtLname.Text & "','" & txtUser.Text & "','" & txtPass.Text & "')", myConnection)
            dr = myCommand.ExecuteReader()
            If (dr.RecordsAffected()) Then
                MsgBox("Employee added!")
                Btn_sub.Hide()
                btn_edit.Show()
            Else
                MsgBox("Error!")
            End If
        End If
    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Hide()
        Dim mn As New Menu
        mn.Show()
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        If (txtName.TextLength > 10 Or txtLname.TextLength > 10 Or txtUser.TextLength > 8 Or txtPass.TextLength > 8) Then
            MsgBox("Value too large for the field")
        Else
            myCommand1 = New OleDbCommand("update employee set EMP_NAME='" & txtName.Text & "',EMP_LNAME='" & txtLname.Text & "',EMP_USER='" & txtUser.Text & "',PASSWORD='" & txtPass.Text & "'where EMP_ID='" & txtId.Text & "' ", myConnection)
            dr1 = myCommand1.ExecuteReader()
            If (dr1.RecordsAffected()) Then
                MsgBox("Employee Updated!")
            Else
                MsgBox("Error!")
            End If
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        txtId.Enabled = True
        Btn_sub.Show()
        btn_edit.Hide()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        If (txtId.Text = "") Then
            MsgBox("No id found!")
            btn_edit.Show()
            Btn_sub.Hide()
        Else
            myCommand2 = New OleDbCommand("Delete from employee where EMP_ID='" & txtId.Text & "'", myConnection)
            dr2 = myCommand2.ExecuteReader()
            If (dr2.RecordsAffected()) Then
                MsgBox("Employee Deleted!")
            Else
                MsgBox("Error!")
            End If
        End If
    End Sub

    Private Sub BindingNavigatorMovePreviousItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMovePreviousItem.Click
        btn_edit.Show()
        Btn_sub.Hide()
    End Sub
End Class