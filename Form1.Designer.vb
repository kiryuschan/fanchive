<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_entrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_usuario
        '
        Me.txt_usuario.BackColor = System.Drawing.Color.MintCream
        Me.txt_usuario.Font = New System.Drawing.Font("Lucida Bright", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.ForeColor = System.Drawing.Color.Indigo
        Me.txt_usuario.Location = New System.Drawing.Point(375, 210)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(342, 27)
        Me.txt_usuario.TabIndex = 11
        '
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.Color.MintCream
        Me.txt_senha.Font = New System.Drawing.Font("Lucida Bright", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.ForeColor = System.Drawing.Color.Indigo
        Me.txt_senha.Location = New System.Drawing.Point(375, 316)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(342, 27)
        Me.txt_senha.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(494, 167)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Usuário"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(503, 271)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Senha"
        '
        'btn_entrar
        '
        Me.btn_entrar.BackColor = System.Drawing.Color.MintCream
        Me.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_entrar.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_entrar.Location = New System.Drawing.Point(448, 427)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(193, 37)
        Me.btn_entrar.TabIndex = 15
        Me.btn_entrar.Text = "entrar"
        Me.btn_entrar.UseVisualStyleBackColor = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1107, 629)
        Me.Controls.Add(Me.btn_entrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_usuario)
        Me.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "login"
        Me.Text = "LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_entrar As Button
End Class
