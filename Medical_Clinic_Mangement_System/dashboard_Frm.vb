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
            records_btn.ForeColor = Color.White
            inventory_btn.ForeColor = Color.White
            addinventory_btn.ForeColor = Color.White
            manInventory_btn.ForeColor = Color.White
            PanelAnimator.ShowSync(sidemenu)
            logoAnimator.ShowSync(logo1)
            logoAnimator.ShowSync(logo)




        Else
            logoAnimator.Hide(logo1)
            logoAnimator.Hide(logo)

            sidemenu.Visible = False

            records_btn.ForeColor = Color.FromArgb(28, 49, 80)
            inventory_btn.ForeColor = Color.FromArgb(28, 49, 80)
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
End Class