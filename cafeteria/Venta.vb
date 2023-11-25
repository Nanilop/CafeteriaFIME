Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports BOCafeteria
Imports Microsoft.VisualBasic.Logging

Public Class Venta
    Private usuario As New BOUsuario
    Private punto As Boolean = False
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
    Private connectionString As String = "Data Source=DESKTOP-CUOAPA9\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True"
    Private conn As New SqlConnection(connectionString)

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim searchTerm As String = txtBusqueda.Text.Trim()
        If String.IsNullOrEmpty(searchTerm) Then
            MessageBox.Show("Por favor, ingresa un término de búsqueda.")
            Return
        End If

        Try

            conn.Open()
            Dim queryProducto As String = "SELECT id_Producto, NombreP,CantidadEx FROM Producto WHERE id_TipoVal!=52 and VistaP=1 and NombreP LIKE @searchTerm"
            Dim cmdProducto As New SqlCommand(queryProducto, conn)
            cmdProducto.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")

            ' Consulta para la tabla Comida
            Dim queryComida As String = "SELECT id_Comida, NombreC FROM Comida WHERE id_TipoVal!=48 and VistaC=1 and NombreC LIKE @searchTerm"
            Dim cmdComida As New SqlCommand(queryComida, conn)
            cmdComida.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")

            ' Creamos DataAdapters para los resultados de las consultas
            Dim adapterProducto As New SqlDataAdapter(cmdProducto)
            Dim adapterComida As New SqlDataAdapter(cmdComida)

            ' Creamos DataTables para almacenar los resultados
            Dim dataTableResult As New DataTable()
            dataTableResult.Columns.Add("Id", GetType(Integer))
            dataTableResult.Columns.Add("Nombre", GetType(String))
            dataTableResult.Columns.Add("PrecioSug", GetType(Decimal))
            dataTableResult.Columns.Add("cop", GetType(Integer))
            dataTableResult.Columns.Add("max", GetType(Integer))




            ' Llenamos los DataTables con los resultados de las consultas
            Dim dataTableProducto As New DataTable()
            adapterProducto.Fill(dataTableProducto)

            Dim dataTableComida As New DataTable()
            adapterComida.Fill(dataTableComida)

            ' Iteramos sobre los resultados de Producto y Comida para obtener el precio de la tabla Precios
            For Each row As DataRow In dataTableProducto.Rows
                Dim precio As Decimal = ObtenerPrecioPorId(row("id_Producto"), conn)
                dataTableResult.Rows.Add(row("id_Producto"), row("NombreP"), precio, 0, row("CantidadEx"))
            Next

            For Each row As DataRow In dataTableComida.Rows
                Dim precio As Decimal = ObtenerPrecioPorId(row("id_Comida"), conn)
                dataTableResult.Rows.Add(row("id_Comida"), row("NombreC"), precio, 1, 0)
            Next

            ' Mostramos los resultados en el DataGridView
            ResultadosP.DataSource = dataTableResult
            ResultadosP.Columns("cop").Visible = False
            ResultadosP.Columns("max").Visible = False

        Catch ex As Exception
            MessageBox.Show("Error al buscar: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Función para obtener el precio por ID desde la tabla Precios
    Private Function ObtenerPrecioPorId(id As Integer, conn As SqlConnection) As Decimal
        Dim precio As Decimal = 0

        ' Consulta para obtener el precio por ID desde la tabla Precios
        Dim queryPrecio As String = "SELECT PrecioSug FROM Precio WHERE id_TipoVal=3 and id_Producto = @id_Producto"
        Dim cmdPrecio As New SqlCommand(queryPrecio, conn)
        cmdPrecio.Parameters.AddWithValue("@id_Producto", id)

        Dim reader As SqlDataReader = cmdPrecio.ExecuteReader()
        If reader.Read() Then
            precio = reader.GetDecimal(0)
        End If

        reader.Close()

        Return precio
    End Function

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ResultadosP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ResultadosP.CellContentClick

    End Sub


    Private Sub ListadoP_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles ListadoP.CellValueChanged
        ' Verificar si la celda modificada pertenece a la columna "Cantidad"
        If e.ColumnIndex < 0 OrElse e.RowIndex < 0 OrElse e.ColumnIndex >= ListadoP.Columns.Count OrElse e.RowIndex >= ListadoP.Rows.Count Then
            Return
        End If

        Dim cantidadColumnIndex As Integer = ListadoP.Columns("Cantidad").Index

        If e.ColumnIndex = cantidadColumnIndex Then
            Dim editedRow As DataGridViewRow = ListadoP.Rows(e.RowIndex)

            ' Verificar si la celda "Cantidad" y "Precio" no es nula
            If editedRow.Cells("Cantidad").Value IsNot Nothing AndAlso editedRow.Cells("Precio").Value IsNot Nothing Then
                ' Obtener los valores de la celda "Cantidad" y "Precio"
                Dim cantidad As Integer = If(IsNumeric(editedRow.Cells("Cantidad").Value), CInt(editedRow.Cells("Cantidad").Value), 0)
                Dim precio As Decimal = If(IsNumeric(editedRow.Cells("Precio").Value), CDec(editedRow.Cells("Precio").Value), 0)

                ' Actualizar la columna "PrecioTot" en la misma fila
                editedRow.Cells("PrecioTot").Value = cantidad * precio
            End If
        End If
        CalcularTotal()
    End Sub

    Private Sub pbAgregar_Click(sender As Object, e As EventArgs) Handles pbAgregar.Click
        If ResultadosP.SelectedRows.Count > 0 Then
            Dim selectedRow = ResultadosP.SelectedRows(0)
            Dim nombre As String = If(selectedRow.Cells("Nombre").Value IsNot Nothing, selectedRow.Cells("Nombre").Value.ToString(), "")
            Dim precio As Decimal = If(selectedRow.Cells("PrecioSug").Value IsNot Nothing, CDec(selectedRow.Cells("PrecioSug").Value), 0)
            Dim idpc As Decimal = If(selectedRow.Cells("id").Value IsNot Nothing, selectedRow.Cells("id").Value.ToString(), 0)
            Dim cop As Decimal = If(selectedRow.Cells("cop").Value IsNot Nothing, selectedRow.Cells("cop").Value.ToString(), 0)
            Dim maximo As Decimal = If(selectedRow.Cells("max").Value IsNot Nothing, selectedRow.Cells("max").Value.ToString(), 0)
            Dim existe = False
            Dim index As Integer = -1

            For i = 0 To ListadoP.Rows.Count - 1
                If ListadoP.Rows(i).Cells("NombrePC").Value IsNot Nothing AndAlso ListadoP.Rows(i).Cells("NombrePC").Value.ToString() = nombre Then
                    existe = True
                    index = i
                    Exit For
                End If
            Next

            If existe Then
                If ListadoP.Rows(index).Cells("Cantidad").Value IsNot Nothing Then
                    If cop = 1 Then
                        ListadoP.Rows(index).Cells("Cantidad").Value = CInt(ListadoP.Rows(index).Cells("Cantidad").Value) + 1
                    Else
                        If ListadoP.Rows(index).Cells("Cantidad").Value < maximo Then
                            ListadoP.Rows(index).Cells("Cantidad").Value = CInt(ListadoP.Rows(index).Cells("Cantidad").Value) + 1
                        End If
                    End If

                Else
                        ' Manejar el caso en el que la celda "Cantidad" esté vacía
                    End If
            Else
                ListadoP.Rows.Add(1, cop, idpc, nombre, precio)
            End If
        Else
            MessageBox.Show("Favor de selecciona un Producto o Comida.")
        End If
        'Recalcular los valores de "PrecioTot" después de agregar un elemento
        For Each fila As DataGridViewRow In ListadoP.Rows
            If Not fila.IsNewRow Then
                Dim cantidad As Integer = If(IsNumeric(fila.Cells("Cantidad").Value), CInt(fila.Cells("Cantidad").Value), 0)
                Dim precio As Decimal = If(IsNumeric(fila.Cells("Precio").Value), CDec(fila.Cells("Precio").Value), 0)
                fila.Cells("PrecioTot").Value = cantidad * precio
            End If
        Next

    End Sub


    Private Sub pbEliminar_Click(sender As Object, e As EventArgs) Handles pbEliminar.Click
        If ListadoP.SelectedRows.Count > 0 Then
            Dim fila As DataGridViewRow = ListadoP.SelectedRows(0)

            Dim cantidad As Integer = CInt(fila.Cells("Cantidad").Value)

            cantidad -= 1

            If cantidad > 0 Then
                fila.Cells("Cantidad").Value = cantidad
            Else
                ListadoP.Rows.Remove(fila)
            End If
        End If
    End Sub
    Private Sub txtbPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbPago.KeyPress
        Dim a = txtbPago.Text.ToArray()
        Dim i As Integer = 0
        Dim cant As Integer = a.Count
        For Each c As Char In a
            If c = "." Then
                i = i + 1
            End If
        Next
        If i = 1 Then
            punto = True
        ElseIf i = 0 Then
            punto = False
        Else

        End If
        If punto Then
            If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsNumber(e.KeyChar) Then
                e.Handled = True
            Else
                If cant = 8 AndAlso Not Char.IsControl(e.KeyChar) Then
                    e.Handled = True
                End If
            End If
        Else
            If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsPunctuation(e.KeyChar) Then

                e.Handled = True
            Else
                If cant = 5 AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsPunctuation(e.KeyChar) Then
                    e.Handled = True
                End If
            End If
        End If
        'If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
        '    e.Handled = True
        'End If
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            CalcularCambio()
            e.Handled = True ' Evitar que se ingrese el salto de línea al presionar Enter
        End If
    End Sub
    Private Sub CalcularTotal()
        Dim total As Decimal = 0

        For Each fila As DataGridViewRow In ListadoP.Rows
            If Not fila.IsNewRow AndAlso fila.Cells("PrecioTot").Value IsNot Nothing AndAlso IsNumeric(fila.Cells("PrecioTot").Value) Then
                total += Convert.ToDecimal(fila.Cells("PrecioTot").Value)
            End If
        Next

        ' Mostrar el total en el TextBox
        txtbTotal.Text = total.ToString()
    End Sub

    Private Sub CalcularCambio()
        Dim total As Decimal = 0
        Dim pago As Decimal = 0

        ' Verificar si los valores en los TextBox son numéricos
        If Decimal.TryParse(txtbTotal.Text, total) AndAlso Decimal.TryParse(txtbPago.Text, pago) Then
            Dim cambio As Decimal = pago - total

            ' Mostrar el resultado en txtbCambio
            txtbCambio.Text = cambio.ToString()
        Else
            ' Manejar el caso en el que los valores no sean numéricos
            txtbCambio.Text = "Pendiente"
        End If
    End Sub
    Private Sub txtbTotal_TextChanged(sender As Object, e As EventArgs) Handles txtbTotal.TextChanged
        CalcularCambio()
    End Sub

    Private Sub txtbCambio_TextChanged(sender As Object, e As EventArgs) Handles txtbCambio.TextChanged
        CalcularCambio()
    End Sub
    Private consultaSQL As String = "SELECT v.NombreV, c.NombreC, d.Cantidad " &
    "FROM venta v " &
    "INNER JOIN DetalleVenta d ON d.id_Venta = v.id_Venta " &
    "INNER JOIN Comida c ON c.id_Comida = d.id_Comida " &
    "WHERE v.id_Venta = 123"

    Private resultados As New DataTable()

    Dim PPD As New PrintPreviewDialog

    'Se define el largo del papel
    Dim longpaper As Integer
    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = ListadoP.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 240
    End Sub

    'boton para imprimir
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim comidahay As Boolean = False
        For Each row As DataGridViewRow In ListadoP.Rows
            If Not row.IsNewRow Then
                If row.Cells("NombrePC").Value IsNot Nothing AndAlso row.Cells("Cantidad").Value IsNot Nothing Then
                    If (row.Cells("cop").Value.ToString().Equals("1")) Then
                        comidahay = True
                    End If
                End If
            End If
        Next

        If comidahay And (String.IsNullOrEmpty(txtCliente.Text) Or String.IsNullOrWhiteSpace(txtCliente.Text)) Then
            MessageBox.Show("Ingrese a quien le pertenece la orden.")
        ElseIf String.IsNullOrEmpty(txtbPago.Text) Or String.IsNullOrWhiteSpace(txtbPago.Text) Or txtbCambio.Text.Equals("Pendiente") Then
            MessageBox.Show("Ingrese la cantidad de dinero proporcionada y precione Enter.")
        ElseIf Convert.ToDecimal(txtbCambio.Text) < 0 Then
            MessageBox.Show("Falta dinero.")
        Else
            changelongpaper()
            PPD.Document = PrintDocument1

            PPD.ShowDialog()
            'Quitar Comentario******************************************************************************************************
            'PrintDocument1.Print()
            conn.Open()
            For Each row As DataGridViewRow In ListadoP.Rows
                If Not row.IsNewRow Then
                    If row.Cells("NombrePC").Value IsNot Nothing AndAlso row.Cells("Cantidad").Value IsNot Nothing Then

                        Dim PoC As String = row.Cells("NombrePC").Value.ToString()
                        If (row.Cells("cop").Value.ToString().Equals("0")) Then
                            ' Verificar si el valor de NombrePC existe en la tabla Productos
                            Dim queryCheckExistence As String = "SELECT COUNT(*) FROM Producto WHERE NombreP = @producto"
                            Using cmdCheckExistence As New SqlCommand(queryCheckExistence, conn)
                                cmdCheckExistence.Parameters.AddWithValue("@producto", PoC)
                                Dim existencia As Integer = Convert.ToInt32(cmdCheckExistence.ExecuteScalar())

                                If existencia > 0 Then ' Si el valor existe en Productos
                                    Dim cantidadARestar As Integer = 0
                                    If Integer.TryParse(row.Cells("Cantidad").Value.ToString(), cantidadARestar) Then
                                        If PoC <> "" AndAlso cantidadARestar > 0 Then
                                            Try
                                                Dim queryCantidadP As String = "SELECT CantidadEx FROM Producto WHERE NombreP = @producto"
                                                Using cmdProducto As New SqlCommand(queryCantidadP, conn)
                                                    cmdProducto.Parameters.AddWithValue("@producto", PoC)
                                                    Dim cantidadActual As Integer = Convert.ToInt32(cmdProducto.ExecuteScalar())

                                                    If cantidadActual >= cantidadARestar Then
                                                        Dim nuevaCantidad As Integer = cantidadActual - cantidadARestar
                                                        Dim updateQuery As String = "UPDATE Producto SET CantidadEx = @nuevaCantidad WHERE NombreP= @producto"

                                                        Using cmdCantidadNP As New SqlCommand(updateQuery, conn)
                                                            cmdCantidadNP.Parameters.AddWithValue("@nuevaCantidad", nuevaCantidad)
                                                            cmdCantidadNP.Parameters.AddWithValue("@producto", PoC)
                                                            ' Ejecutar la actualización de la base de datos aquí
                                                            cmdCantidadNP.ExecuteNonQuery()
                                                        End Using
                                                        Try
                                                            Using sql As New SqlConnection("Data Source=DESKTOP-CUOAPA9\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True")
                                                                sql.Open()
                                                                Using cmd As New SqlCommand
                                                                    With cmd
                                                                        .Connection = sql
                                                                        .CommandText = "REGISTROBitUsuario"
                                                                        .CommandType = CommandType.StoredProcedure
                                                                        .Parameters.Add(New SqlParameter("@id_Usuario", usuario.Id))
                                                                        .Parameters.Add(New SqlParameter("@id_TipoVal", 14))
                                                                        .Parameters.Add(New SqlParameter("@FechaHora", DateTime.Now))
                                                                        .Parameters.Add(New SqlParameter("@VistaBU", "1"))
                                                                    End With
                                                                    cmd.ExecuteNonQuery()
                                                                End Using
                                                                sql.Close()
                                                            End Using
                                                        Catch ex As SqlException
                                                            MessageBox.Show(ex.Message)
                                                        End Try
                                                    Else
                                                        MessageBox.Show("No hay suficiente cantidad de " & PoC & " en la tabla Productos.")
                                                    End If
                                                End Using
                                            Catch ex As SqlException
                                                MessageBox.Show("Error de SQL al actualizar la base de datos: " & ex.Message)
                                            Catch ex As Exception
                                                MessageBox.Show("Error al actualizar la base de datos: " & ex.Message)
                                            End Try
                                        End If
                                    Else
                                        MessageBox.Show("El valor de cantidad no es válido en la fila " & (row.Index + 1).ToString())
                                    End If
                                End If
                            End Using
                        End If
                    Else

                    End If
                End If
            Next


            ' Obtener los valores de los TextBox
            Dim total As Decimal = Decimal.Parse(txtbTotal.Text)
            Dim pago As Decimal = Decimal.Parse(txtbPago.Text)
            Dim cambio As Decimal = Decimal.Parse(txtbCambio.Text)

            Dim existeCoincidencia As Boolean = False

            ' Iterar sobre las filas del DataGridView
            For Each row As DataGridViewRow In ListadoP.Rows
                ' Verificar si la celda NombrePC no está vacía
                If row.Cells("NombrePC").Value IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(row.Cells("NombrePC").Value.ToString()) Then
                    ' Obtener el valor de la celda NombrePC
                    Dim nombrePC As String = row.Cells("NombrePC").Value.ToString()

                    ' Consultar si existe coincidencia en la tabla Comida
                    Dim queryCheck As String = "SELECT COUNT(*) FROM Comida WHERE NombreC = @nombreC"
                    Using cmdCheck As New SqlCommand(queryCheck, conn)
                        cmdCheck.Parameters.AddWithValue("@nombreC", nombrePC)
                        Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

                        ' Si existe alguna coincidencia, asignar la bandera y salir del bucle
                        If count > 0 Then
                            existeCoincidencia = True
                            Exit For
                        End If
                    End Using
                End If
            Next

            Dim idTipoVal As Integer = If(existeCoincidencia, 7, 8)

            ' Insertar los datos de la venta en la base de datos

            Try



                ' Generar el nuevo ID_VENTA

                ' Insertar los datos de la venta en la tabla Venta con id_TipoVal correspondiente
                Dim insertQuery As String = "INSERT INTO Venta ( id_TipoVal, TotalV, PagoV, Feria, FechaVenta,VistaV,id_Usuario,NombreV) VALUES (@idTipoVal, @Total, @Pago, @Cambio, GETDATE(),1,@id_Usuario,@Nombre)"
                Using cmdInsert As New SqlCommand(insertQuery, conn)

                    cmdInsert.Parameters.AddWithValue("@idTipoVal", idTipoVal)
                    cmdInsert.Parameters.AddWithValue("@Total", total)
                    cmdInsert.Parameters.AddWithValue("@Pago", pago)
                    cmdInsert.Parameters.AddWithValue("@Cambio", cambio)
                    cmdInsert.Parameters.AddWithValue("@id_Usuario", usuario.Id)
                    cmdInsert.Parameters.AddWithValue("@Nombre", txtCliente.Text)

                    cmdInsert.ExecuteNonQuery()
                End Using

                MessageBox.Show("Venta registrada correctamente")
                Try
                    Using sql As New SqlConnection("Data Source=DESKTOP-CUOAPA9\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True")
                        sql.Open()
                        Using cmd As New SqlCommand
                            With cmd
                                .Connection = sql
                                .CommandText = "REGISTROBitUsuario"
                                .CommandType = CommandType.StoredProcedure
                                .Parameters.Add(New SqlParameter("@id_Usuario", usuario.Id))
                                .Parameters.Add(New SqlParameter("@id_TipoVal", 35))
                                .Parameters.Add(New SqlParameter("@FechaHora", DateTime.Now))
                                .Parameters.Add(New SqlParameter("@VistaBU", "1"))
                            End With
                            cmd.ExecuteNonQuery()
                        End Using
                        sql.Close()
                    End Using
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try
                ' Insertar en la BitacoraUsuario si la venta fue registrada correctamente
                Dim fechaHoraActual As DateTime = DateTime.Now

                'Dim newIDB As Integer = 0 ' Declarar la variable fuera del bloque Try

                'Try
                '    ' Consulta para obtener el último ID registrado
                '    Dim queryLastIDB As String = "SELECT TOP 1 id_BitUsuario FROM BitacoraUsuario ORDER BY id_BitUsuario DESC"
                '    Dim lastIDB As Integer = 0

                '    Using cmdLastIDB As New SqlCommand(queryLastIDB, conn)
                '        Dim result As Object = cmdLastIDB.ExecuteScalar()
                '        If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                '            lastIDB = Convert.ToInt32(result)
                '        End If
                '    End Using

                '    ' Calcular el nuevo ID fuera del bloque Try
                '    newIDB = lastIDB + 1
                'Catch ex As Exception
                '    ' Manejar excepciones
                'End Try

                ' Consulta para insertar el nuevo registro
                'Dim consulta As String = "INSERT INTO BitacoraUsuario (id_BitUsuario, id_TipoVal, FechaHora) VALUES (@idNuevo, @idTipoValor, @fechaHora)"

                'Using comando As New SqlCommand(consulta, conn)
                '    'comando.Parameters.AddWithValue("@idNuevo", newIDB)
                '    comando.Parameters.AddWithValue("@idTipoValor", 35)
                '    comando.Parameters.AddWithValue("@fechaHora", fechaHoraActual)

                '    comando.ExecuteNonQuery()
                'End Using
                ' Obtener el último ID_VENTA
                Dim queryLastID As String = "SELECT TOP 1 id_Venta FROM Venta ORDER BY id_Venta DESC"
                Dim lastID As Integer = 0

                Using cmdLastID As New SqlCommand(queryLastID, conn)
                    Dim result As Object = cmdLastID.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        lastID = Convert.ToInt32(result)
                    End If
                End Using

                For Each row As DataGridViewRow In ListadoP.Rows
                    ' Verificar si la celda NombrePC no está vacía
                    If row.Cells("NombrePC").Value IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(row.Cells("NombrePC").Value.ToString()) Then
                        ' Obtener el valor de la celda NombrePC
                        Dim c, p As String
                        If row.Cells("cop").Value.ToString().Equals("0") Then
                            c = 0
                            p = row.Cells("idpc").Value

                        Else
                            p = 0
                            c = row.Cells("idpc").Value
                        End If

                        ' Consultar si existe coincidencia en la tabla Comida
                        Try
                            Using sql As New SqlConnection("Data Source=DESKTOP-CUOAPA9\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True")
                                sql.Open()
                                Using cmd As New SqlCommand
                                    With cmd
                                        .Connection = sql
                                        .CommandText = "REGISTROBitacoraInventariodETALLE"
                                        .CommandType = CommandType.StoredProcedure

                                        .Parameters.Add(New SqlParameter("@id_Usuario", usuario.Id))
                                        .Parameters.Add(New SqlParameter("@id_Venta", lastID))
                                        .Parameters.Add(New SqlParameter("@Cantidad", row.Cells("Cantidad").Value))
                                        .Parameters.Add(New SqlParameter("@id_Comida", c))
                                        .Parameters.Add(New SqlParameter("@id_Producto", p))
                                        .Parameters.Add(New SqlParameter("@PrecioVenta", row.Cells("PrecioTot").Value))
                                    End With
                                    cmd.ExecuteNonQuery()
                                End Using
                                sql.Close()
                            End Using
                        Catch ex As SqlException
                            MessageBox.Show(ex.Message)
                        End Try
                    End If
            Next



        Catch ex As Exception
            ' Manejar excepciones
            conn.Close()
            MessageBox.Show("Error al registrar la venta: " & ex.Message)
        End Try
            txtbTotal.Text = String.Empty
            txtbPago.Text = String.Empty
            txtbCambio.Text = String.Empty
            txtCliente.Text = String.Empty
            ListadoP.Rows.Clear()
            ResultadosP.DataSource = New DataTable()
            txtBusqueda.Text = String.Empty
            conn.Close()
        End If
    End Sub


    'se definen los ajustes de impresion y del papel
    Private Sub PrintDocument1_BeginPrint(sender As Object, e As PrintEventArgs) Handles PrintDocument1.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 190, longpaper)
        PrintDocument1.DefaultPageSettings = pagesetup
    End Sub

    'diseño del ticket
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)
        Dim f10ab As New Font("Calibri", 8, FontStyle.Bold)


        Dim leftmargin As Integer = PrintDocument1.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PrintDocument1.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PrintDocument1.DefaultPageSettings.PaperSize.Width


        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "****************************************************************"

        Dim logoImage As Image = My.Resources.ResourceManager.GetObject("Tazita")
        e.Graphics.DrawImage(logoImage, CInt((e.PageBounds.Width - 110) / 2), 5, 100, 95)
        e.Graphics.DrawString("Catering Empresarial", f10ab, Brushes.Black, centermargin, -3, center)
        e.Graphics.DrawString("Info #866 148 8162", f10ab, Brushes.Black, centermargin, 8, center)

        e.Graphics.DrawString("Cliente", f10ab, Brushes.Black, 0, 83)
        e.Graphics.DrawString(":", f10ab, Brushes.Black, 30, 83)
        e.Graphics.DrawString(txtCliente.Text, f8, Brushes.Black, 35, 83)
        e.Graphics.DrawString("Fecha:" + DateTime.Now.ToShortDateString() + "-Hora:" + DateTime.Now.ToShortTimeString(), f10ab, Brushes.Black, 0, 95)

        'Columnas
        e.Graphics.DrawString("Producto", f10ab, Brushes.Black, 0, 110)
        e.Graphics.DrawString("Precio", f10ab, Brushes.Black, 115, 110) '75
        e.Graphics.DrawString("Cant.", f10ab, Brushes.Black, 175, 110, right)
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 120)
        Dim height As Integer
        Dim i As Long
        ListadoP.AllowUserToAddRows = False

        For row As Integer = 0 To ListadoP.RowCount - 1
            Dim largo As Integer = ListadoP.Rows(row).Cells(3).Value.ToString().Count()
            Dim largofin = largo
            height += 15
            If largo < 26 Then
                e.Graphics.DrawString(ListadoP.Rows(row).Cells(3).Value.ToString().Substring(0, largo), f8, Brushes.Black, 0, 110 + height)
            Else
                e.Graphics.DrawString(ListadoP.Rows(row).Cells(3).Value.ToString().Substring(0, 26), f8, Brushes.Black, 0, 110 + height)
            End If

            e.Graphics.DrawString(ListadoP.Rows(row).Cells(4).Value.ToString, f8, Brushes.Black, 120, 110 + height)
            i = ListadoP.Rows(row).Cells(4).Value
            ListadoP.Rows(row).Cells(4).Value = Format(i, "##,##0")
            e.Graphics.DrawString(ListadoP.Rows(row).Cells(0).Value.ToString, f8, Brushes.Black, 165, 110 + height, right)
            If largo > 26 Then
                Dim inicio As Integer = 26
                largo -= 26
                While largo > 0
                    height += 15
                    If largo < 26 Then
                        e.Graphics.DrawString(ListadoP.Rows(row).Cells(3).Value.ToString().Substring(inicio, largo), f8, Brushes.Black, 0, 110 + height)
                    Else
                        e.Graphics.DrawString(ListadoP.Rows(row).Cells(3).Value.ToString().Substring(inicio, 26), f8, Brushes.Black, 0, 110 + height)
                    End If
                    inicio += 26
                    largo -= 26
                End While
            End If
        Next

        Dim height2 As Integer
        height2 = 130 + height


        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2)
        e.Graphics.DrawString("Total: " + txtbTotal.Text, f10ab, Brushes.Black, 0, 10 + height2)
        e.Graphics.DrawString("Pago: " + txtbPago.Text, f10ab, Brushes.Black, 0, 25 + height2)
        e.Graphics.DrawString("Cambio: " + txtbCambio.Text, f10ab, Brushes.Black, 0, 40 + height2)


        e.Graphics.DrawString("~GRACIAS POR SU COMPRA(˘³˘)❤~", f10, Brushes.Black, centermargin, 70 + height2, center)

    End Sub

    Private Sub ListadoP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListadoP.CellContentClick

    End Sub

    Private Sub txtbPago_Leave(sender As Object, e As EventArgs) Handles txtbPago.Leave
        txtbPago.Text = Convert.ToDouble(txtbPago.Text).ToString("0.00")
    End Sub
End Class


