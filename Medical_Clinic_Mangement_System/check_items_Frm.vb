Imports System.Data.SqlClient

Public Class check_items_Frm
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
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        If BunifuPages1.PageIndex = 0 Then
            BunifuPages1.PageIndex = 1
        Else
            Me.Close()
            dashboard_Frm.Show()
        End If


    End Sub



    Private Sub product_List_Txt_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles product_List_Txt.MouseDoubleClick
        If Id_for_edit_lbl.Text = "" And Id_for_edit_lbl.Text.Length = 0 Then
            MsgBox("Select the row from grid")
        Else
            BunifuPages1.PageIndex = 0
        End If
    End Sub

    Private Sub product_List_Txt_TextChanged(sender As Object, e As EventArgs) Handles product_List_Txt.TextChanged

    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub update_Records()
        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "UPDATE  sell_tbl  SET  sell_date= '" & Format(datePicker_Sell.Value, "yyyy-MM-dd") & "', patient_Name= '" & patientName_txt.Text & "', product_list = '" & product_List_Txt.Text & "', patient_Status = '" & patient_Status_Txt.Text & "' , price = '" & grand_Single_Pc.Text & "' , profit_price = '" & profit_Grand_Total.Text & "' , sell_total_quantity = '" & sell_Qty_Txt.Text & "' , sell_by = '" & billby_txt.Text & "'  where sell_Id = '" & Id_for_edit_lbl.Text & "'"

            cmd.ExecuteNonQuery()
            welcomemsg.ForeColor = System.Drawing.Color.DarkGreen
            welcomemsg.Text = "  '" & patientName_txt.Text & "'  Update successfully!"
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
            welcomemsg.ForeColor = System.Drawing.Color.Red
            Me.Dispose()
        End Try
    End Sub
    Public Sub clear()
        Id_for_edit_lbl.Text = String.Empty
        product_List_Txt.Text = " "
        patient_Status_Txt.Text = " "
        sell_Qty_Txt.Text = 0
        billby_txt.Text = " "
        patientName_txt.Text = " "
        grand_Single_Pc.Text = 0
        profit_Grand_Total.Text = 0
        dashboard_Frm.Id_for_edit_lbl.Text = " "
    End Sub
    Private Sub update_Btn_Click(sender As Object, e As EventArgs) Handles update_Btn.Click
        If Id_for_edit_lbl.Text = "" And Id_for_edit_lbl.Text.Length = 0 Then
            MsgBox("Select the row from grid")
        Else
            update_Records()
            dashboard_Frm.get_Selling_Data()
            clear()
        End If
    End Sub
    Private Sub DeleteSelecedRows()

        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "delete from sell_tbl where sell_Id='" & Id_for_edit_lbl.Text & "'"
            cmd.ExecuteNonQuery()

            welcomemsg.ForeColor = System.Drawing.Color.Green
            welcomemsg.Text = " '" & patientName_txt.Text & "' with '" & Id_for_edit_lbl.Text & "'  ID delete successfully!"
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
            welcomemsg.ForeColor = System.Drawing.Color.Red
            Me.Dispose()
        End Try

    End Sub

    Private Sub delete_Btn_Click(sender As Object, e As EventArgs) Handles delete_Btn.Click
        If Id_for_edit_lbl.Text = "" And Id_for_edit_lbl.Text.Length = 0 Then
            MsgBox("Select the row from grid")
        Else
            DeleteSelecedRows()
            dashboard_Frm.get_Selling_Data()
            clear()
        End If
    End Sub

    Private Sub grand_Single_Pc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles grand_Single_Pc.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub profit_Grand_Total_KeyPress(sender As Object, e As KeyPressEventArgs) Handles profit_Grand_Total.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub sell_Qty_Txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles sell_Qty_Txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub
End Class