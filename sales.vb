Imports MySql.Data.MySqlClient
Public Class saless

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    


            Dim totals As Integer
        DataGridView3.Rows.Add(n.Text, s.Text, a.Text, c.Text, q.Text, Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd,HH-mm-ss"), Convert.ToDateTime(DateTimePicker3.Value).ToString("yyyy-MM-dd,HH-mm-ss"), ComboBox3.Text, ComboBox4.Text, price1 * Val(q.Text))
        For Each row As DataGridViewRow In DataGridView3.Rows
            totals = totals + CDec(row.Cells("ttl").Value)
            totalsss.Text = totals

        Next
      
        DataGridView3.Visible = True
        DataGridView1.Visible = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As String
        Dim s As String
        Dim a As String
        Dim c As Integer
        Dim em As Integer
        n = nm.Text
        s = surname.Text
        a = addr.Text
        c = con.Text
        em = emp.Text
        Dim totalexp As Integer
        Try
            conn.Open()
            sql = "Select  * FROM item  WHERE  item.size = '" & ComboBox2.SelectedItem & "' AND  item.desc = '" & ComboBox1.SelectedItem & "'  "
            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader
            dbread.Read()
            it = dbread("item_id")
            price = dbread("price")
            dbread.Close()
            conn.Close()
            conn.Open()
            sql = "INSERT INTO customer (fname, lname, addres, contact, emp_id) VALUES ('" & n & "', '" & s & "', '" & a & "', '" & Val(c) & "', '" & Val(em) & "')"
            dbcomm = New MySqlCommand(sql, conn)
            Dim test As Integer = dbcomm.ExecuteNonQuery
            DataGridView1.Rows.Add(n, s, a, Val(c), ComboBox1.Text, Val(quant.Text), Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd,HH-mm-ss"), price * Val(quant.Text))
            For Each row As DataGridViewRow In DataGridView1.Rows
                totalexp = totalexp + CDec(row.Cells("Total").Value)
                txttotal.Text = totalexp
            Next

            If (test > 0) Then
                MsgBox("record saved")
            Else
                MsgBox("record not saved")

            End If
            conn.Close()
            conn.Open()
            sql = "INSERT INTO purchase (purch_date, quantity, item_id) VALUES ('" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd,HH-mm-ss") & "', '" & quant.Text & "', '" & Val(it) & "')"
            dbcomm = New MySqlCommand(sql, conn)
            Dim cout As Integer = dbcomm.ExecuteNonQuery
            If cout > 0 Then

            Else
                MsgBox("purchase invalid")
            End If
            If quant.Text > count Then
                MsgBox("invalid input")
            End If
            conn.Close()


            conn.Open()
            sql = "UPDATE item set quantity = (quantity - '" & Val(quant.Text) & "') WHERE item.item_id = '" & Val(it) & "'"
            dbcomm = New MySqlCommand(sql, conn)
            dbcomm.ExecuteNonQuery()
            ds = New DataSet()
            databaseAdapter1.Fill(ds, "item")
            DataGridView2.DataSource = ds
            DataGridView2.DataMember = "item"
            DataGridView2.Update()
            DataGridView2.Refresh()
            DataGridView1.Visible = True
            DataGridView3.Visible = False
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        End Try

        nm.Clear()
        surname.Clear()
        addr.Clear()
        emp.Clear()
        quant.Clear()
        con.Clear()
        ComboBox1.ResetText()
        ComboBox2.ResetText()
        conn.Close()



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Try
        '    conn.Open()
        '    sql = "Select  * FROM item  WHERE  item.size = '" & ComboBox2.SelectedItem & "' AND  item.desc = '" & ComboBox1.SelectedItem & "'  "
        '    dbcomm = New MySqlCommand(sql, conn)
        '    dbread = dbcomm.ExecuteReader
        '    dbread.Read()
        '    it = dbread("item_id")
        '    price = dbread("price")
        'Catch ex As MySqlException
        '    MessageBox.Show(ex.Message)
        'End Try
        'dbread.Close()
        'conn.Close()

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click


    End Sub

    Private Sub sales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            sql = "SELECT DISTINCT item.desc FROM item "
            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader
            While dbread.Read
                ComboBox1.Items.Add(dbread("desc"))
                ComboBox3.Items.Add(dbread("desc"))

            End While
            conn.Close()
            conn.Open()
            sql = "SELECT *  FROM item "
            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader
            While dbread.Read
                count = dbread("quantity")
                price1 = dbread("price")
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        dbread.Close()
        conn.Close()
        Try
            conn.Open()
            sql = "SELECT * FROM item"
            dbcomm = New MySqlCommand(sql, conn)
            databaseAdapter1 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            databaseAdapter1.Fill(ds, "item")
            DataGridView2.DataSource = ds
            DataGridView2.DataMember = "item"
            DataGridView2.Update()
            DataGridView2.Refresh()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
        DataGridView1.Visible = False
        DataGridView3.Visible = False
        conn.Close()
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            conn.Open()
            sql = "SELECT * FROM item WHERE item.quantity > 0"
            dbcomm = New MySqlCommand(sql, conn)
            databaseAdapter1 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            databaseAdapter1.Fill(ds, "item")
            DataGridView2.DataSource = ds
            DataGridView2.DataMember = "item"
            DataGridView2.Update()
            DataGridView2.Refresh()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If DataGridView3.SelectedRows.Count > 0 Then
            DataGridView3.Rows.Remove(DataGridView3.SelectedRows(0))
        Else
            MessageBox.Show("Select Rows first before you hit delete")
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Try
            conn.Open()
            sql = "Select  * FROM item  WHERE  item.desc = '" & ComboBox3.Text & "'  "
            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader
            dbread.Read()
            it = dbread("item_id")
            price = dbread("price")
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
        dbread.Close()
        conn.Close()
    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click
        'Try
        '    conn.Open()
        '    sql = "SELECT DISTINCT item.desc FROM item "
        '    dbcomm = New MySqlCommand(sql, conn)
        '    dbread = dbcomm.ExecuteReader
        '    While dbread.Read
        '        ComboBox1.Items.Add(dbread("desc"))
        '    End While
        '    conn.Close()
        '    conn.Open()
        '    sql = "SELECT *  FROM item "
        '    dbcomm = New MySqlCommand(sql, conn)
        '    dbread = dbcomm.ExecuteReader
        '    While dbread.Read
        '        count = dbread("quantity")
        '    End While
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        'dbread.Close()
        'conn.Close()
        'Try
        '    conn.Open()
        '    sql = "SELECT * FROM item WHERE item.quantity > 0"
        '    dbcomm = New MySqlCommand(sql, conn)
        '    databaseAdapter1 = New MySqlDataAdapter(sql, conn)
        '    ds = New DataSet()
        '    databaseAdapter1.Fill(ds, "item")
        '    DataGridView2.DataSource = ds
        '    DataGridView2.DataMember = "item"
        '    DataGridView2.Update()
        '    DataGridView2.Refresh()

        'Catch ex As MySqlException
        '    MessageBox.Show(ex.Message)
        'End Try
        'conn.Close()
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        attendace.Button2.Visible = True
        attendace.Button1.Visible = False
        attendace.Show()
        Me.Hide()

    End Sub

    Private Sub DataGridView3_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try

            conn.Open()
            sql = "INSERT INTO customer (fname, lname, addres, contact, emp_id) VALUES ('" & n.Text & "', '" & s.Text & "', '" & a.Text & "', '" & Val(c.Text) & "', '" & Val(TextBox6.Text) & "')"
            dbcomm = New MySqlCommand(sql, conn)
            Dim test As Integer = dbcomm.ExecuteNonQuery

            If (test > 0) Then
                MsgBox("record saved")

            Else
                MsgBox("record not saved")

            End If
            sql = "SELECT max(cust_id) from customer"
            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader()
            dbread.Read()
            Dim att As Integer
            att = dbread(0)
            dbread.Close()
            conn.Close()

            conn.Open()
            sql = "insert into reservation (res_date,res_p_u_date,cust_id) values ('" & Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd,,HH-mm-ss") & "','" & Convert.ToDateTime(DateTimePicker3.Value).ToString("yyyy-MM-dd,,HH-mm-ss") & "'," & att & ")"
            dbcomm = New MySqlCommand(sql, conn)
            Dim g As Integer = dbcomm.ExecuteNonQuery

            If g > 0 Then
                MsgBox("Saved")

            ElseIf g = 0 Then
                MsgBox("Error")

            End If
            conn.Close()
            conn.Open()
            sql = "SELECT max(reservation.res_id) from reservation"
            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader()
            dbread.Read()
            Dim rs As Integer
            rs = dbread(0)
            dbread.Close()
            conn.Close()
            conn.Open()
            sql = "INSERT INTO resline (resline.item_id, resline.res_id, quantity) VALUES ('" & Val(it) & "', '" & Val(rs) & "', '" & Val(q.Text) & "')"
            dbcomm = New MySqlCommand(sql, conn)
            dbcomm.ExecuteNonQuery()
            conn.Close()
            conn.Open()
            sql = "UPDATE item set quantity = (quantity - '" & Val(q.Text) & "') WHERE item.item_id = '" & Val(it) & "'"
            dbcomm = New MySqlCommand(sql, conn)
            dbcomm.ExecuteNonQuery()
            ds = New DataSet()
            databaseAdapter1.Fill(ds, "item")
            DataGridView2.DataSource = ds
            DataGridView2.DataMember = "item"
            DataGridView2.Update()
            DataGridView2.Refresh()
           
            DataGridView3.Visible = True
            DataGridView1.Visible = False
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()

    End Sub


End Class