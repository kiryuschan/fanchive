Public Class menu_adm
    Private Sub btn_contas_Click(sender As Object, e As EventArgs) Handles btn_contas.Click
        Dim gerenciarContas As New gerenciar_contas()
        gerenciarContas.ShowDialog()
    End Sub

    Private Sub menu_adm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'sair
    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Dim login As New login()
        login.Show()
        Me.Close()
    End Sub

    Private Sub btn_sair_Click_1(sender As Object, e As EventArgs) Handles btn_sair.Click

    End Sub
    'tela de cadastro
    Private Sub btn_cad_Click(sender As Object, e As EventArgs) Handles btn_cad.Click

        Dim telaCadastro As New frm_cadastro()
        telaCadastro.ShowDialog()
    End Sub
End Class