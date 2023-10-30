<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnHome = New System.Windows.Forms.Label()
        Me.btnVenta = New System.Windows.Forms.Label()
        Me.btnInformes = New System.Windows.Forms.Label()
        Me.btninventario = New System.Windows.Forms.Label()
        Me.btnDescuento = New System.Windows.Forms.Label()
        Me.btnAyuda = New System.Windows.Forms.Label()
        Me.opciones = New System.Windows.Forms.Panel()
        Me.btnUsuarios = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EntregarOrden = New System.Windows.Forms.DataGridViewImageColumn()
        Me.CancelarOrden = New System.Windows.Forms.DataGridViewImageColumn()
        Me.VerOrden = New System.Windows.Forms.DataGridViewImageColumn()
        Me.notif = New System.Windows.Forms.PictureBox()
        Me.opciones.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.notif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHome
        '
        Me.btnHome.AutoSize = True
        Me.btnHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHome.Location = New System.Drawing.Point(9, 5)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(58, 26)
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
        Me.btnVenta.Location = New System.Drawing.Point(73, 5)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Size = New System.Drawing.Size(61, 26)
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
        Me.btnInformes.Location = New System.Drawing.Point(244, 5)
        Me.btnInformes.Name = "btnInformes"
        Me.btnInformes.Size = New System.Drawing.Size(87, 26)
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
        Me.btninventario.Location = New System.Drawing.Point(140, 5)
        Me.btninventario.Name = "btninventario"
        Me.btninventario.Size = New System.Drawing.Size(98, 26)
        Me.btninventario.TabIndex = 2
        Me.btninventario.Text = "Inventario"
        '
        'btnDescuento
        '
        Me.btnDescuento.AutoSize = True
        Me.btnDescuento.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDescuento.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescuento.ForeColor = System.Drawing.Color.White
        Me.btnDescuento.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDescuento.Location = New System.Drawing.Point(337, 5)
        Me.btnDescuento.Name = "btnDescuento"
        Me.btnDescuento.Size = New System.Drawing.Size(110, 26)
        Me.btnDescuento.TabIndex = 5
        Me.btnDescuento.Text = "Descuentos"
        '
        'btnAyuda
        '
        Me.btnAyuda.AutoSize = True
        Me.btnAyuda.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAyuda.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAyuda.ForeColor = System.Drawing.Color.White
        Me.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAyuda.Location = New System.Drawing.Point(540, 5)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(66, 26)
        Me.btnAyuda.TabIndex = 4
        Me.btnAyuda.Text = "Ayuda"
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
        Me.opciones.Location = New System.Drawing.Point(81, 12)
        Me.opciones.Name = "opciones"
        Me.opciones.Size = New System.Drawing.Size(617, 39)
        Me.opciones.TabIndex = 6
        '
        'btnUsuarios
        '
        Me.btnUsuarios.AutoSize = True
        Me.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.Color.White
        Me.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUsuarios.Location = New System.Drawing.Point(453, 6)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(85, 26)
        Me.btnUsuarios.TabIndex = 6
        Me.btnUsuarios.Text = "Usuarios"
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Location = New System.Drawing.Point(12, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(57, 51)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 7
        Me.picLogo.TabStop = False
        Me.picLogo.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(12, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(161, 388)
        Me.Panel1.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EntregarOrden, Me.CancelarOrden, Me.VerOrden})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlText
        Me.DataGridView1.Location = New System.Drawing.Point(0, 33)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(161, 369)
        Me.DataGridView1.TabIndex = 0
        '
        'EntregarOrden
        '
        Me.EntregarOrden.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle13.NullValue = CType(resources.GetObject("DataGridViewCellStyle13.NullValue"), Object)
        Me.EntregarOrden.DefaultCellStyle = DataGridViewCellStyle13
        Me.EntregarOrden.FillWeight = 10.0!
        Me.EntregarOrden.HeaderText = ""
        Me.EntregarOrden.Image = Global.cafeteria.My.Resources.Resources.aceptaOrden
        Me.EntregarOrden.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.EntregarOrden.MinimumWidth = 20
        Me.EntregarOrden.Name = "EntregarOrden"
        Me.EntregarOrden.Visible = False
        '
        'CancelarOrden
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle14.NullValue = CType(resources.GetObject("DataGridViewCellStyle14.NullValue"), Object)
        Me.CancelarOrden.DefaultCellStyle = DataGridViewCellStyle14
        Me.CancelarOrden.FillWeight = 10.0!
        Me.CancelarOrden.HeaderText = ""
        Me.CancelarOrden.Image = Global.cafeteria.My.Resources.Resources.cancelaOrden
        Me.CancelarOrden.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.CancelarOrden.Name = "CancelarOrden"
        Me.CancelarOrden.Visible = False
        Me.CancelarOrden.Width = 20
        '
        'VerOrden
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle15.NullValue = CType(resources.GetObject("DataGridViewCellStyle15.NullValue"), Object)
        Me.VerOrden.DefaultCellStyle = DataGridViewCellStyle15
        Me.VerOrden.FillWeight = 10.0!
        Me.VerOrden.HeaderText = ""
        Me.VerOrden.Image = Global.cafeteria.My.Resources.Resources.verOrden
        Me.VerOrden.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.VerOrden.Name = "VerOrden"
        Me.VerOrden.Visible = False
        Me.VerOrden.Width = 20
        '
        'notif
        '
        Me.notif.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.notif.Image = Global.cafeteria.My.Resources.Resources.notificacion1
        Me.notif.Location = New System.Drawing.Point(12, 69)
        Me.notif.Name = "notif"
        Me.notif.Size = New System.Drawing.Size(25, 27)
        Me.notif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.notif.TabIndex = 9
        Me.notif.TabStop = False
        Me.notif.Visible = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.cafeteria.My.Resources.Resources.Diapositiva1
        Me.ClientSize = New System.Drawing.Size(839, 501)
        Me.Controls.Add(Me.notif)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.opciones)
        Me.MaximizeBox = False
        Me.Name = "Menu"
        Me.Text = "Cafeteria"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.opciones.ResumeLayout(False)
        Me.opciones.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.notif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHome As Label
    Friend WithEvents btnVenta As Label
    Friend WithEvents btnInformes As Label
    Friend WithEvents btninventario As Label
    Friend WithEvents btnDescuento As Label
    Friend WithEvents btnAyuda As Label
    Friend WithEvents opciones As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnUsuarios As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EntregarOrden As DataGridViewImageColumn
    Friend WithEvents CancelarOrden As DataGridViewImageColumn
    Friend WithEvents VerOrden As DataGridViewImageColumn
    Friend WithEvents notif As PictureBox
End Class
