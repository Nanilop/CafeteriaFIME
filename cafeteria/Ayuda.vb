Imports System.Data.SqlClient
Imports System.IO
Imports BOCafeteria

Public Class Ayuda
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim archivo As New SaveFileDialog()
        archivo.Filter = "PDF|*.pdf"
        If (archivo.ShowDialog = DialogResult.OK) Then
            File.Copy("..\\..\\Resources\\patrones de bordado.pdf", archivo.FileName)
            MessageBox.Show("Guardado")
            Try
                Using sql As New SqlConnection("Data Source=DESKTOP-CUOAPA9\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True")
                    sql.Open()
                    Using cmd As New SqlCommand
                        With cmd
                            .Connection = sql
                            .CommandText = "REGISTROBitUsuario"
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@id_Usuario", usuario.Id))
                            .Parameters.Add(New SqlParameter("@id_TipoVal", 31))
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
        End If
    End Sub

    Private Sub Label2_MouseMove(sender As Object, e As MouseEventArgs) Handles Label2.MouseMove
        parpadeo(sender, True)
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        parpadeo(sender, False)
    End Sub
    Private Sub parpadeo(lab As Label, inOut As Boolean)
        Dim col As Color = Color.FromArgb(197, 90, 17)
        If inOut Then
            lab.ForeColor = col
            lab.BackColor = Color.White

        Else
            lab.BackColor = Color.Transparent
            lab.ForeColor = Color.White
        End If
    End Sub
End Class