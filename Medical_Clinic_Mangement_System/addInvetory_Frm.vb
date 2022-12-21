
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
            cmd.CommandText = "insert into add_invent_tbl([int_date],[in_product_name],[Qty_or_pcs],[packing],[in_prod_single_price],[in_prod_grand_price],[in_add_by],[in_total_quantity],[address])values
                                                   ('" & in_date.Value & "','" & productName_txt.Text & "','" & qty_txt.Text & "','" & packing_txt.Text & "','" & singlePrice_txt.Text & "','" & grandTotal_txt.Text & "','" & added_by_txt.Text & "','" & instock_txt.Text & "','" & address_txt.Text & "')"
            cmd.ExecuteNonQuery()

            welcomemsg.ForeColor = System.Drawing.Color.DarkGreen
            welcomemsg.Text = "'" & productName_txt.Text & "' details saved successfully!"
            con.Close()
        Catch ex As Exception
            MsgBox("Data Inserted Failed because " & ex.Message)
            Me.Dispose()
        End Try

    End Sub
    Private Sub getdata()

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

    End Sub
    Private Sub add_New()
        qty_txt.Text = ""
        singlePrice_txt.Text = 0
        grandTotal_txt.Text = ""
        qty_txt.Text = ""
        address_txt.Text = ""
        FillCombo_product_name()
        FillCombo_product_packing()
        welcomemsg.Text = ""
    End Sub
    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles BunifuButton5.Click
        insert()
        getdata()
        add_New()
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
    Private Sub txt_searchinvenotry_TextChanged(sender As Object, e As EventArgs) Handles txt_SearchInvenotry.TextChanged
        search_txt()
    End Sub
    Private Sub Grand_Total()


        Dim single_Pc_price As Double
        Dim pcs_qtyy As Double
        Dim grand_total As Double
        single_Pc_price = Convert.ToDouble(singlePrice_txt.Text)
        pcs_qtyy = Convert.ToDouble(qty_txt.Text)
        grand_total = pcs_qtyy * single_Pc_price
        grandTotal_txt.Text = CStr(grand_total)
    End Sub





    Private Sub singlePrice_txt_MouseEnter(sender As Object, e As EventArgs) Handles singlePrice_txt.MouseEnter

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






    Private Sub singlePrice_txt_Leave(sender As Object, e As EventArgs) Handles singlePrice_txt.Leave
        Grand_Total()
    End Sub

    Private Sub packing_txt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles packing_txt.SelectedIndexChanged
        total_Inventory()
    End Sub





    Private Sub get_inventory_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles get_inventory.CellMouseClick
        Try

            Me.In_Id.Text = get_inventory.CurrentRow.Cells(0).Value.ToString
            Me.DateTimePicker1.Value = get_inventory.CurrentRow.Cells(1).Value.ToString
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

    Private Sub original_Price()
        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "UPDATE add_invent_tbl SET original_Single_Price= '" & singlePrice_txt.Text & "',grand_Total_with_orginal_price= '" & grandTotal_txt.Text & "' where inven_Id='" & In_Id.Text & "'"
            cmd.ExecuteNonQuery()

            welcomemsg.ForeColor = System.Drawing.Color.DarkGreen
            welcomemsg.Text = "original price of'" & productName_txt.Text & "'  add successfully!"
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
            welcomemsg.ForeColor = System.Drawing.Color.Red
            Me.Dispose()
        End Try
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs)
        original_Price()
    End Sub

    Private Sub addOriginalPrice_btn_Click(sender As Object, e As EventArgs) Handles addOriginalPrice_btn.Click
        original_Price()
    End Sub
    Private Sub getData_Date()
        Using connection As New SqlConnection(cs)
            Try

                Dim dfrom As Date = filter_DatePicker_To.Value
                ''Dim dto As DateTime = DateTimePicker2.Value
                connection.Open()
                Dim da1 As New SqlDataAdapter("Select inven_Id as[ID],int_date,in_product_name as [Product Name],Qty_or_pcs as [Qty_or_Pcs],packing as [Packing],in_prod_single_price as [Single Product Price],in_prod_grand_price as [Grand Price],in_add_by as [Add by],in_total_quantity as [Total Stock],address as [Address],status as [Status] from add_invent_tbl where int_date = '" & DateTimePicker1.Value.Date & "'", connection)
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


    Private Sub filter_DatePicker_To_ValueChanged(sender As Object, e As EventArgs) Handles filter_DatePicker_To.ValueChanged
        'filter_DatePicker_To.Value = Label1.Text
        Label11.Text = filter_DatePicker_To.Value
        'filter_DatePicker_To.Value = Label1.Text

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        getData_Date()
    End Sub
End Class