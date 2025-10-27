Imports System.Data
Imports MySqlConnector

Public Class gerenciar_contas
    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick

    End Sub

    Private Sub gerenciar_contas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregarDados()
    End Sub

    'colocar os dados no data grid view
    Private Sub carregarDados()
        Try
            'os nomes bonitinho nos campos
            Dim sql As String =
                "SELECT id      AS 'Nº'," &
                "       username AS 'USERNAME'," &
                "       email    AS 'EMAIL'," &
                "       senha    AS 'SENHA'," &
                "       foto_url AS 'FOTO'," &
                "       status   AS 'STATUS'" &
                "  FROM usuarios ORDER BY id;"

            'conectar
            Using conexao = Db.conexao()
                Dim da As New MySqlDataAdapter(sql, conexao)
                Dim dt As New DataTable()
                da.Fill(dt)

                'gerar
                dgv_dados.Columns.Clear()
                dgv_dados.AutoGenerateColumns = True
                dgv_dados.DataSource = dt

                'adicionar botão de editar
                If dgv_dados.Columns.Cast(Of DataGridViewColumn)().All(Function(c) c.HeaderText <> "EDITAR") Then
                    Dim colEditar As New DataGridViewButtonColumn()
                    colEditar.Name = "colEditar"
                    colEditar.HeaderText = "EDITAR"
                    colEditar.Text = "Editar"
                    colEditar.UseColumnTextForButtonValue = True   ' << simples
                    dgv_dados.Columns.Add(colEditar)
                End If


                'adicionar botão de apagar
                If dgv_dados.Columns.Cast(Of DataGridViewColumn)().All(Function(c) c.HeaderText <> "APAGAR") Then
                    Dim colExcluir As New DataGridViewButtonColumn()
                    colExcluir.HeaderText = "APAGAR"
                    colExcluir.Text = "Apagar"
                    colExcluir.Name = "colApagar"
                    colExcluir.UseColumnTextForButtonValue = True
                    dgv_dados.Columns.Add(colExcluir)
                End If

                'deixar responsivo
                dgv_dados.ReadOnly = True
                dgv_dados.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                dgv_dados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                dgv_dados.RowHeadersVisible = False
            End Using

        Catch ex As Exception
            MsgBox("Erro ao carregar: " & ex.Message, vbOKOnly + vbCritical, "Erro")
        End Try
    End Sub

    'DOUBLE CLICK = DESATIVAR
    Private Sub dgv_dados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellDoubleClick
        'pegar da linha dos status valores e etc
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub

        Dim ehStatus As Boolean = dgv_dados.Columns(e.ColumnIndex).HeaderText.ToUpper() = "STATUS"
        If Not ehStatus Then Exit Sub

        ' pega valores da linha
        Dim linha = dgv_dados.Rows(e.RowIndex)
        Dim username As String = linha.Cells("USERNAME").Value.ToString()  'pegar do usuario
        Dim statusAtual As String = linha.Cells(e.ColumnIndex).Value.ToString().ToUpper()

        'var pra definir os status 
        Dim novoStatus As String = If(statusAtual = "ATIVA", "BLOQUEADA", "ATIVA")

        Try
            Using con = Db.conexao()
                con.Open()
                Dim sql As String = "UPDATE usuarios SET status='" & novoStatus & "' WHERE username='" & username & "'"
                Using cmd As New MySqlCommand(sql, con)
                    Dim linhas = cmd.ExecuteNonQuery()
                    If linhas > 0 Then
                        'alterar no datagridview
                        linha.Cells(e.ColumnIndex).Value = novoStatus
                        ' MsgBox("Status de '" & username & "' alterado para " & novoStatus & ".", vbOKOnly + vbInformation, "Sucesso")
                    Else
                        MsgBox("Não foi possível alterar o status.", vbOKOnly + vbExclamation, "Atenção")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Erro ao alterar status: " & ex.Message, vbOKOnly + vbCritical, "Erro")
        End Try
    End Sub

    Private Sub dgv_dados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellClick
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub

        Dim header As String = dgv_dados.Columns(e.ColumnIndex).HeaderText.ToUpper()
        If header <> "EDITAR" AndAlso header <> "APAGAR" Then Exit Sub

        Dim row = dgv_dados.Rows(e.RowIndex)
        Dim id As Integer = CInt(row.Cells("Nº").Value)

        If header = "APAGAR" Then
            If MsgBox("Apagar o usuário selecionado?", vbYesNo + vbQuestion, "Confirmação") = vbYes Then
                Try
                    Using con = Db.conexao()
                        con.Open()
                        Dim sql As String = "DELETE FROM usuarios WHERE id=" & id
                        Using cmd As New MySqlCommand(sql, con)
                            Dim n = cmd.ExecuteNonQuery()
                            If n > 0 Then
                                MsgBox("Usuário apagado.", vbOKOnly + vbInformation, "OK")
                                carregarDados()
                            Else
                                MsgBox("Nada foi apagado.", vbOKOnly + vbExclamation, "Atenção")
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MsgBox("Erro ao apagar: " & ex.Message, vbOKOnly + vbCritical, "Erro")
                End Try
            End If

        ElseIf header = "EDITAR" Then
            ' valores atuais da linha
            Dim oldUser As String = row.Cells("USERNAME").Value.ToString()
            Dim oldEmail As String = row.Cells("EMAIL").Value.ToString()
            Dim oldSenha As String = row.Cells("SENHA").Value.ToString()
            Dim oldStat As String = row.Cells("STATUS").Value.ToString()

            ' InputBox simples (sem foto)
            Dim newUser = InputBox("ALTERAR O NOME DE USUARIO:", "Editar", oldUser)
            Dim newEmail = InputBox("ALTERAR O EMAIL:", "Editar", oldEmail)
            Dim newSenha = InputBox("ALTERAR SENHA:", "Editar", oldSenha)
            'Dim newStat = InputBox("STATUS (ATIVA/BLOQUEADA):", "Editar", oldStat)

            ' validação básica
            If newUser = "" Or newEmail = "" Or newSenha = "" Then
                MsgBox("Edição cancelada ou dados inválidos.", vbOKOnly + vbExclamation, "Atenção")
                Exit Sub
            End If

            Try
                Using con = Db.conexao()
                    con.Open()
                    ' UPDATE sem foto_url
                    Dim sql As String =
                        "UPDATE usuarios SET " &
                        "username='" & newUser & "', " &
                        "email='" & newEmail & "', " &
                        "senha='" & newSenha & "'" &
                        "WHERE id=" & id

                    Using cmd As New MySqlCommand(sql, con)
                        Dim n = cmd.ExecuteNonQuery()
                        If n > 0 Then
                            MsgBox("Atualizado com sucesso!", vbOKOnly + vbInformation, "OK")
                            carregarDados()
                        Else
                            MsgBox("Nenhuma alteração feita.", vbOKOnly + vbExclamation, "Atenção")
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MsgBox("Erro ao atualizar: " & ex.Message, vbOKOnly + vbCritical, "Erro")
            End Try
        End If
    End Sub

End Class

