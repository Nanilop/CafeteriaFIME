Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports BOCafeteria
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Menu

    Dim session As Sesion
    Dim inventa As Inventario
    Dim venta As Venta
    Dim usuario As BOUsuario = New BOUsuario()
    'Dim carga As Cargando = New Cargando()
    Dim inicio As Inicio
    Dim descuento As Descuentos
    Dim informe As Informes
    Dim ayuda As Ayuda
    Dim orden As OrdenVer
    'Dim oredenes As BOOrdenes()
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        opciones.Visible = False
        Me.IsMdiContainer = True
        Me.BackgroundImage = Image.FromFile("..\\..\\Resources\\Presentación1\\Diapositiva1.png")
        picLogo.Image = Image.FromFile("..\\..\\Resources\\11.png")
        picLogo.BackgroundImage = Image.FromFile("..\\..\\Resources\\Presentación1\\Diapositiva1.png")
        session = New Sesion()
        btnHome.Enabled = True
        session.MdiParent = Me
        session.Dock = DockStyle.Fill
        session.Show()
        Eventos()
    End Sub

    Public Sub Eventos()
        Application.DoEvents()
        AddHandler session.btnAcceder.Click, AddressOf Evento
    End Sub
    Private Sub Evento(sender As Object, ea As EventArgs)

        session.BeginInvoke(DirectCast(Sub()
                                           If session.etiqueta Then
                                               usuario = session.usuario
                                               session.Close()
                                               session.Dispose()
                                               session = Nothing
                                               inventa = New Inventario()
                                               venta = New Venta()
                                               descuento = New Descuentos()
                                               informe = New Informes()
                                               ayuda = New Ayuda()
                                               inicio = New Inicio(usuario)
                                               inicio.MdiParent = Me
                                               inicio.Dock = DockStyle.Fill
                                               venta.MdiParent = Me
                                               inventa.MdiParent = Me
                                               venta.Dock = DockStyle.Fill
                                               inventa.Dock = DockStyle.Fill
                                               ayuda.MdiParent = Me
                                               ayuda.Dock = DockStyle.Fill
                                               inicio.Show()
                                               opciones.Visible = True
                                               picLogo.Visible = True
                                               notif.Visible = True
                                           End If
                                       End Sub,
                                       Action))

    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        cerrar()
        venta.Show()
    End Sub
    Private Sub btninventario_Click(sender As Object, e As EventArgs) Handles btninventario.Click
        cerrar()
        inventa.Show()
    End Sub
    Private Sub cerrar()
        inicio.Hide()
        venta.Hide()
        inventa.Hide()
        descuento.Hide()
        informe.Hide()
        ayuda.Hide()
    End Sub
    Private Sub parpadeo(lab As Label, inOut As Boolean)
        Dim col As Color = Color.FromArgb(197, 90, 17)
        If inOut Then
            lab.ForeColor = col
            lab.BackColor = Color.White

        Else
            lab.BackColor = col
            lab.ForeColor = Color.White
        End If

    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles btnHome.MouseMove, btnAyuda.MouseMove, btnInformes.MouseMove, btninventario.MouseMove, btnVenta.MouseMove, btnCerrarSesion.MouseMove
        parpadeo(sender, True)
    End Sub

    Private Sub btnHome_MouseLeave(sender As Object, e As EventArgs) Handles btnHome.MouseLeave, btnAyuda.MouseLeave, btnInformes.MouseLeave, btninventario.MouseLeave, btnVenta.MouseLeave, btnCerrarSesion.MouseLeave
        parpadeo(sender, False)
    End Sub
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        cerrar()
        inicio.Show()
    End Sub

    Private Sub Menu_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Me.Size = New Size(855, 540)

    End Sub

    Private Sub btnAyuda_Click(sender As Object, e As EventArgs) Handles btnAyuda.Click
        cerrar()
        ayuda.Show()
    End Sub
    Private Sub notif_Click(sender As Object, e As EventArgs) Handles notif.Click
        If PNotificaciones.Visible Then
            PNotificaciones.Visible = False
            PicVacio.Visible = False
        Else
            recargaNotif()
            PNotificaciones.Visible = True
        End If
    End Sub

    Private Sub recargaNotif()
        PNotificaciones.Controls.Clear()
        Dim dt As New DataTable
        Try

            Using sql As New SqlConnection("Data Source=DESKTOP-CUOAPA9\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True")

                sql.Open()

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = sql
                        .CommandType = CommandType.Text
                        .CommandText = "select id_Venta, NombreV from Venta where id_TipoVal='7' and VistaV=1"
                    End With

                    Using da = New SqlDataAdapter(cmd)

                        da.Fill(dt)

                    End Using

                End Using
                sql.Close()
            End Using

        Catch ex As SqlException

            MessageBox.Show(ex.Message)

        End Try
        Dim localizacion As New Point(6, 8)
        Dim loc As New Point(6, 8)
        If dt.Rows.Count = 0 Then
            PicVacio.Visible = True
            PicVacio.BringToFront()
        Else
            PicVacio.Visible = False
        End If
        For Each row As DataRow In dt.Rows
            Dim nombre As New BONotificacionLabel(row(0)) With {
                .TextAlign = ContentAlignment.MiddleLeft,
                .AutoSize = False,
                .Size = New Size(94, 26),
                .Text = row(1),
                .Cursor = System.Windows.Forms.Cursors.Hand,
                .ForeColor = Color.White   
            }
            Dim aceptar As New BONotificacion(row(0)) With {
            .Image = Image.FromFile("..\\..\\Resources\\aceptaOrden.png"),
            .Size = New Size(25, 25),
            .SizeMode = PictureBoxSizeMode.StretchImage}
            Dim cancelar As New BONotificacion(row(0)) With {
            .Image = Image.FromFile("..\\..\\Resources\\cancelaOrden.png"),
            .Size = New Size(25, 25),
            .SizeMode = PictureBoxSizeMode.StretchImage}


            nombre.Location = loc
            PNotificaciones.Controls.Add(nombre)
            loc.X = loc.X + 100
            aceptar.Location = loc
            PNotificaciones.Controls.Add(aceptar)
            loc.X = loc.X + 31
            cancelar.Location = loc
            PNotificaciones.Controls.Add(cancelar)

            Application.DoEvents()
            AddHandler cancelar.Click, AddressOf EventoCancelar
            AddHandler aceptar.Click, AddressOf EventoAceptar
            AddHandler nombre.Click, AddressOf EventoVer
            localizacion.Y = localizacion.Y + 37
            loc = localizacion
        Next
    End Sub

    Private Sub EventoCancelar(sender As BONotificacion, ea As EventArgs)
        Dim response As Integer = 0
        Try
            Using sql As New SqlConnection("Data Source=DESKTOP-CUOAPA9\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True")
                sql.Open()
                Using cmd As New SqlCommand
                    With cmd
                        .Connection = sql
                        .CommandText = "ModificaVentaCancela"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add(New SqlParameter("@id_Usuario", usuario.Id))
                        .Parameters.Add(New SqlParameter("@id_Venta", sender.Id))
                    End With
                    response = cmd.ExecuteNonQuery()
                End Using
                sql.Close()
            End Using
            MessageBox.Show("Cancelado")
        Catch ex As SqlException

            MessageBox.Show(ex.Message)

        End Try
        recargaNotif()
    End Sub
    Private Sub EventoAceptar(sender As BONotificacion, ea As EventArgs)
        Dim response As Integer = 0
        Try
            Using sql As New SqlConnection("Data Source=DESKTOP-CUOAPA9\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True")
                sql.Open()
                Using cmd As New SqlCommand
                    With cmd
                        .Connection = sql
                        .CommandText = "ModificaVentaEntregar"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add(New SqlParameter("@id_Usuario", usuario.Id))
                        .Parameters.Add(New SqlParameter("@id_Venta", sender.Id))
                    End With
                    response = cmd.ExecuteNonQuery()
                End Using
                sql.Close()
            End Using
            MessageBox.Show("Entregado")
        Catch ex As SqlException

            MessageBox.Show(ex.Message)

        End Try
        recargaNotif()
    End Sub
    Private Sub EventoVer(sender As BONotificacionLabel, ea As EventArgs)
        orden = New OrdenVer(sender.Id, usuario)
        Application.DoEvents()
        AddHandler orden.btnEntrega.Click, AddressOf EventoRecarga
        AddHandler orden.btnCancela.Click, AddressOf EventoRecarga
        AddHandler orden.btnEntrega.Click, AddressOf EventoCerrarOrden
        AddHandler orden.btnCancela.Click, AddressOf EventoCerrarOrden
        orden.Show()
    End Sub
    Private Sub EventoRecarga(sender As Object, ea As EventArgs)
        recargaNotif()
    End Sub
    Private Sub EventoCerrarOrden(sender As Object, ea As EventArgs)
        orden.Close()
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click

    End Sub

    Private Sub opciones_Paint(sender As Object, e As PaintEventArgs) Handles opciones.Paint

    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        opciones.Visible = False
        picLogo.Visible = False
        session = New Sesion()
        btnHome.Enabled = True
        session.MdiParent = Me
        session.Dock = DockStyle.Fill
        session.Show()
        Eventos()
        notif.Visible = False
        PNotificaciones.Visible = False
        PicVacio.Visible = False
        usuario = New BOUsuario()
    End Sub
End Class
