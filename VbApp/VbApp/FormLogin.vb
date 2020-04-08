
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data

Public Class FormLogin
    Dim c As New ClassConexion()
    Dim clase As New ClassValidacion()


    '----BOTON ENTRAR-----
    Private Sub btEntar_Click(sender As Object, e As EventArgs) Handles btEntar.Click

        If (TxtUsu.Text = "Usuario") Then
            MessageBox.Show("Deve llenar el campo usuario")
        ElseIf (txtclave.Text = "contraseña") Then
            MessageBox.Show("Deve llenar el campo contraseña")
        Else
            loguear(TxtUsu.Text, clase.encriptar(txtclave.Text))
        End If


        '--------------OTRA FORMA DE HACERLO---------------
        'If String.IsNullOrEmpty(TxtUsu.Text.Trim()) Then

        '    MessageBox.Show("Deve llenar el campo usuario")
        'ElseIf String.IsNullOrEmpty(txtclave.Text.Trim()) Then

        '    MessageBox.Show("Deve llenar el campo contraseña")
        'Else
        '    '----PROBANDO EL ENCRYTADO-----
        '    'Dim pass As String = Convert.ToString(TextBox1.Text)
        '    'TextBox2.Text = clase.encriptar(pass)
        '    'TextBox3.Text = clase.desencritar(TextBox2.Text)
        '    loguear(TxtUsu.Text, clase.encriptar(txtclave.Text))
        'End If

    End Sub

    '---METODO DEL LOGIN----
    Sub loguear(usuario As String, contrasena As String)

        'Try
        'c.conn.Open()
        ' Dim cmd As New MySqlCommand("SELECT Id, Tipo_usuario, usuario FROM usuarios WHERE Usuario = @usuario AND Pwd = @pas", c.conn)
        Dim cmd As New MySqlCommand("SELECT  u.Id, u.Tipo_usuario, u.usuario, e.Condicion  FROM usuarios u, empleados e WHERE (u.Usuario = @usuario AND u.Pwd = @pas) AND (e.Id = u.Id_Empleado)", c.conn)
        cmd.Parameters.AddWithValue("usuario", usuario)
            cmd.Parameters.AddWithValue("pas", contrasena)
        Dim sda As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable()
        sda.Fill(dt)

        If (dt.Rows.Count = 1) Then

            ''A','L','V','S'
            '---- Usuario esta Activo -----
            If dt.Rows(0)(3).ToString = "A" Then


                'this.Hide()
                Me.Hide()
                If (dt.Rows(0)(1).ToString() = "Admin") Then

                    ' New useradmin_form2().Show objeto para llamar el formulario
                    'dt.Rows[0][0].ToString() consulata la posicion del nombre en la consulta sql y la covierte a string para enviar los paramatros del nombre al form "useradmin_form2" y al mismo tiempo lo abre .show..
                    Dim matEmp As New FormMenuPrincipal(dt.Rows(0)(0).ToString, dt.Rows(0)(1).ToString, dt.Rows(0)(2).ToString)
                    matEmp.Show()

                    'Try
                    '//INICIO SECCION CONTROL
                    'Dim comando As New MySqlCommand("INSERT INTO   historial_usuario  (Id_usuario, 	Accion, Hora, Fecha, sobre_registro_id ) VALUES ('" + dt.Rows(0)(0).ToString() + "', 'Inicio Seccion', '" + lbHora.Text + "', '" + lbFecha.Text + "', '" + dt.Rows(0)(0).ToString() + "'  );", c.conn)
                    '    comando.ExecuteNonQuery()

                    c.accionrealizada(dt.Rows(0)(0).ToString(), "INICIO SECCION", dt.Rows(0)(0).ToString())



                    'Catch ex As Exception
                    '    MessageBox.Show(ex.Message)
                    'End Try

                ElseIf (dt.Rows(0)(1).ToString() = "Normal")


                    Dim matEmp As New FormMenuPrincipal(dt.Rows(0)(0).ToString, dt.Rows(0)(1).ToString, dt.Rows(0)("usuario").ToString)
                    matEmp.Show()


                    '//INICIO SECCION CONTROL
                    'Dim comando As New MySqlCommand("INSERT INTO   fh_inicio_seccion  (Id_usuario, Accion, Hora, Fecha) VALUES ('" + dt.Rows(0)(0).ToString() + "', 'Inicio Seccion', '" + lbHora.Text + "', '" + lbFechaCorta.Text + "'  );", c.conn)


                    'Dim comando As New MySqlCommand("INSERT INTO   historial_usuario  (Id_usuario, 	Accion, Hora, Fecha, sobre_registro_id ) VALUES ('" + dt.Rows(0)(0).ToString() + "', 'Inicio Seccion', '" + lbHora.Text + "', '" + lbFecha.Text + "', '" + dt.Rows(0)(0).ToString() + "'  );", c.conn)
                    'comando.ExecuteNonQuery()
                    c.accionrealizada(dt.Rows(0)(0).ToString(), "INICIO SECCION", dt.Rows(0)(0).ToString())

                End If


                '---- Usuario Licencia, Vacasiones, Suspendido-----
            Else

                '-LICENCIA
                If dt.Rows(0)(3).ToString = "L" Then
                    c.accionrealizada(dt.Rows(0)(0).ToString(), "INTENTO INICIAR SECCION CON USUARIO DE LICENCIA", dt.Rows(0)(0).ToString())
                    MessageBox.Show("El usuario: " + dt.Rows(0)(2).ToString + " actualmente no tiene acceso al sistema por que se encuentrar de LICENCIA, si no es haci comuniquese con su superior para havilitar el usuario.... O si  usted no es esta persona y esta instentando acceder, recuerde que el sistema es monitoreado y esto puede traer consecuencias legales por espionaje corporativo. ")
                    '-VACASIONES
                ElseIf dt.Rows(0)(3).ToString = "V" Then
                    c.accionrealizada(dt.Rows(0)(0).ToString(), "INTENTO INICIAR SECCION CON USUARIO DE VACASIONES", dt.Rows(0)(0).ToString())
                    MessageBox.Show("El usuario: " + dt.Rows(0)(2).ToString + " actualmente no tiene acceso al sistema por que se encuentrar de VACASIONES, si no es haci comuniquese con su superior para havilitar el usuario.... O si  usted no es esta persona y esta instentando acceder, recuerde que el sistema es monitoreado y esto puede traer consecuencias legales por espionaje corporativo. ")
                    '-SUSPENDIDO
                ElseIf dt.Rows(0)(3).ToString = "S" Then
                    c.accionrealizada(dt.Rows(0)(0).ToString(), "INTENTO INICIAR SECCION CON USUARIO DE SUSPENDIDO", dt.Rows(0)(0).ToString())
                    MessageBox.Show("El usuario: " + dt.Rows(0)(2).ToString + " actualmente no tiene acceso al sistema por que se encuentrar de SUSPENDIDO, si no es haci comuniquese con su superior para havilitar el usuario.... O si  usted no es esta persona y esta instentando acceder, recuerde que el sistema es monitoreado y esto puede traer consecuencias legales por espionaje corporativo. ")
                End If
            End If

        Else

            '//MessageBox.Show("Usuario y/o Contraseña Incorrectos");
            '//this.tbuser.Text = "";
            '//this.tbclave.Text = "";

            '//ELSE MENSAJE DE ERROR
            'LbErrorPass.Visible = False;
            'LbErrorUsuario.Visible = False;
            'LbErrorLogin.Text = "Usuario y/o Contraseña incorrectos...";
            MessageBox.Show("Usuario y/o Contraseña incorrectos...")

            ' hablar()

            'If LbVoca.Text = " O" Then
            '    hablar()
            'ElseIf LbVoca.Text = "___" Then
            '    hablar()
            'End If
            ' LbVoca.BackColor = Color.DarkSlateGray




            'LbErrorLogin.Visible = True;

            '// txtuser.Text = "";
            '// txtpass.Text = "";
            '//txtpass.UseSystemPasswordChar = false;
            '//txtpass_Leave(null, e);
            '//txtuser_Leave(null, e);
            '// txtuser.Focus();
            '//FIN VALIDACION DE INCIO DE SECCION
        End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try


        '    Finally
        '    {

        '    }

        ' c.conn.Close()
        'fin del metodo logear
    End Sub


    '-----------FUNCION RELATIVA DE HABLAR--------------------
    Private Sub hablar()
        If LbVoca.Text = " O" Then
            LbVoca.Text = "___"
            RbOjo1.Checked = True
            RbOjo2.Checked = False
            hablar()
            LbVoca.BackColor = Color.Blue
        ElseIf LbVoca.Text = "___" Then
            LbVoca.Text = " O"
            RbOjo1.Checked = False
            RbOjo2.Checked = True
            hablar()
            LbVoca.BackColor = Color.Gray
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        '//lbHora.Text=DateTime.Now.ToLongTimeString();
        '// formato 24 horas lbHora.Text = DateTime.Now.ToString("HH:MM:SS");

        lbHora.Text = DateTime.Now.ToString("hh:mm:ss")
        '//lbFecha.Text = DateTime.Now.ToLongDateString();
        '//lbFecha.Text = DateTime.Now.ToShortDateString();
        lbFecha.Text = DateTime.Now.ToString("yyy-MM-dd")


        ' //lbHora.Text=DateTime.Now.ToLongTimeString();
        '// formato 24 horas lbHora.Text = DateTime.Now.ToString("HH:MM:SS");
        'lbHora.Text = DateTime.Now.ToString("hhmmss")
        'horaregistro.Text = DateTime.Now.ToString("hh:mm:ss")
        '//lbFecha.Text = DateTime.Now.ToLongDateString();
        '//lbFecha.Text = DateTime.Now.ToShortDateString();
        '//lbFecha.Text = DateTime.Now.ToString("dddd MMM yyy");
        'lbFecha.Text = DateTime.Now.ToString("yyy-MM-dd")
    End Sub

    Private Sub TxtUsu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUsu.KeyPress
        clase.SinEspacios(e)
    End Sub
    Private Sub txtclave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtclave.KeyPress
        clase.SinEspacios(e)
    End Sub

    Private Sub pass_visible_Click(sender As Object, e As EventArgs) Handles pass_visible.Click
        If (txtclave.UseSystemPasswordChar = False) Then
            txtclave.UseSystemPasswordChar = True
        Else
            txtclave.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub TxtUsu_Enter(sender As Object, e As EventArgs) Handles TxtUsu.Enter
        If (TxtUsu.Text = "Usuario") Then
            TxtUsu.Text = ""
            TxtUsu.ForeColor = Color.Black

        End If
    End Sub

    Private Sub TxtUsu_Leave(sender As Object, e As EventArgs) Handles TxtUsu.Leave
        If (TxtUsu.Text = "") Then
            TxtUsu.Text = "Usuario"
            TxtUsu.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtclave_Enter(sender As Object, e As EventArgs) Handles txtclave.Enter
        If (txtclave.Text = "contraseña") Then
            txtclave.Text = ""
            txtclave.ForeColor = Color.Black
            txtclave.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtclave_Leave(sender As Object, e As EventArgs) Handles txtclave.Leave
        If (txtclave.Text = "") Then
            txtclave.Text = "contraseña"
            txtclave.ForeColor = Color.LightGray
            txtclave.UseSystemPasswordChar = False
        End If
    End Sub


End Class
