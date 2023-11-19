Imports System.Reflection.Emit
Imports System.Windows.Forms

Public Class BONotificacionLabel
    Inherits Windows.Forms.Label
    Private _id As String
    Public Sub New(valor As String)
        _id = valor
    End Sub
    Property Id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property
End Class
