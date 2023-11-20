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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Venta))
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.opciones = New System.Windows.Forms.Panel()
        Me.btnUsuarios = New System.Windows.Forms.Label()
        Me.btnAyuda = New System.Windows.Forms.Label()
        Me.btnDescuento = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Label()
        Me.btnVenta = New System.Windows.Forms.Label()
        Me.btnInformes = New System.Windows.Forms.Label()
        Me.btninventario = New System.Windows.Forms.Label()
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
        Me.pbEliminar = New System.Windows.Forms.PictureBox()
        Me.pbAgregar = New System.Windows.Forms.PictureBox()
        Me.opciones.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.ResultadosP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ListadoP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'opciones
        '
        Me.opciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.opciones.Controls.Add(Me.btnUsuarios)
        Me.opciones.Controls.Add(Me.btnAyuda)
        Me.opciones.Controls.Add(Me.btnDescuento)
        Me.opciones.Controls.Add(Me.btnHome)
        Me.opciones.Controls.Add(Me.btnVenta)
        Me.opciones.Controls.Add(Me.btnInformes)
        Me.opciones.Controls.Add(Me.btninventario)
        Me.opciones.Location = New System.Drawing.Point(19, 5)
        Me.opciones.Margin = New System.Windows.Forms.Padding(4)
        Me.opciones.Name = "opciones"
        Me.opciones.Size = New System.Drawing.Size(805, 48)
        Me.opciones.TabIndex = 33
        '
        'btnUsuarios
        '
        Me.btnUsuarios.AutoSize = True
        Me.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.Color.White
        Me.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUsuarios.Location = New System.Drawing.Point(604, 7)
        Me.btnUsuarios.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(110, 33)
        Me.btnUsuarios.TabIndex = 6
        Me.btnUsuarios.Text = "Usuarios"
        '
        'btnAyuda
        '
        Me.btnAyuda.AutoSize = True
        Me.btnAyuda.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAyuda.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAyuda.ForeColor = System.Drawing.Color.White
        Me.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAyuda.Location = New System.Drawing.Point(720, 6)
        Me.btnAyuda.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(83, 33)
        Me.btnAyuda.TabIndex = 4
        Me.btnAyuda.Text = "Ayuda"
        '
        'btnDescuento
        '
        Me.btnDescuento.AutoSize = True
        Me.btnDescuento.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDescuento.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescuento.ForeColor = System.Drawing.Color.White
        Me.btnDescuento.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDescuento.Location = New System.Drawing.Point(449, 6)
        Me.btnDescuento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btnDescuento.Name = "btnDescuento"
        Me.btnDescuento.Size = New System.Drawing.Size(142, 33)
        Me.btnDescuento.TabIndex = 5
        Me.btnDescuento.Text = "Descuentos"
        '
        'btnHome
        '
        Me.btnHome.AutoSize = True
        Me.btnHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHome.Location = New System.Drawing.Point(12, 6)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(73, 33)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Inicio"
        '
        'btnVenta
        '
        Me.btnVenta.AutoSize = True
        Me.btnVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVenta.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVenta.ForeColor = System.Drawing.Color.White
        Me.btnVenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVenta.Location = New System.Drawing.Point(97, 6)
        Me.btnVenta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Size = New System.Drawing.Size(78, 33)
        Me.btnVenta.TabIndex = 1
        Me.btnVenta.Text = "Venta"
        '
        'btnInformes
        '
        Me.btnInformes.AutoSize = True
        Me.btnInformes.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInformes.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInformes.ForeColor = System.Drawing.Color.White
        Me.btnInformes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnInformes.Location = New System.Drawing.Point(325, 6)
        Me.btnInformes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btnInformes.Name = "btnInformes"
        Me.btnInformes.Size = New System.Drawing.Size(112, 33)
        Me.btnInformes.TabIndex = 3
        Me.btnInformes.Text = "Informes"
        '
        'btninventario
        '
        Me.btninventario.AutoSize = True
        Me.btninventario.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btninventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninventario.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninventario.ForeColor = System.Drawing.Color.White
        Me.btninventario.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btninventario.Location = New System.Drawing.Point(187, 6)
        Me.btninventario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btninventario.Name = "btninventario"
        Me.btninventario.Size = New System.Drawing.Size(126, 33)
        Me.btninventario.TabIndex = 2
        Me.btninventario.Text = "Inventario"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(543, 66)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 34)
        Me.btnBuscar.TabIndex = 32
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBusqueda
        '
        Me.txtBusqueda.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtBusqueda.Location = New System.Drawing.Point(649, 72)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(359, 22)
        Me.txtBusqueda.TabIndex = 31
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(212, 60)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(220, 186)
        Me.PictureBox5.TabIndex = 30
        Me.PictureBox5.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.ResultadosP)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Location = New System.Drawing.Point(488, 116)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(605, 145)
        Me.Panel3.TabIndex = 29
        '
        'ResultadosP
        '
        Me.ResultadosP.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ResultadosP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ResultadosP.Location = New System.Drawing.Point(3, 30)
        Me.ResultadosP.Name = "ResultadosP"
        Me.ResultadosP.RowHeadersWidth = 51
        Me.ResultadosP.RowTemplate.Height = 24
        Me.ResultadosP.Size = New System.Drawing.Size(596, 112)
        Me.ResultadosP.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label10)
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(602, 24)
        Me.Panel7.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(249, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 16)
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
        Me.Panel1.Location = New System.Drawing.Point(212, 267)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(881, 295)
        Me.Panel1.TabIndex = 28
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(699, 187)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(132, 27)
        Me.btnImprimir.TabIndex = 7
        Me.btnImprimir.Text = "IMPRIMIR TICKET"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'ListadoP
        '
        Me.ListadoP.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ListadoP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListadoP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.NombrePC, Me.Precio, Me.PrecioTot})
        Me.ListadoP.Location = New System.Drawing.Point(3, 39)
        Me.ListadoP.Name = "ListadoP"
        Me.ListadoP.RowHeadersWidth = 51
        Me.ListadoP.RowTemplate.Height = 24
        Me.ListadoP.Size = New System.Drawing.Size(649, 253)
        Me.ListadoP.TabIndex = 17
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Cantidad.Frozen = True
        Me.Cantidad.HeaderText = "CANT"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 73
        '
        'NombrePC
        '
        Me.NombrePC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NombrePC.Frozen = True
        Me.NombrePC.HeaderText = "PRODUCTO/COMIDA"
        Me.NombrePC.MinimumWidth = 6
        Me.NombrePC.Name = "NombrePC"
        Me.NombrePC.ReadOnly = True
        Me.NombrePC.Width = 169
        '
        'Precio
        '
        Me.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Precio.Frozen = True
        Me.Precio.HeaderText = "PRECIO"
        Me.Precio.MinimumWidth = 6
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 86
        '
        'PrecioTot
        '
        Me.PrecioTot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PrecioTot.Frozen = True
        Me.PrecioTot.HeaderText = "PRECIOT"
        Me.PrecioTot.MinimumWidth = 6
        Me.PrecioTot.Name = "PrecioTot"
        Me.PrecioTot.ReadOnly = True
        Me.PrecioTot.Width = 95
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(156, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 31)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "PRODUCTOS EN NOTA"
        '
        'txtbCambio
        '
        Me.txtbCambio.Location = New System.Drawing.Point(763, 154)
        Me.txtbCambio.Name = "txtbCambio"
        Me.txtbCambio.Size = New System.Drawing.Size(100, 22)
        Me.txtbCambio.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(669, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "TOTAL"
        '
        'txtbPago
        '
        Me.txtbPago.Location = New System.Drawing.Point(763, 127)
        Me.txtbPago.Name = "txtbPago"
        Me.txtbPago.Size = New System.Drawing.Size(100, 22)
        Me.txtbPago.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(669, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "PAGO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(669, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "CAMBIO"
        '
        'txtbTotal
        '
        Me.txtbTotal.Location = New System.Drawing.Point(763, 101)
        Me.txtbTotal.Name = "txtbTotal"
        Me.txtbTotal.Size = New System.Drawing.Size(100, 22)
        Me.txtbTotal.TabIndex = 4
        '
        'pbEliminar
        '
        Me.pbEliminar.BackColor = System.Drawing.Color.Transparent
        Me.pbEliminar.BackgroundImage = CType(resources.GetObject("pbEliminar.BackgroundImage"), System.Drawing.Image)
        Me.pbEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbEliminar.Cursor = System.Windows.Forms.Cursors.No
        Me.pbEliminar.ErrorImage = Nothing
        Me.pbEliminar.Location = New System.Drawing.Point(438, 205)
        Me.pbEliminar.Name = "pbEliminar"
        Me.pbEliminar.Size = New System.Drawing.Size(44, 41)
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
        Me.pbAgregar.Location = New System.Drawing.Point(438, 155)
        Me.pbAgregar.Name = "pbAgregar"
        Me.pbAgregar.Size = New System.Drawing.Size(44, 41)
        Me.pbAgregar.TabIndex = 26
        Me.pbAgregar.TabStop = False
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BackgroundImage = Global.cafeteria.My.Resources.Resources.Diapositiva1
        Me.ClientSize = New System.Drawing.Size(1112, 566)
        Me.Controls.Add(Me.opciones)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbEliminar)
        Me.Controls.Add(Me.pbAgregar)
        Me.Location = New System.Drawing.Point(0, 35)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Venta"
        Me.opciones.ResumeLayout(False)
        Me.opciones.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.ResultadosP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ListadoP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents opciones As Panel
    Friend WithEvents btnUsuarios As Label
    Friend WithEvents btnAyuda As Label
    Friend WithEvents btnDescuento As Label
    Friend WithEvents btnHome As Label
    Friend WithEvents btnVenta As Label
    Friend WithEvents btnInformes As Label
    Friend WithEvents btninventario As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ResultadosP As DataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnImprimir As Button
    Friend WithEvents ListadoP As DataGridView
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents NombrePC As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents PrecioTot As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbCambio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbPago As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbTotal As TextBox
    Friend WithEvents pbEliminar As PictureBox
    Friend WithEvents pbAgregar As PictureBox
End Class
