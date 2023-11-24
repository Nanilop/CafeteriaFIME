Imports System.Data.SqlClient
Imports System.Runtime.ConstrainedExecution
Imports BOCafeteria
Imports Microsoft.VisualBasic.ApplicationServices

Public Class InsModUsuario
    Private usuario As New BOUsuario
    Private ver As Boolean = False
    Private insert As Boolean = False
    Private idUs As String = ""
    Public cerrar As Boolean = True
    Public Sub New(user As BOUsuario, id As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.BackgroundImage = Image.FromFile("..\\..\\Resources\\Presentación1\\Diapositiva1.png")
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        usuario = user
        look.Image = Image.FromFile("..\\..\\Resources\\mostrar.png")
        insert = False
        idUs = id
        Dim dt As New DataTable()
        Try

            Using sql As New SqlConnection("Data Source=LAPTOP-9KA9VTM6\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True")
                sql.Open()
                Using cmd As New SqlCommand
                    With cmd
                        .Connection = sql
                        .CommandType = CommandType.Text
                        .CommandText = "select id_Usuario,Nombre,Telefono,email as Email,
                                        NombreU as [Nombre de Usuario],Contrasena as Contraseña,Vista,Inventario,
                                        Usuario,Venta,Informes,Precios from Usuarios where id_Usuario=" + id
                    End With

                    Using da = New SqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using

        Catch ex As SqlException

            MessageBox.Show(ex.Message)

        End Try
        For Each row As DataRow In dt.Rows
            txtNombre.Text = row(1)
            txtTelefono.Text = row(2)
            txtEmail.Text = row(3)
            txtNombreU.Text = row(4)
            txtContraseña.Text = row(5)
            If row(6) Then
                chkVista.Checked = True
            Else
                chkVista.Checked = False
            End If
            If row(7) Then
                chkInventario.Checked = True
            Else
                chkInventario.Checked = False
            End If
            If row(8) Then
                chkUsuario.Checked = True
            Else
                chkUsuario.Checked = False
            End If
            If row(9) Then
                chkVenta.Checked = True
            Else
                chkVenta.Checked = False
            End If
            If row(10) Then
                chkInforme.Checked = True
            Else
                chkInforme.Checked = False
            End If
            If row(11) Then
                chkPrecio.Checked = True
            Else
                chkPrecio.Checked = False
            End If
        Next

    End Sub
    Public Sub New(user As BOUsuario)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.BackgroundImage = Image.FromFile("..\\..\\Resources\\Presentación1\\Diapositiva1.png")
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        usuario = user
        look.Image = Image.FromFile("..\\..\\Resources\\mostrar.png")
        insert = True
    End Sub

    Private Sub look_Click(sender As Object, e As EventArgs) Handles look.Click
        If (ver) Then
            txtContraseña.PasswordChar = "*"
            ver = False
            look.Image = Image.FromFile("..\\..\\Resources\\mostrar.png")
        Else
            txtContraseña.PasswordChar = ""
            ver = True
            look.Image = Image.FromFile("..\\..\\Resources\\ocultar.png")
        End If
    End Sub

    Private Sub btnGuardarModPrec_Click(sender As Object, e As EventArgs) Handles btnGuardarModPrec.Click
        Dim vis, inv, inf, ven, pre, usrio As Boolean
        vis = chkVista.Checked
        inv = chkInventario.Checked
        inf = chkInforme.Checked
        ven = chkVenta.Checked
        pre = chkPrecio.Checked
        usrio = chkUsuario.Checked
        Dim response As String = ""
        If insert Then
            Try
                Using sql As New SqlConnection("Data Source=LAPTOP-9KA9VTM6\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True")
                    sql.Open()
                    Using cmd As New SqlCommand
                        With cmd
                            .Connection = sql
                            .CommandText = "REGISTROUsuario"
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@Nombre", txtNombre.Text))
                            .Parameters.Add(New SqlParameter("@Telefono", txtTelefono.Text))
                            .Parameters.Add(New SqlParameter("@email", txtEmail.Text))
                            .Parameters.Add(New SqlParameter("@NombreU", txtNombreU.Text))
                            .Parameters.Add(New SqlParameter("@Contrasena", txtContraseña.Text))
                            .Parameters.Add(New SqlParameter("@Vista", vis))
                            .Parameters.Add(New SqlParameter("@Inventario", inv))
                            .Parameters.Add(New SqlParameter("@Usuario", usrio))
                            .Parameters.Add(New SqlParameter("@Venta", ven))
                            .Parameters.Add(New SqlParameter("@Informes", inf))
                            .Parameters.Add(New SqlParameter("@Precios", pre))
                        End With
                        Dim lector As SqlDataReader
                        lector = cmd.ExecuteReader
                        If lector.HasRows Then
                            While lector.Read
                                response = lector(0).ToString()
                            End While
                        End If
                    End Using
                    sql.Close()
                End Using
            Catch ex As SqlException
                MessageBox.Show(ex.Message)
            End Try

            If response.Equals("Escoga otro Nombre de Usuario") Then
                MessageBox.Show(response)
                cerrar = False
            Else
                cerrar = True
                Try
                    Using sql As New SqlConnection("Data Source=LAPTOP-9KA9VTM6\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True")
                        sql.Open()
                        Using cmd As New SqlCommand
                            With cmd
                                .Connection = sql
                                .CommandText = "REGISTROBitUsuario"
                                .CommandType = CommandType.StoredProcedure
                                .Parameters.Add(New SqlParameter("@id_Usuario", usuario.Id))
                                .Parameters.Add(New SqlParameter("@id_TipoVal", 61))
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
            End If
        Else
            Try
                Using sql As New SqlConnection("Data Source=LAPTOP-9KA9VTM6\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True")
                    sql.Open()
                    Using cmd As New SqlCommand
                        With cmd
                            .Connection = sql
                            .CommandText = "ModificaUsuario"
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@id_Usuario", idUs))
                            .Parameters.Add(New SqlParameter("@Nombre", txtNombre.Text))
                            .Parameters.Add(New SqlParameter("@Telefono", txtTelefono.Text))
                            .Parameters.Add(New SqlParameter("@email", txtEmail.Text))
                            .Parameters.Add(New SqlParameter("@NombreU", txtNombreU.Text))
                            .Parameters.Add(New SqlParameter("@Contrasena", txtContraseña.Text))
                            .Parameters.Add(New SqlParameter("@Vista ", vis))
                            .Parameters.Add(New SqlParameter("@Inventario ", inv))
                            .Parameters.Add(New SqlParameter("@Usuario ", usrio))
                            .Parameters.Add(New SqlParameter("@Venta ", ven))
                            .Parameters.Add(New SqlParameter("@Informes ", inf))
                            .Parameters.Add(New SqlParameter("@Precios ", pre))

                        End With
                        Dim lector As SqlDataReader
                        lector = cmd.ExecuteReader
                        If lector.HasRows Then
                            While lector.Read
                                response = lector(0).ToString()
                            End While
                        End If
                    End Using
                    sql.Close()
                End Using
            Catch ex As SqlException
                MessageBox.Show(ex.Message)
            End Try
            If response.Equals("Escoga otro Nombre de Usuario") Then
                MessageBox.Show(response)
                cerrar = False
            Else
                cerrar = True
                Try
                    Using sql As New SqlConnection("Data Source=LAPTOP-9KA9VTM6\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True")
                        sql.Open()
                        Using cmd As New SqlCommand
                            With cmd
                                .Connection = sql
                                .CommandText = "REGISTROBitUsuario"
                                .CommandType = CommandType.StoredProcedure
                                .Parameters.Add(New SqlParameter("@id_Usuario", usuario.Id))
                                .Parameters.Add(New SqlParameter("@id_TipoVal", 62))
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
            End If
        End If
        If chkVista.Checked = False Then
            Try
                Using sql As New SqlConnection("Data Source=LAPTOP-9KA9VTM6\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True")
                    sql.Open()
                    Using cmd As New SqlCommand
                        With cmd
                            .Connection = sql
                            .CommandText = "REGISTROBitUsuario"
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@id_Usuario", usuario.Id))
                            .Parameters.Add(New SqlParameter("@id_TipoVal", 63))
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
        End If
    End Sub
    Private Sub txtNumTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtNombreU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreU.KeyPress
        If Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class