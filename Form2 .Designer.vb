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
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.MintCream
        Me.txt_email.Font = New System.Drawing.Font("Lucida Bright", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.ForeColor = System.Drawing.Color.Indigo
        Me.txt_email.Location = New System.Drawing.Point(385, 270)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(342, 31)
        Me.txt_email.TabIndex = 11
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.MintCream
        Me.TextBox1.Font = New System.Drawing.Font("Lucida Bright", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Indigo
        Me.TextBox1.Location = New System.Drawing.Point(385, 376)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(342, 31)
        Me.TextBox1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(504, 227)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 27)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Usuário"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(513, 331)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 27)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Senha"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MintCream
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(458, 487)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(193, 37)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "entrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1107, 629)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txt_email)
        Me.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "login"
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_email As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
