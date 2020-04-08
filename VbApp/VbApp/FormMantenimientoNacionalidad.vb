Public Class FormMantenimientoNacionalidad
    Dim c As New ClassConexion()
    Dim clase As New ClassValidacion()

    'variables de seccion
    Dim id_usu As String
    Dim usu As String
    Dim tipo_usu As String

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

    Private Sub FormMantenimientoNacionalidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv.DataSource = c.mantenimiento("SELECT * FROM nacionalidades")
        llenarcombox()
    End Sub
    Dim IdS As String

    Sub llenarcombox()
        Dim dt As New DataTable()
        dt.Columns.Add("Estado")
        dt.Columns.Add("Valor")

        dt.Rows.Add("Activo", "1")
        dt.Rows.Add("Desativado", "0")
        cbEstado.DataSource = dt
        cbEstado.DisplayMember = "Estado"
        cbEstado.ValueMember = "Valor"
    End Sub


    Sub borrarDGV()
        If dgv.Rows.Count > 0 Then
            dgv.Rows.RemoveAt(dgv.Rows.Count - 1)
            borrarDGV()
        End If
    End Sub


    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If (e.ColumnIndex = 0) Then
            'Id =
            lbid.Text = dgv.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtNacionalidad.Text = dgv.Rows(e.RowIndex).Cells(1).Value.ToString()
            Dim estado As String = dgv.Rows(e.RowIndex).Cells(2).Value.ToString()

            'MessageBox.Show(cbEstado.SelectedValue)
            If estado = "True" Then
                cbEstado.Text = "Activo"
            ElseIf estado = "False" Then
                cbEstado.Text = "Desativado"
            End If
            '' cbEstado.SelectedItem = estado
            'cbEstado.SelectedValue = estado


        End If

    End Sub

    Private Sub btGuardarNuevo_Click(sender As Object, e As EventArgs) Handles btGuardarNuevo.Click
        If String.IsNullOrEmpty(txtNacionalidad.Text.Trim) Then
            MessageBox.Show("Deve llenar el campo nacionalidad")
        Else
            'falta validarlo
            Try
                dgv.DataSource = c.mantenimiento("INSERT INTO nacionalidades (Nombre, Estado) VALUES ('" + txtNacionalidad.Text + "','" + cbEstado.SelectedValue + "')")
                borrarDGV()
                dgv.DataSource = c.mantenimiento("SELECT * FROM nacionalidades")
                llenarcombox()

                btGuardarNuevo.Enabled = False
                txtNacionalidad.Enabled = False
                cbEstado.Enabled = False
                btEditar.Enabled = True
                btAgregar.Enabled = True
                btCancelar.Enabled = False



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        lbid.Text = ""
    End Sub

    Private Sub btAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        btGuardarNuevo.Enabled = True
        btEditar.Enabled = False
        btAgregar.Enabled = False
        txtNacionalidad.Enabled = True
        cbEstado.Enabled = True
        btCancelar.Enabled = True

        lbid.Clear()
        txtNacionalidad.Clear()
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        btCancelar.Enabled = False
        btGuardarNuevo.Enabled = False
        btActulizar.Visible = False
        txtNacionalidad.Enabled = False
        cbEstado.Enabled = False
        btEditar.Enabled = True
        btAgregar.Enabled = True
        btCancelar.Enabled = False

        lbid.Clear()
        txtNacionalidad.Clear()

    End Sub

    Private Sub btActulizar_Click(sender As Object, e As EventArgs) Handles btActulizar.Click
        'falta validarlo
        If String.IsNullOrEmpty(lbid.Text.Trim) Then
            MessageBox.Show("Deve selecionar el ID de el registro que desea editar de la lista")
        ElseIf String.IsNullOrEmpty(txtNacionalidad.Text.Trim) Then
            MessageBox.Show("Deve llenar el campo nacionalidad para poder editarlo")
        Else
            Try
                dgv.DataSource = c.mantenimiento("UPDATE nacionalidades SET Nombre='" + txtNacionalidad.Text + "', Estado='" + cbEstado.SelectedValue + "' WHERE Id= '" + lbid.Text + "' ")
                'historial de usuarios
                c.accionrealizada(id_usu, "ACTUALIZO NACIONALIDAD", lbid.Text)
                borrarDGV()
                dgv.DataSource = c.mantenimiento("SELECT * FROM nacionalidades")
                MessageBox.Show("se edito satisfatoriamente la nacionalidad de id = " & lbid.Text)
                llenarcombox()

                btActulizar.Visible = False
                txtNacionalidad.Enabled = False
                cbEstado.Enabled = False
                btEditar.Enabled = True
                btAgregar.Enabled = True
                btCancelar.Enabled = False


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        lbid.Text = ""
    End Sub


    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        btActulizar.Visible = True
        btEditar.Enabled = False
        btAgregar.Enabled = False
        txtNacionalidad.Enabled = True
        cbEstado.Enabled = True
        btCancelar.Enabled = True
    End Sub

    Private Sub btvover_Click(sender As Object, e As EventArgs) Handles btvover.Click
        Dim f1 As New FormMenuPrincipal(id_usu, tipo_usu, usu)
        f1.Show()
        Me.Hide()
    End Sub

    Private Sub txtNacionalidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNacionalidad.KeyPress
        txtNacionalidad.Text = clase.quitarDobleEspacio(txtNacionalidad)
    End Sub
End Class