
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Text.RegularExpressions
Public Class signup_Frm

    Dim cmd As New SqlCommand()
    Dim con As New SqlConnection()

    Dim str As String
    Dim com As SqlCommand

    Private bitmap As Bitmap
    Dim rdr As SqlDataReader
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As SqlConnection = New SqlConnection
    Dim ds As DataSet = New DataSet
    Dim da As SqlDataAdapter
    Dim tables As DataTableCollection = ds.Tables
    Dim source1 As New BindingSource()
    Dim source2 As New BindingSource()

    Dim dt As New DataTable
    Dim cs As String = "Data Source=DESKTOP-52B846I;Initial Catalog=mainClinicDb;Integrated Security=True"

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Close()
    End Sub


    Private Sub Next_signup_function()
        If (userNAme_Line.BorderColor = Color.Silver) Then
            If Len(Trim(user_btxt.Text)) = 0 Then
                user_btxt.Focus()
                user_btxt.Visible = True
                phoneNumber_btxt.Visible = False
                email_btxt.Text = False
                pwd_btxt.Text = False
                pwdagain_btxt.Text = False
                address_btxt.Text = False

            Else
                usernam_Circle.BorderColor = Color.Green
                userNAme_Line.BorderColor = Color.Green
            End If

        ElseIf (phoneNumber_Line.BorderColor = Color.Silver) Then
            If Len(Trim(phoneNumber_btxt.Text)) = 0 Then
                phoneNumber_btxt.Focus()
                user_btxt.Visible = False
                phoneNumber_btxt.Visible = True
                email_btxt.Visible = False
                pwd_btxt.Visible = False
                pwdagain_btxt.Visible = False
                address_btxt.Visible = False
                usernameCheck_lbl.Visible = False
            Else
                phone_Circle.BorderColor = Color.Green
                phoneNumber_Line.BorderColor = Color.Green
            End If


        ElseIf (email_Circle.BorderColor = Color.Silver) Then
            If Len(Trim(email_btxt.Text)) = 0 Then
                email_btxt.Focus()
                user_btxt.Visible = False
                phoneNumber_btxt.Visible = False
                email_btxt.Visible = True
                pwd_btxt.Visible = False
                pwdagain_btxt.Visible = False
                address_btxt.Visible = False

            Else
                email_Line.BorderColor = Color.Green
                email_Circle.BorderColor = Color.Green
            End If

        ElseIf (pwd_Line.BorderColor = Color.Silver) Then
            If Len(Trim(pwdagain_btxt.Text)) = 0 Then
                pwdagain_btxt.Focus()
                user_btxt.Visible = False
                phoneNumber_btxt.Visible = False
                email_btxt.Visible = False
                pwd_btxt.Visible = True
                pwdagain_btxt.Visible = True
                address_btxt.Visible = False

            Else
                pwd_Line.BorderColor = Color.Green
                pwd_Circle.BorderColor = Color.Green
            End If


        ElseIf (address_Circle.BorderColor = Color.Silver) Then
            If Len(Trim(address_btxt.Text)) = 0 Then
                user_btxt.Focus()
                user_btxt.Visible = False
                phoneNumber_btxt.Visible = False
                email_btxt.Visible = False
                pwd_btxt.Visible = False
                pwdagain_btxt.Visible = False
                address_btxt.Visible = True
                pwdmatch_lbl.Visible = False
            Else

                address_Circle.BorderColor = Color.Green
                Next_btn.Text = "Finish"
                If (Next_btn.Text = "Finish") Then
                    accountcreated()
                    Login_Frm.Show()
                    Me.Close()


                End If
            End If

        End If
    End Sub
    Public Sub dbaccessconnection()
        Try
            Dim connection As New SqlConnection(cs)
            cmd.Connection = con

            '  MessageBox.Show("Connected");
        Catch e1 As Exception

            MessageBox.Show("Database not Connected")
        End Try
    End Sub
    ' account creation
    Public Sub accountcreated()
        Try
            Dim connection As New SqlConnection(cs)
            connection.Open()


            Dim Username As String = user_btxt.Text
            Dim userrole As String = user_lbl.Text
            Dim Password As String = pwd_btxt.Text
            Dim passagain As String = pwdagain_btxt.Text
            Dim phonenumbr As String = phoneNumber_btxt.Text
            Dim emaill As String = email_btxt.Text
            Dim address As String = address_btxt.Text
            Dim Account_Creation_Date As String = txtDate.Text

            Dim sqlquery As String = ("insert into Users([Username],[UserRole],[Password],[phoneNumber],[Email],[Address],[accunt_create])values('" & user_btxt.Text & "','" & user_lbl.Text & "','" & pwd_btxt.Text & "','" & phoneNumber_btxt.Text & "','" & email_btxt.Text & "','" & address_btxt.Text & "','" & txtDate.Text & "')")
            Dim command As New SqlCommand(sqlquery, connection)

            command.Parameters.AddWithValue("Username", Username)
            command.Parameters.AddWithValue("UserRole", userrole)

            command.Parameters.AddWithValue("Password", Password)

            command.Parameters.AddWithValue("phoneNumber", phonenumbr)
            command.Parameters.AddWithValue("Email", emaill)

            command.Parameters.AddWithValue("Address", address)
            command.Parameters.AddWithValue("Account_Creation_Date", Account_Creation_Date)


            command.ExecuteNonQuery()
            Label7.Text = "Account  Created Successfully"
        Catch ex As Exception
            Label7.Visible = True
            Label7.Text = "Account not Created Successfully"
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub Next_btn_Click(sender As Object, e As EventArgs) Handles Next_btn.Click
        Next_signup_function()

    End Sub


    Private Sub signup_Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbaccessconnection()

        txtDate.Text = DateTime.Now.ToString("MM-dd-yyyy ")
    End Sub
    Public Sub namecheck()
        Dim con As New SqlConnection(cs)
        con.Open()
        str = "select count(*)from Users where Username='" & user_btxt.Text & "'"
        com = New SqlCommand(str, con)
        Dim count As Integer = Convert.ToInt32(com.ExecuteScalar())
        con.Close()
        If count > 0 Then
            usernameCheck_lbl.Visible = True
            usernameCheck_lbl.Text = "Sorry! you can't take this username"
            usernameCheck_lbl.ForeColor = Color.Red
            'usernameCheck_lbl.Text = "";
        Else
            usernameCheck_lbl.Text = ""

        End If

    End Sub

    Private Sub user_btxt_TextChanged(sender As Object, e As EventArgs) Handles user_btxt.TextChanged
        namecheck()
    End Sub

    Private Sub pwdagain_btxt_TextChanged(sender As Object, e As EventArgs) Handles pwdagain_btxt.TextChanged
        If pwd_btxt.Text = pwdagain_btxt.Text Then
            pwdmatch_lbl.Visible = True
            pwdmatch_lbl.Text = "Match"
            pwdmatch_lbl.ForeColor = Color.Green
        Else
            pwdmatch_lbl.Visible = True
            pwdmatch_lbl.Text = "Not match"
            pwdmatch_lbl.ForeColor = Color.Red
        End If
    End Sub
End Class