
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports TheArtOfDev.HtmlRenderer.Core

Public Class addInvetory_Frm
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
    Dim cs As String = "Data Source=.\SQLEXPRESS;Initial Catalog=mainClinicDb;Integrated Security=True; Pooling=False"
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

    Private Sub insert()
        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "insert into add_invent_tbl([int_date],[in_product_name],[Qty_or_pcs],[packing],[in_prod_single_price],[in_prod_grand_price],[in_add_by],[in_total_quantity],[status],[address])values
                                                   ('" & Format(in_date.Value, "yyyy-MM-dd") & "','" & productName_txt.Text & "','" & qty_txt.Text & "','" & packing_txt.Text & "','" & singlePrice_txt.Text & "','" & grandTotal_txt.Text & "','" & added_by_txt.Text & "','" & instock_txt.Text & "','" & stockStatus_lbl.Text & "','" & address_txt.Text & "')"
            cmd.ExecuteNonQuery()

            welcomemsg.ForeColor = System.Drawing.Color.Green
            welcomemsg.Text = "'" & productName_txt.Text & "' details saved successfully!"
            con.Close()
        Catch ex As Exception
            MsgBox("Data Inserted Failed because " & ex.Message)
            Me.Dispose()
        End Try

    End Sub
    Private Sub insert_Admin()
        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "insert into add_invent_tbl([int_date],[in_product_name],[Qty_or_pcs],[packing],[in_prod_single_price],[in_prod_grand_price],[in_add_by],[in_total_quantity],[status],[address],[original_Single_Price],[grand_Total_with_orginal_price])values
                                                   ('" & Format(in_date.Value, "yyyy-MM-dd") & "','" & productName_txt.Text & "','" & qty_txt.Text & "','" & packing_txt.Text & "','" & singlePrice_txt.Text & "','" & grandTotal_txt.Text & "','" & added_by_txt.Text & "','" & instock_txt.Text & "','" & stockStatus_lbl.Text & "','" & address_txt.Text & "','" & adminSingle_txt.Text & "','" & adminGrandtotal_txt.Text & "')"
            cmd.ExecuteNonQuery()

            welcomemsg.ForeColor = System.Drawing.Color.Green
            welcomemsg.Text = "'" & productName_txt.Text & "' details saved successfully!"
            con.Close()
        Catch ex As Exception
            MsgBox("Data Inserted Failed because " & ex.Message)
            Me.Dispose()
        End Try

    End Sub
    Public Sub getdata()

        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select inven_Id as[ID],int_date as [Date],in_product_name as [Product Name],Qty_or_pcs as [Qty_or_Pcs],packing as [Packing],in_prod_single_price as [Single Product Price],in_prod_grand_price as [Grand Price],in_add_by as [Add by],in_total_quantity as [Total Stock],address as [Address],status as [Status] from add_invent_tbl", con)
            Dim dt As New DataTable
            da.Fill(dt)
            source2.DataSource = dt
            get_inventory.DataSource = dt
            get_inventory.Refresh()

        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving Data" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Public Sub getdata_admin()

        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select inven_Id as[ID],int_date as [Date],in_product_name as [Product Name],Qty_or_pcs as [Qty_or_Pcs],packing as [Packing],in_prod_single_price as [Single Product Price],in_prod_grand_price as [Grand Price],in_add_by as [Add by],in_total_quantity as [Total Stock],address as [Address],status as [Status], original_Single_Price as [Orginal Price],[grand_Total_with_orginal_price] as [Original Grand Price] from add_invent_tbl", con)
            Dim dt As New DataTable
            da.Fill(dt)
            source2.DataSource = dt
            admin_grid.DataSource = dt
            admin_grid.Refresh()
        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving Data" & ex.Message)
            Me.Dispose()
        End Try
    End Sub


    Private Sub FillCombo_product_name()
        Try
            Dim conn As New System.Data.SqlClient.SqlConnection(cs)
            Dim strSQL As String = "SELECT distinct in_product_name FROM add_invent_tbl"
            Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, conn)
            Dim ds As New DataSet
            da.Fill(ds, "add_invent_tbl")
            With Me.productName_txt
                .DataSource = ds.Tables("add_invent_tbl")

                .DisplayMember = "in_product_name"
                .ValueMember = "in_product_name"
                .SelectedIndex = -1
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With


        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving and Populating ProductID " & ex.Message)
            Me.Dispose()
        End Try

    End Sub
    Private Sub FillCombo_product_packing()
        Try
            Dim conn As New System.Data.SqlClient.SqlConnection(cs)
            Dim strSQL As String = "SELECT distinct packing FROM add_invent_tbl where in_product_name='" & productName_txt.Text & "'"
            Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, conn)
            Dim ds As New DataSet
            da.Fill(ds, "add_invent_tbl")
            With Me.packing_txt
                .DataSource = ds.Tables("add_invent_tbl")

                .DisplayMember = "packing"
                .ValueMember = "packing"
                .SelectedIndex = -1
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With


        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving and Populating ProductID " & ex.Message)
            Me.Dispose()
        End Try

    End Sub

    Private Sub addInvetory_Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getdata()
        FillCombo_product_name()
    End Sub



    Private Sub productName_txt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles productName_txt.SelectedIndexChanged
        FillCombo_product_packing()
        '' welcomemsg.Text = ""
    End Sub
    Private Sub clear_txt()
        qty_txt.Text = 0
        singlePrice_txt.Text = 0
        grandTotal_txt.Text = ""

        address_txt.Text = ""
        adminSingle_txt.Text = 0
        adminGrandtotal_txt.Text = 0
        FillCombo_product_name()
        FillCombo_product_packing()

    End Sub

    Private Sub update_Stock()
        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "UPDATE stock_tbl SET [stock_quantity]= '" & instock_txt.Text & "'  where [stock_name]='" & productName_txt.Text & "' And [stock_packing]='" & packing_txt.Text & "' "
            cmd.ExecuteNonQuery()

            welcomemsg.ForeColor = System.Drawing.Color.DarkGreen
            welcomemsg.Text = "original price of  '" & productName_txt.Text & "'  add successfully!"
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
            welcomemsg.ForeColor = System.Drawing.Color.Red
            Me.Dispose()
        End Try
    End Sub
    Private Sub insertStock()
        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "insert into stock_tbl([stock_name],[stock_packing],[stock_quantity])values
                                                   ('" & productName_txt.Text & "','" & packing_txt.Text & "','" & instock_txt.Text & "')"
            cmd.ExecuteNonQuery()

            welcomemsg.ForeColor = System.Drawing.Color.Green
            welcomemsg.Text = "'" & productName_txt.Text & "' details saved successfully!"
            con.Close()
        Catch ex As Exception
            MsgBox("Data Inserted Failed because " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Public Sub stockchck()
        Dim cmd As New SqlCommand()
        Dim str As String
        Dim com As SqlCommand
        Dim con As New SqlConnection(cs)
        con.Open()
        str = "select count(*)from [stock_tbl] where [stock_name]='" & productName_txt.Text & "' And [stock_packing]='" & packing_txt.Text & "' "
        com = New SqlCommand(str, con)
        Dim count As Integer = Convert.ToInt32(com.ExecuteScalar())
        con.Close()
        If count > 0 Then
            update_stock()



        Else
            insertStock()

        End If
    End Sub
    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles BunifuButton5.Click
        stockchck()
        insert()
        getdata()
        stockchck()
        clear_txt()
    End Sub
    Private Sub search_txt()

        Dim str As String
        Try
            Dim conn As New System.Data.SqlClient.SqlConnection(cs)
            conn.Open()
            str = "Select  inven_Id as[ID],int_date as [Date],in_product_name as [Product Name],Qty_or_pcs as [Qty_or_Pcs],packing as [Packing],in_prod_single_price as [Single Product Price],in_prod_grand_price as [Grand Price],in_add_by as [Add by],in_total_quantity as [Total Stock],address as [Address],status as [Status]  from add_invent_tbl where in_product_name like '" & txt_SearchInvenotry.Text & "%'"
            cmd = New SqlCommand(str, conn)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "add_invent_tbl")
            conn.Close()
            get_inventory.DataSource = ds
            get_inventory.DataMember = "add_invent_tbl"
            get_inventory.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:Product Name Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub
    Private Sub search_txt_admin()

        Dim str As String
        Try
            Dim conn As New System.Data.SqlClient.SqlConnection(cs)
            conn.Open()
            str = "Select  inven_Id as[ID],int_date as [Date],in_product_name as [Product Name],Qty_or_pcs as [Qty_or_Pcs],packing as [Packing],in_prod_single_price as [Single Product Price],in_prod_grand_price as [Grand Price],in_add_by as [Add by],in_total_quantity as [Total Stock],address as [Address],status as [Status],original_Single_Price as [Orginal Price],[grand_Total_with_orginal_price] as [Original Grand Price]  from add_invent_tbl where in_product_name like '" & txt_SearchInvenotry.Text & "%'"
            cmd = New SqlCommand(str, conn)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "add_invent_tbl")
            conn.Close()
            admin_grid.DataSource = ds
            admin_grid.DataMember = "add_invent_tbl"
            admin_grid.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:Product Name Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub
    Private Sub txt_searchinvenotry_TextChanged(sender As Object, e As EventArgs) Handles txt_SearchInvenotry.TextChanged
        search_txt()
    End Sub
    Private Sub Grand_Total()

        If qty_txt.Text = "" And singlePrice_txt.Text = "" Then
            qty_txt.Text = 0
            singlePrice_txt.Text = 0
        End If
        Dim single_Pc_price As Double
        Dim pcs_qtyy As Double
        Dim grand_totaltxt As Double
        single_Pc_price = Convert.ToDouble(singlePrice_txt.Text)
        pcs_qtyy = Convert.ToDouble(qty_txt.Text)
        grand_totaltxt = pcs_qtyy * single_Pc_price

        grandTotal_txt.Text = CStr(grand_totaltxt)
    End Sub

    Private Sub total_Inventory()
        Using connection As New SqlConnection(cs)
            Try

                Dim command As New SqlCommand("SELECT SUM(Qty_or_pcs) AS stockitems FROM add_invent_tbl where  in_product_name ='" & productName_txt.Text & "' AND  packing ='" & packing_txt.Text & "'", connection)
                connection.Open()
                cmd.Parameters.Clear()
                Dim read As SqlDataReader = command.ExecuteReader()

                Do While read.Read()
                    instock_txt.Text = (read("stockitems").ToString())

                Loop
                read.Close()

            Catch ex As Exception

                MessageBox.Show(ex.Message)
                Me.Dispose()
            End Try
        End Using
    End Sub


    Private Sub packing_txt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles packing_txt.SelectedIndexChanged
        total_Inventory()
        ''
    End Sub

    Private Sub original_Price()
        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "UPDATE add_invent_tbl SET original_Single_Price= '" & adminSingle_txt.Text & "',grand_Total_with_orginal_price= '" & adminGrandtotal_txt.Text & "' where inven_Id='" & In_Id.Text & "'"
            cmd.ExecuteNonQuery()

            welcomemsg.ForeColor = System.Drawing.Color.DarkGreen
            welcomemsg.Text = "original price of  '" & productName_txt.Text & "'  add successfully!"
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
            welcomemsg.ForeColor = System.Drawing.Color.Red
            Me.Dispose()
        End Try
    End Sub

    Private Sub addOriginalPrice_btn_Click(sender As Object, e As EventArgs) Handles addOriginalPrice_btn.Click

        If Label13.Text = "not select" Then
            MsgBox("Select Values from Gridview")
        Else
            BunifuPages1.PageIndex = 1
            original_Price()
            getdata_admin()
        End If
    End Sub
    Private Sub getData_Date()
        Using connection As New SqlConnection(cs)
            Try

                Dim dfrom As Date = filter_DatePicker_To.Value
                ''Dim dto As DateTime = DateTimePicker2.Value
                connection.Open()
                Dim da1 As New SqlDataAdapter("Select inven_Id as[ID],int_date,in_product_name as [Product Name],Qty_or_pcs as [Qty_or_Pcs],packing as [Packing],in_prod_single_price as [Single Product Price],in_prod_grand_price as [Grand Price],in_add_by as [Add by],in_total_quantity as [Total Stock],address as [Address],status as [Status] from add_invent_tbl where int_date BETWEEN   '" & Format(filter_DatePicker_To.Value, "yyyy-MM-dd") & "' AND  '" & Format(user_from_datepicker.Value, "yyyy-MM-dd") & "'", connection)
                Dim dt1 As New DataTable
                da1.Fill(dt1)
                source2.DataSource = dt1
                get_inventory.DataSource = dt1
                get_inventory.Refresh()
            Catch ex As Exception
                MessageBox.Show("Failed:Retrieving Data" & ex.Message)
                Me.Dispose()
            End Try
        End Using


    End Sub
    Private Sub getData_Admin_Date()
        Using connection As New SqlConnection(cs)
            Try

                Dim dfrom As Date = filter_DatePicker_To.Value
                ''Dim dto As DateTime = DateTimePicker2.Value
                connection.Open()
                Dim da1 As New SqlDataAdapter("Select inven_Id as[ID],int_date,in_product_name as [Product Name],Qty_or_pcs as [Qty_or_Pcs],packing as [Packing],in_prod_single_price as [Single Product Price],in_prod_grand_price as [Grand Price],in_add_by as [Add by],in_total_quantity as [Total Stock],address as [Address],status as [Status],original_Single_Price as [Orginal Price],[grand_Total_with_orginal_price] as [Original Grand Price]  from add_invent_tbl where int_date BETWEEN '" & Format(admin_Date_Picker.Value, "yyyy-MM-dd") & "' AND   '" & Format(datePicker_to_txt.Value, "yyyy-MM-dd") & "'", connection)
                Dim dt1 As New DataTable
                da1.Fill(dt1)
                source2.DataSource = dt1
                admin_grid.DataSource = dt1
                admin_grid.Refresh()
            Catch ex As Exception
                MessageBox.Show("Failed:Retrieving Data" & ex.Message)
                Me.Dispose()
            End Try
        End Using


    End Sub



    Private Sub instock_status()

        If instock_txt.Text = "0" Then

            stockStatus_lbl.Text = "out of Stock"
        Else
            If instock_txt.Text > "0" Then
                stockStatus_lbl.Text = "In Stock"
            Else
                stockStatus_lbl.Text = "fdf"
            End If


        End If
    End Sub
    Private Sub add_to_inventory()
        Dim qtyData As Double
        Dim totalStock As Double
        Dim grandStock As Double
        qtyData = Convert.ToDouble(qty_txt.Text)
        totalStock = Convert.ToDouble(instock_txt.Text)
        grandStock = qtyData + totalStock

        instock_txt.Text = CStr(grandStock)
    End Sub
    Private Sub singlePrice_txt_TextChanged(sender As Object, e As EventArgs) Handles singlePrice_txt.TextChanged


        ''instock_txt.Text = qty_txt.Text + instock_txt.Text


    End Sub
    Private Sub DeleteSelecedRows()

        Try
                con.ConnectionString = cs
                cmd.Connection = con
                con.Open()
            cmd.CommandText = "delete  from add_invent_tbl where inven_Id='" & In_Id.Text & "'"
            cmd.ExecuteNonQuery()

            welcomemsg.ForeColor = System.Drawing.Color.Green
            welcomemsg.Text = " '" & productName_txt.Text & "' with '" & In_Id.Text & "'  ID delete successfully!"
            con.Close()
            Catch ex As Exception
                MessageBox.Show("Data Not Updated" & ex.Message)
                welcomemsg.ForeColor = System.Drawing.Color.Red
                Me.Dispose()
            End Try

    End Sub
    Private Sub delete_Btn_Click(sender As Object, e As EventArgs) Handles delete_Btn.Click

        If Label13.Text = "not select" Then
            MsgBox("Select Values from Gridview")
        Else
            BunifuPages1.PageIndex = 1
            DeleteSelecedRows()
            getdata_admin()

            clear_txt()
        End If

    End Sub
    Private Sub update_Records()
        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "UPDATE  add_invent_tbl  SET  int_date= '" & Format(in_date.Value, "yyyy-MM-dd") & "', in_product_name= '" & productName_txt.Text & "', Qty_or_pcs = '" & qty_txt.Text & "', packing = '" & packing_txt.Text & "' , in_prod_single_price = '" & singlePrice_txt.Text & "' , in_prod_grand_price = '" & grandTotal_txt.Text & "' , in_add_by = '" & added_by_txt.Text & "' , in_total_quantity = '" & instock_txt.Text & "' , status = '" & stockStatus_lbl.Text & "' , address = '" & address_txt.Text & "' , original_Single_Price = '" & adminSingle_txt.Text & "' , grand_Total_with_orginal_price = '" & adminGrandtotal_txt.Text & "'  where inven_Id = '" & In_Id.Text & "'"

            cmd.ExecuteNonQuery()
            welcomemsg.ForeColor = System.Drawing.Color.DarkGreen
            welcomemsg.Text = "  '" & productName_txt.Text & "'  Update successfully!"
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
            welcomemsg.ForeColor = System.Drawing.Color.Red
            Me.Dispose()
        End Try
    End Sub
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles update_Btn.Click

        If Label13.Text = "not select" Then
            MsgBox("Select Values from Gridview")
        Else
            BunifuPages1.PageIndex = 1
            update_Records()
            getdata_admin()

            clear_txt()
        End If

    End Sub
    Private Sub Grand_Total1()

        If qty_txt.Text = "" And adminSingle_txt.Text = "" Then
            qty_txt.Text = 0
            adminSingle_txt.Text = 0
        End If
        Dim admin_single_Pc_price As Double
        Dim admin_Grand_Total As Double
        Dim pcs_qtyy As Double
        admin_single_Pc_price = Convert.ToDouble(adminSingle_txt.Text)
        pcs_qtyy = Convert.ToDouble(qty_txt.Text)
        admin_Grand_Total = pcs_qtyy * admin_single_Pc_price
        adminGrandtotal_txt.Text = CStr(admin_Grand_Total)




    End Sub
    Private Sub adminSingle_txt_MouseLeave(sender As Object, e As EventArgs) Handles adminSingle_txt.MouseLeave

    End Sub

    Private Sub adminSingle_txt_TextChanged(sender As Object, e As EventArgs) Handles adminSingle_txt.TextChanged
        instock_status()
    End Sub

    Private Sub show_admin_grid_Click(sender As Object, e As EventArgs) Handles show_admin_grid.Click
        BunifuPages1.PageIndex = 1
        getdata_admin()
    End Sub



    Private Sub get_inventory_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles get_inventory.CellMouseClick
        Try

            Me.In_Id.Text = get_inventory.CurrentRow.Cells(0).Value.ToString
            Me.in_date.Value = get_inventory.CurrentRow.Cells(1).Value.ToString
            Me.productName_txt.Text = get_inventory.CurrentRow.Cells(2).Value.ToString
            Me.qty_txt.Text = get_inventory.CurrentRow.Cells(3).Value.ToString
            Me.packing_txt.Text = get_inventory.CurrentRow.Cells(4).Value.ToString

            Me.singlePrice_txt.Text = get_inventory.CurrentRow.Cells(5).Value.ToString
            Me.grandTotal_txt.Text = get_inventory.CurrentRow.Cells(6).Value.ToString
            Me.added_by_txt.Text = get_inventory.CurrentRow.Cells(7).Value.ToString
            Me.address_txt.Text = get_inventory.CurrentRow.Cells(9).Value.ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:TextBox not found ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub



    Private Sub admin_grid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles admin_grid.CellMouseClick
        Try
            Label13.Text = "click"
            Me.In_Id.Text = admin_grid.CurrentRow.Cells(0).Value.ToString
                Me.in_date.Value = admin_grid.CurrentRow.Cells(1).Value.ToString
                Me.productName_txt.Text = admin_grid.CurrentRow.Cells(2).Value.ToString
                Me.qty_txt.Text = admin_grid.CurrentRow.Cells(3).Value.ToString
                Me.packing_txt.Text = admin_grid.CurrentRow.Cells(4).Value.ToString

                Me.singlePrice_txt.Text = admin_grid.CurrentRow.Cells(5).Value.ToString
                Me.grandTotal_txt.Text = admin_grid.CurrentRow.Cells(6).Value.ToString
                Me.added_by_txt.Text = admin_grid.CurrentRow.Cells(7).Value.ToString
                Me.instock_txt.Text = admin_grid.CurrentRow.Cells(8).Value.ToString
                Me.address_txt.Text = admin_grid.CurrentRow.Cells(9).Value.ToString
                Me.stockStatus_lbl.Text = admin_grid.CurrentRow.Cells(10).Value.ToString
                Me.adminSingle_txt.Text = admin_grid.CurrentRow.Cells(11).Value.ToString
                Me.adminGrandtotal_txt.Text = admin_grid.CurrentRow.Cells(12).Value.ToString


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:TextBox not found ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub

    Private Sub admin__search_product_TextChanged(sender As Object, e As EventArgs) Handles admin__search_product.TextChanged
        search_txt_admin()
    End Sub

    Private Sub save_Btn_Click(sender As Object, e As EventArgs) Handles save_Btn.Click
        stockchck()
        insert_Admin()
        BunifuPages1.PageIndex = 1

        getdata_admin()

        clear_txt()
    End Sub

    Private Sub singlePrice_txt_Validated(sender As Object, e As EventArgs) Handles singlePrice_txt.Validated
        Grand_Total()

    End Sub

    Private Sub adminSingle_txt_Validated(sender As Object, e As EventArgs) Handles adminSingle_txt.Validated
        Grand_Total1()
    End Sub

    Private Sub user_from_datepicker_ValueChanged(sender As Object, e As EventArgs) Handles user_from_datepicker.ValueChanged
        getData_Date()
    End Sub

    Private Sub datePicker_to_txt_ValueChanged(sender As Object, e As EventArgs) Handles datePicker_to_txt.ValueChanged
        getData_Admin_Date()
    End Sub



    Private Sub singlePrice_txt_MouseClick(sender As Object, e As MouseEventArgs) Handles singlePrice_txt.MouseClick
        add_to_inventory()

        instock_status()
        '' add_to_inventory()
    End Sub

    Private Sub qty_txt_TextChanged(sender As Object, e As EventArgs) Handles qty_txt.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class