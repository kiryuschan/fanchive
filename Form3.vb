
Imports System.IO
Imports MySqlConnector
Public Class frm_cadastro
    'o negócio da foto salva
    Private fotoSALVA As String = Nothing

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
    End Sub

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        'SÓ PODE SELECIONAR A FOTO COM NOME DE USUARIO - ELA VAI SALVAR COM O NOME DO USUARIO (EX: RAFS.JPG)
        If txt_usuario.Text.Trim() = "" Then
            MsgBox("Digite o nome de usuário antes de selecionar a foto.", vbOKOnly + vbExclamation, "Atenção")
            Exit Sub
        End If

        Try
            'pesquisar a foto no explorer
            Using dlg As New OpenFileDialog()
                dlg.Title = "Selecione a foto do usuário"
                dlg.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
                dlg.Multiselect = False

                'sair do negócio de boa
                If dlg.ShowDialog(Me) <> DialogResult.OK Then Exit Sub

                'achar o bin debug fotos
                Dim fotosDir As String = Path.Combine(Application.StartupPath, "fotos")
                If Not Directory.Exists(fotosDir) Then Directory.CreateDirectory(fotosDir)

                Dim username As String = txt_usuario.Text.Trim().ToLower()
                Dim extNova As String = Path.GetExtension(dlg.FileName).ToLowerInvariant()

                'mini laço pra achar a foto peguei do chat pq gostei da ideia 
                For Each f As String In Directory.GetFiles(fotosDir, username & ".*")
                    Try : File.Delete(f) : Catch : End Try
                Next

                'arquivo fixo das fotos
                Dim nomeArquivo As String = username & extNova
                Dim destino As String = Path.Combine(fotosDir, nomeArquivo)

                'copia SOBRE o arquivo 
                File.Copy(dlg.FileName, destino, True)

                'guarda no banco e carrega
                fotoSALVA = Path.Combine("fotos", nomeArquivo).Replace("\", "/")

                Dim bytes = File.ReadAllBytes(destino)
                Using ms As New MemoryStream(bytes)
                    img_foto.Image = Image.FromStream(ms)
                End Using

                MsgBox("Foto atualizada com sucesso!", vbOKOnly + vbInformation, "Imagem")

            End Using

        Catch ex As Exception
            MsgBox("Erro ao atualizar a foto: " & ex.Message, vbOKOnly + vbCritical, "Erro")
        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Dim usuario As String = txt_usuario.Text.Trim()
        Dim senha As String = txt_senha.Text
        Dim csenha As String = txt_csenha.Text
        Dim email As String = txt_email.Text.Trim()

        If usuario = "" OrElse senha = "" OrElse csenha = "" OrElse email = "" OrElse fotoSALVA Is Nothing Then
            MsgBox("Preencha TODOS os campos e selecione uma FOTO.", vbOKOnly + vbExclamation, "Atenção")
            Exit Sub
        End If

        'aprendi isso daqui agora e achei bem legal tipo era só isso o tempo todo??????
        If Not email.Contains("@") OrElse Not email.Contains(".") Then
            MsgBox("Informe um e-mail válido.", vbOKOnly + vbExclamation, "Atenção")
            Exit Sub
        End If

        If senha <> csenha Then
            MsgBox("A senha e a confirmação não conferem.", vbOKOnly + vbExclamation, "Atenção")
            Exit Sub
        End If


        Try
            'conexão
            Dim conexao As MySqlConnection = Db.conexao()
            conexao.Open()

            'GARANTIR que não terá erros
            Dim sql As String = $"SELECT * FROM usuarios WHERE username='{txt_usuario.Text}' OR email='{txt_email.Text}'"
            Dim verificar As New MySqlCommand(sql, conexao)
            Dim rd As MySqlDataReader = verificar.ExecuteReader()

            If rd.HasRows Then
                MsgBox("Usuário ou e-mail já cadastrados!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                rd.Close()
                conexao.Close()
                Exit Sub
            End If
            rd.Close()

            'inserir no banco
            sql = $"INSERT INTO usuarios (username, email, senha, foto_url, status) " &
             $"VALUES ('{txt_usuario.Text}', '{txt_email.Text}', '{txt_senha.Text}', '{fotoSALVA}', 'ATIVA')"


            Dim inserir As New MySqlCommand(sql, conexao)
            Dim linhas As Integer = inserir.ExecuteNonQuery()

            If linhas > 0 Then
                MsgBox("Usuário cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO")
            Else
                MsgBox("Usuário não foi cadastrado corretamente.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            End If

            conexao.Close()

            'limpar campos
            txt_usuario.Clear()
            txt_senha.Clear()
            txt_csenha.Clear()
            txt_email.Clear()
            fotoSALVA = Nothing
            img_foto.Image = Nothing

        Catch ex As Exception
            MsgBox("Erro ao gravar no banco: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")

        End Try
    End Sub

    Private Sub txt_usuario_TextChanged(sender As Object, e As EventArgs) Handles txt_usuario.TextChanged

    End Sub
    'CÓDIGO PRA, SE TIVER UM NOME DE USUÁRIO CADASTRADO, ELE PREENCHA TODOS OS CAMPOS
    Private Sub txt_usuario_LostFocus(sender As Object, e As EventArgs) Handles txt_usuario.LostFocus
        If txt_usuario.Text = "" Then Exit Sub

        Try
            Dim conexao As MySqlConnection = Db.conexao()
            conexao.Open()

            'buscar
            Dim sql As String = "SELECT username, email, senha, foto_url, status " &
                            "FROM usuarios WHERE username='" & txt_usuario.Text & "' LIMIT 1"

            Dim ler As New MySqlCommand(sql, conexao)
            Dim rd As MySqlDataReader = ler.ExecuteReader()

            If rd.Read() Then
                'preenche os campos com os dados do banco + foto
                txt_email.Text = rd("email").ToString()
                txt_senha.Text = rd("senha").ToString()
                txt_csenha.Text = rd("senha").ToString()

                Dim foto As String = rd("foto_url").ToString()
                fotoSALVA = If(String.IsNullOrWhiteSpace(foto), Nothing, foto)

                If fotoSALVA IsNot Nothing Then
                    Dim fullPath As String = fotoSALVA
                    If Not Path.IsPathRooted(fotoSALVA) Then
                        fullPath = Path.Combine(Application.StartupPath, fotoSALVA.Replace("/", "\"))
                    End If

                    If File.Exists(fullPath) Then
                        Dim bytes = File.ReadAllBytes(fullPath)
                        Using ms As New MemoryStream(bytes)
                            img_foto.Image = Image.FromStream(ms)
                        End Using
                    Else
                        img_foto.Image = Nothing
                    End If
                Else
                    img_foto.Image = Nothing
                End If

                'MsgBox("Usuário encontrado e carregado com sucesso!", vbOKOnly + vbInformation, "Sucesso")

            Else
                'txt_email.Clear()
                'txt_senha.Clear()
                'txt_csenha.Clear()
                'img_foto.Image = Nothing
                'fotoSALVA = Nothing
                'MsgBox("Usuário não encontrado no banco.", vbOKOnly + vbExclamation, "Atenção")
            End If

            rd.Close()
            conexao.Close()





        Catch ex As Exception
            MsgBox("Erro ao buscar usuário: " & ex.Message, vbOKOnly + vbCritical, "Erro")
        End Try
    End Sub

    Private Sub txt_email_TextChanged(sender As Object, e As EventArgs) Handles txt_email.TextChanged

    End Sub
    'mesma coisasó que com o email pq né    
    Private Sub txt_email_LostFocus(sender As Object, e As EventArgs) Handles txt_email.LostFocus
        If txt_email.Text = "" Then Exit Sub

        Try
            Dim conexao As MySqlConnection = Db.conexao()
            conexao.Open()


            Dim sql As String = "SELECT username, email, senha, foto_url, status " &
                           "FROM usuarios WHERE email='" & txt_email.Text & "' LIMIT 1"


            Dim ler As New MySqlCommand(sql, conexao)
            Dim rd As MySqlDataReader = ler.ExecuteReader()
            If rd.Read() Then
                txt_usuario.Text = rd("username").ToString()
                txt_email.Text = rd("email").ToString()
                txt_senha.Text = rd("senha").ToString()
                txt_csenha.Text = rd("senha").ToString()

                Dim foto As String = rd("foto_url").ToString()
                fotoSALVA = If(String.IsNullOrWhiteSpace(foto), Nothing, foto)

                If fotoSALVA IsNot Nothing Then
                    Dim fullPath As String = fotoSALVA
                    If Not Path.IsPathRooted(fotoSALVA) Then
                        fullPath = Path.Combine(Application.StartupPath, fotoSALVA.Replace("/", "\"))
                    End If

                    If File.Exists(fullPath) Then
                        Dim bytes = File.ReadAllBytes(fullPath)
                        Using ms As New MemoryStream(bytes)
                            img_foto.Image = Image.FromStream(ms)
                        End Using
                    Else
                        img_foto.Image = Nothing
                    End If
                Else
                    img_foto.Image = Nothing
                End If

                'MsgBox("Usuário encontrado e carregado com sucesso!", vbOKOnly + vbInformation, "Sucesso")

            Else
                ' txt_usuario.Clear()
                'txt_senha.Clear()
                'txt_csenha.Clear()
                'img_foto.Image = Nothing
                'fotoSALVA = Nothing
                'MsgBox("E-mail não encontrado no banco.", vbOKOnly + vbExclamation, "Atenção")
            End If

            rd.Close()
            conexao.Close()
        Catch ex As Exception
            MsgBox("Erro ao buscar e-mail: " & ex.Message, vbOKOnly + vbCritical, "Erro")
        End Try
    End Sub

    'limpar tudo e campos específicos
    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        txt_usuario.Clear()
        txt_senha.Clear()
        txt_csenha.Clear()
        txt_email.Clear()
        img_foto.Image = Nothing
        fotoSALVA = Nothing

    End Sub

    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        txt_usuario.Clear()
    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        txt_senha.Clear()
    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        txt_csenha.Clear()
    End Sub

    Private Sub btn_4_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        txt_email.Clear()
    End Sub
End Class