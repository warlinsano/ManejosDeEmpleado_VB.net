<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.TxtUsu = New System.Windows.Forms.TextBox()
        Me.txtclave = New System.Windows.Forms.TextBox()
        Me.btEntar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbHora = New System.Windows.Forms.Label()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pass_visible = New System.Windows.Forms.PictureBox()
        Me.RbOjo1 = New System.Windows.Forms.RadioButton()
        Me.RbOjo2 = New System.Windows.Forms.RadioButton()
        Me.LbVoca = New System.Windows.Forms.Label()
        Me.LbEja1 = New System.Windows.Forms.Label()
        Me.LbEja2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pass_visible, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtUsu
        '
        Me.TxtUsu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsu.ForeColor = System.Drawing.Color.LightGray
        Me.TxtUsu.Location = New System.Drawing.Point(217, 60)
        Me.TxtUsu.Name = "TxtUsu"
        Me.TxtUsu.Size = New System.Drawing.Size(293, 24)
        Me.TxtUsu.TabIndex = 1
        Me.TxtUsu.Text = "Usuario"
        '
        'txtclave
        '
        Me.txtclave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclave.ForeColor = System.Drawing.Color.LightGray
        Me.txtclave.Location = New System.Drawing.Point(217, 112)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.Size = New System.Drawing.Size(257, 24)
        Me.txtclave.TabIndex = 2
        Me.txtclave.Text = "contraseña"
        '
        'btEntar
        '
        Me.btEntar.Location = New System.Drawing.Point(232, 162)
        Me.btEntar.Name = "btEntar"
        Me.btEntar.Size = New System.Drawing.Size(254, 42)
        Me.btEntar.TabIndex = 3
        Me.btEntar.Text = "&ENTRAR"
        Me.btEntar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(214, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "USUARIO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(214, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "CONTRASEÑA:"
        '
        'lbHora
        '
        Me.lbHora.AutoSize = True
        Me.lbHora.Location = New System.Drawing.Point(35, 302)
        Me.lbHora.Name = "lbHora"
        Me.lbHora.Size = New System.Drawing.Size(38, 13)
        Me.lbHora.TabIndex = 10
        Me.lbHora.Text = "lbHora"
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Location = New System.Drawing.Point(35, 276)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(45, 13)
        Me.lbFecha.TabIndex = 11
        Me.lbFecha.Text = "lbFecha"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(176, 212)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'pass_visible
        '
        Me.pass_visible.Image = CType(resources.GetObject("pass_visible.Image"), System.Drawing.Image)
        Me.pass_visible.Location = New System.Drawing.Point(471, 112)
        Me.pass_visible.Name = "pass_visible"
        Me.pass_visible.Size = New System.Drawing.Size(39, 24)
        Me.pass_visible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pass_visible.TabIndex = 13
        Me.pass_visible.TabStop = False
        '
        'RbOjo1
        '
        Me.RbOjo1.AutoSize = True
        Me.RbOjo1.Location = New System.Drawing.Point(75, 78)
        Me.RbOjo1.Name = "RbOjo1"
        Me.RbOjo1.Size = New System.Drawing.Size(14, 13)
        Me.RbOjo1.TabIndex = 14
        Me.RbOjo1.TabStop = True
        Me.RbOjo1.UseVisualStyleBackColor = True
        '
        'RbOjo2
        '
        Me.RbOjo2.AutoSize = True
        Me.RbOjo2.Location = New System.Drawing.Point(102, 78)
        Me.RbOjo2.Name = "RbOjo2"
        Me.RbOjo2.Size = New System.Drawing.Size(14, 13)
        Me.RbOjo2.TabIndex = 15
        Me.RbOjo2.TabStop = True
        Me.RbOjo2.UseVisualStyleBackColor = True
        '
        'LbVoca
        '
        Me.LbVoca.AutoSize = True
        Me.LbVoca.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LbVoca.Location = New System.Drawing.Point(82, 105)
        Me.LbVoca.Name = "LbVoca"
        Me.LbVoca.Size = New System.Drawing.Size(25, 13)
        Me.LbVoca.TabIndex = 16
        Me.LbVoca.Text = "___"
        '
        'LbEja1
        '
        Me.LbEja1.AutoSize = True
        Me.LbEja1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LbEja1.Location = New System.Drawing.Point(64, 62)
        Me.LbEja1.Name = "LbEja1"
        Me.LbEja1.Size = New System.Drawing.Size(25, 13)
        Me.LbEja1.TabIndex = 17
        Me.LbEja1.Text = "___"
        '
        'LbEja2
        '
        Me.LbEja2.AutoSize = True
        Me.LbEja2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LbEja2.Location = New System.Drawing.Point(99, 62)
        Me.LbEja2.Name = "LbEja2"
        Me.LbEja2.Size = New System.Drawing.Size(25, 13)
        Me.LbEja2.TabIndex = 18
        Me.LbEja2.Text = "___"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(544, 234)
        Me.Controls.Add(Me.LbEja2)
        Me.Controls.Add(Me.LbEja1)
        Me.Controls.Add(Me.LbVoca)
        Me.Controls.Add(Me.RbOjo2)
        Me.Controls.Add(Me.RbOjo1)
        Me.Controls.Add(Me.pass_visible)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbFecha)
        Me.Controls.Add(Me.lbHora)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btEntar)
        Me.Controls.Add(Me.txtclave)
        Me.Controls.Add(Me.TxtUsu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pass_visible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtUsu As System.Windows.Forms.TextBox
    Friend WithEvents txtclave As System.Windows.Forms.TextBox
    Friend WithEvents btEntar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbHora As Label
    Friend WithEvents lbFecha As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pass_visible As PictureBox
    Friend WithEvents RbOjo1 As RadioButton
    Friend WithEvents RbOjo2 As RadioButton
    Friend WithEvents LbVoca As Label
    Friend WithEvents LbEja1 As Label
    Friend WithEvents LbEja2 As Label
End Class
