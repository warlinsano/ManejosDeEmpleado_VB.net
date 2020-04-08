<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMantenimientoNacionalidad
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtNacionalidad = New System.Windows.Forms.TextBox()
        Me.btEditar = New System.Windows.Forms.Button()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.btGuardarNuevo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbid = New System.Windows.Forms.TextBox()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.btActulizar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txttipousu = New System.Windows.Forms.Label()
        Me.txtusu = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btvover = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNacionalidad
        '
        Me.txtNacionalidad.Enabled = False
        Me.txtNacionalidad.Location = New System.Drawing.Point(81, 35)
        Me.txtNacionalidad.Name = "txtNacionalidad"
        Me.txtNacionalidad.Size = New System.Drawing.Size(158, 20)
        Me.txtNacionalidad.TabIndex = 0
        '
        'btEditar
        '
        Me.btEditar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btEditar.Location = New System.Drawing.Point(245, 44)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(85, 39)
        Me.btEditar.TabIndex = 2
        Me.btEditar.Text = "Editar"
        Me.btEditar.UseVisualStyleBackColor = False
        '
        'btAgregar
        '
        Me.btAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btAgregar.Location = New System.Drawing.Point(245, 3)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(85, 35)
        Me.btAgregar.TabIndex = 3
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = False
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id})
        Me.dgv.Location = New System.Drawing.Point(25, 156)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(446, 137)
        Me.dgv.TabIndex = 4
        '
        'Id
        '
        Me.Id.DataPropertyName = "id"
        Me.Id.HeaderText = "ID"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nacionalidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Estado:"
        '
        'cbEstado
        '
        Me.cbEstado.AllowDrop = True
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.Enabled = False
        Me.cbEstado.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbEstado.Location = New System.Drawing.Point(81, 61)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(158, 21)
        Me.cbEstado.TabIndex = 7
        Me.cbEstado.TabStop = False
        '
        'btGuardarNuevo
        '
        Me.btGuardarNuevo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btGuardarNuevo.Enabled = False
        Me.btGuardarNuevo.Location = New System.Drawing.Point(336, 3)
        Me.btGuardarNuevo.Name = "btGuardarNuevo"
        Me.btGuardarNuevo.Size = New System.Drawing.Size(104, 52)
        Me.btGuardarNuevo.TabIndex = 9
        Me.btGuardarNuevo.Text = "&GUARGAR"
        Me.btGuardarNuevo.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "ID:"
        '
        'lbid
        '
        Me.lbid.Enabled = False
        Me.lbid.Location = New System.Drawing.Point(81, 7)
        Me.lbid.Name = "lbid"
        Me.lbid.Size = New System.Drawing.Size(158, 20)
        Me.lbid.TabIndex = 11
        '
        'btCancelar
        '
        Me.btCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btCancelar.Enabled = False
        Me.btCancelar.Location = New System.Drawing.Point(336, 59)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(104, 23)
        Me.btCancelar.TabIndex = 12
        Me.btCancelar.Text = "&Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = False
        '
        'btActulizar
        '
        Me.btActulizar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btActulizar.Location = New System.Drawing.Point(336, 3)
        Me.btActulizar.Name = "btActulizar"
        Me.btActulizar.Size = New System.Drawing.Size(104, 49)
        Me.btActulizar.TabIndex = 13
        Me.btActulizar.Text = "&Actualizar"
        Me.btActulizar.UseVisualStyleBackColor = False
        Me.btActulizar.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox1.Controls.Add(Me.txttipousu)
        Me.GroupBox1.Controls.Add(Me.txtusu)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 308)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 74)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS:"
        '
        'txttipousu
        '
        Me.txttipousu.AutoSize = True
        Me.txttipousu.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txttipousu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txttipousu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttipousu.ForeColor = System.Drawing.Color.Black
        Me.txttipousu.Location = New System.Drawing.Point(89, 52)
        Me.txttipousu.Name = "txttipousu"
        Me.txttipousu.Size = New System.Drawing.Size(73, 13)
        Me.txttipousu.TabIndex = 5
        Me.txttipousu.Text = "ID USUARIO:"
        '
        'txtusu
        '
        Me.txtusu.AutoSize = True
        Me.txtusu.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtusu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtusu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusu.ForeColor = System.Drawing.Color.Black
        Me.txtusu.Location = New System.Drawing.Point(87, 34)
        Me.txtusu.Name = "txtusu"
        Me.txtusu.Size = New System.Drawing.Size(73, 13)
        Me.txtusu.TabIndex = 4
        Me.txtusu.Text = "ID USUARIO:"
        '
        'txtid
        '
        Me.txtid.AutoSize = True
        Me.txtid.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.ForeColor = System.Drawing.Color.Black
        Me.txtid.Location = New System.Drawing.Point(91, 16)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(73, 13)
        Me.txtid.TabIndex = 3
        Me.txtid.Text = "ID USUARIO:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(13, 55)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "TIPO:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 37)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "USUARIO:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "ID USUARIO:"
        '
        'btvover
        '
        Me.btvover.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btvover.Location = New System.Drawing.Point(333, 308)
        Me.btvover.Name = "btvover"
        Me.btvover.Size = New System.Drawing.Size(103, 76)
        Me.btvover.TabIndex = 37
        Me.btvover.Text = "&Volver al Menu"
        Me.btvover.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(101, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(288, 20)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "MANTENIMIENTO NACIONALIDADES"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.btAgregar)
        Me.Panel1.Controls.Add(Me.txtNacionalidad)
        Me.Panel1.Controls.Add(Me.btEditar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btActulizar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btCancelar)
        Me.Panel1.Controls.Add(Me.cbEstado)
        Me.Panel1.Controls.Add(Me.lbid)
        Me.Panel1.Controls.Add(Me.btGuardarNuevo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(24, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(446, 92)
        Me.Panel1.TabIndex = 39
        '
        'FormMantenimientoNacionalidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(487, 400)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btvover)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMantenimientoNacionalidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMantenimientoNacionalidad"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNacionalidad As System.Windows.Forms.TextBox
    Friend WithEvents btEditar As System.Windows.Forms.Button
    Friend WithEvents btAgregar As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Id As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents btGuardarNuevo As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbid As System.Windows.Forms.TextBox
    Friend WithEvents btCancelar As System.Windows.Forms.Button
    Friend WithEvents btActulizar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txttipousu As Label
    Friend WithEvents txtusu As Label
    Friend WithEvents txtid As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btvover As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
End Class
