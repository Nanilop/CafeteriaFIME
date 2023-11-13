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
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ResultadosP = New System.Windows.Forms.DataGridView()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.txtbCambio = New System.Windows.Forms.TextBox()
        Me.txtbPago = New System.Windows.Forms.TextBox()
        Me.txtbTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ListadoP = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.pbModificar = New System.Windows.Forms.PictureBox()
        Me.pbEliminar = New System.Windows.Forms.PictureBox()
        Me.pbAgregar = New System.Windows.Forms.PictureBox()
        Me.pbBuscar = New System.Windows.Forms.PictureBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.opciones = New System.Windows.Forms.Panel()
        Me.btnUsuarios = New System.Windows.Forms.Label()
        Me.btnAyuda = New System.Windows.Forms.Label()
        Me.btnDescuento = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Label()
        Me.btnVenta = New System.Windows.Forms.Label()
        Me.btnInformes = New System.Windows.Forms.Label()
        Me.btninventario = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3.SuspendLayout()
        CType(Me.ResultadosP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ListadoP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.opciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBusqueda
        '
        Me.txtBusqueda.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtBusqueda.Location = New System.Drawing.Point(622, 103)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(149, 22)
        Me.txtBusqueda.TabIndex = 21
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.ResultadosP)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Location = New System.Drawing.Point(540, 129)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(230, 162)
        Me.Panel3.TabIndex = 19
        '
        'ResultadosP
        '
        Me.ResultadosP.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ResultadosP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ResultadosP.Location = New System.Drawing.Point(3, 30)
        Me.ResultadosP.Name = "ResultadosP"
        Me.ResultadosP.RowHeadersWidth = 51
        Me.ResultadosP.RowTemplate.Height = 24
        Me.ResultadosP.Size = New System.Drawing.Size(224, 126)
        Me.ResultadosP.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label10)
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(230, 24)
        Me.Panel7.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(64, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "RESULTADOS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(139, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "CLIENTE"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnImprimir)
        Me.Panel2.Controls.Add(Me.txtbCambio)
        Me.Panel2.Controls.Add(Me.txtbPago)
        Me.Panel2.Controls.Add(Me.txtbTotal)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(540, 297)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(231, 150)
        Me.Panel2.TabIndex = 16
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(48, 116)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(132, 27)
        Me.btnImprimir.TabIndex = 7
        Me.btnImprimir.Text = "IMPRIMIR TICKET"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'txtbCambio
        '
        Me.txtbCambio.Location = New System.Drawing.Point(112, 83)
        Me.txtbCambio.Name = "txtbCambio"
        Me.txtbCambio.Size = New System.Drawing.Size(100, 22)
        Me.txtbCambio.TabIndex = 6
        '
        'txtbPago
        '
        Me.txtbPago.Location = New System.Drawing.Point(112, 56)
        Me.txtbPago.Name = "txtbPago"
        Me.txtbPago.Size = New System.Drawing.Size(100, 22)
        Me.txtbPago.TabIndex = 5
        '
        'txtbTotal
        '
        Me.txtbTotal.Location = New System.Drawing.Point(112, 30)
        Me.txtbTotal.Name = "txtbTotal"
        Me.txtbTotal.Size = New System.Drawing.Size(100, 22)
        Me.txtbTotal.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "CAMBIO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "PAGO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "TOTAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "CIERRE DE VENTA"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ListadoP)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(24, 181)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(494, 264)
        Me.Panel1.TabIndex = 15
        '
        'ListadoP
        '
        Me.ListadoP.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ListadoP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListadoP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column1, Me.Column2, Me.Column5, Me.Column4})
        Me.ListadoP.Location = New System.Drawing.Point(8, 39)
        Me.ListadoP.Name = "ListadoP"
        Me.ListadoP.RowHeadersWidth = 51
        Me.ListadoP.RowTemplate.Height = 24
        Me.ListadoP.Size = New System.Drawing.Size(483, 212)
        Me.ListadoP.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(91, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 31)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "PRODUCTOS EN NOTA"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(24, 79)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(109, 96)
        Me.PictureBox5.TabIndex = 20
        Me.PictureBox5.TabStop = False
        '
        'pbModificar
        '
        Me.pbModificar.BackColor = System.Drawing.Color.Transparent
        Me.pbModificar.BackgroundImage = CType(resources.GetObject("pbModificar.BackgroundImage"), System.Drawing.Image)
        Me.pbModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbModificar.Location = New System.Drawing.Point(781, 242)
        Me.pbModificar.Name = "pbModificar"
        Me.pbModificar.Size = New System.Drawing.Size(44, 41)
        Me.pbModificar.TabIndex = 14
        Me.pbModificar.TabStop = False
        '
        'pbEliminar
        '
        Me.pbEliminar.BackColor = System.Drawing.Color.Transparent
        Me.pbEliminar.BackgroundImage = CType(resources.GetObject("pbEliminar.BackgroundImage"), System.Drawing.Image)
        Me.pbEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbEliminar.Cursor = System.Windows.Forms.Cursors.No
        Me.pbEliminar.ErrorImage = Nothing
        Me.pbEliminar.Location = New System.Drawing.Point(782, 196)
        Me.pbEliminar.Name = "pbEliminar"
        Me.pbEliminar.Size = New System.Drawing.Size(44, 41)
        Me.pbEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbEliminar.TabIndex = 13
        Me.pbEliminar.TabStop = False
        '
        'pbAgregar
        '
        Me.pbAgregar.BackColor = System.Drawing.Color.Transparent
        Me.pbAgregar.BackgroundImage = CType(resources.GetObject("pbAgregar.BackgroundImage"), System.Drawing.Image)
        Me.pbAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAgregar.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbAgregar.Location = New System.Drawing.Point(781, 149)
        Me.pbAgregar.Name = "pbAgregar"
        Me.pbAgregar.Size = New System.Drawing.Size(44, 41)
        Me.pbAgregar.TabIndex = 12
        Me.pbAgregar.TabStop = False
        '
        'pbBuscar
        '
        Me.pbBuscar.BackColor = System.Drawing.Color.Transparent
        Me.pbBuscar.BackgroundImage = CType(resources.GetObject("pbBuscar.BackgroundImage"), System.Drawing.Image)
        Me.pbBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbBuscar.Cursor = System.Windows.Forms.Cursors.No
        Me.pbBuscar.ErrorImage = Nothing
        Me.pbBuscar.Location = New System.Drawing.Point(784, 104)
        Me.pbBuscar.Name = "pbBuscar"
        Me.pbBuscar.Size = New System.Drawing.Size(41, 41)
        Me.pbBuscar.TabIndex = 11
        Me.pbBuscar.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(540, 103)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(76, 22)
        Me.btnBuscar.TabIndex = 22
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Location = New System.Drawing.Point(245, 116)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(85, 20)
        Me.RadioButton1.TabIndex = 23
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "ALUMNO"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Location = New System.Drawing.Point(245, 142)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(95, 20)
        Me.RadioButton2.TabIndex = 24
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "MAESTRO"
        Me.RadioButton2.UseVisualStyleBackColor = False
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
        Me.opciones.Location = New System.Drawing.Point(14, 13)
        Me.opciones.Margin = New System.Windows.Forms.Padding(4)
        Me.opciones.Name = "opciones"
        Me.opciones.Size = New System.Drawing.Size(805, 48)
        Me.opciones.TabIndex = 25
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
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Column3
        '
        Me.Column3.Frozen = True
        Me.Column3.HeaderText = "CANT"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 47
        '
        'Column1
        '
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "PRODUCTO/COMIDA"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 200
        '
        'Column2
        '
        Me.Column2.Frozen = True
        Me.Column2.HeaderText = "PRECIO"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 60
        '
        'Column5
        '
        Me.Column5.Frozen = True
        Me.Column5.HeaderText = "DESC."
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 50
        '
        'Column4
        '
        Me.Column4.Frozen = True
        Me.Column4.HeaderText = "PRECIOT"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 70
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BackgroundImage = Global.cafeteria.My.Resources.Resources.Diapositiva1
        Me.ClientSize = New System.Drawing.Size(832, 452)
        Me.Controls.Add(Me.opciones)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbModificar)
        Me.Controls.Add(Me.pbEliminar)
        Me.Controls.Add(Me.pbAgregar)
        Me.Controls.Add(Me.pbBuscar)
        Me.Name = "Venta"
        Me.Text = "Venta"
        Me.Panel3.ResumeLayout(False)
        CType(Me.ResultadosP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ListadoP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.opciones.ResumeLayout(False)
        Me.opciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ResultadosP As DataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtbCambio As TextBox
    Friend WithEvents txtbPago As TextBox
    Friend WithEvents txtbTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ListadoP As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents pbModificar As PictureBox
    Friend WithEvents pbEliminar As PictureBox
    Friend WithEvents pbAgregar As PictureBox
    Friend WithEvents pbBuscar As PictureBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnImprimir As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents opciones As Panel
    Friend WithEvents btnUsuarios As Label
    Friend WithEvents btnAyuda As Label
    Friend WithEvents btnDescuento As Label
    Friend WithEvents btnHome As Label
    Friend WithEvents btnVenta As Label
    Friend WithEvents btnInformes As Label
    Friend WithEvents btninventario As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
