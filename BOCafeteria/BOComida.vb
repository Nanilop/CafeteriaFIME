Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Contexts

Public Class BOComida
    Private _id_Comida As String
    Private _NombreC As String
    Private _id_TipoVal As String
    Private _HoraInicio As TimeSpan
    Private _HoraFin As TimeSpan
    Private _VistaC As Integer
    Private conexion As String = "Server=DESKTOP-R538THL;Database=Proyecto; Integrated Security=True;"
    Public Sub New()
        _id_Comida = ""
        _NombreC = ""
        _id_TipoVal = ""
        _HoraInicio = New TimeSpan(0, 0, 0)
        _HoraFin = New TimeSpan(0, 0, 0)
        _VistaC = 0
    End Sub
    Public Sub New(id As String, nombrec As String, idtipoval As String, horainicio As TimeSpan, horafin As TimeSpan, vc As Integer)
        _id_Comida = id
        _NombreC = nombrec
        _id_TipoVal = idtipoval
        _HoraInicio = horainicio
        _HoraFin = horafin
        _VistaC = vc
    End Sub
    Public Sub New(row As DataRow)
        _id_Comida = row.Field(Of String)("id_Comida")
        _NombreC = row.Field(Of String)("NombreC")
        _id_TipoVal = row.Field(Of String)("id_TipoVal")
        _HoraInicio = row.Field(Of TimeSpan)("HoraInicio")
        _HoraFin = row.Field(Of TimeSpan)("HoraFin")
        _VistaC = row.Field(Of String)("VistaC")
    End Sub
    Property IdComida As String
        Get
            Return _id_Comida
        End Get
        Set(value As String)
            _id_Comida = value
        End Set
    End Property
    Property NombreC As String
        Get
            Return _NombreC
        End Get
        Set(value As String)
            _NombreC = value
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
    Property HoraInicio As TimeSpan
        Get
            Return _HoraInicio
        End Get
        Set(value As TimeSpan)
            _HoraInicio = value
        End Set
    End Property
    Property HoraFin As TimeSpan
        Get
            Return _HoraFin
        End Get
        Set(value As TimeSpan)
            _HoraFin = value
        End Set
    End Property
    Property VistaC As Integer
        Get
            Return _VistaC
        End Get
        Set(value As Integer)
            _VistaC = value
        End Set
    End Property
    Function RegistrarComida(id As String, nomc As String, tipoval As String, hinicio As TimeSpan,
                             hfin As TimeSpan, vc As Integer)

        Dim response As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("REGISTROComida", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@id_Comida", id))
        cmd.Parameters.Add(New SqlParameter("@NombreC", nomc))
        cmd.Parameters.Add(New SqlParameter("@id_TipoVal", tipoval))
        cmd.Parameters.Add(New SqlParameter("@HoraInicio", hinicio))
        cmd.Parameters.Add(New SqlParameter("@HoraFin", hfin))
        cmd.Parameters.Add(New SqlParameter("@VistaC", vc))
        Using rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read
                response = rdr("response")
            End While
        End Using
        If response = 1 Then
            IdComida = id
            NombreC = nomc
            IdTipoVal = tipoval
            HoraInicio = hinicio
            HoraFin = hfin
            VistaC = vc
        End If
        conn.Close()
        Return response
    End Function
    Function ModificarComida(id As String, nomc As String, tipoval As String, hinicio As TimeSpan, hfin As TimeSpan, vc As Integer)
        Dim response As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("ModificaComida", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@id_Comida", id))
        cmd.Parameters.Add(New SqlParameter("@NombreC", nomc))
        cmd.Parameters.Add(New SqlParameter("@id_TipoVal", tipoval))
        cmd.Parameters.Add(New SqlParameter("@HoraInicio", hinicio))
        cmd.Parameters.Add(New SqlParameter("@HoraFin", hfin))
        cmd.Parameters.Add(New SqlParameter("@VistaC", vc))
        Using rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read
                response = rdr("response")
            End While
        End Using
        If response = 1 Then
            IdComida = id
            NombreC = nomc
            IdTipoVal = tipoval
            HoraInicio = hinicio
            HoraFin = hfin
            VistaC = vc
        End If
        conn.Close()
        Return response
    End Function
    Function EliminarComida(id As String)
        Dim response As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("EliminarComida", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@id_Comida", id))

        Using rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read
                response = rdr("response")
            End While
        End Using
        If response = 1 Then
            IdComida = id
        End If
        conn.Close()
        Return response
    End Function
End Class
