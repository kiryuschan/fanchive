<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_cadastro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadastro))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_voltar = New System.Windows.Forms.ToolStripButton()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_gravar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_csenha = New System.Windows.Forms.TextBox()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.btn_4 = New System.Windows.Forms.Button()
        Me.btn_3 = New System.Windows.Forms.Button()
        Me.btn_2 = New System.Windows.Forms.Button()
        Me.btn_1 = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Thistle
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_voltar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1107, 27)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_voltar
        '
        Me.btn_voltar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_voltar.Image = CType(resources.GetObject("btn_voltar.Image"), System.Drawing.Image)
        Me.btn_voltar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(29, 24)
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(187, 167)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(239, 22)
        Me.txt_senha.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(268, 144)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "SENHA"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(186, 108)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(238, 22)
        Me.txt_usuario.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 85)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "USUARIO"
        '
        'img_foto
        '
        Me.img_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_foto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(889, 115)
        Me.img_foto.Margin = New System.Windows.Forms.Padding(4)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(186, 195)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 13
        Me.img_foto.TabStop = False
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(185, 253)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(579, 22)
        Me.txt_email.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(443, 230)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 19)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "EMAIL"
        '
        'btn_gravar
        '
        Me.btn_gravar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_gravar.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gravar.Location = New System.Drawing.Point(185, 368)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(579, 56)
        Me.btn_gravar.TabIndex = 16
        Me.btn_gravar.Text = "GRAVAR"
        Me.btn_gravar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(578, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 19)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "CONFIRMAR SENHA"
        '
        'txt_csenha
        '
        Me.txt_csenha.Location = New System.Drawing.Point(543, 144)
        Me.txt_csenha.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_csenha.Name = "txt_csenha"
        Me.txt_csenha.Size = New System.Drawing.Size(239, 22)
        Me.txt_csenha.TabIndex = 18
        '
        'btn_limpar
        '
        Me.btn_limpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_limpar.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpar.Location = New System.Drawing.Point(333, 430)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(281, 56)
        Me.btn_limpar.TabIndex = 19
        Me.btn_limpar.Text = "LIMPAR"
        Me.btn_limpar.UseVisualStyleBackColor = True
        '
        'btn_4
        '
        Me.btn_4.Image = CType(resources.GetObject("btn_4.Image"), System.Drawing.Image)
        Me.btn_4.Location = New System.Drawing.Point(789, 253)
        Me.btn_4.Name = "btn_4"
        Me.btn_4.Size = New System.Drawing.Size(31, 23)
        Me.btn_4.TabIndex = 21
        Me.btn_4.UseVisualStyleBackColor = True
        '
        'btn_3
        '
        Me.btn_3.Image = CType(resources.GetObject("btn_3.Image"), System.Drawing.Image)
        Me.btn_3.Location = New System.Drawing.Point(789, 144)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(31, 23)
        Me.btn_3.TabIndex = 24
        Me.btn_3.UseVisualStyleBackColor = True
        '
        'btn_2
        '
        Me.btn_2.Image = CType(resources.GetObject("btn_2.Image"), System.Drawing.Image)
        Me.btn_2.Location = New System.Drawing.Point(431, 167)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.Size = New System.Drawing.Size(31, 23)
        Me.btn_2.TabIndex = 25
        Me.btn_2.UseVisualStyleBackColor = True
        '
        'btn_1
        '
        Me.btn_1.Image = CType(resources.GetObject("btn_1.Image"), System.Drawing.Image)
        Me.btn_1.Location = New System.Drawing.Point(431, 107)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(31, 23)
        Me.btn_1.TabIndex = 26
        Me.btn_1.UseVisualStyleBackColor = True
        '
        'frm_cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1107, 629)
        Me.Controls.Add(Me.btn_1)
        Me.Controls.Add(Me.btn_2)
        Me.Controls.Add(Me.btn_3)
        Me.Controls.Add(Me.btn_4)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.txt_csenha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_gravar)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.img_foto)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cadastro"
        Me.Text = "CADASTRO DE USUÁRIO"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents btn_voltar As ToolStripButton
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_gravar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_csenha As TextBox
    Friend WithEvents btn_limpar As Button
    Friend WithEvents btn_4 As Button
    Friend WithEvents btn_3 As Button
    Friend WithEvents btn_2 As Button
    Friend WithEvents btn_1 As Button
End Class
