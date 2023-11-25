Imports System.Data.SqlClient

Public Class PrecioModificar
    Private identificador As String = ""
    Public Sub New(nombre As String, precio As String, id As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.BackgroundImage = Image.FromFile("..\\..\\Resources\\Presentación1\\Diapositiva1.png")
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.MaximizeBox = False
        Me.MinimizeBox = False

        txtNombreProdPrec.Text = nombre
        txtprecioPrecioMod.Text = precio
        identificador = id
    End Sub
    Private Sub parpadeo(lab As Label, inOut As Boolean)
        Dim col As Color = Color.FromArgb(229, 150, 96)
        If inOut Then
            lab.ForeColor = col
            lab.BackColor = Color.White

        Else
            lab.BackColor = col
            lab.ForeColor = Color.White
        End If

    End Sub
    Private Sub btnGuardarModPrec_MouseLeave(sender As Object, e As EventArgs) Handles btnGuardarModPrec.MouseLeave
        parpadeo(sender, False)
    End Sub

    Private Sub btnGuardarModPrec_MouseMove(sender As Object, e As MouseEventArgs) Handles btnGuardarModPrec.MouseMove
        parpadeo(sender, True)
    End Sub

    Private Sub txtprecioPrecioMod_Leave(sender As Object, e As EventArgs) Handles txtprecioPrecioMod.Leave
        txtprecioPrecioMod.Text = Convert.ToDouble(txtprecioPrecioMod.Text).ToString("0.00")
    End Sub
    Private punto As Boolean = False
    Private Sub txtprecioPrecioMod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecioPrecioMod.KeyPress
        Dim a = txtprecioPrecioMod.Text.ToArray()
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
    End Sub

    Private Sub btnGuardarModPrec_Click(sender As Object, e As EventArgs) Handles btnGuardarModPrec.Click
        Try
            Using sql As New SqlConnection("Data Source=DESKTOP-CUOAPA9\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True")
                sql.Open()
                Using cmd As New SqlCommand
                    With cmd
                        .Connection = sql
                        .CommandText = "ModificaPrecio"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add(New SqlParameter("@id_Precio", identificador))
                        .Parameters.Add(New SqlParameter("@PrecioSug", txtprecioPrecioMod.Text))
                    End With
                    cmd.ExecuteNonQuery()
                End Using
                sql.Close()
            End Using
        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class