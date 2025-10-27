<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_adm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menu_adm))
        Me.btn_cad = New System.Windows.Forms.Button()
        Me.btn_contas = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_voltar = New System.Windows.Forms.ToolStripButton()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cad
        '
        Me.btn_cad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cad.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cad.Location = New System.Drawing.Point(317, 233)
        Me.btn_cad.Name = "btn_cad"
        Me.btn_cad.Size = New System.Drawing.Size(207, 120)
        Me.btn_cad.TabIndex = 0
        Me.btn_cad.Text = "CADASTRO DE USUÁRIO"
        Me.btn_cad.UseVisualStyleBackColor = True
        '
        'btn_contas
        '
        Me.btn_contas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_contas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_contas.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_contas.Location = New System.Drawing.Point(554, 233)
        Me.btn_contas.Name = "btn_contas"
        Me.btn_contas.Size = New System.Drawing.Size(207, 120)
        Me.btn_contas.TabIndex = 2
        Me.btn_contas.Text = "GERENCIAR CONTAS"
        Me.btn_contas.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Thistle
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_voltar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1107, 27)
        Me.ToolStrip1.TabIndex = 3
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
        Me.btn_sair.TabIndex = 4
        Me.btn_sair.Text = "SAIR"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'menu_adm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1107, 629)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btn_contas)
        Me.Controls.Add(Me.btn_cad)
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "menu_adm"
        Me.Text = "MENU"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cad As Button
    Friend WithEvents btn_contas As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_voltar As ToolStripButton
    Friend WithEvents btn_sair As Button
End Class
