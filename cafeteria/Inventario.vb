Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports BOCafeteria

Public Class Inventario
    Dim cnn As SqlConnection = New SqlConnection("Data Source=DESKTOP-CUOAPA9\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True")
    Private usuario As New BOUsuario
    Private bcomida As Boolean = False
    Private bproducto As Boolean = False
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
        If bproducto Then

        Else
            bproducto = True
            Dim p As New InventarioProducto(usuario)
            Application.DoEvents()
            AddHandler p.btnRegresarP.Click, AddressOf abre
            AddHandler p.FormClosed, AddressOf abre
            p.Show()
        End If

    End Sub
    Private Sub abre(sender As Object, ea As EventArgs)
        bproducto = False
    End Sub
    Private Sub abrec(sender As Object, ea As EventArgs)
        bcomida = False
    End Sub

    Private Sub btnEditarC_Click(sender As Object, e As EventArgs) Handles btnEditarC.Click
        If bcomida Then
        Else
            bcomida = True
            Dim c As New InventarioComida(usuario)
            Application.DoEvents()
            AddHandler c.btnRegresarC.Click, AddressOf abrec
            AddHandler c.FormClosed, AddressOf abrec
            c.Show()
        End If
    End Sub
    Public Sub MostrarProductos()
        Dim cmd = New SqlCommand("SELECT * FROM Producto order by id_TipoVal desc", cnn)
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
        dgvProductos.Columns("NombreP").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvProductos.Columns("id_TipoVal").Visible = False
        dgvProductos.Columns("VistaP").Visible = False
    End Sub
    Public Sub MostrarComidas()
        Dim cmd = New SqlCommand("SELECT * FROM Comida order by VistaC desc", cnn)
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
        dgvComidas.Columns("NombreC").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvComidas.Columns("id_TipoVal").Visible = False
        dgvComidas.Columns("VistaC").Visible = False
    End Sub

    Private Sub btnActualizarP_Click(sender As Object, e As EventArgs) Handles btnActualizarP.Click
        MostrarProductos()
    End Sub

    Private Sub btnActualizarC_Click(sender As Object, e As EventArgs) Handles btnActualizarC.Click
        MostrarComidas()
    End Sub
End Class

