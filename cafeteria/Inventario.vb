Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports BOCafeteria

Public Class Inventario
    Dim cnn As SqlConnection = New SqlConnection("Server=DESKTOP-R538THL;Database=Proyecto; Integrated Security=True;")
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
    Private Sub btnEditarP_Click(sender As Object, e As EventArgs) Handles btnEditarP.Click
        InventarioProducto.Show()
    End Sub

    Private Sub btnEditarC_Click(sender As Object, e As EventArgs) Handles btnEditarC.Click
        InventarioComida.Show()
    End Sub
    Public Sub MostrarProductos()
        Dim cmd = New SqlCommand("SELECT * FROM Producto", cnn)
        Dim da = New SqlDataAdapter(cmd)
        Dim dt = New DataTable()
        Try
            cnn.Open()
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show("Error al abrir la conexión: " & ex.Message)
        Finally
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        End Try

        ' Mostrar los datos en el DataGridView
        dgvProductos.DataSource = dt
    End Sub
    Public Sub MostrarComidas()
        Dim cmd = New SqlCommand("SELECT * FROM Comida", cnn)
        Dim da = New SqlDataAdapter(cmd)
        Dim dt = New DataTable()
        Try
            cnn.Open()
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show("Error al abrir la conexión: " & ex.Message)
        Finally
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        End Try

        ' Mostrar los datos en el DataGridView
        dgvComidas.DataSource = dt
    End Sub

    Private Sub btnActualizarP_Click(sender As Object, e As EventArgs) Handles btnActualizarP.Click
        MostrarProductos()
    End Sub

    Private Sub btnActualizarC_Click(sender As Object, e As EventArgs) Handles btnActualizarC.Click
        MostrarComidas()
    End Sub
End Class

