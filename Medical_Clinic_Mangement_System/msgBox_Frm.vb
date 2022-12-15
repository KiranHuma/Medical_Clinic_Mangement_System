Imports System.Reflection.Emit
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class msgBox_Frm
    Dim second As Integer
    Private Sub msgBox_Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.ToString

        second = second + 1
        If second >= 1 Then
            Timer1.Stop() 'Timer stops functioning
            Me.Close()
            'MsgBox("Timer Stopped....")
        End If
    End Sub


End Class