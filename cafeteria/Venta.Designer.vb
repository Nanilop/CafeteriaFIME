<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Venta))
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ResultadosP = New System.Windows.Forms.DataGridView()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.ListadoP = New System.Windows.Forms.DataGridView()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cop = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idpc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombrePC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioTot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbCambio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbPago = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.pbEliminar = New System.Windows.Forms.PictureBox()
        Me.pbAgregar = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.ResultadosP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ListadoP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(351, 46)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 28)
        Me.btnBuscar.TabIndex = 32
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBusqueda
        '
        Me.txtBusqueda.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtBusqueda.Location = New System.Drawing.Point(430, 50)
        Me.txtBusqueda.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(270, 20)
        Me.txtBusqueda.TabIndex = 0
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.cafeteria.My.Resources.Resources.Logotipo_cafe
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(103, 41)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(165, 151)
        Me.PictureBox5.TabIndex = 30
        Me.PictureBox5.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.ResultadosP)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Location = New System.Drawing.Point(310, 86)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(454, 118)
        Me.Panel3.TabIndex = 29
        '
        'ResultadosP
        '
        Me.ResultadosP.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ResultadosP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ResultadosP.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ResultadosP.ColumnHeadersHeight = 29
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ResultadosP.DefaultCellStyle = DataGridViewCellStyle2
        Me.ResultadosP.Location = New System.Drawing.Point(2, 24)
        Me.ResultadosP.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ResultadosP.Name = "ResultadosP"
        Me.ResultadosP.RowHeadersWidth = 51
        Me.ResultadosP.RowTemplate.Height = 24
        Me.ResultadosP.Size = New System.Drawing.Size(447, 91)
        Me.ResultadosP.TabIndex = 0
        Me.ResultadosP.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label10)
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(452, 20)
        Me.Panel7.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(187, 4)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "RESULTADOS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnImprimir)
        Me.Panel1.Controls.Add(Me.ListadoP)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtbCambio)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtbPago)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtbTotal)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(103, 209)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(661, 240)
        Me.Panel1.TabIndex = 28
        '
        'btnImprimir
        '
        Me.btnImprimir.BackgroundImage = Global.cafeteria.My.Resources.Resources.imprimir
        Me.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Location = New System.Drawing.Point(531, 155)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(58, 54)
        Me.btnImprimir.TabIndex = 3
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'ListadoP
        '
        Me.ListadoP.AllowUserToAddRows = False
        Me.ListadoP.AllowUserToDeleteRows = False
        Me.ListadoP.BackgroundColor = System.Drawing.Color.White
        Me.ListadoP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListadoP.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ListadoP.ColumnHeadersHeight = 29
        Me.ListadoP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.cop, Me.idpc, Me.NombrePC, Me.Precio, Me.PrecioTot})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ListadoP.DefaultCellStyle = DataGridViewCellStyle4
        Me.ListadoP.Location = New System.Drawing.Point(98, 31)
        Me.ListadoP.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListadoP.Name = "ListadoP"
        Me.ListadoP.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListadoP.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.ListadoP.RowHeadersWidth = 51
        Me.ListadoP.RowTemplate.Height = 24
        Me.ListadoP.Size = New System.Drawing.Size(361, 206)
        Me.ListadoP.TabIndex = 0
        Me.ListadoP.TabStop = False
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Cantidad.Frozen = True
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 74
        '
        'cop
        '
        Me.cop.Frozen = True
        Me.cop.HeaderText = "cop"
        Me.cop.MinimumWidth = 6
        Me.cop.Name = "cop"
        Me.cop.ReadOnly = True
        Me.cop.Visible = False
        Me.cop.Width = 125
        '
        'idpc
        '
        Me.idpc.Frozen = True
        Me.idpc.HeaderText = "idpc"
        Me.idpc.MinimumWidth = 6
        Me.idpc.Name = "idpc"
        Me.idpc.ReadOnly = True
        Me.idpc.Visible = False
        Me.idpc.Width = 125
        '
        'NombrePC
        '
        Me.NombrePC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NombrePC.Frozen = True
        Me.NombrePC.HeaderText = "Producto // Comida"
        Me.NombrePC.MinimumWidth = 6
        Me.NombrePC.Name = "NombrePC"
        Me.NombrePC.ReadOnly = True
        Me.NombrePC.Width = 126
        '
        'Precio
        '
        Me.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Precio.Frozen = True
        Me.Precio.HeaderText = "Precio"
        Me.Precio.MinimumWidth = 6
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 62
        '
        'PrecioTot
        '
        Me.PrecioTot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PrecioTot.Frozen = True
        Me.PrecioTot.HeaderText = "Precio Total"
        Me.PrecioTot.MinimumWidth = 6
        Me.PrecioTot.Name = "PrecioTot"
        Me.PrecioTot.ReadOnly = True
        Me.PrecioTot.Width = 89
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(182, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 26)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "PRODUCTOS EN NOTA"
        '
        'txtbCambio
        '
        Me.txtbCambio.Enabled = False
        Me.txtbCambio.Location = New System.Drawing.Point(562, 125)
        Me.txtbCambio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbCambio.Name = "txtbCambio"
        Me.txtbCambio.Size = New System.Drawing.Size(76, 20)
        Me.txtbCambio.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(491, 84)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "TOTAL"
        '
        'txtbPago
        '
        Me.txtbPago.Location = New System.Drawing.Point(562, 103)
        Me.txtbPago.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbPago.Name = "txtbPago"
        Me.txtbPago.Size = New System.Drawing.Size(76, 20)
        Me.txtbPago.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(491, 106)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "PAGO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(491, 128)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "CAMBIO"
        '
        'txtbTotal
        '
        Me.txtbTotal.Enabled = False
        Me.txtbTotal.Location = New System.Drawing.Point(562, 82)
        Me.txtbTotal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbTotal.Name = "txtbTotal"
        Me.txtbTotal.Size = New System.Drawing.Size(76, 20)
        Me.txtbTotal.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(494, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(160, 51)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente:"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(10, 17)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(144, 19)
        Me.txtCliente.TabIndex = 1
        '
        'pbEliminar
        '
        Me.pbEliminar.BackColor = System.Drawing.Color.Transparent
        Me.pbEliminar.BackgroundImage = CType(resources.GetObject("pbEliminar.BackgroundImage"), System.Drawing.Image)
        Me.pbEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbEliminar.Cursor = System.Windows.Forms.Cursors.No
        Me.pbEliminar.ErrorImage = Nothing
        Me.pbEliminar.Location = New System.Drawing.Point(272, 159)
        Me.pbEliminar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pbEliminar.Name = "pbEliminar"
        Me.pbEliminar.Size = New System.Drawing.Size(33, 33)
        Me.pbEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbEliminar.TabIndex = 27
        Me.pbEliminar.TabStop = False
        '
        'pbAgregar
        '
        Me.pbAgregar.BackColor = System.Drawing.Color.Transparent
        Me.pbAgregar.BackgroundImage = CType(resources.GetObject("pbAgregar.BackgroundImage"), System.Drawing.Image)
        Me.pbAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAgregar.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbAgregar.Location = New System.Drawing.Point(272, 118)
        Me.pbAgregar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pbAgregar.Name = "pbAgregar"
        Me.pbAgregar.Size = New System.Drawing.Size(33, 33)
        Me.pbAgregar.TabIndex = 26
        Me.pbAgregar.TabStop = False
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BackgroundImage = Global.cafeteria.My.Resources.Resources.Diapositiva1
        Me.ClientSize = New System.Drawing.Size(834, 460)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbEliminar)
        Me.Controls.Add(Me.pbAgregar)
        Me.Location = New System.Drawing.Point(0, 35)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Venta"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.ResultadosP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ListadoP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ResultadosP As DataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnImprimir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbCambio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbPago As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbTotal As TextBox
    Friend WithEvents pbEliminar As PictureBox
    Friend WithEvents pbAgregar As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents ListadoP As DataGridView
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents cop As DataGridViewTextBoxColumn
    Friend WithEvents idpc As DataGridViewTextBoxColumn
    Friend WithEvents NombrePC As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents PrecioTot As DataGridViewTextBoxColumn
End Class
