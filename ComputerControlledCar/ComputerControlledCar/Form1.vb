Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)Handles Button2.Click
        Dim result1 As DialogResult = MessageBox.Show("Do You wish To end The Game?", _
            "Close Program", _
        MessageBoxButtons.YesNo, _
        MessageBoxIcon.Question)

        If result1 = Windows.Forms.DialogResult.No Then Me.Show()
        If result1 = Windows.Forms.DialogResult.Yes Then End
    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

End Class
