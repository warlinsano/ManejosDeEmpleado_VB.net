Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.IO


Public Class ClassConexion

    Dim c As String = "server=172.16.0.2; userid=warlin; password=warlin1234; database=dbwarlin;"
    Public conn As New MySqlConnection(c)
    Dim dt As New DataTable()
    Dim da As New MySqlDataAdapter()


    Public Function mantenimiento(querry As String) As DataTable
        Try
            Dim cmd = conn.CreateCommand()
            cmd.CommandText = querry
            da.SelectCommand = cmd
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            '  Throw New Exception("ERROR EN LA CONSULTA EN LA DB")
        End Try
    End Function




    Public Function loguin(user As String, pwd As String) As Boolean
        Try
            Dim cmd = conn.CreateCommand()
            cmd.CommandText = "SELECT * FROM usuarios WHERE Usuario= @USU AND Pwd= @CLAVE "
            cmd.Parameters.AddWithValue("@USU", user)
            cmd.Parameters.AddWithValue("@CLAVE", pwd)
            da.SelectCommand = cmd
            da.Fill(dt)

            If dt.Rows.Count = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception("USUARIO O CLAVE NO VALIDO")
        End Try

    End Function

    '     Dim c As New ClassConexion()
    '      DtGv.DataSource = c.motrar()

    '"Select * from usuario where usuario= @user and clave= @pass"
    'cmd.Parameters.AddWithValue("@user", user)
    'cmd.Parameters.AddWithValue("@pass", pass)


    '------------------------------------------
    '----------------------------------------
    ' Try
    '    Process.Start("http://www.microsoft.com")
    'Catch ex As Exception
    '    MsgBox("Can't load Web page" & vbCrLf & ex.Message)
    'End Try




    'metodo que registra la accion del usuario o el historial
    Sub accionrealizada(user As String, accion As String, sobreId As String)
        Try
            conn.Open()
            'MessageBox.Show(DateTime.Now.ToString("yyy-MM-dd"))
            'MySqlCommand cmd = New MySqlCommand("INSERT INTO   fh_inicio_seccion  (Id_usuario, Accion, Hora_cierre_seccion, Fecha_cierre_seccion ) VALUES ('" + LbIDUser.Text + "', 'Cerro Seccion', '" + lbHora.Text + "', '" + lbFechaCorta.Text + "'  );", conn);
            Dim cmd As New MySqlCommand("INSERT INTO   historial_usuario  (Id_usuario, 	Accion, Hora, Fecha, sobre_registro_id ) VALUES (@usu, @accion1, '" + DateTime.Now.ToString("hh:mm:ss") + "', '" + DateTime.Now.ToString("yyy-MM-dd") + "',  @sobre_Id );", conn)
            cmd.Parameters.AddWithValue("usu", user)
            cmd.Parameters.AddWithValue("accion1", accion)
            cmd.Parameters.AddWithValue("sobre_Id", sobreId)
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'Throw New Exception("USUARIO O CLAVE NO VALIDO")
            conn.Close()
        End Try
    End Sub


    'Private CadenaConexion As String = "server=172.16.0.2; userid=warlin; pass=warlin1234; database=dbwarlin;"
    'Private Conexion As New MySqlConnection(CadenaConexion)

    'Public Function AbriConexion() As MySqlConnection
    '    If (Conexion.State = ConnectionState.Closed) Then
    '        Conexion.Open()
    '    End If
    '    Return Conexion
    'End Function


    'Public Function CerrarConexion() As MySqlConnection
    '    If (Conexion.State = ConnectionState.Open) Then
    '        Conexion.Close()
    '    End If
    '    Return Conexion
    'End Function


End Class
