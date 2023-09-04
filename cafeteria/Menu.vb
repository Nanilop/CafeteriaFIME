﻿Public Class Menu
    Dim session As Sesion = New Sesion
    Dim venta As Venta = New Venta
    Dim inventa As Inventario = New Inventario
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.IsMdiContainer = True
        Me.BackgroundImage = Image.FromFile("..\\..\\Resources\\Presentación1\\Diapositiva1.png")
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        session.MdiParent = Me
        venta.MdiParent = Me
        inventa.MdiParent = Me
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cerrar()
        session.Show()
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
End Class
