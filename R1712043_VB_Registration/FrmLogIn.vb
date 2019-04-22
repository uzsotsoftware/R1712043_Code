Public Class lblLogin

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

    End Sub

    Private Sub lblLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "josphat" And txtPassword.Text = "jos123" Then
            MsgBox("Success")
            FrmMenu.Show()
            Me.Hide()

        Else
            MsgBox("login failure")
            Close()
            Me.Hide()

        End If
    End Sub

    Private Sub lblCancel_Click(sender As Object, e As EventArgs) Handles lblCancel.Click
        Close()
    End Sub
End Class
