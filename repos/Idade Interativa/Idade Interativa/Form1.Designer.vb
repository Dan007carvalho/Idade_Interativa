<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class janela_interativa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(janela_interativa))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_idade = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Radio_femin = New System.Windows.Forms.RadioButton()
        Me.Radio_masc = New System.Windows.Forms.RadioButton()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Lime
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Aqua
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Idade:"
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(100, 21)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(176, 20)
        Me.txt_nome.TabIndex = 2
        '
        'txt_idade
        '
        Me.txt_idade.Location = New System.Drawing.Point(98, 67)
        Me.txt_idade.Name = "txt_idade"
        Me.txt_idade.Size = New System.Drawing.Size(57, 20)
        Me.txt_idade.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Yellow
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.Radio_femin)
        Me.GroupBox1.Controls.Add(Me.Radio_masc)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(36, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 91)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sexo"
        '
        'Radio_femin
        '
        Me.Radio_femin.AutoSize = True
        Me.Radio_femin.Location = New System.Drawing.Point(19, 58)
        Me.Radio_femin.Name = "Radio_femin"
        Me.Radio_femin.Size = New System.Drawing.Size(89, 25)
        Me.Radio_femin.TabIndex = 1
        Me.Radio_femin.TabStop = True
        Me.Radio_femin.Text = "Feminino"
        Me.Radio_femin.UseVisualStyleBackColor = True
        '
        'Radio_masc
        '
        Me.Radio_masc.AutoSize = True
        Me.Radio_masc.Location = New System.Drawing.Point(19, 19)
        Me.Radio_masc.Name = "Radio_masc"
        Me.Radio_masc.Size = New System.Drawing.Size(96, 25)
        Me.Radio_masc.TabIndex = 0
        Me.Radio_masc.TabStop = True
        Me.Radio_masc.Text = "Masculino"
        Me.Radio_masc.UseVisualStyleBackColor = True
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.Fuchsia
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.Location = New System.Drawing.Point(36, 244)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 31)
        Me.btn_ok.TabIndex = 5
        Me.btn_ok.Text = "Ok"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'btn_limpar
        '
        Me.btn_limpar.BackColor = System.Drawing.Color.Red
        Me.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_limpar.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpar.Location = New System.Drawing.Point(201, 244)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(75, 31)
        Me.btn_limpar.TabIndex = 6
        Me.btn_limpar.Text = "Limpar"
        Me.btn_limpar.UseVisualStyleBackColor = False
        '
        'janela_interativa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Idade_Interativa.My.Resources.Resources.city1
        Me.ClientSize = New System.Drawing.Size(312, 301)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_idade)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "janela_interativa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Janela Interativa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_idade As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Radio_femin As RadioButton
    Friend WithEvents Radio_masc As RadioButton
    Friend WithEvents btn_ok As Button
    Friend WithEvents btn_limpar As Button
End Class
