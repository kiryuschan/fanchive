' topo do arquivo
Imports System.Windows.Forms
Imports MySqlConnector
Public Class login

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'conexão 
            Dim conexao As MySqlConnection = Db.conexao()
            conexao.Open()

            'SE CONECTAR    
            'MsgBox("Conexão com o banco estabelecida com sucesso!", vbOKOnly + vbInformation, "Sucesso")

            conexao.Close()
        Catch ex As Exception
            'SE NÃO CONECTAR
            MsgBox("Erro ao conectar ao banco: " & ex.Message, vbOKOnly + vbCritical, "Erro de Conexão")
        End Try

        ' tecla Enter ativa o botão Entrar
        Me.AcceptButton = btn_entrar
        ' esconder a senha enquanto digita
        txt_senha.UseSystemPasswordChar = True
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Dim user As String = txt_usuario.Text.Trim()
        Dim pass As String = txt_senha.Text

        ' acesso de adm
        If String.Equals(user, "admin", StringComparison.OrdinalIgnoreCase) AndAlso pass = "admin" Then
            ' abrir menu adm
            Dim frm As New menu_adm()
            frm.Show()
            Me.Hide()
            Return
        End If

        ' conexão com banco
        Try
            Using conexao As MySqlConnection = Db.conexao()
                conexao.Open()

                ' Consulta no banco (username OU email)
                Dim sql As String = "
                    SELECT username, email, senha, status
                    FROM usuarios
                    WHERE (username = @user OR email = @user) 
                      AND senha = @senha;
                "

                Using cmd As New MySqlCommand(sql, conexao)
                    cmd.Parameters.AddWithValue("@user", user)
                    cmd.Parameters.AddWithValue("@senha", pass)

                    Using rd As MySqlDataReader = cmd.ExecuteReader()
                        If rd.Read() Then
                            ' encontrou o usuário
                            Dim status As String = rd("status").ToString()

                            If status = "ATIVA" Then
                                MsgBox("Login realizado com sucesso!", vbOKOnly + vbInformation, "Bem-vindo")
                                Dim frm As New menu_usuario()
                                frm.Show()
                                Me.Hide()
                            Else
                                MsgBox("Essa conta está bloqueada.", vbOKOnly + vbExclamation, "Acesso Negado")
                            End If

                        Else
                            ' não achou
                            MsgBox("Usuário ou senha incorretos.", vbOKOnly + vbCritical, "Erro de Login")
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Erro ao acessar o banco: " & ex.Message, vbOKOnly + vbCritical, "Erro de Conexão")
        End Try

        ' limpar campos e focar novamente
        txt_usuario.Clear()
        txt_senha.Clear()
        txt_usuario.Focus()
    End Sub


End Class
