Public Class Form3


    Private Sub Form3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.W Then
            out(Val(888), 1)
        End If
        If e.KeyCode = Keys.A Then
            out(Val(888), 4)
        End If
        If e.KeyCode = Keys.S Then
            out(Val(888), 2)
        End If
        If e.KeyCode = Keys.D Then
            out(Val(888), 8)
        End If
        If e.KeyCode = Keys.F Then
            out(Val(888), 0)
        End If
    End Sub
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)Handles MyBase.Load
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class