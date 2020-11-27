Imports System.Data.SqlClient
Public Class Form2

    Dim connection As New SqlConnection("Data Source=DESKTOP-TBJF9FD;Initial Catalog=Administrator;Integrated Security=True")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As New SqlCommand("select * from Admein where username = @username and Parseword = @Parseword", connection)
        command.Parameters.Add("@username", SqlDbType.VarChar).Value = TextBox1.Text
        command.Parameters.Add("@username", SqlDbType.VarChar).Value = TextBox1.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)

        If (TextBox1.Text = "" And TextBox2.Text = Nothing) Then
            MessageBox.Show("you ave not typed anything!")

        Else
            If table.Rows.Count() <= 0 Then
                MessageBox.Show("UserName and password invalid")
            Else
                MessageBox.Show("Login successful!")
                For Each control As Control In Me.Controls
                    If TypeOf control Is TextBox Then
                        control.Text = String.Empty
                    End If
                Next
                Form1.Show()
            End If
        End If
    End Sub

End Class