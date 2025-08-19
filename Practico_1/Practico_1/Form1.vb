Public Class Form1
    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click

        ' Concatenar el Apellido y el Nombre
        Dim nombreCompleto As String = TextBoxApellido.Text & " " & TextBoxNombre.Text

        ' Mostrar el nombre completo en el tercer TextBox
        TextBoxResult.Text = nombreCompleto

    End Sub



    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click

        ' Limpiar el contenido del TextBox multilinea
        TextBoxResult.Clear()

    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click

        ' Finalizar la aplicación
        End

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        ' Verificar si se presiona Ctrl + S
        If e.Control AndAlso e.KeyCode = Keys.S Then
            ' Simular clic en el botón BSalir
            BSalir.PerformClick()
        End If
    End Sub



End Class
