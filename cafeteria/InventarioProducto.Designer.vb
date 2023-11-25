<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventarioProducto
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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkvistaP = New System.Windows.Forms.CheckBox()
        Me.txtIDproducto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCantidadEx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMinimoEx = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMaximoEx = New System.Windows.Forms.TextBox()
        Me.btnEliminarP = New System.Windows.Forms.Button()
        Me.btnModificarP = New System.Windows.Forms.Button()
        Me.btnRegresarP = New System.Windows.Forms.Button()
        Me.btnRegistrarP = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = Global.cafeteria.My.Resources.Resources.buscar
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(572, 31)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(113, 43)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Image = Global.cafeteria.My.Resources.Resources.limpiar
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiar.Location = New System.Drawing.Point(572, 86)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(113, 46)
        Me.btnLimpiar.TabIndex = 9
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.chkvistaP)
        Me.GroupBox1.Controls.Add(Me.txtIDproducto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombreP)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCantidadEx)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtMinimoEx)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtMaximoEx)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(30, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 283)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos"
        '
        'chkvistaP
        '
        Me.chkvistaP.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkvistaP.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.chkvistaP.Location = New System.Drawing.Point(145, 237)
        Me.chkvistaP.Name = "chkvistaP"
        Me.chkvistaP.Size = New System.Drawing.Size(84, 27)
        Me.chkvistaP.TabIndex = 65
        Me.chkvistaP.Text = "Vista: "
        Me.chkvistaP.UseVisualStyleBackColor = True
        '
        'txtIDproducto
        '
        Me.txtIDproducto.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.txtIDproducto.Location = New System.Drawing.Point(215, 36)
        Me.txtIDproducto.Name = "txtIDproducto"
        Me.txtIDproducto.Size = New System.Drawing.Size(277, 31)
        Me.txtIDproducto.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 26)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Codigo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(119, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 26)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Nombre:"
        '
        'txtNombreP
        '
        Me.txtNombreP.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.txtNombreP.Location = New System.Drawing.Point(215, 76)
        Me.txtNombreP.Name = "txtNombreP"
        Me.txtNombreP.Size = New System.Drawing.Size(277, 31)
        Me.txtNombreP.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 26)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Cantidad Existencia:"
        '
        'txtCantidadEx
        '
        Me.txtCantidadEx.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.txtCantidadEx.Location = New System.Drawing.Point(215, 116)
        Me.txtCantidadEx.Name = "txtCantidadEx"
        Me.txtCantidadEx.Size = New System.Drawing.Size(277, 31)
        Me.txtCantidadEx.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 26)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Minimo Existencia:"
        '
        'txtMinimoEx
        '
        Me.txtMinimoEx.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.txtMinimoEx.Location = New System.Drawing.Point(215, 156)
        Me.txtMinimoEx.Name = "txtMinimoEx"
        Me.txtMinimoEx.Size = New System.Drawing.Size(277, 31)
        Me.txtMinimoEx.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 26)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Maximo Existencia:"
        '
        'txtMaximoEx
        '
        Me.txtMaximoEx.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.txtMaximoEx.Location = New System.Drawing.Point(215, 196)
        Me.txtMaximoEx.Name = "txtMaximoEx"
        Me.txtMaximoEx.Size = New System.Drawing.Size(277, 31)
        Me.txtMaximoEx.TabIndex = 5
        '
        'btnEliminarP
        '
        Me.btnEliminarP.Enabled = False
        Me.btnEliminarP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarP.Image = Global.cafeteria.My.Resources.Resources.eliminar
        Me.btnEliminarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarP.Location = New System.Drawing.Point(343, 325)
        Me.btnEliminarP.Name = "btnEliminarP"
        Me.btnEliminarP.Size = New System.Drawing.Size(113, 44)
        Me.btnEliminarP.TabIndex = 12
        Me.btnEliminarP.Text = "Eliminar"
        Me.btnEliminarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminarP.UseVisualStyleBackColor = True
        Me.btnEliminarP.Visible = False
        '
        'btnModificarP
        '
        Me.btnModificarP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarP.Image = Global.cafeteria.My.Resources.Resources.editar
        Me.btnModificarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificarP.Location = New System.Drawing.Point(572, 199)
        Me.btnModificarP.Name = "btnModificarP"
        Me.btnModificarP.Size = New System.Drawing.Size(113, 46)
        Me.btnModificarP.TabIndex = 11
        Me.btnModificarP.Text = "Editar"
        Me.btnModificarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificarP.UseVisualStyleBackColor = True
        '
        'btnRegresarP
        '
        Me.btnRegresarP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresarP.Image = Global.cafeteria.My.Resources.Resources.salir
        Me.btnRegresarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegresarP.Location = New System.Drawing.Point(572, 257)
        Me.btnRegresarP.Name = "btnRegresarP"
        Me.btnRegresarP.Size = New System.Drawing.Size(113, 43)
        Me.btnRegresarP.TabIndex = 13
        Me.btnRegresarP.Text = "Regresar"
        Me.btnRegresarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegresarP.UseVisualStyleBackColor = True
        '
        'btnRegistrarP
        '
        Me.btnRegistrarP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarP.Image = Global.cafeteria.My.Resources.Resources.anadir
        Me.btnRegistrarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrarP.Location = New System.Drawing.Point(572, 144)
        Me.btnRegistrarP.Name = "btnRegistrarP"
        Me.btnRegistrarP.Size = New System.Drawing.Size(113, 43)
        Me.btnRegistrarP.TabIndex = 10
        Me.btnRegistrarP.Text = "Añadir"
        Me.btnRegistrarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegistrarP.UseVisualStyleBackColor = True
        '
        'InventarioProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 381)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEliminarP)
        Me.Controls.Add(Me.btnModificarP)
        Me.Controls.Add(Me.btnRegresarP)
        Me.Controls.Add(Me.btnRegistrarP)
        Me.Name = "InventarioProducto"
        Me.Text = "InventarioProducto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtIDproducto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCantidadEx As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMinimoEx As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMaximoEx As TextBox
    Friend WithEvents btnEliminarP As Button
    Friend WithEvents btnModificarP As Button
    Friend WithEvents btnRegresarP As Button
    Friend WithEvents btnRegistrarP As Button
    Friend WithEvents chkvistaP As CheckBox
End Class
