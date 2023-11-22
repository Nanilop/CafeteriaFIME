Imports System.Data.SqlClient
Imports System.Runtime.ConstrainedExecution
Imports BOCafeteria

Public Class Usuarios
    Private usuario As New BOUsuario
    Private ver As Boolean = False
    Private modifica As InsModUsuario
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
                        .CommandText = "select id_Usuario,Nombre,Telefono,email as Email,
                                        NombreU as [Nombre de Usuario],Contrasena as Contraseña,Vista,Inventario,
                                        Usuario,Venta,Informes,Precios from Usuarios where id_Usuario!=1"
                    End With

                    Using da = New SqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using

        Catch ex As SqlException

            MessageBox.Show(ex.Message)

        End Try
        dgvusuarios.DataSource = dt
        dgvusuarios.Columns("Contraseña").Visible = False
        dgvusuarios.Columns("Nombre de Usuario").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvusuarios.Columns("id_Usuario").Visible = False
        dgvusuarios.Columns("Vista").Visible = False
        dgvusuarios.Columns("Inventario").Visible = False
        dgvusuarios.Columns("Usuario").Visible = False
        dgvusuarios.Columns("Venta").Visible = False
        dgvusuarios.Columns("Informes").Visible = False
        dgvusuarios.Columns("Precios").Visible = False
    End Sub
    Private Sub abre(sender As Object, ea As EventArgs)
        abierto = False
    End Sub
    Private Sub btnModifica_Click(sender As Object, e As EventArgs) Handles btnModifica.Click
        If abierto Then
            MessageBox.Show("Guardeo cierre para modificar")
        Else
            If dgvusuarios.SelectedRows.Count = 1 Then
                abierto = True
                modifica = New InsModUsuario(usuario, dgvusuarios.SelectedRows(0).Cells("id_Usuario").Value.ToString())
                Application.DoEvents()
                AddHandler modifica.btnGuardarModPrec.Click, AddressOf EventoRecarga
                AddHandler modifica.FormClosed, AddressOf abre
                modifica.Show()
            Else
                MessageBox.Show("Seleccione un renglon.")
            End If

        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If abierto Then
            MessageBox.Show("Guarde o cierre para insertar uno nuevo")
        Else

            abierto = True
                modifica = New InsModUsuario(usuario)
                Application.DoEvents()
                AddHandler modifica.btnGuardarModPrec.Click, AddressOf EventoRecarga
                AddHandler modifica.FormClosed, AddressOf abre
            modifica.Show()
        End If
    End Sub
End Class