Public Class Applica
    Private mProcesarFic As Menu
    Private Sub Applica_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Applica_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

    End Sub

    Private Sub Applica_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Dim carga As Cargando = New Cargando()
        carga.Show()
        While (carga.ProgressBarCargando.Value < 100)
            carga.ProgressBarCargando.Value += 1
        End While
        mProcesarFic = New Menu()
        carga.ProgressBarCargando.Value = 100
        carga.Hide()
        mProcesarFic.Show()
    End Sub
End Class