Imports System.Data.SqlClient
Imports BOCafeteria
Imports Excel = Microsoft.Office.Interop.Excel


Public Class Informes
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles btnExportaInfo.Click
        Dim dialogoGuardar = New SaveFileDialog()
        dialogoGuardar.Filter = "Hoja de cálculo de Microsoft Excel (*.xlsx)|*.xlsx"
        If (dialogoGuardar.ShowDialog() = DialogResult.Cancel) Then
            Return
        End If


        Dim aplicacion As New Excel.Application()
        Dim libros_trabajo As Excel.Workbook
        Dim hoja_trabajo As Excel.Worksheet

        libros_trabajo = aplicacion.Workbooks.Add()
        hoja_trabajo = CType(libros_trabajo.Worksheets.Item(1), Excel.Worksheet)

        Dim a As Integer = 2
        If cbInformes.SelectedIndex = 0 Then
            'Reporte de Venta
            hoja_trabajo.Cells(1, 1) = "A Nombre de"
            hoja_trabajo.Cells(1, 2) = "Fecha"
            hoja_trabajo.Cells(1, 3) = "Total"
            hoja_trabajo.Cells(1, 4) = "Pago"
            hoja_trabajo.Cells(1, 5) = "Cambio"
            hoja_trabajo.Cells(1, 6) = "Vendedor"
            hoja_trabajo.Cells(1, 7) = "Usuario"
            hoja_trabajo.Cells(1, 8) = "Telefono"
            hoja_trabajo.Cells(1, 9) = "Estatus"
            For Each fila As DataGridViewRow In dgvInformes.Rows

                hoja_trabajo.Cells(a, 1) = fila.Cells(0).Value.ToString()
                hoja_trabajo.Cells(a, 2) = fila.Cells(1).Value.ToString()
                hoja_trabajo.Cells(a, 3) = fila.Cells(2).Value.ToString()
                hoja_trabajo.Cells(a, 4) = fila.Cells(3).Value.ToString()
                hoja_trabajo.Cells(a, 5) = fila.Cells(4).Value.ToString()
                hoja_trabajo.Cells(a, 6) = fila.Cells(5).Value.ToString()
                hoja_trabajo.Cells(a, 7) = fila.Cells(6).Value.ToString()
                hoja_trabajo.Cells(a, 8) = fila.Cells(7).Value.ToString()
                hoja_trabajo.Cells(a, 9) = fila.Cells(8).Value.ToString()
                a += 1
            Next
            Try
                Using sql As New SqlConnection("Data Source=DESKTOP-CUOAPA9\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True")
                    sql.Open()
                    Using cmd As New SqlCommand
                        With cmd
                            .Connection = sql
                            .CommandText = "REGISTROBitUsuario"
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@id_Usuario", usuario.Id))
                            .Parameters.Add(New SqlParameter("@id_TipoVal", 56))
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
        ElseIf cbInformes.SelectedIndex = 1 Then
            'Reporte de Historial de Usuarios
            hoja_trabajo.Cells(1, 1) = "Fecha"
            hoja_trabajo.Cells(1, 2) = "Empleado"
            hoja_trabajo.Cells(1, 3) = "Telefono"
            hoja_trabajo.Cells(1, 4) = "Email"
            hoja_trabajo.Cells(1, 5) = "Usuario"
            hoja_trabajo.Cells(1, 6) = "Accion"
            For Each fila As DataGridViewRow In dgvInformes.Rows
                hoja_trabajo.Cells(a, 1) = fila.Cells(0).Value.ToString()
                hoja_trabajo.Cells(a, 2) = fila.Cells(1).Value.ToString()
                hoja_trabajo.Cells(a, 3) = fila.Cells(2).Value.ToString()
                hoja_trabajo.Cells(a, 4) = fila.Cells(3).Value.ToString()
                hoja_trabajo.Cells(a, 5) = fila.Cells(4).Value.ToString()
                hoja_trabajo.Cells(a, 6) = fila.Cells(5).Value.ToString()
                a += 1
            Next
            Try
                Using sql As New SqlConnection("Data Source=DESKTOP-CUOAPA9\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True")
                    sql.Open()
                    Using cmd As New SqlCommand
                        With cmd
                            .Connection = sql
                            .CommandText = "REGISTROBitUsuario"
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@id_Usuario", usuario.Id))
                            .Parameters.Add(New SqlParameter("@id_TipoVal", 57))
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
        ElseIf cbInformes.SelectedIndex = 2 Then
            'Reporte de Inventarios
            hoja_trabajo.Cells(1, 1) = "Fecha"
            hoja_trabajo.Cells(1, 2) = "Cantidad"
            hoja_trabajo.Cells(1, 3) = "Producto"
            hoja_trabajo.Cells(1, 4) = "Accion"
            hoja_trabajo.Cells(1, 5) = "Empleado"
            hoja_trabajo.Cells(1, 6) = "Telefono"
            hoja_trabajo.Cells(1, 7) = "Usuario"
            For Each fila As DataGridViewRow In dgvInformes.Rows
                hoja_trabajo.Cells(a, 1) = fila.Cells(0).Value.ToString()
                hoja_trabajo.Cells(a, 2) = fila.Cells(1).Value.ToString()
                hoja_trabajo.Cells(a, 3) = fila.Cells(2).Value.ToString()
                hoja_trabajo.Cells(a, 4) = fila.Cells(3).Value.ToString()
                hoja_trabajo.Cells(a, 5) = fila.Cells(4).Value.ToString()
                hoja_trabajo.Cells(a, 6) = fila.Cells(5).Value.ToString()
                hoja_trabajo.Cells(a, 7) = fila.Cells(6).Value.ToString()
                a += 1
            Next
            Try
                Using sql As New SqlConnection("Data Source=DESKTOP-CUOAPA9\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True")
                    sql.Open()
                    Using cmd As New SqlCommand
                        With cmd
                            .Connection = sql
                            .CommandText = "REGISTROBitUsuario"
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@id_Usuario", usuario.Id))
                            .Parameters.Add(New SqlParameter("@id_TipoVal", 55))
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
        libros_trabajo.SaveAs(dialogoGuardar.FileName)
        libros_trabajo.Close(True)
        aplicacion.Quit()
        MessageBox.Show("Exportado")
    End Sub

    Private Sub btnBuscarInformes_Click(sender As Object, e As EventArgs) Handles btnBuscarInformes.Click
        If cbInformes.SelectedIndex = 0 Then
            'Reporte de Venta
            Dim consult As String = ""
            If chkfinInfo.Checked And chkInicioInfo.Checked Then
                consult = "Select * from InformeVenta where convert(date,Fecha)>='" + dtInicioInfome.Value.ToString("yyyy/MM/dd") + "' and convert(date,Fecha)<='" + dtFinInfo.Value.ToString("yyyy/MM/dd") + "'"
            ElseIf chkInicioInfo.Checked Then
                consult = "Select * from InformeVenta where convert(date,Fecha)>='" + dtInicioInfome.Value.ToString("yyyy/MM/dd") + "' "

            ElseIf chkfinInfo.Checked Then
                consult = "Select * from InformeVenta where convert(date,Fecha)<='" + dtFinInfo.Value.ToString("yyyy/MM/dd") + "'"
            Else
                consult = "Select * from InformeVenta"
            End If
            Dim dt As New DataTable

            Try

                Using sql As New SqlConnection("Data Source=DESKTOP-CUOAPA9\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True")
                    sql.Open()
                    Using cmd As New SqlCommand
                        With cmd
                            .Connection = sql
                            .CommandType = CommandType.Text
                            .CommandText = consult
                        End With

                        Using da = New SqlDataAdapter(cmd)
                            da.Fill(dt)
                        End Using
                    End Using
                End Using

            Catch ex As SqlException

                MessageBox.Show(ex.Message)

            End Try
            dgvInformes.DataSource = dt
            dgvInformes.Columns("Fecha").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Try
                Using sql As New SqlConnection("Data Source=DESKTOP-CUOAPA9\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True")
                    sql.Open()
                    Using cmd As New SqlCommand
                        With cmd
                            .Connection = sql
                            .CommandText = "REGISTROBitUsuario"
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@id_Usuario", usuario.Id))
                            .Parameters.Add(New SqlParameter("@id_TipoVal", 59))
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

        ElseIf cbInformes.SelectedIndex = 1 Then
            'Reporte de Historial de Usuarios
            Dim consult As String = ""
            If chkfinInfo.Checked And chkInicioInfo.Checked Then
                consult = "Select * from InformeHistorialUsuarios where convert(date,Fecha)>='" + dtInicioInfome.Value.ToString("yyyy/MM/dd") + "' and convert(date,Fecha)<='" + dtFinInfo.Value.ToString("yyyy/MM/dd") + "'"
            ElseIf chkInicioInfo.Checked Then
                consult = "Select * from InformeHistorialUsuarios where convert(date,Fecha)>='" + dtInicioInfome.Value.ToString("yyyy/MM/dd") + "' "

            ElseIf chkfinInfo.Checked Then
                consult = "Select * from InformeHistorialUsuarios where convert(date,Fecha)<='" + dtFinInfo.Value.ToString("yyyy/MM/dd") + "'"
            Else
                consult = "Select * from InformeHistorialUsuarios"
            End If
            Dim dt As New DataTable

            Try

                Using sql As New SqlConnection("Data Source=DESKTOP-CUOAPA9\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True")
                    sql.Open()
                    Using cmd As New SqlCommand
                        With cmd
                            .Connection = sql
                            .CommandType = CommandType.Text
                            .CommandText = consult
                        End With

                        Using da = New SqlDataAdapter(cmd)
                            da.Fill(dt)
                        End Using
                    End Using
                End Using

            Catch ex As SqlException

                MessageBox.Show(ex.Message)

            End Try
            dgvInformes.DataSource = dt
            dgvInformes.Columns("Fecha").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Try
                Using sql As New SqlConnection("Data Source=DESKTOP-CUOAPA9\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True")
                    sql.Open()
                    Using cmd As New SqlCommand
                        With cmd
                            .Connection = sql
                            .CommandText = "REGISTROBitUsuario"
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@id_Usuario", usuario.Id))
                            .Parameters.Add(New SqlParameter("@id_TipoVal", 60))
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
        ElseIf cbInformes.SelectedIndex = 2 Then
            'Reporte de Inventario
            Dim consult As String = ""
            If chkfinInfo.Checked And chkInicioInfo.Checked Then
                consult = "Select * from InformeInventario where convert(date,Fecha)>='" + dtInicioInfome.Value.ToString("yyyy/MM/dd") + "' and convert(date,Fecha)<='" + dtFinInfo.Value.ToString("yyyy/MM/dd") + "'"
            ElseIf chkInicioInfo.Checked Then
                consult = "Select * from InformeInventario where convert(date,Fecha)>='" + dtInicioInfome.Value.ToString("yyyy/MM/dd") + "' "

            ElseIf chkfinInfo.Checked Then
                consult = "Select * from InformeInventario where convert(date,Fecha)<='" + dtFinInfo.Value.ToString("yyyy/MM/dd") + "'"
            Else
                consult = "Select * from InformeInventario"
            End If
            Dim dt As New DataTable

            Try

                Using sql As New SqlConnection("Data Source=DESKTOP-CUOAPA9\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True")
                    sql.Open()
                    Using cmd As New SqlCommand
                        With cmd
                            .Connection = sql
                            .CommandType = CommandType.Text
                            .CommandText = consult
                        End With

                        Using da = New SqlDataAdapter(cmd)
                            da.Fill(dt)
                        End Using
                    End Using
                End Using

            Catch ex As SqlException

                MessageBox.Show(ex.Message)

            End Try
            dgvInformes.DataSource = dt
            dgvInformes.Columns("Fecha").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            Try
                Using sql As New SqlConnection("Data Source=DESKTOP-CUOAPA9\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True")
                    sql.Open()
                    Using cmd As New SqlCommand
                        With cmd
                            .Connection = sql
                            .CommandText = "REGISTROBitUsuario"
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@id_Usuario", usuario.Id))
                            .Parameters.Add(New SqlParameter("@id_TipoVal", 58))
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

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkInicioInfo.CheckedChanged
        If chkInicioInfo.Checked Then
            dtInicioInfome.Enabled = True
        Else
            dtInicioInfome.Enabled = False
        End If
    End Sub

    Private Sub chkfinInfo_CheckedChanged(sender As Object, e As EventArgs) Handles chkfinInfo.CheckedChanged
        If chkfinInfo.Checked Then
            dtFinInfo.Enabled = True
        Else
            dtFinInfo.Enabled = False
        End If
    End Sub
End Class