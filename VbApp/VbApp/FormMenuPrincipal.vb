Public Class FormMenuPrincipal
    Dim c As New ClassConexion()

    'variables de seccion
    Dim id_usu As String
    Dim usu As String
    Dim tipo_usu As String

    'constructor
    Sub New(ByVal id As String, tipo_usuario As String, usuario As String)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        lbbienvenida.Text = ("Bienvenid@ " + usuario)
        id_usu = id
        usu = usuario
        tipo_usu = tipo_usuario
        txtid.Text = id
        txtusu.Text = usuario
        txttipousu.Text = tipo_usuario
    End Sub




    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        'boton cerrar
        Dim dialogo As DialogResult = MessageBox.Show("¿Está seguro " + usu + " que desea Cerrar la Seccion ?", "Cerrar el Seccion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dialogo = DialogResult.No) Then
            'no hagas nada....
        Else
            c.accionrealizada(id_usu, "CERROR SECCION", id_usu)
            ' MessageBox.Show("CERROR SECCION: " + usu)
            Dim f1 As New FormLogin()
            f1.Show()
            Me.Hide()
        End If


    End Sub

    Private Sub btEmpleado_Click(sender As Object, e As EventArgs) Handles btEmpleado.Click
        Dim f1 As New FormMantenimentoEmpleado(id_usu, tipo_usu, usu)
        f1.Show()
        Me.Hide()
    End Sub

    Private Sub btNacionalidades_Click(sender As Object, e As EventArgs) Handles btNacionalidades.Click
        Dim f1 As New FormMantenimientoNacionalidad(id_usu, tipo_usu, usu)
        f1.Show()
        Me.Hide()
    End Sub

    Private Sub btHitorial_Click(sender As Object, e As EventArgs) Handles btHitorial.Click
        MessageBox.Show("Esta ventana no esta disponible por el monento, Disculpe los inconvinientes", "INFORMACION DEL SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LbHora.Text = DateTime.Now.ToString("hh:mm:ss")
        LbFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub btInfo_Click(sender As Object, e As EventArgs) Handles btInfo.Click
        MessageBox.Show("Este programa fue creado por WARLIN ANT. SANO BAEZ, para Soporte Tecnicos llamar al TEl.: 829-329-0694. o comunicarse al correo: warlinsano@gmail.com.", "INFORMACION DEL SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btConfiguracion_Click(sender As Object, e As EventArgs) Handles btConfiguracion.Click
        MessageBox.Show("Esta ventana no esta disponible por el monento, Disculpe los inconvinientes", "INFORMACION DEL SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class