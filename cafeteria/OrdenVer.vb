Imports System.Data.SqlClient
Imports BOCafeteria

Public Class OrdenVer
    Private usuario As New BOUsuario()
    Private idVentas As String = ""
    Public Sub New(idventa As String, user As BOUsuario)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        usuario = user
        idVentas = idventa
        Dim dt As New DataTable
        Try

            Using sql As New SqlConnection("Data Source=DESKTOP-CUOAPA9\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True")

                sql.Open()

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = sql
                        .CommandType = CommandType.Text
                        .CommandText = "select  NombreV from Venta where id_TipoVal='7' and VistaV=1 and Id_Venta=" + idventa.ToString() + ""
                    End With

                    Using da = New SqlDataAdapter(cmd)

                        da.Fill(dt)

                    End Using

                End Using
                sql.Close()
            End Using

        Catch ex As SqlException

            MessageBox.Show(ex.Message)

        End Try
        For Each row As DataRow In dt.Rows
            labelOrdenVer.Text = row(0)
        Next
        Dim dtalle As New DataTable
        Try

            Using sql As New SqlConnection("Data Source=DESKTOP-CUOAPA9\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True")

                sql.Open()

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = sql
                        .CommandType = CommandType.Text
                        .CommandText = "select c.NombreC,d.Cantidad,d.PrecioVenta from DetalleVenta d inner join Comida c on d.id_Comida=c.id_Comida where d.id_Venta=" + idventa.ToString() + " and d.Vista=1 and d.id_Comida is not null"
                    End With

                    Using da = New SqlDataAdapter(cmd)

                        da.Fill(dtalle)

                    End Using

                End Using
                sql.Close()
            End Using

        Catch ex As SqlException

            MessageBox.Show(ex.Message)

        End Try
        dgvDetalleOrden.DataSource=dtalle
    End Sub

    Private Sub OrdenVer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEntrega_Click(sender As Object, e As EventArgs) Handles btnEntrega.Click
        Dim response As Integer = 0
        Try
            Using sql As New SqlConnection("Data Source=DESKTOP-CUOAPA9\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True")
                sql.Open()
                Using cmd As New SqlCommand
                    With cmd
                        .Connection = sql
                        .CommandText = "ModificaVentaEntregar"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add(New SqlParameter("@id_Usuario", usuario.Id))
                        .Parameters.Add(New SqlParameter("@id_Venta", idVentas))
                    End With
                    response = cmd.ExecuteNonQuery()
                End Using
                sql.Close()
            End Using
            MessageBox.Show("Entregado")
        Catch ex As SqlException

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnCancela_Click(sender As Object, e As EventArgs) Handles btnCancela.Click
        Dim response As Integer = 0
        Try
            Using sql As New SqlConnection("Data Source=DESKTOP-CUOAPA9\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True")
                sql.Open()
                Using cmd As New SqlCommand
                    With cmd
                        .Connection = sql
                        .CommandText = "ModificaVentaCancela"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add(New SqlParameter("@id_Usuario", usuario.Id))
                        .Parameters.Add(New SqlParameter("@id_Venta", idVentas))
                    End With
                    response = cmd.ExecuteNonQuery()
                End Using
                sql.Close()
            End Using
            MessageBox.Show("Cancelado")
        Catch ex As SqlException

            MessageBox.Show(ex.Message)

        End Try

    End Sub
End Class