Imports BOCafeteria
Public Class InventarioComida
    Public comida As New BOComida()
    Dim etiqueta As Boolean = True
    Private Sub btnRegresarC_Click(sender As Object, e As EventArgs) Handles btnRegresarC.Click
        Me.Hide()
    End Sub
    Private Sub btnRegistrarC_Click(sender As Object, e As EventArgs) Handles btnRegistrarC.Click
        Dim valido As Boolean = True

        If (String.IsNullOrEmpty(txtIdComida.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtNombreC.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtIDtipoval.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtHoraInicio.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtHoraFin.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtVistaC.Text)) Then
            valido = False
        End If
        If valido Then
            Dim Hora1, Hora2 As String
            Dim HoraInicio, HoraFin, A, B As TimeSpan

            Hora1 = (txtHoraInicio.Text & ":" & txtMinInicio.Text & ":" & "00")
            Hora2 = (txtHoraFin.Text & ":" & txtMinFin.Text & ":" & "00")

            If TimeSpan.TryParse(Hora1, A) AndAlso TimeSpan.TryParse(Hora2, B) Then
                HoraInicio = A
                HoraFin = B
                etiqueta = comida.RegistrarComida(txtIdComida.Text, txtNombreC.Text, txtIDtipoval.Text, HoraInicio, HoraFin, txtVistaC.Text)
            Else
                MsgBox("Formato de tiempo incorrecto. Introduce el tiempo en formato HH:mm:ss")
            End If

        End If
        If etiqueta Then
            MsgBox("La informacion se ha registrado con Exito")
        Else
            MessageBox.Show("No se ha podido registrar la informacion.")
        End If
    End Sub

    Private Sub btnModificarC_Click(sender As Object, e As EventArgs) Handles btnModificarC.Click
        Dim valido As Boolean = True

        If (String.IsNullOrEmpty(txtIdComida.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtNombreC.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtIDtipoval.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtHoraInicio.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtHoraFin.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtVistaC.Text)) Then
            valido = False
        End If
        If valido Then
            Dim Hora1, Hora2 As String
            Dim HoraInicio, HoraFin, A, B As TimeSpan

            Hora1 = (txtHoraInicio.Text & ":" & txtMinInicio.Text & ":" & "00")
            Hora2 = (txtHoraFin.Text & ":" & txtMinFin.Text & ":" & "00")

            If TimeSpan.TryParse(Hora1, A) AndAlso TimeSpan.TryParse(Hora2, B) Then
                HoraInicio = A
                HoraFin = B
                etiqueta = comida.RegistrarComida(txtIdComida.Text, txtNombreC.Text, txtIDtipoval.Text, HoraInicio, HoraFin, txtVistaC.Text)
            Else
                MsgBox("Formato de tiempo incorrecto. Introduce el tiempo en formato HH:mm:ss")
            End If
        End If
        If etiqueta Then
            MsgBox("La informacion se ha Modificado con Exito")
        Else
            MessageBox.Show("No se ha podido Modificar la informacion.")
        End If
    End Sub

    Private Sub btnEliminarC_Click(sender As Object, e As EventArgs) Handles btnEliminarC.Click
        Dim valido As Boolean = True

        If (String.IsNullOrEmpty(txtIdComida.Text)) Then
            valido = False
        End If
        If valido Then

            etiqueta = comida.EliminarComida(txtIdComida.Text)
        End If
        If etiqueta Then
            MsgBox("La informacion se ha eliminado con Exito")
        Else
            MessageBox.Show("No se ha podido eliminar la informacion.")
        End If
    End Sub
End Class