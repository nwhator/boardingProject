Public Class Form1
    Private Sub RegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem.Click

    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click

    End Sub

    Private Sub SignInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignInToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub LoginToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem1.Click
        Form2.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub

    Private Sub EnterToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles EnterToolStripMenuItem3.Click
        Dim cancel As Integer
        cancel = MsgBox("Are you sure you want to exit the application", 1, "Exit Message")

        If cancel = 1 Then
            Me.Close()
        Else
            MessageBox.Show("OK", "Confirmination")
        End If

    End Sub

    Private Sub RegisterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem1.Click
        Form3.Show()
    End Sub

    Private Sub EnterToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EnterToolStripMenuItem2.Click
        Form6.Show()
    End Sub

    Private Sub EnterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EnterToolStripMenuItem1.Click
        Form5.Show()
    End Sub

    Private Sub PersonalDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonalDetailsToolStripMenuItem.Click

    End Sub

    Private Sub EnterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterToolStripMenuItem.Click
        Form4.show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub
End Class
