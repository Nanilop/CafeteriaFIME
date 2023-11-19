Imports System.Data.Common
Imports System.Data.SqlClient

Public Class BOUsuario
    Private _id_Usuario As String
    Private _nombre As String
    Private _telefono As String
    Private _email As String
    Private _nombreU As String
    Private _contrasena As String
    Private _vista As Boolean
    Private _inventario As Boolean
    Private _Usuario As Boolean
    Private _Venta As Boolean
    Private _Informes As Boolean
    Private _Descuentos As Boolean


    Private conexion As String = "Server=DESKTOP-CUOAPA9\SQLEXPRESS;Database=Proyecto;User Id=Admin;Password=AdminTCE123;"
    Public Sub New()
        _id_Usuario = ""
        _nombre = ""
        _telefono = ""
        _email = ""
        _nombreU = ""
        _contrasena = ""
        _vista = False
        _inventario = False
        _Usuario = False
        _Venta = False
        _Informes = False
        _Descuentos = false
    End Sub
    Public Sub New(id As String, nombre As String, telefono As String, email As String,
                   usuario As String, contrasena As String, vista As Boolean, inventario As Boolean,
                   usuarios As Boolean, venta As Boolean, informes As Boolean, descuentos As Boolean)
        _id_Usuario = id
        _nombre = nombre
        _telefono = telefono
        _email = email
        _nombreU = usuario
        _contrasena = contrasena
        _vista = vista
        _inventario = inventario
        _Usuario = usuarios
        _Venta = venta
        _Informes = informes
        _Descuentos = descuentos
    End Sub
    Public Sub New(row As DataRow)
        _id_Usuario = row.Field(Of String)("id_Usuario")
        _nombre = row.Field(Of String)("Nombre")
        _telefono = row.Field(Of String)("Telefono")
        _email = row.Field(Of String)("email")
        _nombreU = row.Field(Of String)("NombreU")
        _contrasena = row.Field(Of String)("Contrasena")
        _vista = row.Field(Of Boolean)("Vista")
        _inventario = row.Field(Of Boolean)("Inventario")
        _Usuario = row.Field(Of Boolean)("Usuario")
        _Venta = row.Field(Of Boolean)("Venta")
        _Informes = row.Field(Of Boolean)("Informes")
        _Descuentos = row.Field(Of Boolean)("Descuentos")
    End Sub

    Property Id As String
        Get
            Return _id_Usuario
        End Get
        Set(value As String)
            _id_Usuario = value
        End Set
    End Property
    Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property
    Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property
    Property Usuario As String
        Get
            Return _nombreU
        End Get
        Set(value As String)
            _nombreU = value
        End Set
    End Property
    Property Contraseña As String
        Get
            Return _contrasena
        End Get
        Set(value As String)
            _contrasena = value
        End Set
    End Property
    Property Vista As Boolean
        Get
            Return _vista
        End Get
        Set(value As Boolean)
            _vista = value
        End Set
    End Property
    Property Inventario As Boolean
        Get
            Return _inventario
        End Get
        Set(value As Boolean)
            _inventario = value
        End Set
    End Property
    Property Venta As Boolean
        Get
            Return _Venta
        End Get
        Set(value As Boolean)
            _Venta = value
        End Set
    End Property
    Property Informes As Boolean
        Get
            Return _Informes
        End Get
        Set(value As Boolean)
            _Informes = value
        End Set
    End Property
    Property Usuarios As Boolean
        Get
            Return _Usuario
        End Get
        Set(value As Boolean)
            _Usuario = value
        End Set
    End Property
    Property Descuentos As Boolean
        Get
            Return _Descuentos
        End Get
        Set(value As Boolean)
            _Descuentos = value
        End Set
    End Property

    Function Acceder(user As String, contrasena As String) As Boolean
        Dim dt As New DataTable()

        Dim response As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("GetValidUserPassword", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@usuario", user))
        cmd.Parameters.Add(New SqlParameter("@contraseña", contrasena))
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        For Each row As DataRow In dt.Rows
            response = row(0)
            If response Then
                Usuario = user
                Contraseña = contrasena
                Id = row(1)
                Nombre = row(2)
                Telefono = row(3)
                Email = row(4)
                Vista = row(7)
                Inventario = row(8)
                Venta = row(10)
                Informes = row(11)
                Usuarios = row(9)
                Descuentos = row(12)
            End If
        Next
        conn.Close()
        Return response
    End Function

End Class
