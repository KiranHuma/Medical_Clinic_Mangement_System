Public Class signup_Frm



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

            Else

                address_Circle.BorderColor = Color.Green
                Next_btn.Text = "Finish"
                If (Next_btn.Text = "Finish") Then

                    msgBox_Frm.Show()

                End If
            End If

            End If
    End Sub

    Private Sub Next_btn_Click(sender As Object, e As EventArgs) Handles Next_btn.Click
        Next_signup_function()

    End Sub
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs)
        msgBox_Frm.Show()




    End Sub
End Class