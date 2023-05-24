Imports System.Data.SqlClient

Public Class manage_Inventory_Frm
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
        dashboard_Frm.Show()
        Me.Close()
    End Sub


    Public Sub clear()
        Id_for_edit_lbl.Text = String.Empty
        Stock_Id.Text = String.Empty
        product_Name_txt.Text = " "
        packing_txt.Text = 0
        stockqty_txt.Text = " "
        stockthreshold_txt.Text = " "
        dashboard_Frm.Label33.Text = " "
    End Sub
    Private Sub DeleteSelecedRows()

        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "delete from stock_tbl where stock_id='" & Stock_Id.Text & "'"
            cmd.ExecuteNonQuery()
            welcomemsg.Visible = True
            welcomemsg.ForeColor = System.Drawing.Color.Green
            welcomemsg.Text = " '" & product_Name_txt.Text & "' with '" & Stock_Id.Text & "'  ID delete successfully!"
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
            welcomemsg.ForeColor = System.Drawing.Color.Red
            Me.Dispose()
        End Try

    End Sub
    Private Sub delete_Btn_Click(sender As Object, e As EventArgs) Handles delete_Btn.Click
        If Stock_Id.Text = "" And Stock_Id.Text.Length = 0 Then
            MsgBox("Select the row from grid")
        Else
            DeleteSelecedRows()
            dashboard_Frm.get_total_stock_Data()
            clear()
        End If
    End Sub
    Private Sub update_Records()
        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "UPDATE  stock_tbl  SET  stock_name= '" & product_Name_txt.Text & "', stock_packing= '" & packing_txt.Text & "', stock_quantity = '" & stockqty_txt.Text & "', threshold_value = '" & stockthreshold_txt.Text & "',sell_price= '" & stock_sell_price.Text & "'  where stock_id = '" & Stock_Id.Text & "'"

            cmd.ExecuteNonQuery()
            welcomemsg.Visible = True

            welcomemsg.ForeColor = System.Drawing.Color.DarkGreen
            welcomemsg.Text = "  '" & product_Name_txt.Text & "'  Update successfully!"
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
            welcomemsg.ForeColor = System.Drawing.Color.Red
            Me.Dispose()
        End Try
    End Sub
    Private Sub update_Btn_Click(sender As Object, e As EventArgs) Handles update_Btn.Click
        If Stock_Id.Text = "" And Stock_Id.Text.Length = 0 Then
            MsgBox("Select the row from grid")
        Else
            update_Records()
            dashboard_Frm.get_total_stock_Data()
            clear()
        End If
    End Sub
    Private Sub FillCombo_product_name()
        Try
            Dim conn As New System.Data.SqlClient.SqlConnection(cs)
            Dim strSQL As String = "SELECT distinct stock_name FROM stock_tbl"
            Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, conn)
            Dim ds As New DataSet
            da.Fill(ds, "stock_tbl")
            With Me.product_Name_txt
                .DataSource = ds.Tables("stock_tbl")
                .DisplayMember = "stock_name"
                .ValueMember = "stock_name"
                .SelectedIndex = -1
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving and Populating ProductID " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub FillCombo_packing()
        Try
            Dim conn As New System.Data.SqlClient.SqlConnection(cs)
            Dim strSQL As String = "SELECT distinct stock_packing FROM stock_tbl"
            Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, conn)
            Dim ds As New DataSet
            da.Fill(ds, "stock_tbl")
            With Me.packing_txt
                .DataSource = ds.Tables("stock_tbl")
                .DisplayMember = "stock_packing"
                .ValueMember = "stock_packing"
                .SelectedIndex = -1
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving and Populating ProductID " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub manage_Inventory_Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        '
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        FillCombo_product_name()
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        FillCombo_packing()
    End Sub

    Private Sub stockqty_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles stockqty_txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub stock_sell_price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles stock_sell_price.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub stockthreshold_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles stockthreshold_txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub
End Class