
Imports System.Collections.ObjectModel
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports TheArtOfDev.HtmlRenderer.Core
Public Class dashboard_Frm
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
    Private Sub insert()
        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "insert into sell_tbl([sell_date],[patient_Name],[product_list],[patient_Status],[price],[profit_price],[sell_total_quantity],[sell_by])values
            ('" & Format(datePicker_Sell.Value, "yyyy-MM-dd") & "','" & patientName_txt.Text & "','" & product_List_Txt.Text & "','" & patient_Status_Txt.Text & "','" & grand_Single_Pc.Text & "','" & profit_Grand_Total.Text & "','" & sell_Qty_Txt.Text & "','" & billby_txt.Text & "')"
            cmd.ExecuteNonQuery()
            welcomemsg.ForeColor = System.Drawing.Color.Green
            welcomemsg.Text = "'" & patientName_txt.Text & "' details saved successfully!"
            con.Close()
        Catch ex As Exception
            MsgBox("Data Inserted Failed because " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Close()
    End Sub
    Private Sub list_products()
        product_List_Txt.Text &= "Product Name" & ":" & product_Name_txt.Text & "," & "Packing " & ":" & packing_txt.Text & "," & "Quantity " & ":" & qty_txt.Text & "," & "Sell Price" & ":" + single_pc_to.Text & vbNewLine
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
    Private Sub addinventory_btn_Click(sender As Object, e As EventArgs) Handles addinventory_btn.Click
        addInvetory_Frm.ShowDialog()
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
    Private Sub Grand_Sell_bill()

        'single piece quantity and price
        Dim single_Pc_price As Double
        Dim pcs_qtyy As Double
        Dim grand_totaltxt As Double
        Dim single_totaltxt As Double
        Dim grand_totaltxt2 As Double
        single_Pc_price = Convert.ToDouble(sell_Price_Txt.Text)
        pcs_qtyy = Convert.ToDouble(qty_txt.Text)
        grand_totaltxt = pcs_qtyy * single_Pc_price
        single_pc_to.Text = CStr(grand_totaltxt)

        ''sum all single pc price
        Dim num4 As Double
        single_totaltxt = Convert.ToDouble(single_pc_to.Text)
        grand_totaltxt2 = Convert.ToDouble(grand_Single_Pc.Text)
        num4 = single_totaltxt + grand_totaltxt2
        grand_Single_Pc.Text = CStr(num4)


        ''sum all quantities
        Dim single_totalquntity3 As Double
        Dim single_totalquntity4 As Double
        Dim num5 As Double
        single_totalquntity3 = Convert.ToDouble(qty_txt.Text)
        single_totalquntity4 = Convert.ToDouble(sell_Qty_Txt.Text)
        num5 = single_totalquntity3 + single_totalquntity4
        sell_Qty_Txt.Text = CStr(num5)



        ''profit price calculation

        Dim sellePrice1 As Double
        Dim purchasePrice2 As Double
        Dim GrandpurchasePrice2 As Double
        Dim num6 As Double
        Dim num7 As Double
        sellePrice1 = Convert.ToDouble(sell_Price_Txt.Text)
        purchasePrice2 = Convert.ToDouble(profit_Price_Txt.Text)
        GrandpurchasePrice2 = Convert.ToDouble(profit_Grand_Total.Text)

        num6 = (sellePrice1 - purchasePrice2) * single_totalquntity3
        num7 = GrandpurchasePrice2 + num6

        profit_Grand_Total.Text = CStr(num7)
    End Sub
    Private Sub total_Inventory()



        Using connection As New SqlConnection(cs)
                Try

                Dim command As New SqlCommand("SELECT stock_name,stock_packing,stock_quantity FROM stock_tbl where  stock_name ='" & product_Name_txt.Text & "' AND  stock_packing ='" & packing_txt.Text & "'", connection)
                connection.Open()
                    cmd.Parameters.Clear()
                    Dim read As SqlDataReader = command.ExecuteReader()

                    Do While read.Read()
                        Label32.Text = (read("stock_quantity").ToString())
                        ''profit_Price_Txt.Text = (read("original_Single_Price").ToString())
                    Loop
                    read.Close()

                Catch ex As Exception

                    MessageBox.Show(ex.Message)
                    Me.Dispose()
                End Try
            End Using


    End Sub
    Private Sub original_price()
        Using connection As New SqlConnection(cs)
            Try

                Dim command As New SqlCommand("SELECT original_Single_Price,in_product_name,packing,in_prod_single_price FROM add_invent_tbl where  in_product_name ='" & product_Name_txt.Text & "' AND  packing ='" & packing_txt.Text & "' AND in_prod_single_price ='" & sell_Price_Txt.Text & "'", connection)
                connection.Open()
                cmd.Parameters.Clear()
                Dim read As SqlDataReader = command.ExecuteReader()

                Do While read.Read()
                    profit_Price_Txt.Text = (read("original_Single_Price").ToString())
                    ''profit_Price_Txt.Text = (read("original_Single_Price").ToString())
                Loop
                read.Close()

            Catch ex As Exception

                MessageBox.Show(ex.Message)
                Me.Dispose()
            End Try
        End Using
    End Sub
    Private Sub FillCombo_product_name()
        Try
            Dim conn As New System.Data.SqlClient.SqlConnection(cs)
            Dim strSQL As String = "SELECT distinct in_product_name FROM add_invent_tbl"
            Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, conn)
            Dim ds As New DataSet
            da.Fill(ds, "add_invent_tbl")
            With Me.product_Name_txt
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
            Dim strSQL As String = "SELECT distinct packing FROM add_invent_tbl where in_product_name='" & product_Name_txt.Text & "'"
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
    Private Sub FillCombo_product_price()
        Try
            Dim conn As New System.Data.SqlClient.SqlConnection(cs)
            Dim strSQL As String = "SELECT distinct in_prod_single_price FROM add_invent_tbl  where in_product_name='" & product_Name_txt.Text & "' AND   packing='" & packing_txt.Text & "'"
            Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, conn)
            Dim ds As New DataSet
            da.Fill(ds, "add_invent_tbl")
            With Me.sell_Price_Txt
                .DataSource = ds.Tables("add_invent_tbl")

                .DisplayMember = "in_prod_single_price"
                .ValueMember = "in_prod_single_price"
                .SelectedIndex = -1
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With


        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving and Populating ProductID " & ex.Message)
            Me.Dispose()
        End Try

    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles Check_Out_Btn.Click
        insert()
        get_Selling_Data()
    End Sub
    Private Sub grand_Single_Pc_MouseClick(sender As Object, e As MouseEventArgs) Handles grand_Single_Pc.MouseClick
        original_price()
        total_Inventory()
        Grand_Sell_bill()
        list_products()
    End Sub
    Private Sub get_Selling_Data()
        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select sell_Id as[ID],[sell_date] as [Date],[patient_Name] as [Patient Name],[product_list] as [Product List],[patient_Status] as [Patient Status],[price] as [Sell Price],[profit_price] as [Profit Price],[sell_total_quantity] as [Total Quantity],[sell_by] as [Sell By] from sell_tbl", con)
            Dim dt As New DataTable
            da.Fill(dt)
            source2.DataSource = dt
            sell_grid.DataSource = dt
            sell_grid.Refresh()

        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving Data" & ex.Message)
            Me.Dispose()
        End Try
    End Sub


    Private Sub product_Name_txt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles product_Name_txt.SelectedIndexChanged
        FillCombo_product_packing()
    End Sub

    Private Sub packing_txt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles packing_txt.SelectedIndexChanged

        FillCombo_product_price()
        total_Inventory()
    End Sub



    Private Sub BunifuButton3_Click_1(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        BunifuPages1.PageIndex = 3
    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub dashboard_Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo_product_name()

    End Sub

    Private Sub sell_Price_Txt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sell_Price_Txt.SelectedIndexChanged


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        total_Inventory()

    End Sub



End Class