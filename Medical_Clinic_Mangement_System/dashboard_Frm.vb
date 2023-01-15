
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports HtmlRenderer
Imports Microsoft.Reporting.WinForms

Imports Org.BouncyCastle.Math.EC
Imports TheArtOfDev.HtmlRenderer.Core
Public Class dashboard_Frm




    Dim str As String
    Dim com As SqlCommand


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
    Private Sub insert_with_admit_label()
        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "insert into sell_tbl([sell_date],[patient_Name],[product_list],[patient_Status],[price],[profit_price],[sell_total_quantity],[sell_by])values
            ('" & Format(datePicker_Sell.Value, "yyyy-MM-dd") & "','" & patientName_txt.Text & "','" & product_List_Txt.Text & "','" & patient_over_all_status_lbl.Text & "','" & grand_Single_Pc.Text & "','" & profit_Grand_Total.Text & "','" & sell_Qty_Txt.Text & "','" & billby_txt.Text & "')"
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
        user_Records_Frm.ShowDialog()

    End Sub
    Private Sub inventory_btn_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub manInventory_btn_Click(sender As Object, e As EventArgs) Handles manInventory_btn.Click
        BunifuPages1.PageIndex = 4
        get_total_stock_Data()
    End Sub
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        BunifuPages1.PageIndex = 3
        get_Selling_Data()
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


        'stock after selling
        Dim stockSell As Double
        Dim totalStock As Double
        Dim remaingStock As Double
        stockSell = Convert.ToDouble(qty_txt.Text)
        totalStock = Convert.ToDouble(stock_get_label.Text)
        remaingStock = totalStock - stockSell
        stock_get_label.Text = CStr(remaingStock)


    End Sub
    Private Sub Check_if_stock_exists()
        Using connection As New SqlConnection(cs)
            Try

                Dim command As New SqlCommand("Select count(1) as stockrecord from stock_tbl where stock_name ='" & product_Name_txt.Text & "' AND  stock_packing ='" & packing_txt.Text & "' AND sell_price='" & sell_Price_Txt.Text & "'", connection)
                connection.Open()
                cmd.Parameters.Clear()
                Dim read As SqlDataReader = command.ExecuteReader()

                Do While read.Read()
                    stockcheck_lbl.Text = (read("stockrecord").ToString())
                    ''profit_Price_Txt.Text = (read("original_Single_Price").ToString())
                Loop
                read.Close()

            Catch ex As Exception

                MessageBox.Show("Check_if_stock_exists", ex.Message)
                Me.Dispose()
            End Try
        End Using



    End Sub

    Private Sub total_Inventory()
        Check_if_stock_exists()
        If stockcheck_lbl.Text > 0 Then
            stockcheck_lbl.Visible = False
            stock_get_label.ForeColor = System.Drawing.Color.Green

            Using connection1 As New SqlConnection(cs)
                Try
                    ''SELECT column_name(s) From table_name Where EXISTS(SELECT column_name FROM table_name WHERE condition)
                    Dim command1 As New SqlCommand("SELECT stock_name,stock_packing,stock_quantity FROM stock_tbl where  stock_name ='" & product_Name_txt.Text & "' AND  stock_packing ='" & packing_txt.Text & "' AND sell_price='" & sell_Price_Txt.Text & "' ", connection1)
                    connection1.Open()
                    cmd.Parameters.Clear()
                    Dim read As SqlDataReader = command1.ExecuteReader()

                    Do While read.Read()
                        stock_get_label.Text = (read("stock_quantity").ToString())
                        ''profit_Price_Txt.Text = (read("original_Single_Price").ToString())
                    Loop
                    read.Close()

                Catch ex As Exception

                    MessageBox.Show("Total Invenotry error", ex.Message)
                    Me.Dispose()
                End Try
            End Using
        Else
            stockcheck_lbl.Visible = True
            stockcheck_lbl.Text = "Record Not found"

            stock_get_label.Text = 0
            stock_get_label.ForeColor = System.Drawing.Color.Red
        End If
    End Sub
    Private Sub clear()
        patient_Status_Txt.Text = ""

        product_Name_txt.Text = ""
        packing_txt.Text = ""
        sell_Price_Txt.Text = 0
        qty_txt.Text = 0
        single_pc_to.Text = 0



    End Sub
    Private Sub original_price()
        Using connection As New SqlConnection(cs)
            Try

                Dim command As New SqlCommand("SELECT Top 1 original_Single_Price FROM add_invent_tbl where  in_product_name ='" & product_Name_txt.Text & "' AND  packing ='" & packing_txt.Text & "' AND in_prod_single_price ='" & sell_Price_Txt.Text & "'", connection)
                connection.Open()
                cmd.Parameters.Clear()
                Dim read As SqlDataReader = command.ExecuteReader()

                Do While read.Read()
                    profit_Price_Txt.Text = (read("original_Single_Price").ToString())
                    ''profit_Price_Txt.Text = (read("original_Single_Price").ToString())
                Loop
                read.Close()

            Catch ex As Exception

                MessageBox.Show("Original Price Error", ex.Message)
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
                AddHandler packing_txt.SelectedIndexChanged, AddressOf packing_txt_SelectedIndexChanged
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
    Private Sub update_stock_after_sell()
        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "UPDATE stock_tbl SET [stock_quantity]= '" & stock_get_label.Text & "'  where [stock_name]='" & product_Name_txt.Text & "' And [stock_packing]='" & packing_txt.Text & "' And [sell_price]='" & sell_Price_Txt.Text & "'"
            cmd.ExecuteNonQuery()

            ''welcomemsg.ForeColor = System.Drawing.Color.DarkGreen
            ''welcomemsg.Text = "update stock of  '" & product_Name_txt.Text & "'  add successfully!"
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Stock Not Updated" & ex.Message)
            welcomemsg.ForeColor = System.Drawing.Color.Red
            Me.Dispose()
        End Try
    End Sub
    Private Sub check_out_clear()
        welcomemsg.Text = ""
        sell_Qty_Txt.Text = 0
        grand_Single_Pc.Text = 0
        patientName_txt.Text = ""
        profit_Price_Txt.Text = 0
        profit_Grand_Total.Text = 0
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles Check_Out_Btn.Click
        If product_List_Txt.Text.Contains("Admit Fees") Then
            patient_over_all_status_lbl.Text = "Admit"
            insert_with_admit_label()
            get_Selling_Data()
            product_List_Txt.Text = String.Empty
            check_out_clear()
            clear()
        Else
            insert()
            get_Selling_Data()
            product_List_Txt.Text = String.Empty
            check_out_clear()
            clear()
        End If



    End Sub
    Private Sub list_products()

        If patient_Status_Txt.Text = "Admit" Then
            product_List_Txt.Text &= "Cause Name" & ":" & " " & " " & product_Name_txt.Text & "," & " " & " " & "Admit Fees" & ":" + " " & " " & sell_Price_Txt.Text & vbNewLine
        ElseIf patient_Status_Txt.Text = "CheckUp" Then
            product_List_Txt.Text &= "Service Name" & ":" & " " & " " & product_Name_txt.Text & "," & " " & " " & "Service Charges" & ":" + " " & " " & sell_Price_Txt.Text & vbNewLine
        ElseIf patient_Status_Txt.Text = "Customer" Then
            product_List_Txt.Text &= "Product Name" & ":" & " " & " " & product_Name_txt.Text & "," & " " & " " & "Packing " & ":" & " " & " " & packing_txt.Text & "," & " " & " " & "Quantity " & ":" & " " & " " & qty_txt.Text & "," & " " & " " & "Sell Price" & ":" + " " & " " & single_pc_to.Text & vbNewLine
        End If
    End Sub
    Private Sub bill_cal_admit_chk()
        Dim selladmit_ch1 As Double
        Dim selladmit_ch2 As Double
        Dim selladmit_ch3 As Double
        Dim selladmit_ch4 As Double
        Dim selladmit_ch5 As Double
        selladmit_ch1 = Convert.ToDouble(sell_Price_Txt.Text)
        selladmit_ch2 = Convert.ToDouble(grand_Single_Pc.Text)
        selladmit_ch3 = selladmit_ch1 + selladmit_ch2
        grand_Single_Pc.Text = CStr(selladmit_ch3)
        selladmit_ch4 = Convert.ToDouble(profit_Grand_Total.Text)
        selladmit_ch5 = selladmit_ch1 + selladmit_ch4
        profit_Grand_Total.Text = CStr(selladmit_ch5)
    End Sub
    Private Sub admit_cust_checkup()
        If patient_Status_Txt.Text = "Admit" Then

            admit_tag_lbl.Visible = True
            cause_lbl.Visible = True

            productName_tag_lbl.Visible = False
            sellPrice_tag_lbl.Visible = False
            service_tag_lbl.Visible = False
            serCharge_tag_lbl.Visible = False
            Panel1.Visible = False
            packing_txt.Visible = False
            Label3.Visible = False
            list_products()
            stock_get_label.Text = 0
            bill_cal_admit_chk()
            stock_get_label.Visible = False
            packing_txt.Text = ""
            qty_txt.Text = 0
            single_pc_to.Text = 0


        ElseIf patient_Status_Txt.Text = "CheckUp" Then
            admit_tag_lbl.Visible = False
            cause_lbl.Visible = False
            Panel1.Visible = False
            productName_tag_lbl.Visible = False
            sellPrice_tag_lbl.Visible = False
            service_tag_lbl.Visible = True
            serCharge_tag_lbl.Visible = True
            packing_txt.Visible = False
            Label3.Visible = False
            list_products()
            stock_get_label.Text = 0
            stock_get_label.Visible = False
            bill_cal_admit_chk()
            qty_txt.Text = 0
            single_pc_to.Text = 0


        Else
            If patient_Status_Txt.Text = "Customer" Then
                admit_tag_lbl.Visible = False
                cause_lbl.Visible = False
                Panel1.Visible = True
                productName_tag_lbl.Visible = True
                sellPrice_tag_lbl.Visible = True
                service_tag_lbl.Visible = False
                serCharge_tag_lbl.Visible = False
                packing_txt.Visible = True
                stock_get_label.Visible = True
                Label3.Visible = True




                total_Inventory()

                If stock_get_label.Text > 0 Or qty_txt.Text < stock_get_label.Text Then
                    If qty_txt.Text = 0 Or qty_txt.Text = "" Then
                        MsgBox("Enter Quantity")
                    Else
                        original_price()
                        Grand_Sell_bill()
                        list_products()
                        update_stock_after_sell()
                    End If

                Else
                    MessageBox.Show("Out of Stock or less quantity")
                End If
            Else
                MsgBox("Error in Customer Checkup Admit")
            End If
        End If
        '' clear()
    End Sub
    Private Sub grand_Single_Pc_MouseClick(sender As Object, e As MouseEventArgs) Handles grand_Single_Pc.MouseClick
        admit_cust_checkup()
        clear()

    End Sub
    Public Sub get_Selling_Data()
        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select sell_Id as[ID],[sell_date] as [Date],[patient_Name] as [Patient Name],[product_list] as [Sell List],[patient_Status] as [Patient Status],[price] as [Sell Price],[profit_price] as [Profit Price],[sell_total_quantity] as [Total Products Sale],[sell_by] as [Sell By] from sell_tbl ORDER BY sell_Id DESC", con)
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
    Private Sub patient_Status_Txt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles patient_Status_Txt.SelectedIndexChanged
        If patient_Status_Txt.Text = "Admit" Then

            admit_tag_lbl.Visible = True
            cause_lbl.Visible = True

            productName_tag_lbl.Visible = False
            sellPrice_tag_lbl.Visible = False
            service_tag_lbl.Visible = False
            serCharge_tag_lbl.Visible = False
            Panel1.Visible = False
            packing_txt.Visible = False
            Label3.Visible = False
            product_Name_txt.DropDownStyle = ComboBoxStyle.Simple
            sell_Price_Txt.DropDownStyle = ComboBoxStyle.Simple
        ElseIf patient_Status_Txt.Text = "CheckUp" Then
            admit_tag_lbl.Visible = False
            cause_lbl.Visible = False

            productName_tag_lbl.Visible = False
            sellPrice_tag_lbl.Visible = False
            service_tag_lbl.Visible = True
            serCharge_tag_lbl.Visible = True
            packing_txt.Visible = False
            Label3.Visible = False
            Panel1.Visible = False
            product_Name_txt.DropDownStyle = ComboBoxStyle.Simple
            sell_Price_Txt.DropDownStyle = ComboBoxStyle.Simple
        ElseIf patient_Status_Txt.Text = "Customer" Then
            admit_tag_lbl.Visible = False
            cause_lbl.Visible = False

            productName_tag_lbl.Visible = True
            sellPrice_tag_lbl.Visible = True
            service_tag_lbl.Visible = False
            serCharge_tag_lbl.Visible = False
            packing_txt.Visible = True
            Label3.Visible = True
            Panel1.Visible = True
            product_Name_txt.DropDownStyle = ComboBoxStyle.DropDown
            sell_Price_Txt.DropDownStyle = ComboBoxStyle.DropDown
            FillCombo_product_name()
        End If

    End Sub
    Private Sub product_Name_txt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles product_Name_txt.SelectedIndexChanged



        FillCombo_product_packing()



    End Sub

    Private Sub packing_txt_SelectedIndexChanged(sender As Object, e As EventArgs)


        FillCombo_product_price()




    End Sub



    Private Sub BunifuButton3_Click_1(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        BunifuPages1.PageIndex = 3
        get_Selling_Data()
    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub dashboard_Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''FillCombo_product_name()
        get_Selling_Data()
        get_total_stock_Data()
        will_out_of_stock()


    End Sub



    Public Sub getData_Selling_Date()
        Using connection1 As New SqlConnection(cs)
            Try


                connection1.Open()
                Dim da2 As New SqlDataAdapter("Select sell_Id,sell_date,[patient_Name] as [Patient Name],[product_list] as [Sell List],[patient_Status] as [Patient_Status],[price] as [Price],[profit_price] as [Profit],[sell_total_quantity] as [Total Products Sale],[sell_by] as [Sell By] from [sell_tbl] where sell_date BETWEEN '" & Format(admin_Sell_Date_Picker.Value, "yyyy-MM-dd") & "' AND   '" & Format(sell_datePicker_to_txt.Value, "yyyy-MM-dd") & "' ORDER BY [sell_Id] DESC", connection1)
                Dim dt2 As New DataTable
                da2.Fill(dt2)
                source2.DataSource = dt2
                sell_grid.DataSource = dt2
                sell_grid.Refresh()
                connection1.Close()
            Catch ex As Exception
                MessageBox.Show("Failed:Retrieving Data" & ex.Message)
                Me.Dispose()
            End Try
        End Using


    End Sub
    Private Sub search_txt_selling_admin()

        Dim str As String
        Try
            Dim conn As New System.Data.SqlClient.SqlConnection(cs)
            conn.Open()
            str = "Select [sell_Id] as[ID],[sell_date],[patient_Name] as [Patient Name],[product_list] as [Sell List],[patient_Status] as [Patient_Status],[price] as [Price],[profit_price] as [Profit],[sell_total_quantity] as [Total Products Sale],[sell_by] as [Sell By] from sell_tbl where patient_Name like '" & admin_search_product.Text & "%' 
             OR product_list like '" & admin_search_product.Text & "%'  OR  patient_Status like '" & admin_search_product.Text & "%' ORDER BY sell_Id DESC"

            cmd = New SqlCommand(str, conn)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "sell_tbl")
            conn.Close()
            sell_grid.DataSource = ds
            sell_grid.DataMember = "sell_tbl"
            sell_grid.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:Product Name Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub
    Private Sub datePicker_to_txt_ValueChanged(sender As Object, e As EventArgs) Handles sell_datePicker_to_txt.ValueChanged
        getData_Selling_Date()
    End Sub

    Private Sub admin_search_product_TextChanged(sender As Object, e As EventArgs) Handles admin_search_product.TextChanged
        If admin_search_product.Text IsNot "" And admin_search_product.Text.Length > 0 Then
            search_txt_selling_admin()
        Else
            get_Selling_Data()
        End If
    End Sub

    Private Sub admin_search_product_Validating(sender As Object, e As CancelEventArgs) Handles admin_search_product.Validating

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub sell_grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles sell_grid.CellContentClick

    End Sub
    Private Sub send_data_to_update_del()
        Id_for_edit_lbl.Text = "edit"
        check_items_Frm.check_product_List_Txt.Text = sell_grid.CurrentRow.Cells(3).Value.ToString

        check_items_Frm.Id_for_edit_lbl.Text = sell_grid.CurrentRow.Cells(0).Value.ToString
        check_items_Frm.datePicker_Sell.Text = sell_grid.CurrentRow.Cells(1).Value.ToString
        check_items_Frm.patientName_txt.Text = sell_grid.CurrentRow.Cells(2).Value.ToString
        check_items_Frm.product_List_Txt.Text = sell_grid.CurrentRow.Cells(3).Value.ToString
        check_items_Frm.patient_Status_Txt.Text = sell_grid.CurrentRow.Cells(4).Value.ToString
        check_items_Frm.grand_Single_Pc.Text = sell_grid.CurrentRow.Cells(5).Value.ToString
        check_items_Frm.profit_Grand_Total.Text = sell_grid.CurrentRow.Cells(6).Value.ToString
        check_items_Frm.sell_Qty_Txt.Text = sell_grid.CurrentRow.Cells(7).Value.ToString
        check_items_Frm.billby_txt.Text = sell_grid.CurrentRow.Cells(8).Value.ToString
    End Sub



    Private Sub sell_grid_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles sell_grid.MouseDoubleClick
        If (String.IsNullOrEmpty(Id_for_edit_lbl.Text)) Then
            MsgBox("Select the row from grid")
        Else

            check_items_Frm.BunifuPages1.PageIndex = 1
            send_data_to_update_del()
            check_items_Frm.Show()
            ''inventory_edit()
            ''clear()

        End If
    End Sub

    Private Sub sell_grid_MouseClick(sender As Object, e As MouseEventArgs) Handles sell_grid.MouseClick

        send_data_to_update_del()

    End Sub

    Private Sub TabPage5_Click(sender As Object, e As EventArgs) Handles TabPage5.Click

    End Sub

    Private Sub Label33_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub get_getting_out_of_stock_Data()
        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select [stock_id] as [ID],[stock_name] as [Product Name],[stock_packing] as [Packing],[stock_quantity] as [Quantity],[threshold_value] as [Limit],sell_price as [Sell Price] from stock_tbl where stock_quantity <= threshold_value ORDER BY stock_id DESC ", con)
            Dim dt As New DataTable
            da.Fill(dt)
            source2.DataSource = dt
            check_Stock_Grid.DataSource = dt
            check_Stock_Grid.Refresh()

        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving Data" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Public Sub get_total_stock_Data()
        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select [stock_id] as [ID],[stock_name] as [Product Name],[stock_packing] as [Packing],[stock_quantity] as [Quantity],[threshold_value] as [Limit],sell_price as [Sell Price] from stock_tbl  ORDER BY stock_id DESC ", con)
            Dim dt As New DataTable
            da.Fill(dt)
            source2.DataSource = dt
            check_Stock_Grid.DataSource = dt
            check_Stock_Grid.Refresh()

        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving Data" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Public Sub will_out_of_stock()


        Using connection As New SqlConnection(cs)
            Try

                Dim command As New SqlCommand("Select count(*) as thres_value from stock_tbl where stock_quantity <= threshold_value", connection)
                connection.Open()
                cmd.Parameters.Clear()
                Dim read As SqlDataReader = command.ExecuteReader()

                Do While read.Read()
                    threshold_msg_lbl.Text = (read("thres_value").ToString())
                    ''profit_Price_Txt.Text = (read("original_Single_Price").ToString())
                Loop
                read.Close()
                If threshold_msg_lbl.Text > 0 Then
                    Label35.Visible = True
                    Label35.Text = "Medicine need to ReStock"

                    threshold_msg_lbl.Visible = True
                End If
            Catch ex As Exception

                MessageBox.Show("Will out of stock", ex.Message)
                Me.Dispose()
            End Try
        End Using
    End Sub
    Private Sub BunifuRadioButton2_CheckedChanged2(sender As Object, e As Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs)

    End Sub

    Private Sub BunifuButton4_Click_1(sender As Object, e As EventArgs) Handles BunifuButton4.Click

        BunifuPages1.PageIndex = 4
        get_total_stock_Data()
    End Sub



    Private Sub BunifuRadioButton1_CheckedChanged2(sender As Object, e As Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        get_getting_out_of_stock_Data()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        get_total_stock_Data()
    End Sub

    Private Sub check_Stock_Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles check_Stock_Grid.CellContentClick

    End Sub
    Public Sub stock_mange()
        Label33.Text = "edit"
        manage_Inventory_Frm.Stock_Id.Text = check_Stock_Grid.CurrentRow.Cells(0).Value.ToString
        manage_Inventory_Frm.product_Name_txt.Text = check_Stock_Grid.CurrentRow.Cells(1).Value.ToString
        manage_Inventory_Frm.packing_txt.Text = check_Stock_Grid.CurrentRow.Cells(2).Value.ToString
        manage_Inventory_Frm.stockqty_txt.Text = check_Stock_Grid.CurrentRow.Cells(3).Value.ToString
        manage_Inventory_Frm.stockthreshold_txt.Text = check_Stock_Grid.CurrentRow.Cells(4).Value.ToString
        manage_Inventory_Frm.stock_sell_price.Text = check_Stock_Grid.CurrentRow.Cells(5).Value.ToString
    End Sub

    Private Sub check_Stock_Grid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles check_Stock_Grid.CellMouseClick

        stock_mange()
    End Sub

    Private Sub check_Stock_Grid_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles check_Stock_Grid.CellMouseDoubleClick

    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click


        Dim con As New SqlConnection(cs)
        Dim com As New SqlCommand("Select sell_Id,sell_date,patient_Name,product_list,patient_Status,price,profit_price,sell_total_quantity,sell_by from sell_tbl where sell_date BETWEEN '" & Format(admin_Sell_Date_Picker.Value, "yyyy-MM-dd") & "' AND   '" & Format(sell_datePicker_to_txt.Value, "yyyy-MM-dd") & "'", con)
        Dim sd As New SqlDataAdapter(com)
        Dim dt As New DataTable
        sd.Fill(dt)

        With By_Date_Selling_ReportFrm.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "sellingReport.rdlc"
            .DataSources.Add(New ReportDataSource("sellrecorddataset", dt))
        End With
        By_Date_Selling_ReportFrm.ReportViewer1.RefreshReport()
        By_Date_Selling_ReportFrm.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

    End Sub

    Private Sub ManageListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageListToolStripMenuItem.Click
        If (String.IsNullOrEmpty(Label33.Text)) Then
            MsgBox("Select the row from grid")
        Else


            stock_mange()
            manage_Inventory_Frm.Show()
            ''inventory_edit()            ''clear()

        End If
    End Sub

    Private Sub qty_txt_TextChanged(sender As Object, e As EventArgs) Handles qty_txt.TextChanged


        total_Inventory()

    End Sub

    Private Sub patientName_txt_TextChanged(sender As Object, e As EventArgs) Handles patientName_txt.TextChanged

    End Sub

    Private Sub sell_Price_Txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles sell_Price_Txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub qty_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles qty_txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    'REPORT CODE BELOW'
    Private Sub textbox_report()

        sell_Report_Frm.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        textbox_report()
    End Sub


End Class