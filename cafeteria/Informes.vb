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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
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
        'hoja_trabajo.Cells(1, 1) = "Nombre"
        'hoja_trabajo.Cells(1, 2) = "Usuario"
        'hoja_trabajo.Cells(1, 3) = "Lenguaje"
        'hoja_trabajo.Cells(1, 4) = "Archivo"
        'hoja_trabajo.Cells(1, 5) = "Fecha_Hora"
        'For Each fila As DataGridViewRow In dgvInformes.Rows

        '    hoja_trabajo.Cells(a, 1) = fila.Cells(0).Value.ToString()
        '    hoja_trabajo.Cells(a, 2) = fila.Cells(1).Value.ToString()
        '    hoja_trabajo.Cells(a, 3) = fila.Cells(2).Value.ToString()
        '    hoja_trabajo.Cells(a, 4) = fila.Cells(3).Value.ToString()
        '    hoja_trabajo.Cells(a, 5) = fila.Cells(4).Value.ToString()
        '    a += 1

        'Next
        libros_trabajo.SaveAs(dialogoGuardar.FileName)
        libros_trabajo.Close(True)
        aplicacion.Quit()
    End Sub
End Class