Public Class Inventario
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.BackgroundImage = Image.FromFile("..\\..\\Resources\\Presentación1\\Diapositiva1.png")
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.FormBorderStyle = FormBorderStyle.None
        btnComidas.Image = Image.FromFile("..\\..\\Resources\\plato.png")
        btnProductos.Image = Image.FromFile("..\\..\\Resources\\producto.png")

    End Sub
End Class