<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMantenimentoEmpleado
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDirrecion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.cbEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.DtpFechaIngeso = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaSalida = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbNacionalidad = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txttipousu = New System.Windows.Forms.Label()
        Me.txtusu = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btvover = New System.Windows.Forms.Button()
        Me.CbCondicion = New System.Windows.Forms.ComboBox()
        Me.RbMasculino = New System.Windows.Forms.RadioButton()
        Me.RbFemenina = New System.Windows.Forms.RadioButton()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.btEditar = New System.Windows.Forms.Button()
        Me.btActulizar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.btGuardarNuevo = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxCrearUser = New System.Windows.Forms.CheckBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(108, 80)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(202, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(108, 106)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(202, 20)
        Me.txtApellido.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellido:"
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(108, 132)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(202, 20)
        Me.txtCedula.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cedula:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Estado Civil:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(108, 184)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(202, 20)
        Me.txtTelefono.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Telefono:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Fecha Nac:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(333, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Fecha Ingreso:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(333, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Condicion:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(412, 135)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(229, 20)
        Me.txtEmail.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(333, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Email:"
        '
        'txtDirrecion
        '
        Me.txtDirrecion.Location = New System.Drawing.Point(412, 109)
        Me.txtDirrecion.Name = "txtDirrecion"
        Me.txtDirrecion.Size = New System.Drawing.Size(229, 20)
        Me.txtDirrecion.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(333, 113)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Dirrecion:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(333, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Genero:"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID})
        Me.dgv.Location = New System.Drawing.Point(14, 244)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(849, 222)
        Me.dgv.TabIndex = 24
        '
        'ID
        '
        Me.ID.DataPropertyName = "id"
        Me.ID.HeaderText = "ID EMPLEADO"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'DtpFechaNac
        '
        Me.DtpFechaNac.CustomFormat = ""
        Me.DtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaNac.Location = New System.Drawing.Point(108, 157)
        Me.DtpFechaNac.Name = "DtpFechaNac"
        Me.DtpFechaNac.Size = New System.Drawing.Size(202, 20)
        Me.DtpFechaNac.TabIndex = 27
        Me.DtpFechaNac.Value = New Date(2019, 4, 2, 0, 0, 0, 0)
        '
        'cbEstadoCivil
        '
        Me.cbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoCivil.FormattingEnabled = True
        Me.cbEstadoCivil.Location = New System.Drawing.Point(108, 209)
        Me.cbEstadoCivil.Name = "cbEstadoCivil"
        Me.cbEstadoCivil.Size = New System.Drawing.Size(202, 21)
        Me.cbEstadoCivil.TabIndex = 28
        '
        'DtpFechaIngeso
        '
        Me.DtpFechaIngeso.CustomFormat = ""
        Me.DtpFechaIngeso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaIngeso.Location = New System.Drawing.Point(412, 190)
        Me.DtpFechaIngeso.Name = "DtpFechaIngeso"
        Me.DtpFechaIngeso.Size = New System.Drawing.Size(229, 20)
        Me.DtpFechaIngeso.TabIndex = 29
        '
        'DtpFechaSalida
        '
        Me.DtpFechaSalida.CustomFormat = ""
        Me.DtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaSalida.Location = New System.Drawing.Point(412, 217)
        Me.DtpFechaSalida.Name = "DtpFechaSalida"
        Me.DtpFechaSalida.Size = New System.Drawing.Size(229, 20)
        Me.DtpFechaSalida.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(333, 221)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Fecha Salida:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(331, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Nacionalidad:"
        '
        'cbNacionalidad
        '
        Me.cbNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNacionalidad.FormattingEnabled = True
        Me.cbNacionalidad.Location = New System.Drawing.Point(411, 58)
        Me.cbNacionalidad.Name = "cbNacionalidad"
        Me.cbNacionalidad.Size = New System.Drawing.Size(230, 21)
        Me.cbNacionalidad.TabIndex = 33
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txttipousu)
        Me.GroupBox1.Controls.Add(Me.txtusu)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 472)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 74)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS:"
        '
        'txttipousu
        '
        Me.txttipousu.AutoSize = True
        Me.txttipousu.BackColor = System.Drawing.Color.LightGray
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
        Me.txtusu.BackColor = System.Drawing.Color.LightGray
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
        Me.txtid.BackColor = System.Drawing.Color.LightGray
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
        Me.btvover.Location = New System.Drawing.Point(720, 493)
        Me.btvover.Name = "btvover"
        Me.btvover.Size = New System.Drawing.Size(143, 53)
        Me.btvover.TabIndex = 36
        Me.btvover.Text = "&Volver al Menu"
        Me.btvover.UseVisualStyleBackColor = True
        '
        'CbCondicion
        '
        Me.CbCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCondicion.FormattingEnabled = True
        Me.CbCondicion.Location = New System.Drawing.Point(411, 162)
        Me.CbCondicion.Name = "CbCondicion"
        Me.CbCondicion.Size = New System.Drawing.Size(230, 21)
        Me.CbCondicion.TabIndex = 37
        '
        'RbMasculino
        '
        Me.RbMasculino.AutoSize = True
        Me.RbMasculino.Location = New System.Drawing.Point(412, 83)
        Me.RbMasculino.Name = "RbMasculino"
        Me.RbMasculino.Size = New System.Drawing.Size(88, 17)
        Me.RbMasculino.TabIndex = 38
        Me.RbMasculino.TabStop = True
        Me.RbMasculino.Text = "MASCULINO"
        Me.RbMasculino.UseVisualStyleBackColor = True
        '
        'RbFemenina
        '
        Me.RbFemenina.AutoSize = True
        Me.RbFemenina.Location = New System.Drawing.Point(543, 82)
        Me.RbFemenina.Name = "RbFemenina"
        Me.RbFemenina.Size = New System.Drawing.Size(81, 17)
        Me.RbFemenina.TabIndex = 39
        Me.RbFemenina.TabStop = True
        Me.RbFemenina.Text = "FEMENINO"
        Me.RbFemenina.UseVisualStyleBackColor = True
        '
        'btAgregar
        '
        Me.btAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btAgregar.Location = New System.Drawing.Point(658, 60)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(85, 35)
        Me.btAgregar.TabIndex = 41
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = False
        '
        'btEditar
        '
        Me.btEditar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btEditar.Location = New System.Drawing.Point(658, 101)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(85, 39)
        Me.btEditar.TabIndex = 40
        Me.btEditar.Text = "Editar"
        Me.btEditar.UseVisualStyleBackColor = False
        '
        'btActulizar
        '
        Me.btActulizar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btActulizar.Location = New System.Drawing.Point(749, 61)
        Me.btActulizar.Name = "btActulizar"
        Me.btActulizar.Size = New System.Drawing.Size(118, 49)
        Me.btActulizar.TabIndex = 44
        Me.btActulizar.Text = "&Actualizar"
        Me.btActulizar.UseVisualStyleBackColor = False
        Me.btActulizar.Visible = False
        '
        'btCancelar
        '
        Me.btCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btCancelar.Enabled = False
        Me.btCancelar.Location = New System.Drawing.Point(749, 116)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(118, 23)
        Me.btCancelar.TabIndex = 43
        Me.btCancelar.Text = "&Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = False
        '
        'btGuardarNuevo
        '
        Me.btGuardarNuevo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btGuardarNuevo.Enabled = False
        Me.btGuardarNuevo.Location = New System.Drawing.Point(749, 58)
        Me.btGuardarNuevo.Name = "btGuardarNuevo"
        Me.btGuardarNuevo.Size = New System.Drawing.Size(118, 52)
        Me.btGuardarNuevo.TabIndex = 42
        Me.btGuardarNuevo.Text = "&GUARGAR"
        Me.btGuardarNuevo.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(33, 58)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(19, 13)
        Me.Label17.TabIndex = 45
        Me.Label17.Text = "Id:"
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(108, 54)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(202, 20)
        Me.txt_id.TabIndex = 46
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(266, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(234, 20)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "MANTENIMIENTO EMPLEADO"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBoxCrearUser)
        Me.GroupBox2.Location = New System.Drawing.Point(661, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(206, 76)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS PARA INICIAR SECCION"
        '
        'CheckBoxCrearUser
        '
        Me.CheckBoxCrearUser.AutoSize = True
        Me.CheckBoxCrearUser.Enabled = False
        Me.CheckBoxCrearUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxCrearUser.Location = New System.Drawing.Point(11, 38)
        Me.CheckBoxCrearUser.Name = "CheckBoxCrearUser"
        Me.CheckBoxCrearUser.Size = New System.Drawing.Size(189, 17)
        Me.CheckBoxCrearUser.TabIndex = 0
        Me.CheckBoxCrearUser.Text = "Crear Usuario  para este empleado"
        Me.CheckBoxCrearUser.UseVisualStyleBackColor = True
        '
        'FormMantenimentoEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(879, 552)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btAgregar)
        Me.Controls.Add(Me.btEditar)
        Me.Controls.Add(Me.btActulizar)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btGuardarNuevo)
        Me.Controls.Add(Me.RbFemenina)
        Me.Controls.Add(Me.RbMasculino)
        Me.Controls.Add(Me.CbCondicion)
        Me.Controls.Add(Me.btvover)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbNacionalidad)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.DtpFechaSalida)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DtpFechaIngeso)
        Me.Controls.Add(Me.cbEstadoCivil)
        Me.Controls.Add(Me.DtpFechaNac)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDirrecion)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMantenimentoEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMantenimentoEmpleado"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDirrecion As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents DtpFechaNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbEstadoCivil As System.Windows.Forms.ComboBox
    Friend WithEvents DtpFechaIngeso As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFechaSalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbNacionalidad As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txttipousu As Label
    Friend WithEvents txtusu As Label
    Friend WithEvents txtid As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btvover As Button
    Friend WithEvents CbCondicion As ComboBox
    Friend WithEvents RbMasculino As RadioButton
    Friend WithEvents RbFemenina As RadioButton
    Friend WithEvents btAgregar As Button
    Friend WithEvents btEditar As Button
    Friend WithEvents btActulizar As Button
    Friend WithEvents btCancelar As Button
    Friend WithEvents btGuardarNuevo As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents ID As DataGridViewButtonColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBoxCrearUser As CheckBox
End Class
