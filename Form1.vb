Imports MySql.Data.MySqlClient



Public Class Form1
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=crud_vb_dotnet")
    Dim i As Integer
    Dim dr As MySqlDataReader

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DVG_load()

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        clear()
    End Sub

    Public Sub DVG_load()
        grid_data.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `products`", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                grid_data.Rows.Add(dr.Item("product_number"), dr.Item("product_name"), dr.Item("price"), dr.Item("product_group"), dr.Item("date"), Format(CBool(dr.Item("status"))))
            End While
            dr.Dispose()



        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        save()
        DVG_load()
    End Sub



    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        update()
    End Sub



    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        delete()
    End Sub

    Public Sub clear()
        txt_no.Clear()
        txt_name.Clear()
        txt_price.Clear()
        combo_group.Text = ""
        date_expired.Value = Now
        status_checkbox.CheckState = False
        txt_no.ReadOnly = False
        btn_save.Enabled = True

    End Sub

    Public Sub save()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("INSERT INTO `products`(`product_number`, `product_name`, `price`, `product_group`, `date`, `status`) VALUES (@product_number, @product_name, @price, @product_group, @date, @status);", conn)

            cmd.Parameters.Clear()

            ' Add parameters and ensure they are not empty or null before running the insert query
            If String.IsNullOrWhiteSpace(txt_no.Text) Or String.IsNullOrWhiteSpace(txt_name.Text) Or String.IsNullOrWhiteSpace(combo_group.Text) Then
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            cmd.Parameters.AddWithValue("@product_number", txt_no.Text)
            cmd.Parameters.AddWithValue("@product_name", txt_name.Text)
            cmd.Parameters.AddWithValue("@price", CDec(txt_price.Text))
            cmd.Parameters.AddWithValue("@product_group", combo_group.Text)
            cmd.Parameters.AddWithValue("@date", CDate(date_expired.Value))
            cmd.Parameters.AddWithValue("@status", status_checkbox.Checked.ToString())

            Dim i As Integer = cmd.ExecuteNonQuery()

            If i > 0 Then
                MessageBox.Show("Record Saved Successfully", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record Save Failed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        clear()
    End Sub


    Public Sub update()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("UPDATE `products` SET `product_name`=@product_name, `price`=@price, `product_group`=@product_group, `date`=@date, `status`=@status WHERE `product_number`=@product_number;", conn)

            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@product_number", txt_no.Text)
            cmd.Parameters.AddWithValue("@product_name", txt_name.Text)
            cmd.Parameters.AddWithValue("@price", CDec(txt_price.Text))
            cmd.Parameters.AddWithValue("@product_group", combo_group.Text)
            cmd.Parameters.AddWithValue("@date", CDate(date_expired.Value))
            cmd.Parameters.AddWithValue("@status", status_checkbox.Checked.ToString())

            Dim i As Integer = cmd.ExecuteNonQuery()

            If i > 0 Then
                MessageBox.Show("Record Updated Successfully", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record Update Failed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        clear()
        DVG_load()
    End Sub


    Public Sub delete()
        ' Ask for confirmation before deleting
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' If the user clicks 'Yes', proceed with deletion
        If result = DialogResult.Yes Then
            Try
                conn.Open()

                Dim cmd As New MySqlCommand("DELETE FROM `products` WHERE `product_number`=@product_number;", conn)

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@product_number", txt_no.Text)

                Dim i As Integer = cmd.ExecuteNonQuery()

                If i > 0 Then
                    MessageBox.Show("Record Deleted Successfully", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Record Delete Failed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try

            ' Clear fields and reload data
            clear()
            DVG_load()
        Else
            ' If the user clicks 'No', do nothing
            MessageBox.Show("Deletion canceled.", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    Private Sub grid_data_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_data.CellClick
        txt_no.Text = grid_data.CurrentRow.Cells(0).Value
        txt_name.Text = grid_data.CurrentRow.Cells(1).Value
        txt_price.Text = grid_data.CurrentRow.Cells(2).Value
        combo_group.Text = grid_data.CurrentRow.Cells(3).Value
        date_expired.Text = grid_data.CurrentRow.Cells(4).Value

        txt_no.ReadOnly = True
        btn_save.Enabled = False

        ' Safely parse the value to Boolean and assign to the Checked property
        Dim statusValue As String = If(grid_data.CurrentRow.Cells(5).Value IsNot Nothing, grid_data.CurrentRow.Cells(5).Value.ToString().Trim().ToLower(), String.Empty)
        If statusValue = "true" Or statusValue = "1" Then
            status_checkbox.Checked = True
        ElseIf statusValue = "false" Or statusValue = "0" Then
            status_checkbox.Checked = False
        Else
            ' Handle unexpected values or set a default
            status_checkbox.Checked = False
        End If
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        grid_data.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `products` WHERE product_number LIKE '%" & txt_search.Text & "%' OR product_name LIKE '%" & txt_search.Text & "%' OR price LIKE '%" & txt_search.Text & "%' OR status LIKE '%" & txt_search.Text & "%'", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                grid_data.Rows.Add(dr.Item("product_number"), dr.Item("product_name"), dr.Item("price"), dr.Item("product_group"), dr.Item("date"), Format(CBool(dr.Item("status"))))
            End While
            dr.Dispose()



        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
