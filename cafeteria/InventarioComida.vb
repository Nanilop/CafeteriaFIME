Imports System.Data.SqlClient
Imports BOCafeteria
Public Class InventarioComida
    Public comida As New BOComida()
    Dim etiqueta As Boolean = True
    Private usuario As New BOUsuario

    Public Sub New(user As BOUsuario)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.BackgroundImage = Image.FromFile("..\\..\\Resources\\Presentación1\\Diapositiva1.png")
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        usuario = user
    End Sub
    Private Sub btnRegresarC_Click(sender As Object, e As EventArgs) Handles btnRegresarC.Click
        LimpiarTxt()
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

        Dim conn = New SqlConnection("Server=LAPTOP-9KA9VTM6\SQLEXPRESS01;Database=Proyecto; Integrated Security=True;")
        conn.Open()
        Dim query As String = ("select * from Comida where id_Comida = '" & txtIdComida.Text & "'")
        Dim cmd_ As New SqlCommand(query, conn)
        Dim rdr As SqlDataReader = cmd_.ExecuteReader()
        If rdr.HasRows Then
            MessageBox.Show("El identificador unico ya existe, por favor, introduzca uno nuevo.")
        Else
            If valido Then
                Dim Hora1, Hora2 As String
                Dim HoraInicio, HoraFin, A, B As TimeSpan

                Hora1 = txtHoraInicio.Text
                Hora2 = txtHoraFin.Text

                If TimeSpan.TryParse(Hora1, A) AndAlso TimeSpan.TryParse(Hora2, B) Then
                    HoraInicio = A
                    HoraFin = B
                    etiqueta = comida.RegistrarComida(txtIdComida.Text, txtNombreC.Text, txtIDtipoval.Text, HoraInicio, HoraFin, txtVistaC.Text)
                    MsgBox("La informacion se ha registrado con Exito")
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
                                    .Parameters.Add(New SqlParameter("@id_TipoVal", 19))
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
                                    .Parameters.Add(New SqlParameter("@id_TipoVal", 44))
                                    .Parameters.Add(New SqlParameter("@FechaHora", DateTime.Now))
                                    .Parameters.Add(New SqlParameter("@CantidadB", 1))
                                    .Parameters.Add(New SqlParameter("@id_Producto", comida.IdComida))
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
                    MsgBox("No se ha podido registrar la informacion: Formato de tiempo incorrecto. Introduce el tiempo en formato HH:mm")
                End If
            End If
        End If
        conn.Close()
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

            Hora1 = txtHoraInicio.Text
            Hora2 = txtHoraFin.Text

            If TimeSpan.TryParse(Hora1, A) AndAlso TimeSpan.TryParse(Hora2, B) Then
                HoraInicio = A
                HoraFin = B
                etiqueta = comida.ModificarComida(txtIdComida.Text, txtNombreC.Text, txtIDtipoval.Text, HoraInicio, HoraFin, txtVistaC.Text)
                MsgBox("La informacion se ha Modificado con Exito")
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
                                .Parameters.Add(New SqlParameter("@id_TipoVal", 18))
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
                                .Parameters.Add(New SqlParameter("@id_TipoVal", 43))
                                .Parameters.Add(New SqlParameter("@FechaHora", DateTime.Now))
                                .Parameters.Add(New SqlParameter("@CantidadB", 1))
                                .Parameters.Add(New SqlParameter("@id_Producto", comida.IdComida))
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
                MsgBox("No se ha podido Modificar la informacion: Formato de tiempo incorrecto. Introduce el tiempo en formato HH:mm:ss")
            End If
        End If
    End Sub

    Private Sub btnEliminarC_Click(sender As Object, e As EventArgs) Handles btnEliminarC.Click
        Dim valido As Boolean = True

        If (String.IsNullOrEmpty(txtIdComida.Text)) Then
            valido = False
        End If
        If valido Then

            etiqueta = comida.EliminarComida(txtIdComida.Text)
            MsgBox("La informacion se ha eliminado con Exito")
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
                            .Parameters.Add(New SqlParameter("@id_TipoVal", 17))
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
                            .Parameters.Add(New SqlParameter("@id_TipoVal", 42))
                            .Parameters.Add(New SqlParameter("@FechaHora", DateTime.Now))
                            .Parameters.Add(New SqlParameter("@CantidadB", 1))
                            .Parameters.Add(New SqlParameter("@id_Producto", comida.IdComida))
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
        txtIdComida.Clear()
        txtNombreC.Clear()
        txtIDtipoval.Clear()
        txtHoraInicio.Clear()
        txtHoraFin.Clear()
        txtVistaC.Clear()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim conexion As String = "Server=LAPTOP-9KA9VTM6\SQLEXPRESS01;Database=Proyecto; Integrated Security=True;"
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("select * from Comida where id_Comida = @id_Comida", conn)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Add(New SqlParameter("@id_Comida", txtIdComida.Text))
        Using sda As New SqlDataAdapter()
            sda.SelectCommand = cmd
            Using dt As New DataTable()
                sda.Fill(dt)
                If dt.Rows.Count Then
                    txtNombreC.Text = dt.Rows(0)(1).ToString
                    txtIDtipoval.Text = dt.Rows(0)(2).ToString
                    txtHoraInicio.Text = dt.Rows(0)(3).ToString
                    txtHoraFin.Text = dt.Rows(0)(4).ToString
                    If dt.Rows(0)(5) = True Then
                        txtVistaC.Text = 1
                    Else
                        txtVistaC.Text = 0
                    End If
                End If
            End Using
        End Using
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarTxt()
    End Sub

    Private Sub txtHoraInicio_Click(sender As Object, e As EventArgs) Handles txtHoraInicio.Click
        txtHoraInicio.Clear()
    End Sub

    Private Sub txtHoraFin_Click(sender As Object, e As EventArgs) Handles txtHoraFin.Click
        txtHoraFin.Clear()
    End Sub

    Private Sub InventarioComida_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class