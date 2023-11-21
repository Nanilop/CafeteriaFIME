Imports System.Data.SqlClient
Imports BOCafeteria
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Precios
    Private usuario As New BOUsuario
    Private modifica As PrecioModificar
    Private abierto As Boolean = False
    Public Sub New(user As BOUsuario)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.BackgroundImage = Image.FromFile("..\\..\\Resources\\Presentación1\\Diapositiva1.png")
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.FormBorderStyle = FormBorderStyle.None
        usuario = user
        recarga()

    End Sub
    Private Sub EventoRecarga(sender As Object, ea As EventArgs)
        recarga()
        modifica.Close()
        abierto = False
        Try
            Using sql As New SqlConnection("Data Source=DESKTOP-CUOAPA9\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True")
                sql.Open()
                Using cmd As New SqlCommand
                    With cmd
                        .Connection = sql
                        .CommandText = "REGISTROBitUsuario"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add(New SqlParameter("@id_Usuario", usuario.Id))
                        .Parameters.Add(New SqlParameter("@id_TipoVal", 64))
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
    End Sub
    Private Sub abre(sender As Object, ea As EventArgs)
        abierto = False
    End Sub
    Private Sub recarga()
        Dim dt As New DataTable()
        Try

            Using sql As New SqlConnection("Data Source=DESKTOP-CUOAPA9\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True")
                sql.Open()
                Using cmd As New SqlCommand
                    With cmd
                        .Connection = sql
                        .CommandType = CommandType.Text
                        .CommandText = "select p.*,isNull(c.NombreC,pr.NombreP) [Producto/Comida] from Precio p 
                                        left join comida c on p.id_Comida=c.id_Comida
                                        left join Producto pr on p.id_Producto=pr.id_Producto
                                        where p.id_TipoVal=3"
                    End With

                    Using da = New SqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using

        Catch ex As SqlException

            MessageBox.Show(ex.Message)

        End Try
        dgvPrecio.DataSource = dt
        dgvPrecio.Columns("PrecioSug").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvPrecio.Columns("id_Precio").Visible = False
        dgvPrecio.Columns("id_TipoVal").Visible = False
        dgvPrecio.Columns("id_Producto").Visible = False
        dgvPrecio.Columns("id_Comida").Visible = False
        dgvPrecio.Columns("VistaP").Visible = False
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If abierto Then
            MessageBox.Show("Guarde para modificar y cerrar")
        Else
            If dgvPrecio.SelectedRows.Count = 1 Then
                modifica = New PrecioModificar(dgvPrecio.SelectedRows(0).Cells("Producto/Comida").Value.ToString(), dgvPrecio.SelectedRows(0).Cells("PrecioSug").Value.ToString(), dgvPrecio.SelectedRows(0).Cells("id_Precio").Value.ToString())
                Application.DoEvents()
                AddHandler modifica.btnGuardarModPrec.Click, AddressOf EventoRecarga
                AddHandler modifica.FormClosed, AddressOf abre
                modifica.Show()
            Else
                MessageBox.Show("Seleccione un renglon")
            End If
            abierto = True
        End If
    End Sub
End Class