
Imports System.Data.SqlClient
Public Class Login_Frm

    Private cmd As New SqlCommand()
    Private con As New SqlConnection()

    'Dim cs As String = " Data Source=|Data Directory|\Database\medicalClinicdb.mdf;Integrated Security=True"
    Dim cs As String = "Data Source=.\SQLEXPRESS;Initial Catalog=mainClinicDb;Integrated Security=True; Pooling=False"
    '' Dim cs As String = "Data Source=.\SQLEXPRESS;Initial Catalog=medicalClinicdb;Integrated Security=True;Pooling=False"  'connection string to connect with sql server
    Public Sub dbaccessconnection()
        Try
            Dim connection As New SqlConnection(cs)

            cmd.Connection = con

            ' MessageBox.Show("Connected")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show("Database not Connected")
        End Try
    End Sub



    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        signup_Frm.Show()
        Me.Close()

    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        If selectUser.Text = "User" Then

            Dim con As New SqlConnection(cs) ' making connection
            Dim sda As New SqlDataAdapter("SELECT COUNT(*) FROM Users WHERE Username='" & txtUsername.Text & "' AND Password='" & txtPass.Text & "' ", con)
            ' in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. 
            Dim dt As New DataTable() 'this is creating a virtual table
            sda.Fill(dt)
            If dt.Rows(0)(0).ToString() = "1" Then
                'Me.Close()

                addInvetory_Frm.added_by_txt.Text = Me.txtUsername.Text
                dashboard_Frm.billby_txt.Text = Me.txtUsername.Text
                dashboard_Frm.clinictodaybtn_dshbrd.Visible = False
                dashboard_Frm.usersRecords_Btn.Visible = False
                dashboard_Frm.manInventory_btn.Visible = False


                dashboard_Frm.Show()
                Me.Close()
            Else
                MessageBox.Show("Invalid username or password")
            End If
        ElseIf selectUser.Text = "Admin" Then
            Dim con As New SqlConnection(cs) ' making connection
            Dim sda As New SqlDataAdapter("SELECT COUNT(*) FROM admin_tb WHERE Username='" & txtUsername.Text & "'  AND Password='" & txtPass.Text & "'", con)
            ' in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. 
            Dim dt As New DataTable() 'this is creating a virtual table
            sda.Fill(dt)
            If dt.Rows(0)(0).ToString() = "1" Then

                addInvetory_Frm.added_by_txt.Text = Me.txtUsername.Text
                dashboard_Frm.billby_txt.Text = Me.txtUsername.Text
                dashboard_Frm.Label5.Text = Me.selectUser.Text

                dashboard_Frm.Show()
                Me.Close()
            Else
                MessageBox.Show("Your username Or password is not match", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                label6.ForeColor = Color.Red
                label6.Text = " Not succsessfully login "


            End If
        Else
            MessageBox.Show("Select your choice", "ADMIN or USER", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Login_Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
