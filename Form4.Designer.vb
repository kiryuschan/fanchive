<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menu_usuario))
        Me.btn_cad_fic = New System.Windows.Forms.Button()
        Me.btn_lista = New System.Windows.Forms.Button()
        Me.btn_estatistica = New System.Windows.Forms.Button()
        Me.btn_avaliacao = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_voltar = New System.Windows.Forms.ToolStripButton()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cad_fic
        '
        Me.btn_cad_fic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cad_fic.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cad_fic.Location = New System.Drawing.Point(314, 171)
        Me.btn_cad_fic.Name = "btn_cad_fic"
        Me.btn_cad_fic.Size = New System.Drawing.Size(207, 120)
        Me.btn_cad_fic.TabIndex = 0
        Me.btn_cad_fic.Text = "CADASTRO DE FANFICS"
        Me.btn_cad_fic.UseVisualStyleBackColor = True
        '
        'btn_lista
        '
        Me.btn_lista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_lista.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_lista.Location = New System.Drawing.Point(314, 297)
        Me.btn_lista.Name = "btn_lista"
        Me.btn_lista.Size = New System.Drawing.Size(207, 120)
        Me.btn_lista.TabIndex = 1
        Me.btn_lista.Text = "LISTA DE FANFICS"
        Me.btn_lista.UseVisualStyleBackColor = True
        '
        'btn_estatistica
        '
        Me.btn_estatistica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_estatistica.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_estatistica.Location = New System.Drawing.Point(556, 299)
        Me.btn_estatistica.Name = "btn_estatistica"
        Me.btn_estatistica.Size = New System.Drawing.Size(207, 120)
        Me.btn_estatistica.TabIndex = 3
        Me.btn_estatistica.Text = "ESTATÍSTICAS"
        Me.btn_estatistica.UseVisualStyleBackColor = True
        '
        'btn_avaliacao
        '
        Me.btn_avaliacao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_avaliacao.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_avaliacao.Location = New System.Drawing.Point(556, 173)
        Me.btn_avaliacao.Name = "btn_avaliacao"
        Me.btn_avaliacao.Size = New System.Drawing.Size(207, 120)
        Me.btn_avaliacao.TabIndex = 2
        Me.btn_avaliacao.Text = "AVALIAÇÕES"
        Me.btn_avaliacao.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Thistle
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_voltar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1107, 27)
        Me.ToolStrip1.TabIndex = 4
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
        'btn_sair
        '
        Me.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sair.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.Location = New System.Drawing.Point(435, 448)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(206, 41)
        Me.btn_sair.TabIndex = 5
        Me.btn_sair.Text = "SAIR"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'menu_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1107, 629)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btn_estatistica)
        Me.Controls.Add(Me.btn_avaliacao)
        Me.Controls.Add(Me.btn_lista)
        Me.Controls.Add(Me.btn_cad_fic)
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "menu_usuario"
        Me.Text = "MENU"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cad_fic As Button
    Friend WithEvents btn_lista As Button
    Friend WithEvents btn_estatistica As Button
    Friend WithEvents btn_avaliacao As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_voltar As ToolStripButton
    Friend WithEvents btn_sair As Button
End Class
