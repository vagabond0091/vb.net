Imports MySql.Data.MySqlClient
Public Class attendace

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try


            conn.Open()
            sql = "INSERT INTO attendance (att_id,time_in,time_out,emp_id) VALUES (NULL,'" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd,HH-mm-ss") & "',NULL,'" & tb3.Text & "')"
            dbcomm = New MySqlCommand(sql, conn)
            dbcomm.ExecuteNonQuery()
            MsgBox("Time in Successfully")
            conn.Close()
            Me.Hide()
            saless.Show()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            conn.Close()
            conn.Open()
            sql = "SELECT max(att_id) from attendance,employee WHERE employee.emp_id = attendance.emp_id AND employee.username = '" & employee.tb1.Text & "'"
            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader()
            dbread.Read()
            Dim att As Integer
            att = dbread(0)
            dbread.Close()
            conn.Close()
            conn.Open()
            sql = "Update attendance set time_out = '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd,HH-mm-ss") & "' WHERE ATT_ID = " & att & ""

            dbcomm = New MySqlCommand(sql, conn)
            dbcomm.ExecuteNonQuery()
            MsgBox("Time out Successfully")
            Dim confirmation = MessageBox.Show("Do you want to exit?", "confirmation", MessageBoxButtons.YesNo)
            If confirmation = DialogResult.Yes Then
                Me.Close()
            End If


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()

    End Sub

    Private Sub attendace_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button2.Visible = False
    End Sub
End Class