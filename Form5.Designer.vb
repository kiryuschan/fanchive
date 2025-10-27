<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gerenciar_contas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gerenciar_contas))
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_voltar = New System.Windows.Forms.ToolStripButton()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.senha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.foto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.AllowUserToDeleteRows = False
        Me.dgv_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_dados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_dados.BackgroundColor = System.Drawing.Color.Thistle
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.username, Me.email, Me.senha, Me.foto, Me.status, Me.Column5, Me.Column7})
        Me.dgv_dados.Location = New System.Drawing.Point(13, 45)
        Me.dgv_dados.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.ReadOnly = True
        Me.dgv_dados.RowHeadersWidth = 51
        Me.dgv_dados.Size = New System.Drawing.Size(1081, 571)
        Me.dgv_dados.TabIndex = 15
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Thistle
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_voltar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1107, 27)
        Me.ToolStrip1.TabIndex = 16
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
        Me.btn_voltar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nº"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 64
        '
        'username
        '
        Me.username.HeaderText = "USERNAME"
        Me.username.MinimumWidth = 6
        Me.username.Name = "username"
        Me.username.ReadOnly = True
        Me.username.Width = 147
        '
        'email
        '
        Me.email.HeaderText = "EMAIL"
        Me.email.MinimumWidth = 6
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Width = 99
        '
        'senha
        '
        Me.senha.HeaderText = "SENHA"
        Me.senha.MinimumWidth = 6
        Me.senha.Name = "senha"
        Me.senha.ReadOnly = True
        Me.senha.Width = 107
        '
        'foto
        '
        Me.foto.HeaderText = "FOTO"
        Me.foto.MinimumWidth = 6
        Me.foto.Name = "foto"
        Me.foto.ReadOnly = True
        Me.foto.Width = 96
        '
        'status
        '
        Me.status.HeaderText = "STATUS"
        Me.status.MinimumWidth = 6
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Width = 119
        '
        'Column5
        '
        Me.Column5.HeaderText = "EDITAR"
        Me.Column5.Image = CType(resources.GetObject("Column5.Image"), System.Drawing.Image)
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 92
        '
        'Column7
        '
        Me.Column7.HeaderText = "EXCLUIR"
        Me.Column7.Image = CType(resources.GetObject("Column7.Image"), System.Drawing.Image)
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'gerenciar_contas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1107, 629)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgv_dados)
        Me.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "gerenciar_contas"
        Me.Text = "GERENCIAMENTO DE CONTAS"
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_voltar As ToolStripButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents senha As DataGridViewTextBoxColumn
    Friend WithEvents foto As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Column7 As DataGridViewImageColumn
End Class
