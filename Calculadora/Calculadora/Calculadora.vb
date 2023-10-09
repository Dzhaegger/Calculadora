'Tarea II Programación II "Calculadora Básica"
'Jefferson Saldaña Castro 2023
Public Class Calculadora
    Dim operacion As String
    Dim resultado As Double
    Dim mouseOffset As Point

    ' Manejar el evento pnlbarra del ToolStrip (barra de título)
    Private Sub pnlbarra_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlbarra.MouseDown
        If e.Button = MouseButtons.Left Then
            mouseOffset = New Point(-e.X, -e.Y)
        End If
    End Sub

    ' Manejar el evento pnlbarra para arrastrar el formulario
    Private Sub pnlbarra_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlbarra.MouseMove
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    'Las siguientes funciones se encargan de imprimir los operadores
    'Suma,resta,multiplicación,división...
    Private Sub btnsumar_Click(sender As Object, e As EventArgs) Handles btnsumar.Click
        txtpantalla.Text &= " + "
        operacion = "+"
    End Sub
    Private Sub btnrestar_Click(sender As Object, e As EventArgs) Handles btnrestar.Click

        txtpantalla.Text &= " - "
        operacion = "-"
    End Sub

    Private Sub btnmultiplicar_Click(sender As Object, e As EventArgs) Handles btnmultiplicar.Click

        txtpantalla.Text &= " * "
        operacion = "*"
    End Sub

    Private Sub btndividir_Click(sender As Object, e As EventArgs) Handles btndividir.Click

        txtpantalla.Text &= " / "
        operacion = "/"
    End Sub

    'Minimizar el programa
    Private Sub btnminimizar_Click(sender As Object, e As EventArgs) Handles btnminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Cerrar el programa
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    'Borrar digito por digito
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If txtpantalla.Text.Length > 0 Then
            txtpantalla.Text = txtpantalla.Text.Substring(0, txtpantalla.Text.Length - 1)
        End If
    End Sub

    'Limpiar la calculadora
    Private Sub btnwipe_Click(sender As Object, e As EventArgs) Handles btnwipe.Click
        txtpantalla.Clear()
    End Sub

    'Se encarga de imprimir el teclado numérico
    Private Sub btnNumero_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        Dim boton As Button = DirectCast(sender, Button)
        txtpantalla.Text &= boton.Text
    End Sub

    Private Sub btndecimal_Click(sender As Object, e As EventArgs) Handles btndecimal.Click
        ' Verifica si el cuadro de texto ya contiene un punto decimal o una coma
        If Not txtpantalla.Text.Contains(".") AndAlso Not txtpantalla.Text.Contains(",") Then
            ' Verifica si el cuadro de texto está vacío
            If String.IsNullOrEmpty(txtpantalla.Text) Then
                ' Si está vacío, agrega un 0 antes de la coma
                txtpantalla.Text = "0,"
            Else
                ' De lo contrario, simplemente agrega la coma
                txtpantalla.Text &= ","
            End If
        End If
    End Sub

    Private Sub btnOperador_Click(sender As Object, e As EventArgs) Handles btnsumar.Click, btnrestar.Click, btnmultiplicar.Click, btndividir.Click
        ' Verifica si el cuadro de texto está vacío
        If String.IsNullOrWhiteSpace(txtpantalla.Text) Then
            ' Muestra un mensaje de error
            MsgBox("Ingrese un número antes de seleccionar una operación.")
            Return ' Salir del método sin hacer ninguna operación
        End If

        ' Obtiene el operador del botón que desencadenó el evento
        Dim botonOperador As Button = DirectCast(sender, Button)
        Dim operador As String = botonOperador.Text

        ' Muestra el operador en la pantalla
        txtpantalla.Text &= operador

        ' Almacena el operador para su posterior uso
        operacion = operador
    End Sub

    'Resultado de operación
    Private Sub btnequal_Click(sender As Object, e As EventArgs) Handles btnequal.Click
        If String.IsNullOrWhiteSpace(txtpantalla.Text) Then
            ' Muestra un mensaje de error
            MsgBox("Ingrese una expresión antes de realizar un cálculo.")
            Return ' Salir del método sin hacer ninguna operación
        End If

        Try
            Dim expresion As String = txtpantalla.Text.Replace(",", ".")
            Dim dt As DataTable = New DataTable()
            Dim resultadoExpresion As Double = CDbl(dt.Compute(expresion, ""))

            ' En lugar de mostrar el resultado en un cuadro de mensaje, asignamos el resultado a txtpantalla
            txtpantalla.Text = resultadoExpresion.ToString()
        Catch ex As Exception
            ' Manejo de error si la expresión no es válida
            CalcAdvise.ShowDialog()
            txtpantalla.Clear()
        End Try
    End Sub

    'Elevar número con resultado
    Private Sub btnelevar_Click(sender As Object, e As EventArgs) Handles btnelevar.Click
        Dim exponente As Double

        If Double.TryParse(InputBox("Ingrese el exponente:"), exponente) Then
            ' Verifica si el cuadro de texto está vacío
            If String.IsNullOrWhiteSpace(txtpantalla.Text) Then
                ' Muestra un mensaje de error
                MsgBox("Ingrese un número antes de calcular la potencia.")
                Return ' Salir del método sin hacer ninguna operación
            End If

            ' Calcula la potencia y muestra el resultado en txtpantalla
            Dim base As Double = CDbl(txtpantalla.Text)
            Dim resultadoPotencia As Double = Math.Pow(base, exponente)
            txtpantalla.Text = resultadoPotencia.ToString()
        Else
            ' Manejo de error si el exponente no es válido o el usuario cancela la operación
            MsgBox("Exponente no válido o operación cancelada. Ingrese un número válido para el exponente.")
        End If
    End Sub
End Class

