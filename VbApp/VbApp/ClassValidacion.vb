Public Class ClassValidacion

    'funcion vacio...
    Function Vacio(texto As String, msj_error As String) As Boolean
        If (IsNothing(texto)) Then
            Throw New Exception(msj_error)
            Return False
        Else
            Return True
        End If
    End Function

    'Validacion de doble espacios..  Funcion Recursiva
    Function quitarDobleEspacio(t As TextBox) As String
        t.Text = t.Text.TrimStart()
        If (t.Text.Contains("  ")) Then
            t.Text = t.Text.Replace("  ", " ")
            quitarDobleEspacio(t)
        End If
        Return t.Text
    End Function

    'metodo de encritar
    Function encriptar(cadena As String) As String
        Dim resultado As String = String.Empty
        Dim textoEncriptar As Byte() = System.Text.Encoding.Unicode.GetBytes(cadena)
        resultado = Convert.ToBase64String(textoEncriptar)
        Return resultado
    End Function


    'metodo de desencritar     
    Function desencritar(cadena As String) As String
        Dim resultado As String = String.Empty
        Dim textodesencritar As Byte() = Convert.FromBase64String(cadena)
        resultado = System.Text.Encoding.Unicode.GetString(textodesencritar)
        Return resultado
    End Function


    'Metodo de solo letras
    Public Sub SoloLetras(e As KeyPressEventArgs)
        Try
            If (Char.IsLetter(e.KeyChar)) Then
                e.Handled = False
            ElseIf (Char.IsControl(e.KeyChar))
                e.Handled = False
            ElseIf (Char.IsSeparator(e.KeyChar))
                e.Handled = False
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    'Metodo de solo numero
    Public Sub SoloNumero(e As KeyPressEventArgs)
        Try
            If (Char.IsNumber(e.KeyChar)) Then
                e.Handled = False
            ElseIf (Char.IsControl(e.KeyChar))
                e.Handled = False
            ElseIf (Char.IsSeparator(e.KeyChar))
                '  e.Handled = False
                e.Handled = True
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Metodo de sin espacios
    Public Sub SinEspacios(e As KeyPressEventArgs)
        Try
            If (Char.IsSeparator(e.KeyChar)) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Validacion de doble espacios..  Funcion Recursiva
    Function NingunEspacio(t As TextBox) As String
        t.Text = t.Text.TrimStart()
        If (t.Text.Contains("  ")) Then
            t.Text = t.Text.Replace(" ", "")
            quitarDobleEspacio(t)
        End If
        Return t.Text
    End Function

    'metodo de validar cedula
    Sub validarCedula(valorCedula As Integer)
        ' Dim menu As Integer = 1
        'Do
        '        Console.Clear()

        '        Console.WriteLine("                   *********************************      ")
        '        Console.WriteLine("               **  **** Creado por WARLIN SANO  ****   ** ")
        '        Console.WriteLine("                   *********************************      ")
        '        Console.WriteLine(" ")
        '        Console.WriteLine("            ************************************************** ")
        '        Console.WriteLine("            ** VALIDACION DE LA CEDULA  EN VISUAL BASIC.NET ** ")
        '        Console.WriteLine("            ************************************************** ")
        '        Console.WriteLine(" ")

        '        Dim Cedula, tmp As String
        'Dim temporal As Integer
        'Dim longitud As String
        'Dim n As Integer = 0
        'Dim ultimo As Integer = 0

        '        Console.Write(" - Por Favor Digite su Cedula de Identidad y Electoral---: ")
        '        Cedula = Console.ReadLine()

        '        If Cedula.Length < 11 Then
        '            Console.WriteLine(" ")
        '            Console.WriteLine(" ********************************* ")
        '            Console.WriteLine(" * La Cedula esta incompleta...  * ")
        '            Console.WriteLine(" ********************************* ")
        '            Console.ReadKey()
        '        Else

        'For conteo As Integer = 0 To Cedula.Length - 2
        '                ultimo = Convert.ToInt64(Cedula(10).ToString)
        '                If conteo Mod 2 = 0 Then
        '                    '  es par
        '                    temporal = Convert.ToInt64(Cedula(conteo).ToString) * 1
        '                Else
        '                    ' es impar
        '                    temporal = Convert.ToInt64(Cedula(conteo).ToString) * 2
        '                End If

        'For c As Integer = 0 To (temporal.ToString).Length - 1
        '                    tmp = temporal.ToString
        '                   n = n + Convert.ToInt64(tmp(c).ToString)                     
        '                Next

        'Next
        '            tmp = n.ToString                
        '            'VALIDACION DE SI QUEDA EN LA DESENA
        '            If tmp(1).ToString <> 0 Then

        '                Cedula = (Convert.ToInt64(tmp(0).ToString) + 1) * 10
        '                tmp = ""
        '                For c As Integer = 2 To (n.ToString).Length - 1
        '                    tmp = "0" + tmp
        '                Next
        '                Cedula = Convert.ToInt64(Cedula & tmp)

        '            End If
        '            Cedula = Cedula - n
        '            If Cedula = ultimo Then

        '                Console.WriteLine("  ")
        '                Console.WriteLine(" *********************** ")
        '                Console.WriteLine(" * LA CEDULA ES VALIDA *")
        '                Console.WriteLine(" *********************** ")
        '                Console.WriteLine("  ")

        '                Console.WriteLine("       *  *  *  *                     *          ")
        '                Console.WriteLine("    *  ---   ---   *                 *           ")
        '                Console.WriteLine("   *    ^     ^     *               *            ")
        '                Console.WriteLine("   *                *              *             ")
        '                Console.WriteLine("   *       v        *        *    *              ")
        '                Console.WriteLine("    *              *          *  *               ")
        '                Console.WriteLine("      *  *   *   *             *                 ")


        '            Else
        '                Console.WriteLine("  ")
        '                Console.WriteLine(" ************************** ")
        '                Console.WriteLine(" * LA CEDULA NO ES VALIDA *")
        '                Console.WriteLine(" ************************** ")
        '                Console.WriteLine("  ")

        '                Console.WriteLine("       *  *  *  *         *        *     ")
        '                Console.WriteLine("    *  ---   ----  *        *    *      ")
        '                Console.WriteLine("   *    O     O     *         * *       ")
        '                Console.WriteLine("   *                *         * *       ")
        '                Console.WriteLine("   *       o        *        *   *      ")
        '                Console.WriteLine("    *              *        *     *     ")
        '                Console.WriteLine("      *  *   *   *         *       *    ")

        '            End If
        '            Console.ReadKey()
        '            Console.Clear()
        '            Console.WriteLine("  ")
        '            Console.WriteLine(" ************************** ")
        '            Console.WriteLine(" *    DESEA SALIR?        *")
        '            Console.WriteLine(" ************************** ")
        '            Console.WriteLine("  ")
        '            Console.WriteLine(" 0 - SI      ")
        '            Console.WriteLine(" 1 - NO       ")
        '            Console.WriteLine("  ")
        '            Console.Write(" Elija # de la Opcion Deseada----: ")
        '            menu = Console.ReadLine()
        '        End If

        'Loop Until menu = 0
    End Sub


End Class
