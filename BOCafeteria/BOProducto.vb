Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.ApplicationServices

Public Class BOProducto
    Private _id_Producto As String
    Private _NombreP As String
    Private _CantidadEx As Integer
    Private _MinimoEx As Integer
    Private _MaximoEx As Integer
    Private _id_TipoVal As String
    Private _VistaP As Boolean
    Private conexion As String = "Data Source=DESKTOP-CUOAPA9\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True"
    Public Sub New()
        _id_Producto = ""
        _NombreP = ""
        _CantidadEx = 0
        _MinimoEx = 0
        _MaximoEx = 0
        _id_TipoVal = ""
        _VistaP = False
    End Sub
    Public Sub New(id As String, nombrep As String, cantidadex As Integer, minex As Integer,
                   maxex As Integer, idtipoval As String, vistap As Boolean)
        _id_Producto = id
        _NombreP = nombrep
        _CantidadEx = cantidadex
        _MinimoEx = minex
        _MaximoEx = maxex
        _id_TipoVal = idtipoval
        _VistaP = vistap
    End Sub
    Public Sub New(row As DataRow)
        _id_Producto = row.Field(Of String)("id_Producto")
        _NombreP = row.Field(Of String)("NombreP")
        _CantidadEx = row.Field(Of Integer)("CantidadEx")
        _MinimoEx = row.Field(Of Integer)("MinimoEx")
        _MaximoEx = row.Field(Of Integer)("MaximoEx")
        _id_TipoVal = row.Field(Of String)("id_TipoVal")
        _VistaP = row.Field(Of Boolean)("VistaP")
    End Sub
    Property IdProducto As String
        Get
            Return _id_Producto
        End Get
        Set(value As String)
            _id_Producto = value
        End Set
    End Property
    Property NombreProducto As String
        Get
            Return _NombreP
        End Get
        Set(value As String)
            _NombreP = value
        End Set
    End Property
    Property CantEx As Integer
        Get
            Return _CantidadEx
        End Get
        Set(value As Integer)
            _CantidadEx = value
        End Set
    End Property
    Property MinimoEx As Integer
        Get
            Return _MinimoEx
        End Get
        Set(value As Integer)
            _MinimoEx = value
        End Set
    End Property
    Property MaximoEx As Integer
        Get
            Return _MaximoEx
        End Get
        Set(value As Integer)
            _MaximoEx = value
        End Set
    End Property
    Property IdTipoVal As String
        Get
            Return _id_TipoVal
        End Get
        Set(value As String)
            _id_TipoVal = value
        End Set
    End Property
    Property Vistap As Boolean
        Get
            Return _VistaP
        End Get
        Set(value As Boolean)
            _VistaP = value
        End Set
    End Property
    Function RegistrarProducto(id As String, nombrep As String, cantidadex As Integer, minex As Integer,
                   maxex As Integer, vp As Boolean)

        Dim response As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("REGISTROProducto", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@id_Producto", id))
        cmd.Parameters.Add(New SqlParameter("@NombreP", nombrep))
        cmd.Parameters.Add(New SqlParameter("@CantidadEx", cantidadex))
        cmd.Parameters.Add(New SqlParameter("@MinimoEx", minex))
        cmd.Parameters.Add(New SqlParameter("@MaximoEx", maxex))
        cmd.Parameters.Add(New SqlParameter("@VistaP", vp))
        Using rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read
                response = rdr("response")
            End While
        End Using
        If response = 1 Then
            IdProducto = id
            NombreProducto = nombrep
            CantEx = cantidadex
            MinimoEx = minex
            MaximoEx = maxex
            Vistap = vp
        End If
        Return response
    End Function
    Function ModificarProducto(id As String, nombrep As String, cantidadex As Integer, minex As Integer,
                   maxex As Integer, vp As Boolean)

        Dim response As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("ModificaProductos", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@id_Producto", id))
        cmd.Parameters.Add(New SqlParameter("@NombreP", nombrep))
        cmd.Parameters.Add(New SqlParameter("@CantidadEx", cantidadex))
        cmd.Parameters.Add(New SqlParameter("@MinimoEx", minex))
        cmd.Parameters.Add(New SqlParameter("@MaximoEx", maxex))
        cmd.Parameters.Add(New SqlParameter("@VistaP", vp))
        Using rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read
                response = rdr("response")
            End While
        End Using
        If response = 1 Then
            IdProducto = id
            NombreProducto = nombrep
            CantEx = cantidadex
            MinimoEx = minex
            MaximoEx = maxex
            Vistap = vp
        End If
        Return response
    End Function
    Function EliminarProducto(id As String)
        Dim response As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("EliminarProducto", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@id_Producto", id))
        Using rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read
                response = rdr("response")
            End While
        End Using
        If response = 1 Then
            IdProducto = id
        End If
        Return response
    End Function
End Class
