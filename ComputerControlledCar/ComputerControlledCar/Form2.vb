
Public Class Form2
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        out(Val(888), 1)
        TextBox1.Text = "Forward:"
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        out(Val(888), 4)
        TextBox1.Text = "Left"
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        out(Val(888), 2)
        TextBox1.Text = "Reverse"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        out(Val(888), 8)
        TextBox1.Text = "Right"

    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        out(Val(888), 0)
        TextBox1.Text = "End"
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        End
    End Sub
    Private Sub Form2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        out(Val(888), 0)
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Button10.Visible = True
        Button8.Visible = True
        Button9.Visible = True
        Label1.Visible = True
        ListView1.Visible = True
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        out(Val(888), 1)
        delay(1)
        out(Val(888), 4)
        delay(1)
        out(Val(888), 2)
        delay(1)
        out(Val(888), 8)
        delay(1)
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Button10.Visible = False
        Button8.Visible = False
        Button9.Visible = False
        Label1.Visible = False
        ListView1.Visible = False
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
