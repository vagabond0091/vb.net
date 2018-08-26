Imports MySql.Data.MySqlClient
Public Class employee

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            conn.Open()
            sql = "SELECT * FROM employee WHERE employee.username = '" & tb1.Text & "' AND employee.password = '" & tb2.Text & "'"
            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader
            Dim count As Integer
            count = 0
            While dbread.Read
                attendace.tb3.Text = dbread("emp_id")
                saless.TextBox6.Text = dbread("emp_id")
                saless.emp.Text = dbread("emp_id")
                count = count + 1

            End While
            If count = 1 Then
                MsgBox("Login Successfully")
                Me.Hide()
                attendace.Show()

            Else
                MsgBox("Wrong username or passord")
            End If
            dbread.Close()
            conn.Close()
           

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        End Try
        
        conn.Close()

    End Sub

    Private Sub employee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class