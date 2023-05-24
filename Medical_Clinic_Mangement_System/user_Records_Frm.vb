Imports System.Data.SqlClient
Imports System.Reflection.Emit

Public Class user_Records_Frm

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
    Dim cs As String = "Data Source=DESKTOP-52B846I;Initial Catalog=mainClinicDb;Integrated Security=True"
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub user_Records_Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_usersData()
        BunifuPages1.PageIndex = 1
    End Sub
    Private Sub get_usersData()
        Using con As SqlConnection = New SqlConnection(cs) 'You have to set the CONNECTION STRING
            con.Open()
            'for two tables
            '' Using adapter As SqlDataAdapter = New SqlDataAdapter("select d.Username,d.UserRole,d.Password,d.phoneNumber,d.Email,d.Address,d.accunt_create  from Users c join  admin_tb d on c.Cid=d.cId", con)
            Using adapter As SqlDataAdapter = New SqlDataAdapter("select * from Users", con)
                Dim dt As DataTable = New DataTable()
                adapter.Fill(dt) 'Filling dt with the information from the DB
                user_grid.DataSource = dt 'Populating gv with the values in dt

                ''edit button
                ''Dim editbutton As DataGridViewButtonColumn = New DataGridViewButtonColumn()
                '' editbutton.FlatStyle = FlatStyle.Popup
                ''editbutton.HeaderText = "Edit"
                ''editbutton.Name = "Edit"
                '' editbutton.UseColumnTextForButtonValue = True
                '' editbutton.Text = "Edit"
                '' editbutton.Width = 60
                '' If (user_grid.Columns.Contains(editbutton.Name = "Edit")) Then
                '' Else
                '' user_grid.Columns.Add(editbutton)
                '' End If

                ''delete button
                '' Dim deletebutton As DataGridViewButtonColumn = New DataGridViewButtonColumn()
                '' deletebutton.FlatStyle = FlatStyle.Popup
                '' deletebutton.HeaderText = "Delete"
                '' deletebutton.Name = "Delete"
                '' deletebutton.UseColumnTextForButtonValue = True
                '' deletebutton.Text = "Delete"
                '' deletebutton.Width = 60
                '' If (user_grid.Columns.Contains(deletebutton.Name = "Delete")) Then
                '' Else
                ''user_grid.Columns.Add(deletebutton)
                ''End If

            End Using
        End Using
    End Sub


    Private Sub send_user_data_to_grid()
        Try
            Me.id_lbl.Text = user_grid.CurrentRow.Cells(0).Value.ToString
            Me.user_btxt.Text = user_grid.CurrentRow.Cells(1).Value.ToString

            Me.pwd_btxt.Text = user_grid.CurrentRow.Cells(3).Value.ToString
            Me.phoneNumber_btxt.Text = user_grid.CurrentRow.Cells(4).Value.ToString
            Me.email_btxt.Text = user_grid.CurrentRow.Cells(5).Value.ToString

            Me.address_btxt.Text = user_grid.CurrentRow.Cells(6).Value.ToString
            Me.txtDate.Text = user_grid.CurrentRow.Cells(7).Value.ToString
            BunifuPages1.PageIndex = 0

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:TextBox not found ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub
    Private Sub user_grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles user_grid.CellContentClick
        ''  If (e.ColumnIndex = 7) Then

        ''ElseIf (e.ColumnIndex = 8) Then


        '' End If

    End Sub

    Private Sub user_grid_MouseClick(sender As Object, e As MouseEventArgs) Handles user_grid.MouseClick
        send_user_data_to_grid()
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        BunifuPages1.PageIndex = 1
    End Sub
    Public Sub getData_users_Date()
        Using connection1 As New SqlConnection(cs)
            Try


                connection1.Open()
                Dim da2 As New SqlDataAdapter("Select * from Users where accunt_create BETWEEN '" & Format(BunifuDatePicker1.Value, "yyyy-MM-dd") & "' AND   '" & Format(BunifuDatePicker2.Value, "yyyy-MM-dd") & "'", connection1)
                Dim dt2 As New DataTable
                da2.Fill(dt2)
                source2.DataSource = dt2
                user_grid.DataSource = dt2
                user_grid.Refresh()
                connection1.Close()
            Catch ex As Exception
                MessageBox.Show("Failed:Retrieving Data" & ex.Message)
                Me.Dispose()
            End Try
        End Using
    End Sub
    Private Sub search_txt_users()
        If txtUsername.Text IsNot String.Empty Then
            Dim str As String
            Try
                Dim conn As New System.Data.SqlClient.SqlConnection(cs)
                conn.Open()
                str = "Select *  from Users where Username like '" & txtUsername.Text & "%' ORDER BY U_ID DESC"
                cmd = New SqlCommand(str, conn)
                da = New SqlDataAdapter(cmd)
                ds = New DataSet
                da.Fill(ds, "Users")
                conn.Close()
                user_grid.DataSource = ds
                user_grid.DataMember = "Users"
                user_grid.Visible = True

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Failed: Name Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Dispose()
            End Try
        End If

    End Sub
    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        search_txt_users()
    End Sub

    Private Sub BunifuDatePicker2_ValueChanged(sender As Object, e As EventArgs) Handles BunifuDatePicker2.ValueChanged
        getData_users_Date()
    End Sub
    Private Sub DeleteSelecedRows()

        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "delete  from Users where U_ID='" & id_lbl.Text & "'"
            cmd.ExecuteNonQuery()

            welcomemsg.ForeColor = System.Drawing.Color.Green
            welcomemsg.Text = " '" & user_btxt.Text & "' with '" & id_lbl.Text & "'  ID delete successfully!"
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
            welcomemsg.ForeColor = System.Drawing.Color.Red
            Me.Dispose()
        End Try

    End Sub
    Private Sub update_Records()
        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "UPDATE  Users  SET  Username= '" & user_btxt.Text & "', Password= '" & pwd_btxt.Text & "', phoneNumber= '" & phoneNumber_btxt.Text & "', Email = '" & email_btxt.Text & "' , Address = '" & address_btxt.Text & "'  where U_ID = '" & id_lbl.Text & "'"

            cmd.ExecuteNonQuery()
            welcomemsg.ForeColor = System.Drawing.Color.DarkGreen
            welcomemsg.Text = "  '" & user_btxt.Text & "'  Update successfully!"
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
            welcomemsg.ForeColor = System.Drawing.Color.Red
            Me.Dispose()
        End Try
    End Sub
    Private Sub delete_Btn_Click(sender As Object, e As EventArgs) Handles delete_Btn.Click


        If id_lbl.Text = String.Empty Then
            MsgBox("Select Values from Gridview")
        Else
            DeleteSelecedRows()
            update_Records()
            get_usersData()
            clear_previous_entity()
            welcomemsg.Text = " "
            BunifuPages1.PageIndex = 1
        End If
    End Sub
    Private Sub clear_previous_entity()
        For Each txt In Panel1.Controls.OfType(Of TextBox)()
            txt.Text = ""
        Next

    End Sub

    Private Sub update_Btn_Click(sender As Object, e As EventArgs) Handles update_Btn.Click
        If id_lbl.Text = String.Empty Then
            MsgBox("Select Values from Gridview")
        Else
            update_Records()
            get_usersData()
            clear_previous_entity()
            welcomemsg.Text = " "
            BunifuPages1.PageIndex = 1
        End If
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
    End Sub
End Class