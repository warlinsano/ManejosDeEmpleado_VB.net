'----libreias-------------
Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.IO

Public Class FormMantenimentoEmpleado
    '---Instanciasion de clases----------
    Dim c As New ClassConexion()
    Dim clase As New ClassValidacion()

    '-----------variables de seccion-----------
    Dim id_usu As String
    Dim usu As String
    Dim tipo_usu As String

    '------constructor-----------
    Sub New(ByVal id As String, tipo_usuario As String, usuario As String)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        id_usu = id
        usu = usuario
        tipo_usu = tipo_usuario
        txtid.Text = id
        txtusu.Text = usuario
        txttipousu.Text = tipo_usuario
    End Sub

    '---------------- EVENTOS ------------------------
    Private Sub FormMantenimentoEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarcbNacionalidad()
        llenarcbEstadoCivil()
        llenarCbCondicion()
        llenarDgv()
        DesavilitarCampos()
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        clase.SoloLetras(e)
        txtNombre.MaxLength = 40
        clase.quitarDobleEspacio(txtNombre)
    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        clase.SoloLetras(e)
        txtApellido.MaxLength = 40
        clase.quitarDobleEspacio(txtApellido)
    End Sub

    Private Sub txtCedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCedula.KeyPress
        clase.SoloNumero(e)
        'clase.quitarEspacio(txtCedula)
        clase.SinEspacios(e)
        txtCedula.MaxLength = 11
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        clase.SoloNumero(e)
        clase.SinEspacios(e)
        txtTelefono.MaxLength = 10
    End Sub
    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        txtEmail.MaxLength = 60
    End Sub


    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        '---GENERO O SEXO----
        Dim Genero As Char = ""
        If (e.ColumnIndex = 0) Then
            'Id =
            'SELECT Id, Nombre, Apellido, Cedula, Fecha_Nacimiento, Telefono, Estado_civil, Genero, Direccion, Email, Condicion, Fecha_Ingreso, Fecha_Salida, Id_Nacionalida FROM empleados
            txt_id.Text = dgv.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtNombre.Text = dgv.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtApellido.Text = dgv.Rows(e.RowIndex).Cells(2).Value.ToString()
            txtCedula.Text = dgv.Rows(e.RowIndex).Cells(3).Value.ToString()
            DtpFechaNac.Value = dgv.Rows(e.RowIndex).Cells(4).Value.ToString 'revisar sino le ponemos text
            txtTelefono.Text = dgv.Rows(e.RowIndex).Cells(5).Value.ToString()
            cbEstadoCivil.SelectedValue = dgv.Rows(e.RowIndex).Cells(6).Value.ToString() 'revisar
            Genero = dgv.Rows(e.RowIndex).Cells(7).Value.ToString        'genero.........................
            txtDirrecion.Text = dgv.Rows(e.RowIndex).Cells(8).Value.ToString()
            txtEmail.Text = dgv.Rows(e.RowIndex).Cells(9).Value.ToString()
            CbCondicion.SelectedValue = dgv.Rows(e.RowIndex).Cells(10).Value.ToString() 'revisar
            DtpFechaIngeso.Text = dgv.Rows(e.RowIndex).Cells(11).Value.ToString()
            DtpFechaSalida.Text = dgv.Rows(e.RowIndex).Cells(12).Value.ToString()

            cbNacionalidad.SelectedValue = dgv.Rows(e.RowIndex).Cells(13).Value.ToString() 'revisar

            If (Genero = "M") Then  '---HOMBRE
                RbMasculino.Checked = True
            ElseIf (Genero = "F") Then  '----MUJER  
                RbFemenina.Checked = True
            End If
            'Dim estado As String = dgv.Rows(e.RowIndex).Cells(2).Value.ToString()

            ''MessageBox.Show(cbEstado.SelectedValue)
            'If estado = "True" Then
            '    cbEstado.Text = "Activo"
            'ElseIf estado = "False" Then
            '    cbEstado.Text = "Desativado"
            'End If
            ''' cbEstado.SelectedItem = estado
            ''cbEstado.SelectedValue = estado

        End If
    End Sub



    '----METODOS ------------
    Sub borrarDGV()
        If dgv.Rows.Count > 0 Then
            dgv.Rows.RemoveAt(dgv.Rows.Count - 1)
            borrarDGV()
        End If
    End Sub


    '-------------- LLENAR COMBOX --------------
    Sub llenarcbNacionalidad()
        Try
            'conn.Open();
            Dim comando As New MySqlCommand("SELECT Id, Nombre, Estado FROM nacionalidades WHERE Estado=1 ", c.conn)
            Dim adactador As New MySqlDataAdapter(comando)
            Dim dt As New DataTable()
            adactador.Fill(dt)

            cbNacionalidad.DisplayMember = "Nombre"
            cbNacionalidad.ValueMember = "Id" 'indentificador
            cbNacionalidad.DataSource = dt
            cbNacionalidad.SelectedIndex = -1    'opcional
            'conn.Close();
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '---'S','C','D','V'
    Sub llenarcbEstadoCivil()
        Dim dt As New DataTable()
        dt.Columns.Add("Estado")
        dt.Columns.Add("Valor")

        dt.Rows.Add(" ", "")
        dt.Rows.Add("SOLTERO", "S")
        dt.Rows.Add("CASADO", "C")
        dt.Rows.Add("DIVORSIADO", "D")
        dt.Rows.Add("VIUDO", "V")
        cbEstadoCivil.DataSource = dt
        cbEstadoCivil.DisplayMember = "Estado"
        cbEstadoCivil.ValueMember = "Valor"
    End Sub

    '--- 'A','L','V','S'
    Sub llenarCbCondicion()
        Dim dt As New DataTable()
        dt.Columns.Add("Estado")
        dt.Columns.Add("Valor")

        dt.Rows.Add(" ", "")
        dt.Rows.Add("ACTIVO", "A")
        dt.Rows.Add("LICENCIA", "L")
        dt.Rows.Add("VACACIONES", "V")
        dt.Rows.Add("SUSPENDIDO", "S")
        CbCondicion.DataSource = dt
        CbCondicion.DisplayMember = "Estado"
        CbCondicion.ValueMember = "Valor"
    End Sub

    Sub llenarDgv()
        llenarcbNacionalidad()
        llenarcbEstadoCivil()
        llenarCbCondicion()
        'SELECT Id, Nombre, Apellido, Cedula, Fecha_Nacimiento, Telefono, Estado_civil, Genero, Direccion, Email, Condicion, Fecha_Ingreso, Fecha_Salida, Id_Nacionalida FROM empleados
        dgv.DataSource = c.mantenimiento("SELECT Id, Nombre, Apellido, Cedula, Fecha_Nacimiento, Telefono, Estado_civil, Genero, Direccion, Email, Condicion, Fecha_Ingreso, Fecha_Salida, Id_Nacionalida FROM empleados")
    End Sub

    Sub HabilitarCampos()
        txt_id.Enabled = True
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        txtCedula.Enabled = True
        DtpFechaNac.Enabled = True
        txtTelefono.Enabled = True
        cbEstadoCivil.Enabled = True
        cbNacionalidad.Enabled = True
        RbMasculino.Enabled = True
        RbFemenina.Enabled = True
        txtDirrecion.Enabled = True
        txtEmail.Enabled = True
        CbCondicion.Enabled = True
        DtpFechaIngeso.Enabled = True
        DtpFechaSalida.Enabled = True
    End Sub

    Sub DesavilitarCampos()
        txt_id.Enabled = False
        txtNombre.Enabled = False
        txtApellido.Enabled = False
        txtCedula.Enabled = False
        DtpFechaNac.Enabled = False
        txtTelefono.Enabled = False
        cbEstadoCivil.Enabled = False
        cbNacionalidad.Enabled = False
        RbMasculino.Enabled = False
        RbFemenina.Enabled = False
        txtDirrecion.Enabled = False
        txtEmail.Enabled = False
        CbCondicion.Enabled = False
        DtpFechaIngeso.Enabled = False
        DtpFechaSalida.Enabled = False
    End Sub

    Sub LimpiarCampos()
        txt_id.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtCedula.Clear()
        DtpFechaNac.ResetText()
        txtTelefono.Clear()
        cbEstadoCivil.Text = ""
        cbNacionalidad.Text = ""
        RbMasculino.Checked = False
        RbFemenina.Checked = False
        txtDirrecion.Clear()
        txtEmail.Clear()
        CbCondicion.Text = ""
        DtpFechaIngeso.Text = ""
        DtpFechaSalida.Text = ""

    End Sub

    '----------Eventos de Botones----------------
    Private Sub btGuardarNuevo_Click(sender As Object, e As EventArgs) Handles btGuardarNuevo.Click
        '---GENERO O SEXO----
        Dim Genero As Char = ""
        If (RbMasculino.Checked = True) Then  '---HOMBRE
            Genero = "M"
        ElseIf (RbFemenina.Checked = True) Then  '----MUJER  
            Genero = "F"
        End If


        If String.IsNullOrEmpty(txtNombre.Text.Trim) Then
            MessageBox.Show("Deve llenar el campo nombre")
            txtNombre.Focus()
        ElseIf String.IsNullOrEmpty(txtApellido.Text.Trim) Then
            MessageBox.Show("Deve llenar el campo apellido")
            txtApellido.Focus()
        ElseIf String.IsNullOrEmpty(txtCedula.Text.Trim) Then
            MessageBox.Show("Deve llenar el campo cedula")
            txtCedula.Focus()
            'ElseIf String.IsNullOrEmpty(DtpFechaNac.Text.Trim) Then
            '    MessageBox.Show("Deve  seleccionar la fecha de nacimiento")
            '    DtpFechaNac.Focus()
        ElseIf String.IsNullOrEmpty(txtTelefono.Text.Trim) Then
            MessageBox.Show("Deve llenar el campo telefono")
            txtTelefono.Focus()
        ElseIf String.IsNullOrEmpty(cbEstadoCivil.Text.Trim) Then
            MessageBox.Show("Deve seleccionar un Estado Civil")
            cbEstadoCivil.Focus()
        ElseIf String.IsNullOrEmpty(cbNacionalidad.Text.Trim) Then
            MessageBox.Show("Deve seleccionar una  nacionalidad")
            cbNacionalidad.Focus()

        ElseIf (RbMasculino.Checked = False And RbFemenina.Checked = False) Then
            MessageBox.Show("Deve seleccionar el sexo ")
            '  RbMasculino.Focus()
        ElseIf String.IsNullOrEmpty(txtDirrecion.Text.Trim) Then
            MessageBox.Show("Deve llenar el campo Direccion")
            txtDirrecion.Focus()
        ElseIf String.IsNullOrEmpty(txtEmail.Text.Trim) Then
            MessageBox.Show("Deve llenar el campo Email")
            txtEmail.Focus()
        ElseIf String.IsNullOrEmpty(CbCondicion.Text.Trim) Then
            MessageBox.Show("Deve seleccionar una condicion")
            CbCondicion.Focus()
        Else
            Try
                ' cbNacionalidad.SelectedValue.trim()


                ' dgv.DataSource = c.mantenimiento("INSERT INTO empleados (Nombre,Apellido,Cedula,Fecha_Nacimiento,Telefono,Estado_civil,Genero,Direccion,Email,Condicion,Fecha_Ingreso,Fecha_Salida,Id_Nacionalida) VALUES ('" + txtNombre.Text.Trim() + "','" + txtApellido.Text.Trim() + "','" + txtCedula.Text + "','" + DtpFechaNac.Value.ToString("yyyy-MM-dd") + "','" + txtTelefono.Text + "','" + cbEstadoCivil.SelectedValue + "','" + Genero + "','" + txtDirrecion.Text + " ','" + txtEmail.Text.Trim() + "','" + CbCondicion.SelectedValue + "','" + DtpFechaIngeso.Value.ToString("yyyy-MM-dd") + "','" + DtpFechaSalida.Value.ToString("yyyy-MM-dd") + "'," + Convert.ToString(cbNacionalidad.SelectedValue) + ")")

                dgv.DataSource = c.mantenimiento("INSERT INTO empleados (Nombre,Apellido,Cedula,Fecha_Nacimiento,Telefono,Estado_civil,Genero,Direccion,Email,Condicion,Fecha_Ingreso,Id_Nacionalida) VALUES ('" + txtNombre.Text.Trim() + "','" + txtApellido.Text.Trim() + "','" + txtCedula.Text + "','" + DtpFechaNac.Value.ToString("yyyy-MM-dd") + "','" + txtTelefono.Text + "','" + cbEstadoCivil.SelectedValue + "','" + Genero + "','" + txtDirrecion.Text + " ','" + txtEmail.Text.Trim() + "','" + CbCondicion.SelectedValue + "','" + DtpFechaIngeso.Value.ToString("yyyy-MM-dd") + "'," + Convert.ToString(cbNacionalidad.SelectedValue) + ")")

                'INSERT INTO empleados (Nombre,Apellido,Cedula,Fecha_Nacimiento,Telefono,Estado_civil,Genero,Direccion,Email,Condicion,Fecha_Ingreso,Id_Nacionalida) VALUES ('will','Baez','00115747','1989-04-21','8095697044','S','M','bani ','will@gmail.com','A','2015-03-08',1)
                'historial de usuarios
                borrarDGV()
                llenarDgv()
                c.accionrealizada(id_usu, "INSERTO EMPLEADO", "0")
                llenarcbNacionalidad()
                llenarcbEstadoCivil()
                llenarCbCondicion()


                btGuardarNuevo.Enabled = False
                'txtNacionalidad.Enabled = False
                'cbEstado.Enabled = False
                btEditar.Enabled = True
                btAgregar.Enabled = True
                btCancelar.Enabled = False
                MessageBox.Show("se inserto el empleado satisfactoriamente... ")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            'MessageBox.Show("ok...")

        End If
        txt_id.Clear()
        borrarDGV()
        llenarDgv()

    End Sub
    '--------------BOTON AGREGAR-----------
    Private Sub btAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        btGuardarNuevo.Enabled = True
        btCancelar.Enabled = True
        btEditar.Enabled = False
        btAgregar.Enabled = False

        LimpiarCampos()
        HabilitarCampos()


    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        btCancelar.Enabled = False
        btGuardarNuevo.Enabled = False
        btActulizar.Visible = False

        btEditar.Enabled = True
        btAgregar.Enabled = True
        btCancelar.Enabled = False

 

        LimpiarCampos()
        DesavilitarCampos()

    End Sub

    Private Sub btActulizar_Click(sender As Object, e As EventArgs) Handles btActulizar.Click

        '---GENERO O SEXO----
        Dim Genero As Char = ""
        If (RbMasculino.Checked = True) Then  '---HOMBRE
            Genero = "M"
        ElseIf (RbFemenina.Checked = True) Then  '----MUJER  
            Genero = "F"
        End If

        If String.IsNullOrEmpty(txt_id.Text.Trim) Then
            MessageBox.Show("Deve selecionar elel registro que desea editar de la lista")
        ElseIf String.IsNullOrEmpty(txtNombre.Text.Trim) Then
            MessageBox.Show("Deve llenar el campo nombre")
            txtNombre.Focus()
        ElseIf String.IsNullOrEmpty(txtApellido.Text.Trim) Then
            MessageBox.Show("Deve llenar el campo apellido")
            txtApellido.Focus()
        ElseIf String.IsNullOrEmpty(txtCedula.Text.Trim) Then
            MessageBox.Show("Deve llenar el campo cedula")
            txtCedula.Focus()
            'ElseIf String.IsNullOrEmpty(DtpFechaNac.Text.Trim) Then
            '    MessageBox.Show("Deve  seleccionar la fecha de nacimiento")
            '    DtpFechaNac.Focus()
        ElseIf String.IsNullOrEmpty(txtTelefono.Text.Trim) Then
            MessageBox.Show("Deve llenar el campo telefono")
            txtTelefono.Focus()
        ElseIf String.IsNullOrEmpty(cbEstadoCivil.Text.Trim) Then
            MessageBox.Show("Deve seleccionar un Estado Civil")
            cbEstadoCivil.Focus()
        ElseIf String.IsNullOrEmpty(cbNacionalidad.Text.Trim) Then
            MessageBox.Show("Deve seleccionar una  nacionalidad")
            cbNacionalidad.Focus()

        ElseIf (RbMasculino.Checked = False And RbFemenina.Checked = False) Then
            MessageBox.Show("Deve seleccionar el sexo ")
            '  RbMasculino.Focus()
        ElseIf String.IsNullOrEmpty(txtDirrecion.Text.Trim) Then
            MessageBox.Show("Deve llenar el campo Direccion")
            txtDirrecion.Focus()
        ElseIf String.IsNullOrEmpty(txtEmail.Text.Trim) Then
            MessageBox.Show("Deve llenar el campo Email")
            txtEmail.Focus()
        ElseIf String.IsNullOrEmpty(CbCondicion.Text.Trim) Then
            MessageBox.Show("Deve seleccionar una condicion")
            CbCondicion.Focus()
        Else
            Try

                dgv.DataSource = c.mantenimiento("UPDATE empleados SET Nombre='" + txtNombre.Text.Trim() + "',Apellido='" + txtApellido.Text.Trim() + "',Cedula='" + txtCedula.Text + "',Fecha_Nacimiento='" + DtpFechaNac.Value.ToString("yyyy-MM-dd") + "',Telefono='" + txtTelefono.Text + "',Estado_civil='" + cbEstadoCivil.SelectedValue + "',Genero='" + Genero + "',Direccion='" + txtDirrecion.Text + " ',Email='" + txtEmail.Text.Trim() + "',Condicion='" + CbCondicion.SelectedValue + "',Fecha_Ingreso='" + DtpFechaIngeso.Value.ToString("yyyy-MM-dd") + "',Fecha_Salida='" + DtpFechaSalida.Value.ToString("yyyy-MM-dd") + "',Id_Nacionalida=" + Convert.ToString(cbNacionalidad.SelectedValue) + " WHERE Id= '" + txt_id.Text + "' ")
                'historial de usuarios
                c.accionrealizada(id_usu, "ACTUALIZO EMPLEADO", txt_id.Text)

                If CheckBoxCrearUser.Checked = True Then
                    Dim usuarioLoguin As String = (clase.NingunEspacio(txtNombre) + txt_id.Text)

                    Dim dt As New DataTable()
                    dt = c.mantenimiento("SELECT * FROM usuarios WHERE Id_Empleado= '" + txt_id.Text + "' ")
                    If (dt.Rows.Count = 0) Then
                        dgv.DataSource = c.mantenimiento("INSERT INTO usuarios (Id_Empleado, Usuario, Pwd, Estado, Tipo_usuario) VALUES ('" + txt_id.Text + "','" + usuarioLoguin + "','" + clase.encriptar(usuarioLoguin) + "','1','Normal' ) ")
                        c.accionrealizada(id_usu, "CREO USUARIO", txt_id.Text)
                        MessageBox.Show("Se creo el usuaruario para el empleado id = " & txt_id.Text & " su credenciales son USUARIO: " & usuarioLoguin & " Y CLAVE: " & usuarioLoguin & " SE RECOMIENDA CAMBIAR LA CALVE EN SU PRIMER INICIO DE SECCION..", "INFORMACION DEL SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("ESTE EMPLEADO YA POSEE UN USUARIO...", "INFORMACION DEL SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If



                End If

                borrarDGV()
                llenarcbNacionalidad()
                llenarcbEstadoCivil()
                llenarCbCondicion()
                llenarDgv()

                btActulizar.Visible = False
                'txtNacionalidad.Enabled = False
                'cbEstado.Enabled = False
                btEditar.Enabled = True
                btAgregar.Enabled = True
                btCancelar.Enabled = False



                MessageBox.Show("se edito satisfatoriamente la el empleado de id = " & txt_id.Text)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        LimpiarCampos()
        DesavilitarCampos()
    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        btActulizar.Visible = True
        btEditar.Enabled = False
        btAgregar.Enabled = False
        'txtNacionalidad.Enabled = True
        'cbEstado.Enabled = True
        btCancelar.Enabled = True

        CheckBoxCrearUser.Checked = False
        CheckBoxCrearUser.Enabled = True

        LimpiarCampos()
        HabilitarCampos()
    End Sub

    Private Sub btvover_Click(sender As Object, e As EventArgs) Handles btvover.Click
        Dim f1 As New FormMenuPrincipal(id_usu, tipo_usu, usu)
        f1.Show()
        Me.Hide()
    End Sub

End Class