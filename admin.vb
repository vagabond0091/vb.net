Imports MySql.Data.MySqlClient
Public Class admin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            conn.Open()
            sql = "SELECT * FROM admin WHERE username = '" & tb1.Text & "' AND password = '" & tb2.Text & "' "
            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader()
            Dim count As Integer
            count = 0
            While dbread.Read
                count = count + 1
            End While
            If count = 1 Then
                MsgBox("Login Successfully")
                Me.Hide()
                admincontrol.Show()
            Else
                MsgBox("Wrong username or password")
            End If
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class