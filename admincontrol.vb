Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports System.Data
Public Class admincontrol

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            conn.Open()
            sql = "SELECT employee.emp_id,att_id,employee.fname,employee.lname,employee.address,employee.contact,attendance.time_in, attendance.time_out FROM admin,employee,attendance WHERE    admin.admin_id = employee.admin_id AND employee.emp_id = attendance.emp_id"
            dbcomm = New MySqlCommand(sql, conn)
            databaseAdapter1 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            databaseAdapter1.Fill(ds, "employee")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "employee"
            DataGridView1.Update()
            DataGridView1.Refresh()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        End Try
        conn.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            conn.Open()
            sql = "SELECT * FROM item"
            dbcomm = New MySqlCommand(sql, conn)
            databaseAdapter1 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            databaseAdapter1.Fill(ds, "item")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "item"
            DataGridView1.Update()
            DataGridView1.Refresh()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            conn.Open()
            sql = "UPDATE item set quantity = " & Val(qty.Text) & " WHERE item_id = " & Val(itID.Text) & ""
            Label10.Text = sql
            dbcomm = New MySqlCommand(sql, conn)
            dbcomm.ExecuteNonQuery()
            conn.Close()
            conn.Open()
            sql = "SELECT * FROM item"
            dbcomm = New MySqlCommand(sql, conn)
            databaseAdapter1 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            databaseAdapter1.Fill(ds, "item")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "item"
            DataGridView1.Update()
            DataGridView1.Refresh()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            conn.Open()
            sql = "SELECT item.item_id,item.desc,item.price,item.size,purchase.quantity,purchase.purch_date FROM purchase,item WHERE item.item_id = purchase.item_id AND purch_date  BETWEEN  '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd") & "' AND  '" & Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd") & "'  "
            dbcomm = New MySqlCommand(sql, conn)
            databaseAdapter1 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()

            databaseAdapter1.Fill(ds, "item")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "item"
            DataGridView1.Update()
            DataGridView1.Refresh()
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try

        conn.Close()


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try

            conn.Open()
            sql = "SELECT * FROM reservation"
            dbcomm = New MySqlCommand(sql, conn)
            databaseAdapter1 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet
            databaseAdapter1.Fill(ds, "reservation")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "reservation"
            DataGridView1.Update()
            DataGridView1.Refresh()
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        'Dim sn As String = supN.Text
        'Dim sl As String = supLname.Text
        'Dim sa As String = supAddr.Text
        'Dim c As Integer = SupCon.Text

        'Dim supcp As Integer = SupCost.Text
        'Dim i As String = Item.Text
        'Dim s As String = ComboBox1.Text
        'Dim suggest As Integer = srp.Text
        'Dim totalexp As Integer
        Try
            conn.Open()
            sql = "INSERT INTO supplier (sup_name, sup_lname, sup_address, sup_contact, admin_id, sup_costprice) VALUES ('" & supN.Text & "', '" & supLname.Text & "', '" & supAddr.Text & "', '" & Val(SupCon.Text) & "', '1', '" & Val(SupCost.Text) & "')"
            dbcomm = New MySqlCommand(sql, conn)
            Dim test As Integer = dbcomm.ExecuteNonQuery()
            If (test > 0) Then
                MsgBox("record saved")
            Else
                MsgBox("record not saved")

            End If
            conn.Close()
           
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub

   

  
   
    
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            conn.Open()
            sql = "INSERT INTO item (item.desc, size, price, quantity, sup_id) VALUES ('" & desc.Text & "','" & ComboBox1.Text & "','" & Val(price.Text) & "','" & Val(quantity.Text) & "','" & Val(supp.Text) & "') "
            dbcomm = New MySqlCommand(sql, conn)
            Dim test As Integer = dbcomm.ExecuteNonQuery()
            If (test > 0) Then
                MsgBox("record saved")
            Else
                MsgBox("record not saved")

            End If



        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        End Try
        conn.Close()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Try
            conn.Open()
            sql = "SELECT supplier.sup_id, supplier.sup_name,supplier.sup_lname,supplier.sup_address,supplier.sup_contact,supplier.sup_costprice,item.item_id,item.desc,item.size,item.price,item.quantity FROM supplier,item WHERE supplier.sup_id = item.sup_id AND item.desc LIKE '" & SEO.Text & "'  OR supplier.sup_name LIKE '" & SEO.Text & "'"
            dbcomm = New MySqlCommand(sql, conn)
            databaseAdapter1 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            databaseAdapter1.Fill(ds, "supplier")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "supplier"
            DataGridView1.Update()
            DataGridView1.Refresh()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            conn.Open()
            sql = "Select * FROM supplier"
            dbcomm = New MySqlCommand(sql, conn)
            databaseAdapter1 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            databaseAdapter1.Fill(ds, "supplier")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "supplier"
            DataGridView1.Update()
            DataGridView1.Refresh()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

        Dim crpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument


        Try
            conn.Open()
            sql = " SELECT * FROM item "
            dbcomm = New MySqlCommand(sql, conn)
            databaseAdapter1 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()

            databaseAdapter1.Fill(ds, "supplier")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "supplier"
            DataGridView1.Update()
            DataGridView1.Refresh()
            'Dim dt As New DataTable
            'With dt
            '    .Columns.Add("item_id")
            '    .Columns.Add("desc")
            '    .Columns.Add("size")
            '    .Columns.Add("price")
            '    .Columns.Add("quantity")
            '    .Columns.Add("sup_id")
            'End With
            'For Each dr As DataGridViewRow In Me.DataGridView1.Rows
            '    dt.Rows.Add(dr.Cells("item_id").Value, dr.Cells("desc").Value, dr.Cells("size").Value, dr.Cells("price").Value, dr.Cells("quantity").Value, dr.Cells("sup_id").Value)
            'Next
            'Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            'rptDoc = New CrystalReport2
            'rptDoc.SetDataSource(dt)
            'Form2.CrystalReportViewer1.ReportSource = rptDoc

            crpt.Load("C:\Users\Ivy Diane\Desktop\CSA project - Copy - Copy\rundownsys\rundownsys\CrystalReport2.rpt")

            crpt.SetDataSource(ds.Tables(0))


            Form2.CrystalReportViewer1.ReportSource = crpt
            Form2.CrystalReportViewer1.Update()
            Form2.CrystalReportViewer1.Refresh()

            Form2.Show()
            'Me.Close()

            conn.Close()



        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub admincontrol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rptDoc As New ReportDocument
        rptDoc = New CrystalReport2

    End Sub
End Class