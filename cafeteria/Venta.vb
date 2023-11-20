Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports BOCafeteria

Public Class Venta
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
    Public conn2 As New OleDbConnection
    Public Sub conecta()
        Try
            '*---
            'Conexion a SQL Server
            '*---C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA
            conn2.ConnectionString = "Data Source=C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Proyecto.mdf"

            conn2.Open()
            'MsgBox("Conectado a la base de datos...", vbInformation, "Aviso")
        Catch ex As Exception
            MsgBox("No se conecto a la base de datos...", vbInformation, ex.Message)

        End Try
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbBuscar.Click
        txtbTotal.Focus()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim searchTerm As String = txtBusqueda.Text.Trim()
        If String.IsNullOrEmpty(searchTerm) Then
            MessageBox.Show("Por favor, ingresa un término de búsqueda.")
            Return
        End If

        Try
            Using connection As New SqlConnection(conn2.ConnectionString)
                connection.Open()

                Dim queryComidas As String = "SELECT id_Comida, NombreC FROM Comida WHERE NombreC LIKE @searchTerm"
                Dim cmdComidas As New SqlCommand(queryComidas, connection)
                cmdComidas.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")

                Dim adapterComidas As New SqlDataAdapter(cmdComidas)
                Dim dataTableComidas As New DataTable()
                adapterComidas.Fill(dataTableComidas)

                Dim queryProductos As String = "SELECT id_Producto, NombreP FROM Productos WHERE NombreP LIKE @searchTerm"
                Dim cmdProductos As New SqlCommand(queryProductos, connection)
                cmdProductos.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")

                Dim adapterProductos As New SqlDataAdapter(cmdProductos)
                Dim dataTableProductos As New DataTable()
                adapterProductos.Fill(dataTableProductos)

                Dim dataTableResult As New DataTable()
                dataTableResult.Columns.Add("Id", GetType(Integer))
                dataTableResult.Columns.Add("Nombre", GetType(String))
                dataTableResult.Columns.Add("Precio", GetType(Decimal))

                For Each row As DataRow In dataTableComidas.Rows
                    dataTableResult.Rows.Add(row("Id"), row("Nombre"), ObtenerPrecioPorId(row("Id")))
                Next

                For Each row As DataRow In dataTableProductos.Rows
                    dataTableResult.Rows.Add(row("Id"), row("Nombre"), ObtenerPrecioPorId(row("Id")))
                Next

                ResultadosP.DataSource = dataTableResult

                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al buscar: " & ex.Message)
        End Try
    End Sub

    Private Function ObtenerPrecioPorId(id As Integer) As Decimal
        Dim precio As Decimal = 0

        Using connection As New SqlConnection(conn2.ConnectionString)
            connection.Open()

            Dim queryPrecio As String = "SELECT PrecioSug FROM Precio WHERE id_Producto or id_Comida = @id"
            Dim cmdPrecio As New SqlCommand(queryPrecio, connection)
            cmdPrecio.Parameters.AddWithValue("@id", id)

            Dim reader As SqlDataReader = cmdPrecio.ExecuteReader()
            If reader.Read() Then
                precio = reader.GetDecimal(0)
            End If

            reader.Close()

            connection.Close()
        End Using

        Return precio
    End Function

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles pbModificar.Click

    End Sub

    Private Sub ResultadosP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ResultadosP.CellContentClick

    End Sub
    Private Sub pbAgregar_Click(sender As Object, e As EventArgs) Handles pbAgregar.Click
        If ResultadosP.SelectedRows.Count > 0 Then
            Dim nombre As String = ResultadosP.SelectedRows(0).Cells("Nombre").Value.ToString()
            Dim precio As Decimal = CDec(ResultadosP.SelectedRows(0).Cells("Precio").Value)

            Dim existe = False
            Dim index As Integer = -1

            For i = 0 To ListadoP.Rows.Count - 1
                If ListadoP.Rows(i).Cells("Nombre").Value.ToString() = nombre Then
                    existe = True
                    index = i
                    Exit For
                End If
            Next

            If existe Then
                ListadoP.Rows(index).Cells("CANT").Value = CInt(ListadoP.Rows(index).Cells("CANT").Value) + 1
            Else
                ListadoP.Rows.Add(nombre, precio, 1)
            End If
        Else
            MessageBox.Show("Selecciona un elemento en el DataGridView ResultadosP antes de agregarlo.")
        End If
    End Sub
    Private Sub pbEliminar_Click(sender As Object, e As EventArgs) Handles pbEliminar.Click
        If ListadoP.SelectedRows.Count > 0 Then
            Dim fila As DataGridViewRow = ListadoP.SelectedRows(0)

            Dim cantidad As Integer = CInt(fila.Cells("CANT").Value)

            cantidad -= 1

            If cantidad > 0 Then
                fila.Cells("CANT").Value = cantidad
            Else
                ListadoP.Rows.Remove(fila)
            End If
        End If
    End Sub
    Private Sub txtbPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbPago.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ListadoP_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles ListadoP.CellEndEdit

        If e.ColumnIndex = ListadoP.Columns("CANT").Index Then
            Dim fila As DataGridViewRow = ListadoP.Rows(e.RowIndex)

            Dim cantidad As Integer = CInt(fila.Cells("CANT").Value)
            Dim precio As Decimal = CDec(fila.Cells("PRECIO").Value)

            fila.Cells("PRECIOT").Value = cantidad * precio
        End If
    End Sub

    Private Sub CalcularTotal()
        Dim total As Integer = 0

        For Each fila As DataGridViewRow In ListadoP.Rows
            If Not fila.IsNewRow Then
                total += CInt(fila.Cells("CANT").Value)
            End If
        Next

        txtbTotal.Text = total.ToString()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CalcularTotal()
    End Sub

    Private Sub CalcularCambio()
        If IsNumeric(txtbPago.Text) AndAlso IsNumeric(txtbTotal.Text) Then
            Dim pago As Decimal = Decimal.Parse(txtbPago.Text)
            Dim total As Decimal = Decimal.Parse(txtbTotal.Text)

            Dim cambio As Decimal = pago - total
            txtbCambio.Text = cambio.ToString("0.00")
        Else
            txtbCambio.Text = "Valor no válido"
        End If
    End Sub

    Private Sub txtbPago_TextChanged(sender As Object, e As EventArgs) Handles txtbPago.TextChanged
        CalcularCambio()
    End Sub

    Private Sub txtbTotal_TextChanged(sender As Object, e As EventArgs) Handles txtbTotal.TextChanged
        CalcularCambio()
    End Sub
    Private Sub txtbCambio_TextChanged(sender As Object, e As EventArgs) Handles txtbCambio.TextChanged

    End Sub
    Private consultaSQL As String = "SELECT v.NombreV, c.NombreC, d.Cantidad " &
    "FROM venta v " &
    "INNER JOIN DetalleVenta d ON d.id_Venta = v.id_Venta " &
    "INNER JOIN Comida c ON c.id_Comida = d.id_Comida " &
    "WHERE v.id_Venta = 123"

    Private resultados As New DataTable()
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click



        Using conexion As New SqlConnection(conn2.ConnectionString)
            Using adaptador As New SqlDataAdapter(consultaSQL, conexion)
                adaptador.Fill(resultados)
            End Using
        End Using

        AddHandler PrintDocument1.PrintPage, AddressOf PrintPage

        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim fuente As New Font("Arial", 12)
        Dim posicionY As Single = 0

        Dim rectangulo As New RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height)

        Using pinceles As New SolidBrush(Color.Black)
            Using formato As New StringFormat()
                e.Graphics.DrawString("Resultados de la consulta:", fuente, pinceles, rectangulo, formato)
                posicionY += fuente.GetHeight()

                For Each fila As DataRow In resultados.Rows
                    Dim linea As String = $"{fila("NombreV").ToString()}, {fila("NombreC").ToString()}, {fila("Cantidad").ToString()}"
                    e.Graphics.DrawString(linea, fuente, pinceles, rectangulo, formato)
                    posicionY += fuente.GetHeight()
                Next
            End Using
        End Using
    End Sub


End Class


