Imports System.Data.SqlClient

Public Class BOUsuario
    Private _id_Usuario As String
    Private _nombre As String
    Private _telefono As String
    Private _email As String
    Private _nombreU As String
    Private _contrasena As String
    Private _vista As Integer
    Private conexion As String = "Server=DESKTOP-CUOAPA9\SQLEXPRESS;Database=Proyecto;User Id=Admin;Password=AdminTCE123;"
    Public Sub New()
        _id_Usuario = ""
        _nombre = ""
        _telefono = ""
        _email = ""
        _nombreU = ""
        _contrasena = ""
        _vista = 0
    End Sub
    Public Sub New(id As String, nombre As String, telefono As String, email As String,
                   usuario As String, contrasena As String, vista As Integer)
        _id_Usuario = id
        _nombre = nombre
        _telefono = telefono
        _email = email
        _nombreU = usuario
        _contrasena = contrasena
        _vista = vista
    End Sub
    Public Sub New(row As DataRow)
        _id_Usuario = row.Field(Of String)("id_Usuario")
        _nombre = row.Field(Of String)("Nombre")
        _telefono = row.Field(Of String)("Telefono")
        _email = row.Field(Of String)("email")
        _nombreU = row.Field(Of String)("NombreU")
        _contrasena = row.Field(Of String)("Contrasena")
        _vista = row.Field(Of Integer)("Vista")
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
    Property Vista As String
        Get
            Return _vista
        End Get
        Set(value As String)
            _vista = value
        End Set
    End Property
    Function Acceder(user As String, contrasena As String) As Boolean
        Dim response As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("GetValidUserPassword", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@usuario", user))
        cmd.Parameters.Add(New SqlParameter("@contraseña", contrasena))
        Using rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read
                response = rdr("response")
            End While
        End Using
        If response = 1 Then
            Usuario = user
            Contraseña = contrasena
        End If
        Return response
    End Function

End Class
