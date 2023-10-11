Imports System.Windows.Forms
Imports cafeteria
Imports System

Module Home
    Dim menus As New cafeteria.Menu()
    <STAThread>
    Public Sub Main(args As String())
        Dim a As New Home

        a.ShowSplash()

        Application.Run(menus)

    End Sub
    Public Class Home
        Public sp As New Cargando()
        'Public t As New System.Windows.Forms.Timer()
        Public Sub ShowSplash()
            sp.Show()
            Application.DoEvents()

            AddHandler menus.Shown, AddressOf Evento
        End Sub
        Private Sub Evento(sender As Object, ea As EventArgs)

            sp.BeginInvoke(DirectCast(Sub()
                                          sp.Close()
                                          sp.Dispose()
                                          sp = Nothing
                                      End Sub,
                                       Action))

        End Sub



    End Class
End Module
