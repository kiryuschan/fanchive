Public Class menu_usuario
    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Dim login As New login()
        login.Show()
        Me.Close()
    End Sub
End Class