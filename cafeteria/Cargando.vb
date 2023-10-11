Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class Cargando

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.FormBorderStyle = FormBorderStyle.None
        Me.BackgroundImage = Image.FromFile("..\\..\\Resources\\cargando.jpg")
        picLogo.Image = Image.FromFile("..\\..\\Resources\\11.png")

    End Sub



    Private Sub Cargando_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Cargando_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged

    End Sub


End Class