Imports System.Data.SqlClient

Public Class resetFrm
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
    Dim con As New SqlClient.SqlConnection
    Dim cmd As New SqlClient.SqlCommand
    Dim dt As New DataTable
    Dim cs As String = "Data Source=DESKTOP-52B846I;Initial Catalog=mainClinicDb;Integrated Security=True"

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        dashboard_Frm.Show()
        Me.Close()
    End Sub
    Private Sub DeleteSelecedRows_inventory()

        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "DELETE FROM add_invent_tbl"
            cmd.ExecuteNonQuery()

            welcomemsg.ForeColor = System.Drawing.Color.Green
            welcomemsg.Text = "delete successfully!"
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
            welcomemsg.ForeColor = System.Drawing.Color.Red
            Me.Dispose()
        End Try

    End Sub
    Private Sub altertable_inventory()

        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "ALTER TABLE add_invent_tbl AUTO_INCREMENT = 1 "
            cmd.ExecuteNonQuery()

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
            welcomemsg.ForeColor = System.Drawing.Color.Red
            Me.Dispose()
        End Try

    End Sub
    Private Sub DeleteSelecedRows_sell_tbl()

        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "DELETE FROM sell_tbl"
            cmd.ExecuteNonQuery()

            welcomemsg.ForeColor = System.Drawing.Color.Green
            welcomemsg.Text = "delete successfully!"
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
            welcomemsg.ForeColor = System.Drawing.Color.Red
            Me.Dispose()
        End Try

    End Sub
    Private Sub altertable_sell_tbl()

        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "ALTER TABLE sell_tbl AUTO_INCREMENT = 1 "
            cmd.ExecuteNonQuery()

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
            welcomemsg.ForeColor = System.Drawing.Color.Red
            Me.Dispose()
        End Try

    End Sub
    Private Sub DeleteSelecedRows_users()

        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "DELETE FROM Users"
            cmd.ExecuteNonQuery()

            welcomemsg.ForeColor = System.Drawing.Color.Green
            welcomemsg.Text = "delete successfully!"
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
            welcomemsg.ForeColor = System.Drawing.Color.Red
            Me.Dispose()
        End Try

    End Sub
    Private Sub altertable_usersy()

        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "ALTER TABLE Users AUTO_INCREMENT = 1 "
            cmd.ExecuteNonQuery()

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
            welcomemsg.ForeColor = System.Drawing.Color.Red
            Me.Dispose()
        End Try

    End Sub
    Private Sub DeleteSelecedRows_stock_tbl()

        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "DELETE FROM stock_tbl"
            cmd.ExecuteNonQuery()

            welcomemsg.ForeColor = System.Drawing.Color.Green
            welcomemsg.Text = "delete successfully!"
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
            welcomemsg.ForeColor = System.Drawing.Color.Red
            Me.Dispose()
        End Try

    End Sub
    Private Sub altertable_stock_tbl()

        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "ALTER TABLE stock_tbl AUTO_INCREMENT = 1 "
            cmd.ExecuteNonQuery()

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
            welcomemsg.ForeColor = System.Drawing.Color.Red
            Me.Dispose()
        End Try

    End Sub
    Private Sub BunifuButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        DeleteSelecedRows_inventory()
        altertable_inventory()

    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        DeleteSelecedRows_sell_tbl()
        altertable_sell_tbl()
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        DeleteSelecedRows_stock_tbl()
        altertable_stock_tbl()
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        DeleteSelecedRows_users()
        altertable_usersy()
    End Sub
End Class