Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports BOCafeteria

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

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles btnHome.MouseMove, btnAyuda.MouseMove, btnDescuento.MouseMove, btnInformes.MouseMove, btninventario.MouseMove, btnVenta.MouseMove

        parpadeo(sender, True)
    End Sub

    Private Sub btnHome_MouseLeave(sender As Object, e As EventArgs) Handles btnHome.MouseLeave, btnAyuda.MouseLeave, btnDescuento.MouseLeave, btnInformes.MouseLeave, btninventario.MouseLeave, btnVenta.MouseLeave
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
        Else
            recargaNotif()
            PNotificaciones.Visible = True
        End If
    End Sub

    Private Sub recargaNotif()

    End Sub
End Class
