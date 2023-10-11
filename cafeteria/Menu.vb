Imports BOCafeteria

Public Class Menu
    Dim session As Sesion
    Dim inventa As Inventario
    Dim venta As Venta
    Dim usuario As BOUsuario = New BOUsuario()
    'Dim carga As Cargando = New Cargando()
    Dim tamaño As Size
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        opciones.Visible = False
        Me.IsMdiContainer = True
        Me.BackgroundImage = Image.FromFile("..\\..\\Resources\\Presentación1\\Diapositiva1.png")
        session = New Sesion()

        session.MdiParent = Me
        btnHome.Enabled = True
        session.Dock = DockStyle.Fill
        session.Show()



        'carga.Show()

    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tamaño = New Drawing.Size((Me.Size.Width - 20), (Me.Size.Height - 80))
        'session.Size = tamaño
        'opciones.Location = New Point(tamaño.Width - 540, 7)

        'venta = New Venta()
        'cargando.ProgressBarCargando.Value += 10
        'inventa = New Inventario()
        'cargando.ProgressBarCargando.Value += 10

        'venta.MdiParent = Me
        'inventa.MdiParent = Me
        'cargando.ProgressBarCargando.Value = 100
        'cargando.Close()
        'carga.ProgressBarCargando.Value = 100
        'carga.Hide()


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
        venta.Hide()
        session.Hide()
        inventa.Hide()
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

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Menu_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click

    End Sub
End Class
