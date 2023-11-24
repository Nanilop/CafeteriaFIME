Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports BOCafeteria
Public Class InventarioProducto
    Private usuario As New BOUsuario
    Public producto As New BOProducto()
    Dim etiqueta As Boolean = True
    Public Sub New(user As BOUsuario)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.BackgroundImage = Image.FromFile("..\\..\\Resources\\Presentación1\\Diapositiva1.png")
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        usuario = user
    End Sub
    Private Sub btnRegresarP_Click(sender As Object, e As EventArgs) Handles btnRegresarP.Click
        LimpiarTxt()
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

        Dim conn = New SqlConnection("Data Source=DESKTOP-CUOAPA9\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True")
        conn.Open()
        Dim query As String = ("select * from Producto where id_Producto = '" & txtIDproducto.Text & "'")
        Dim cmd_ As New SqlCommand(query, conn)
        Dim rdr As SqlDataReader = cmd_.ExecuteReader()
        If rdr.HasRows Then
            MessageBox.Show("El identificador unico ya existe, por favor, introduzca uno nuevo.")
        Else
            If valido Then
                etiqueta = producto.RegistrarProducto(txtIDproducto.Text, txtNombreP.Text, txtCantidadEx.Text, txtMinimoEx.Text, txtMaximoEx.Text, "49", "1")
                MessageBox.Show("La informacion se ha registrado con exito.")
                LimpiarTxt()
                Try
                    Using sql As New SqlConnection("Data Source=LAPTOP-9KA9VTM6\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True")
                        sql.Open()
                        Using cmd As New SqlCommand
                            With cmd
                                .Connection = sql
                                .CommandText = "REGISTROBitUsuario"
                                .CommandType = CommandType.StoredProcedure
                                .Parameters.Add(New SqlParameter("@id_Usuario", usuario.Id))
                                .Parameters.Add(New SqlParameter("@id_TipoVal", 33))
                                .Parameters.Add(New SqlParameter("@FechaHora", DateTime.Now))
                                .Parameters.Add(New SqlParameter("@VistaBU", "1"))
                            End With
                            cmd.ExecuteNonQuery()
                        End Using
                        sql.Close()
                    End Using
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try
                Try
                    Using sql As New SqlConnection("Data Source=LAPTOP-9KA9VTM6\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True")
                        sql.Open()
                        Using cmd As New SqlCommand
                            With cmd
                                .Connection = sql
                                .CommandText = "REGISTROBitUsuario"
                                .CommandType = CommandType.StoredProcedure
                                .Parameters.Add(New SqlParameter("@id_Usuario", usuario.Id))
                                .Parameters.Add(New SqlParameter("@id_TipoVal", 15))
                                .Parameters.Add(New SqlParameter("@FechaHora", DateTime.Now))
                                .Parameters.Add(New SqlParameter("@VistaBU", "1"))
                            End With
                            cmd.ExecuteNonQuery()
                        End Using
                        sql.Close()
                    End Using
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try
                'Bitacora Inventario
                Try
                    Using sql As New SqlConnection("Data Source=LAPTOP-9KA9VTM6\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True")
                        sql.Open()
                        Using cmd As New SqlCommand
                            With cmd
                                .Connection = sql
                                .CommandText = "REGISTROBitacoraInventario"
                                .CommandType = CommandType.StoredProcedure
                                .Parameters.Add(New SqlParameter("@id_TipoVal", 40))
                                .Parameters.Add(New SqlParameter("@FechaHora", DateTime.Now))
                                .Parameters.Add(New SqlParameter("@CantidadB", txtCantidadEx.Text))
                                .Parameters.Add(New SqlParameter("@id_Producto", txtIDproducto.Text))
                                .Parameters.Add(New SqlParameter("@id_Usuario", usuario.Id))
                                .Parameters.Add(New SqlParameter("@VistaB", "1"))
                            End With
                            cmd.ExecuteNonQuery()
                        End Using
                        sql.Close()
                    End Using
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MessageBox.Show("No se ha podido registrar la informacion.")
            End If
        End If
        conn.Close()
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
            Dim Diff = Val(txtCantidadEx)

            etiqueta = producto.ModificarProducto(txtIDproducto.Text, txtNombreP.Text, txtCantidadEx.Text, txtMinimoEx.Text, txtMaximoEx.Text, txtIDtipoval.Text, txtVistaP.Text)

            MessageBox.Show("La informacion se ha modificado con exito.")
            LimpiarTxt()
            Try
                Using sql As New SqlConnection("Data Source=LAPTOP-9KA9VTM6\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True")
                    sql.Open()
                    Using cmd As New SqlCommand
                        With cmd
                            .Connection = sql
                            .CommandText = "REGISTROBitUsuario"
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@id_Usuario", usuario.Id))
                            .Parameters.Add(New SqlParameter("@id_TipoVal", 77))
                            .Parameters.Add(New SqlParameter("@FechaHora", DateTime.Now))
                            .Parameters.Add(New SqlParameter("@VistaBU", "1"))
                        End With
                        cmd.ExecuteNonQuery()
                    End Using
                    sql.Close()
                End Using
            Catch ex As SqlException
                MessageBox.Show(ex.Message)
            End Try
            Try
                Using sql As New SqlConnection("Data Source=LAPTOP-9KA9VTM6\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True")
                    sql.Open()
                    Using cmd As New SqlCommand
                        With cmd
                            .Connection = sql
                            .CommandText = "REGISTROBitacoraInventario"
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@id_TipoVal", 76))
                            .Parameters.Add(New SqlParameter("@FechaHora", DateTime.Now))
                            .Parameters.Add(New SqlParameter("@CantidadB", producto.CantEx - Diff))
                            .Parameters.Add(New SqlParameter("@id_Producto", producto.IdProducto))
                            .Parameters.Add(New SqlParameter("@id_Usuario", usuario.Id))
                            .Parameters.Add(New SqlParameter("@VistaB", "1"))
                        End With
                        cmd.ExecuteNonQuery()
                    End Using
                    sql.Close()
                End Using
            Catch ex As SqlException
                MessageBox.Show(ex.Message)
            End Try
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
            MessageBox.Show("La informacion se ha eliminado con exito.")
            LimpiarTxt()
            Try
                Using sql As New SqlConnection("Data Source=LAPTOP-9KA9VTM6\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True")
                    sql.Open()
                    Using cmd As New SqlCommand
                        With cmd
                            .Connection = sql
                            .CommandText = "REGISTROBitUsuario"
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@id_Usuario", usuario.Id))
                            .Parameters.Add(New SqlParameter("@id_TipoVal", 16))
                            .Parameters.Add(New SqlParameter("@FechaHora", DateTime.Now))
                            .Parameters.Add(New SqlParameter("@VistaBU", "1"))
                        End With
                        cmd.ExecuteNonQuery()
                    End Using
                    sql.Close()
                End Using
            Catch ex As SqlException
                MessageBox.Show(ex.Message)
            End Try
            Try
                Using sql As New SqlConnection("Data Source=LAPTOP-9KA9VTM6\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True")
                    sql.Open()
                    Using cmd As New SqlCommand
                        With cmd
                            .Connection = sql
                            .CommandText = "REGISTROBitacoraInventario"
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@id_TipoVal", 41))
                            .Parameters.Add(New SqlParameter("@FechaHora", DateTime.Now))
                            .Parameters.Add(New SqlParameter("@CantidadB", producto.CantEx))
                            .Parameters.Add(New SqlParameter("@id_Producto", producto.IdProducto))
                            .Parameters.Add(New SqlParameter("@id_Usuario", usuario.Id))
                            .Parameters.Add(New SqlParameter("@VistaB", "1"))
                        End With
                        cmd.ExecuteNonQuery()
                    End Using
                    sql.Close()
                End Using
            Catch ex As SqlException
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("No se ha podido eliminar la informacion.")
        End If

    End Sub
    Private Sub LimpiarTxt()
        txtIDproducto.Clear()
        txtNombreP.Clear()
        txtCantidadEx.Clear()
        txtMinimoEx.Clear()
        txtMaximoEx.Clear()
        txtIDtipoval.Clear()
        txtVistaP.Clear()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim conexion As String = "Server=DESKTOP-R538THL;Database=Proyecto; Integrated Security=True;"
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("select * from Producto where id_Producto = @id_Producto", conn)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Add(New SqlParameter("@id_Producto", txtIDproducto.Text))
        Using sda As New SqlDataAdapter()
            sda.SelectCommand = cmd
            Using dt As New DataTable()
                sda.Fill(dt)
                If dt.Rows.Count Then
                    txtNombreP.Text = dt.Rows(0)(1).ToString
                    txtCantidadEx.Text = dt.Rows(0)(2).ToString
                    txtMinimoEx.Text = dt.Rows(0)(3).ToString
                    txtMaximoEx.Text = dt.Rows(0)(4).ToString
                    txtIDtipoval.Text = dt.Rows(0)(5).ToString
                    If dt.Rows(0)(6) = True Then
                        txtVistaP.Text = 1
                    Else
                        txtVistaP.Text = 0
                    End If
                End If
            End Using
        End Using
        conn.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarTxt()

    End Sub
End Class