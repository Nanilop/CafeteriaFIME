Imports BOCafeteria
Public Class InventarioProducto
    Public producto As New BOProducto()
    Dim etiqueta As Boolean = True
    Private Sub btnRegresarP_Click(sender As Object, e As EventArgs) Handles btnRegresarP.Click
        Me.Hide()
    End Sub
    Private Sub btnRegistrarP_Click(sender As Object, e As EventArgs) Handles btnRegistrarP.Click
        Dim valido As Boolean = True

        If (String.IsNullOrEmpty(txtIDproducto.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtNombreP.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtCantidadEx.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtMinimoEx.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtMaximoEx.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtIDtipoval.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtVistaP.Text)) Then
            valido = False
        End If
        If valido Then

            etiqueta = producto.RegistrarProducto(txtIDproducto.Text, txtNombreP.Text, txtCantidadEx.Text, txtMinimoEx.Text, txtMaximoEx.Text, txtIDtipoval.Text, txtVistaP.Text)
        End If
        If etiqueta Then

        Else
            MessageBox.Show("No se ha podido registrar la informacion.")
        End If
    End Sub
    Private Sub btnModificarP_Click(sender As Object, e As EventArgs) Handles btnModificarP.Click
        Dim valido As Boolean = True

        If (String.IsNullOrEmpty(txtIDproducto.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtNombreP.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtCantidadEx.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtMinimoEx.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtMaximoEx.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtIDtipoval.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtVistaP.Text)) Then
            valido = False
        End If
        If valido Then

            etiqueta = producto.ModificarProducto(txtIDproducto.Text, txtNombreP.Text, txtCantidadEx.Text, txtMinimoEx.Text, txtMaximoEx.Text, txtIDtipoval.Text, txtVistaP.Text)
        End If
        If etiqueta Then

        Else
            MessageBox.Show("No se ha podido modificar la informacion.")
        End If
    End Sub
    Private Sub btnEliminarP_Click(sender As Object, e As EventArgs) Handles btnEliminarP.Click
        Dim valido As Boolean = True

        If (String.IsNullOrEmpty(txtIDproducto.Text)) Then
            valido = False
        End If

        If valido Then
            etiqueta = producto.EliminarProducto(txtIDproducto.Text)
        End If
        If etiqueta Then

        Else
            MessageBox.Show("No se ha podido eliminar la informacion.")
        End If
    End Sub
End Class