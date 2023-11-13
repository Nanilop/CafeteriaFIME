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
        Me.btnHome = New System.Windows.Forms.Label()
        Me.btnVenta = New System.Windows.Forms.Label()
        Me.btnInformes = New System.Windows.Forms.Label()
        Me.btninventario = New System.Windows.Forms.Label()
        Me.btnDescuento = New System.Windows.Forms.Label()
        Me.btnAyuda = New System.Windows.Forms.Label()
        Me.opciones = New System.Windows.Forms.Panel()
        Me.btnUsuarios = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.PNotificaciones = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.notif = New System.Windows.Forms.PictureBox()
        Me.opciones.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNotificaciones.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'PNotificaciones
        '
        Me.PNotificaciones.AutoScroll = True
        Me.PNotificaciones.BackColor = System.Drawing.Color.Chocolate
        Me.PNotificaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PNotificaciones.Controls.Add(Me.PictureBox2)
        Me.PNotificaciones.Controls.Add(Me.PictureBox1)
        Me.PNotificaciones.Controls.Add(Me.Label1)
        Me.PNotificaciones.Location = New System.Drawing.Point(0, 101)
        Me.PNotificaciones.Name = "PNotificaciones"
        Me.PNotificaciones.Size = New System.Drawing.Size(180, 400)
        Me.PNotificaciones.TabIndex = 8
        Me.PNotificaciones.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.cafeteria.My.Resources.Resources.cancelaOrden
        Me.PictureBox2.Location = New System.Drawing.Point(137, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.cafeteria.My.Resources.Resources.aceptaOrden
        Me.PictureBox1.Location = New System.Drawing.Point(106, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(6, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 26)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Inventario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Controls.Add(Me.PNotificaciones)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.opciones)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(855, 540)
        Me.MinimumSize = New System.Drawing.Size(855, 540)
        Me.Name = "Menu"
        Me.Text = "Cafeteria"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.opciones.ResumeLayout(False)
        Me.opciones.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNotificaciones.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PNotificaciones As Panel
    Friend WithEvents notif As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
