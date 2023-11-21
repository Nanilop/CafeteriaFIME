<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.chkVista = New System.Windows.Forms.CheckBox()
        Me.chkInventario = New System.Windows.Forms.CheckBox()
        Me.chkUsuario = New System.Windows.Forms.CheckBox()
        Me.chkInforme = New System.Windows.Forms.CheckBox()
        Me.chkPrecio = New System.Windows.Forms.CheckBox()
        Me.chkVenta = New System.Windows.Forms.CheckBox()
        Me.txtprecioPrecioMod = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.btnGuardarModPrec = New System.Windows.Forms.Label()
        Me.look = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.look, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 104)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(440, 378)
        Me.DataGridView1.TabIndex = 0
        '
        'chkVista
        '
        Me.chkVista.AutoSize = True
        Me.chkVista.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.chkVista.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVista.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.chkVista.Location = New System.Drawing.Point(478, 395)
        Me.chkVista.Name = "chkVista"
        Me.chkVista.Size = New System.Drawing.Size(95, 23)
        Me.chkVista.TabIndex = 1
        Me.chkVista.Text = "Habilitado"
        Me.chkVista.UseVisualStyleBackColor = False
        '
        'chkInventario
        '
        Me.chkInventario.AutoSize = True
        Me.chkInventario.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.chkInventario.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInventario.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.chkInventario.Location = New System.Drawing.Point(478, 424)
        Me.chkInventario.Name = "chkInventario"
        Me.chkInventario.Size = New System.Drawing.Size(93, 23)
        Me.chkInventario.TabIndex = 2
        Me.chkInventario.Text = "Inventario"
        Me.chkInventario.UseVisualStyleBackColor = False
        '
        'chkUsuario
        '
        Me.chkUsuario.AutoSize = True
        Me.chkUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.chkUsuario.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.chkUsuario.Location = New System.Drawing.Point(478, 453)
        Me.chkUsuario.Name = "chkUsuario"
        Me.chkUsuario.Size = New System.Drawing.Size(78, 23)
        Me.chkUsuario.TabIndex = 3
        Me.chkUsuario.Text = "Usuario"
        Me.chkUsuario.UseVisualStyleBackColor = False
        '
        'chkInforme
        '
        Me.chkInforme.AutoSize = True
        Me.chkInforme.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.chkInforme.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInforme.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.chkInforme.Location = New System.Drawing.Point(583, 453)
        Me.chkInforme.Name = "chkInforme"
        Me.chkInforme.Size = New System.Drawing.Size(78, 23)
        Me.chkInforme.TabIndex = 8
        Me.chkInforme.Text = "Informe"
        Me.chkInforme.UseVisualStyleBackColor = False
        '
        'chkPrecio
        '
        Me.chkPrecio.AutoSize = True
        Me.chkPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.chkPrecio.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrecio.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.chkPrecio.Location = New System.Drawing.Point(583, 424)
        Me.chkPrecio.Name = "chkPrecio"
        Me.chkPrecio.Size = New System.Drawing.Size(68, 23)
        Me.chkPrecio.TabIndex = 7
        Me.chkPrecio.Text = "Precio"
        Me.chkPrecio.UseVisualStyleBackColor = False
        '
        'chkVenta
        '
        Me.chkVenta.AutoSize = True
        Me.chkVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.chkVenta.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVenta.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.chkVenta.Location = New System.Drawing.Point(583, 395)
        Me.chkVenta.Name = "chkVenta"
        Me.chkVenta.Size = New System.Drawing.Size(65, 23)
        Me.chkVenta.TabIndex = 6
        Me.chkVenta.Text = "Venta"
        Me.chkVenta.UseVisualStyleBackColor = False
        '
        'txtprecioPrecioMod
        '
        Me.txtprecioPrecioMod.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.txtprecioPrecioMod.Location = New System.Drawing.Point(478, 126)
        Me.txtprecioPrecioMod.Name = "txtprecioPrecioMod"
        Me.txtprecioPrecioMod.Size = New System.Drawing.Size(344, 33)
        Me.txtprecioPrecioMod.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.TextBox1.Location = New System.Drawing.Point(478, 183)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(344, 33)
        Me.TextBox1.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.TextBox2.Location = New System.Drawing.Point(478, 240)
        Me.TextBox2.MaxLength = 10
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(344, 33)
        Me.TextBox2.TabIndex = 11
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.TextBox3.Location = New System.Drawing.Point(478, 297)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(344, 33)
        Me.TextBox3.TabIndex = 12
        '
        'txtContraseña
        '
        Me.txtContraseña.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.txtContraseña.Location = New System.Drawing.Point(478, 356)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(344, 33)
        Me.txtContraseña.TabIndex = 13
        '
        'btnGuardarModPrec
        '
        Me.btnGuardarModPrec.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnGuardarModPrec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarModPrec.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarModPrec.ForeColor = System.Drawing.Color.White
        Me.btnGuardarModPrec.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardarModPrec.Location = New System.Drawing.Point(732, 437)
        Me.btnGuardarModPrec.Name = "btnGuardarModPrec"
        Me.btnGuardarModPrec.Size = New System.Drawing.Size(90, 39)
        Me.btnGuardarModPrec.TabIndex = 14
        Me.btnGuardarModPrec.Text = "Guardar"
        Me.btnGuardarModPrec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'look
        '
        Me.look.BackColor = System.Drawing.SystemColors.Window
        Me.look.Location = New System.Drawing.Point(788, 362)
        Me.look.Name = "look"
        Me.look.Size = New System.Drawing.Size(24, 21)
        Me.look.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.look.TabIndex = 15
        Me.look.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(474, 332)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(474, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(474, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(474, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Nombre de Usuario"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(474, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 20)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Email"
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 494)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.look)
        Me.Controls.Add(Me.btnGuardarModPrec)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtprecioPrecioMod)
        Me.Controls.Add(Me.chkInforme)
        Me.Controls.Add(Me.chkPrecio)
        Me.Controls.Add(Me.chkVenta)
        Me.Controls.Add(Me.chkUsuario)
        Me.Controls.Add(Me.chkInventario)
        Me.Controls.Add(Me.chkVista)
        Me.Controls.Add(Me.DataGridView1)
        Me.Location = New System.Drawing.Point(0, 35)
        Me.Name = "Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Tag = "Contraseña"
        Me.Text = "Usuarios"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.look, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents chkVista As CheckBox
    Friend WithEvents chkInventario As CheckBox
    Friend WithEvents chkUsuario As CheckBox
    Friend WithEvents chkInforme As CheckBox
    Friend WithEvents chkPrecio As CheckBox
    Friend WithEvents chkVenta As CheckBox
    Friend WithEvents txtprecioPrecioMod As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents btnGuardarModPrec As Label
    Friend WithEvents look As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
