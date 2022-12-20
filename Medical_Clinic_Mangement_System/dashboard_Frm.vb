Public Class dashboard_Frm
    Private Sub dashboard_Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Close()
    End Sub

    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        If (sidemenu.Width = 70) Then
            sidemenu.Visible = False

            sidemenu.Width = 260
            usersRecords_Btn.ForeColor = Color.White

            addinventory_btn.ForeColor = Color.White
            manInventory_btn.ForeColor = Color.White
            PanelAnimator.ShowSync(sidemenu)
            logoAnimator.ShowSync(logo1)
            logoAnimator.ShowSync(logo)




        Else
            logoAnimator.Hide(logo1)
            logoAnimator.Hide(logo)

            sidemenu.Visible = False

            usersRecords_Btn.ForeColor = Color.FromArgb(28, 49, 80)

            addinventory_btn.ForeColor = Color.FromArgb(28, 49, 80)
            manInventory_btn.ForeColor = Color.FromArgb(28, 49, 80)


            sidemenu.Width = 70
            PanelAnimator.ShowSync(sidemenu)
        End If

    End Sub

    Private Sub sidemenu_Paint(sender As Object, e As PaintEventArgs) Handles sidemenu.Paint

    End Sub

    Private Sub header_Paint(sender As Object, e As PaintEventArgs) Handles header.Paint

    End Sub

    Private Sub addinventory_btn_Click(sender As Object, e As EventArgs) Handles addinventory_btn.Click

        addInvetory_Frm.Show()
        Me.Close()
    End Sub

    Private Sub records_btn_Click(sender As Object, e As EventArgs) Handles usersRecords_Btn.Click
        user_Records_Frm.Show()
        Me.Close()
    End Sub

    Private Sub inventory_btn_Click(sender As Object, e As EventArgs)

        Me.Close()
    End Sub

    Private Sub manInventory_btn_Click(sender As Object, e As EventArgs) Handles manInventory_btn.Click
        manage_Inventory_Frm.Show()
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub BunifuTextBox1_TextChanged(sender As Object, e As EventArgs) Handles BunifuTextBox1.TextChanged

    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles billby_txt.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        patients_Frm.Show()
        Me.Close()

    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles clinictodaybtn_dshbrd.Click
        BunifuPages1.PageIndex = 1
    End Sub

    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles BunifuButton5.Click
        BunifuPages1.PageIndex = 0
    End Sub

    Private Sub BunifuButton6_Click(sender As Object, e As EventArgs) Handles BunifuButton6.Click
        BunifuPages1.PageIndex = 2
    End Sub
End Class