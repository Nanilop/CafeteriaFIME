Imports BOCafeteria
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Precios
    Private usuario As New BOUsuario
    Public Sub New(user As BOUsuario)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.BackgroundImage = Image.FromFile("..\\..\\Resources\\Presentación1\\Diapositiva1.png")
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.FormBorderStyle = FormBorderStyle.None
        usuario = user
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim modifica As New PrecioModificar("Nombre", "0.00")
        modifica.Show()
    End Sub
End Class