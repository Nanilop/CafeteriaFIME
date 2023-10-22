Imports BOCafeteria

Public Class Sesion
    Private ver As Boolean = False
    Private usuario As BOUsuario
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.BackgroundImage = Image.FromFile("..\\..\\Resources\\Presentación1\\Diapositiva1.png")
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.FormBorderStyle = FormBorderStyle.None
        picLogo.Image = Image.FromFile("..\\..\\Resources\\11.png")
        look.Image = Image.FromFile("..\\..\\Resources\\mostrar.png")

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

    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        Dim valido As Boolean = True
        If (String.IsNullOrEmpty(txtContraseña.Text)) Then
            advcontra.Visible = True
            valido = False
        End If
        If (String.IsNullOrEmpty(txtUsuario.Text)) Then
            advusuario.Visible = True
            valido = False
        End If
        If valido Then

        End If
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
        advusuario.Visible = False
    End Sub

    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged
        advcontra.Visible = False
    End Sub
End Class