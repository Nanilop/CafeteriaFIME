Imports System.Data
Imports System.Data.OleDb
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Inventario
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.BackgroundImage = Image.FromFile("..\\..\\Resources\\Presentación1\\Diapositiva1.png")
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub

    Public conn2 As New OleDbConnection
    Public Sub conecta()
        Try
            '*---
            'Conexion a SQL Server
            '*---
            conn2.ConnectionString = "Data Source=C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Proyecto.mdf"

            conn2.Open()
            'MsgBox("Conectado a la base de datos...", vbInformation, "Aviso")
        Catch ex As Exception
            MsgBox("No se conecto a la base de datos...", vbInformation, ex.Message)

        End Try
    End Sub

    Public cmd As New OleDb.OleDbCommand
    Public dr As OleDb.OleDbDataReader
    Dim vAlta As Boolean
    Dim wProductonuevo As Integer

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta()
    End Sub

    Private Sub CargaProducto(ByRef papellidop As String)
        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim query As String

        If (Len(papellidop) = 0) Then
            query = "Select * from Producto"
            oda = New OleDbDataAdapter(query, conn2)  'Ejecutar la query (consulta) en la BD a la que apunta conn
            ods.Tables.Add("Producto")         'Generar tabla Producto en memoria
            oda.Fill(ods.Tables("Producto"))   'Poblar tabla Producto
            dgvInventario.DataSource = ods.Tables("Producto")
            dgvInventario.Visible = True
        End If
    End Sub

    Private Sub ValidaAlta()
        '*-- Validar Codigo Producto
        If (vAlta) Then
            If (Len(txtIDproducto.Text) = 0) Then
                vAlta = False
                Label8.Text = "Codigo producto..."
            End If
        End If
        '*-- Validar Minimo Existencia
        If (vAlta) Then
            If (Len(txtMinExP.Text) = 0) Then
                vAlta = False
                Label8.Text = "Minimo Existencia..."
            End If
        End If
        '*-- Validar Maximo Existencia
        If (vAlta) Then
            If (Len(txtMaxExP.Text) = 0) Then
                vAlta = False
                Label8.Text = "Maximo Existencia..."
            End If
        End If
        '*-- Validar Nombre Prpoducto
        If (vAlta) Then
            If (Len(txtNombreP.Text) > 0) Then
                vAlta = True
            Else
                vAlta = False
                Label8.Text = "Nombre Prpoducto..."
            End If
        End If

        '*-- Validar Cantidad Existencia
        If (vAlta) Then
            If (Not (IsNumeric(txtExistenciaP.Text))) Then
                vAlta = False
                Label8.Text = "Cantidad Existencia..."
            End If
        End If

        '*-- Validar Codigo Tipo Valor
        If (vAlta) Then
            If (Not (IsNumeric(txtIDtipoval.Text))) Then
                vAlta = False
                Label8.Text = "Codigo Tipo Valor..."
            End If
        End If

        'vAlta = (Len( txtNombreP.Text) > 0) And (Len(txtExistenciaP.Text) > 0) And (Len(txtMinExP.Text) > 0) And (Len(txtMaxExP.Text) > 0) And (Len(txtIDtipoval.Text) > 0) And (Len(VistaP.Text) > 0)
    End Sub
    Private Sub insertaProducto(ByRef producto As Integer)
        Dim query As String
        Dim id_Producto As Integer
        Dim NombreP As String
        Dim CantidadEx As String
        Dim MinimoEx As String
        Dim MaximoEx As String
        Dim id_TipoVal As String
        Dim VistaP As String

        '*---
        id_Producto = producto
        NombreP = txtNombreP.Text
        CantidadEx = txtExistenciaP.Text
        MinimoEx = txtMinExP.Text
        MaximoEx = txtMaxExP.Text
        id_TipoVal = txtIDtipoval.Text
        VistaP = txtVistaP.Text

        '*---
        cmd.Connection = conn2
        cmd.CommandType = CommandType.Text
        '*---
        query = "INSERT INTO Producto (id_Producto,NombreP,CantidadEx,MinimoEx,MaximoEx,id_TipoVal,VistaP) "
        query = query & "VALUES (" & id_Producto & ", '" & NombreP & "', "
        query = query & "'" & CantidadEx & "', '" & MinimoEx & "', " & "'" & MaximoEx & "', " & "'" & id_TipoVal & "', "
        query = query & "'" & VistaP & "') "
        '*---
        'MsgBox("Query=" & query)
        '*---
        cmd.CommandText = query
        '
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.ToString)
            MsgBox("Error al insertar registros...revisar información")
            vAlta = False
        End Try
        '*---
        cmd.Connection.Close()
    End Sub

    Private Sub generaProducto()
        Dim query As String
        Dim numProducto As Integer
        '
        cmd.Connection = conn2
        cmd.CommandType = CommandType.Text
        '
        numProducto = -1
        query = "Select * from Producto"
        cmd.CommandText = query
        Try
            dr = cmd.ExecuteReader
            '
            If dr.HasRows Then
                'Obtener el numero del Producto del ultimo registro
                While dr.Read()
                    numProducto = Val(dr(0).ToString)
                End While
            Else
            End If
            '
            dr.Close()
            '
            If (numProducto < 0) Then
                numProducto = 1
            Else
                numProducto = numProducto + 1
            End If
            '*---
            '*---
            'Insertar el nuevo Producto a la base de datos
            insertaProducto(numProducto)
            '*---
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnRegistrarP_Click(sender As Object, e As EventArgs) Handles btnRegistrarP.Click
        vAlta = False
        ValidaAlta()
        If (vAlta) Then
            'Generar el nuevo numero de Producto
            generaProducto()
            If (vAlta) Then
                Label8.Text = "Registro exitoso....."
            Else
                Label8.Text = "Error al insertar registro....."
            End If
            'Else
            '   Label8.Text = "Error en la información..."
        Else
            Label8.Text = "Error al insertar registro....."
        End If
    End Sub

    Private Sub dgvInventario_DoubleClick(sender As Object, e As EventArgs) Handles dgvInventario.DoubleClick
        Dim fila As Integer

        '*- Mover información a pantalla
        '*---
        fila = dgvInventario.CurrentRow.Index   'Regresa el renglon donde se dio el dobleclick
        txtIDproducto.Text = dgvInventario.Rows(fila).Cells(0).Value
        txtNombreP.Text = dgvInventario.Rows(fila).Cells(1).Value
        txtExistenciaP.Text = dgvInventario.Rows(fila).Cells(2).Value
        txtMinExP.Text = dgvInventario.Rows(fila).Cells(3).Value
        txtMaxExP.Text = dgvInventario.Rows(fila).Cells(4).Value
        txtIDtipoval.Text = dgvInventario.Rows(fila).Cells(5).Value
        txtVistaP.Text = dgvInventario.Rows(fila).Cells(6).Value
    End Sub

    Private Sub btnActualizarP_Click(sender As Object, e As EventArgs) Handles btnActualizarP.Click
        '*---
        '*-Concetar a basa de datos Producto
        '*---
        conecta()
        '*---
        CargaProducto("")
    End Sub

    Private Sub EditaProductos(ByRef id_Producto As String)

        Dim query As String
        Dim NombreP As String
        Dim CantidadEx As String
        Dim MinimoEx As String
        Dim MaximoEx As String
        Dim id_TipoVal As String
        Dim VistaP As String
        '*---

        NombreP = txtNombreP.Text
        CantidadEx = txtExistenciaP.Text
        MinimoEx = txtMinExP.Text
        MaximoEx = txtMaxExP.Text
        id_TipoVal = txtIDtipoval.Text
        VistaP = txtVistaP.Text
        '*---
        cmd.Connection = conn2
        cmd.CommandType = CommandType.Text
        '*---
        query = ""
        query = query & "UPDATE Producto SET NombreP = '" & NombreP & "',"
        query = query & " CantidadEx ='" & CantidadEx & "',"
        query = query & " MinimoEx ='" & MinimoEx & "',"
        query = query & " MaximoEx ='" & MaximoEx & "',"
        query = query & " id_TipoVal ='" & id_TipoVal & "',"
        query = query & " VistaP ='" & VistaP & "'  "
        query = query & " WHERE (id_Producto =" & id_Producto & ")"
        '*---
        'MsgBox("Query=" & query)
        '*---
        cmd.CommandText = query
        '
        Try
            cmd.ExecuteNonQuery()
            '*---
            Label8.Text = "Edicion realizada...."
            '*---
            CargaProducto("")
        Catch ex As Exception
            'MsgBox(ex.ToString)
            MsgBox("Error al Editar registro...revisar información")
        End Try
    End Sub

    Private Sub btnEditarP_Click(sender As Object, e As EventArgs) Handles btnEditarP.Click
        EditaProductos(txtIDproducto.Text)
    End Sub


    Private Sub eliminaProducto(ByRef id_Producto As String)
        Dim query As String
        If (Len(id_Producto) > 0) Then
            '*---
            cmd.Connection = conn2
            cmd.CommandType = CommandType.Text
            '*---
            query = "Delete * from Producto where id_Producto = " + id_Producto
            '*---
            'MsgBox("Query=" & query)
            '*---
            cmd.CommandText = query
            '
            Try
                cmd.ExecuteNonQuery()
                Label8.Text = "Eliminacion completa...."
                '*---
                CargaProducto("")
            Catch ex As Exception
                'MsgBox(ex.ToString)
                MsgBox("Error al eliminar registro...revisar información")
            End Try
            '*---
            cmd.Connection.Close()

        End If
    End Sub

    Private Sub btnEliminarP_Click(sender As Object, e As EventArgs) Handles btnEliminarP.Click
        eliminaProducto(txtIDproducto.Text)
    End Sub
End Class

