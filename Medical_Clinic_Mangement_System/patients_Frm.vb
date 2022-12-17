Public Class patients_Frm
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        dashboard_Frm.Show()
        Me.Close()
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs)
        BunifuPages1.PageIndex = 1
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        BunifuPages1.PageIndex = 0
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        BunifuPages1.PageIndex = 1
    End Sub
End Class