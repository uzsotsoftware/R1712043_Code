Public Class FrmRegistration

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLevel.SelectedIndexChanged

    End Sub

    Private Sub txtRegNo_TextChanged(sender As Object, e As EventArgs) Handles txtRegNo.TextChanged

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        FrmMenu.Show()
        Me.Hide()
    End Sub
End Class