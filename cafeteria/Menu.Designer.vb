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
        Me.btnAyuda = New System.Windows.Forms.Label()
        Me.opciones = New System.Windows.Forms.Panel()
        Me.btnCerrarSesion = New System.Windows.Forms.Label()
        Me.btnUsuarios = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.PNotificaciones = New System.Windows.Forms.Panel()
        Me.PicVacio = New System.Windows.Forms.PictureBox()
        Me.notif = New System.Windows.Forms.PictureBox()
        Me.opciones.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicVacio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.notif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnHome.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHome.Location = New System.Drawing.Point(0, 0)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(65, 39)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Inicio"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVenta
        '
        Me.btnVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnVenta.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVenta.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVenta.ForeColor = System.Drawing.Color.White
        Me.btnVenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVenta.Location = New System.Drawing.Point(65, 0)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Size = New System.Drawing.Size(68, 39)
        Me.btnVenta.TabIndex = 1
        Me.btnVenta.Text = "Venta"
        Me.btnVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnInformes
        '
        Me.btnInformes.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnInformes.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInformes.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInformes.ForeColor = System.Drawing.Color.White
        Me.btnInformes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnInformes.Location = New System.Drawing.Point(238, 0)
        Me.btnInformes.Name = "btnInformes"
        Me.btnInformes.Size = New System.Drawing.Size(94, 39)
        Me.btnInformes.TabIndex = 3
        Me.btnInformes.Text = "Informes"
        Me.btnInformes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btninventario
        '
        Me.btninventario.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btninventario.Dock = System.Windows.Forms.DockStyle.Left
        Me.btninventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninventario.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninventario.ForeColor = System.Drawing.Color.White
        Me.btninventario.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btninventario.Location = New System.Drawing.Point(133, 0)
        Me.btninventario.Name = "btninventario"
        Me.btninventario.Size = New System.Drawing.Size(105, 39)
        Me.btninventario.TabIndex = 2
        Me.btninventario.Text = "Inventario"
        Me.btninventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAyuda
        '
        Me.btnAyuda.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnAyuda.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAyuda.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAyuda.ForeColor = System.Drawing.Color.White
        Me.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAyuda.Location = New System.Drawing.Point(424, 0)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(73, 39)
        Me.btnAyuda.TabIndex = 4
        Me.btnAyuda.Text = "Ayuda"
        Me.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'opciones
        '
        Me.opciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.opciones.Controls.Add(Me.btnCerrarSesion)
        Me.opciones.Controls.Add(Me.btnAyuda)
        Me.opciones.Controls.Add(Me.btnUsuarios)
        Me.opciones.Controls.Add(Me.btnInformes)
        Me.opciones.Controls.Add(Me.btninventario)
        Me.opciones.Controls.Add(Me.btnVenta)
        Me.opciones.Controls.Add(Me.btnHome)
        Me.opciones.Location = New System.Drawing.Point(81, 12)
        Me.opciones.Name = "opciones"
        Me.opciones.Size = New System.Drawing.Size(674, 39)
        Me.opciones.TabIndex = 6
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesion.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrarSesion.Location = New System.Drawing.Point(497, 0)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(133, 39)
        Me.btnCerrarSesion.TabIndex = 7
        Me.btnCerrarSesion.Text = "Cerrar Sesión"
        Me.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUsuarios
        '
        Me.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.Color.White
        Me.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUsuarios.Location = New System.Drawing.Point(332, 0)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(92, 39)
        Me.btnUsuarios.TabIndex = 6
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.PNotificaciones.Location = New System.Drawing.Point(0, 101)
        Me.PNotificaciones.Name = "PNotificaciones"
        Me.PNotificaciones.Size = New System.Drawing.Size(180, 400)
        Me.PNotificaciones.TabIndex = 8
        Me.PNotificaciones.Visible = False
        '
        'PicVacio
        '
        Me.PicVacio.BackColor = System.Drawing.Color.Chocolate
        Me.PicVacio.Image = Global.cafeteria.My.Resources.Resources.aceptaOrden
        Me.PicVacio.Location = New System.Drawing.Point(45, 254)
        Me.PicVacio.Name = "PicVacio"
        Me.PicVacio.Size = New System.Drawing.Size(82, 85)
        Me.PicVacio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicVacio.TabIndex = 12
        Me.PicVacio.TabStop = False
        Me.PicVacio.Visible = False
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
        Me.Controls.Add(Me.PicVacio)
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
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicVacio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.notif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHome As Label
    Friend WithEvents btnVenta As Label
    Friend WithEvents btnInformes As Label
    Friend WithEvents btninventario As Label
    Friend WithEvents btnAyuda As Label
    Friend WithEvents opciones As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnUsuarios As Label
    Friend WithEvents PNotificaciones As Panel
    Friend WithEvents notif As PictureBox
    Friend WithEvents PicVacio As PictureBox
    Friend WithEvents btnCerrarSesion As Label
End Class
