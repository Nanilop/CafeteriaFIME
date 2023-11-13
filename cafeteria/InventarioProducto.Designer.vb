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
        Me.btnEliminarP = New System.Windows.Forms.Button()
        Me.btnModificarP = New System.Windows.Forms.Button()
        Me.btnRegresarP = New System.Windows.Forms.Button()
        Me.btnRegistrarP = New System.Windows.Forms.Button()
        Me.txtVistaP = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIDtipoval = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMaximoEx = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMinimoEx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCantidadEx = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIDproducto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEliminarP
        '
        Me.btnEliminarP.Location = New System.Drawing.Point(312, 138)
        Me.btnEliminarP.Name = "btnEliminarP"
        Me.btnEliminarP.Size = New System.Drawing.Size(102, 26)
        Me.btnEliminarP.TabIndex = 68
        Me.btnEliminarP.Text = "Eliminar"
        Me.btnEliminarP.UseVisualStyleBackColor = True
        '
        'btnModificarP
        '
        Me.btnModificarP.Location = New System.Drawing.Point(312, 93)
        Me.btnModificarP.Name = "btnModificarP"
        Me.btnModificarP.Size = New System.Drawing.Size(102, 26)
        Me.btnModificarP.TabIndex = 67
        Me.btnModificarP.Text = "Modificar"
        Me.btnModificarP.UseVisualStyleBackColor = True
        '
        'btnRegresarP
        '
        Me.btnRegresarP.Location = New System.Drawing.Point(312, 364)
        Me.btnRegresarP.Name = "btnRegresarP"
        Me.btnRegresarP.Size = New System.Drawing.Size(102, 26)
        Me.btnRegresarP.TabIndex = 66
        Me.btnRegresarP.Text = "BACK"
        Me.btnRegresarP.UseVisualStyleBackColor = True
        '
        'btnRegistrarP
        '
        Me.btnRegistrarP.Location = New System.Drawing.Point(312, 51)
        Me.btnRegistrarP.Name = "btnRegistrarP"
        Me.btnRegistrarP.Size = New System.Drawing.Size(102, 26)
        Me.btnRegistrarP.TabIndex = 65
        Me.btnRegistrarP.Text = "Registrar"
        Me.btnRegistrarP.UseVisualStyleBackColor = True
        '
        'txtVistaP
        '
        Me.txtVistaP.Location = New System.Drawing.Point(139, 273)
        Me.txtVistaP.Name = "txtVistaP"
        Me.txtVistaP.Size = New System.Drawing.Size(100, 20)
        Me.txtVistaP.TabIndex = 64
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(100, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Vista"
        '
        'txtIDtipoval
        '
        Me.txtIDtipoval.Location = New System.Drawing.Point(139, 233)
        Me.txtIDtipoval.Name = "txtIDtipoval"
        Me.txtIDtipoval.Size = New System.Drawing.Size(100, 20)
        Me.txtIDtipoval.TabIndex = 62
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(61, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "ID Tipo Valor"
        '
        'txtMaximoEx
        '
        Me.txtMaximoEx.Location = New System.Drawing.Point(139, 197)
        Me.txtMaximoEx.Name = "txtMaximoEx"
        Me.txtMaximoEx.Size = New System.Drawing.Size(100, 20)
        Me.txtMaximoEx.TabIndex = 60
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Maximo Existencia"
        '
        'txtMinimoEx
        '
        Me.txtMinimoEx.Location = New System.Drawing.Point(139, 161)
        Me.txtMinimoEx.Name = "txtMinimoEx"
        Me.txtMinimoEx.Size = New System.Drawing.Size(100, 20)
        Me.txtMinimoEx.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Minimo Existencia"
        '
        'txtCantidadEx
        '
        Me.txtCantidadEx.Location = New System.Drawing.Point(139, 126)
        Me.txtCantidadEx.Name = "txtCantidadEx"
        Me.txtCantidadEx.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidadEx.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Cantidad Existencia"
        '
        'txtNombreP
        '
        Me.txtNombreP.Location = New System.Drawing.Point(139, 90)
        Me.txtNombreP.Name = "txtNombreP"
        Me.txtNombreP.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreP.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Nombre"
        '
        'txtIDproducto
        '
        Me.txtIDproducto.Location = New System.Drawing.Point(139, 55)
        Me.txtIDproducto.Name = "txtIDproducto"
        Me.txtIDproducto.Size = New System.Drawing.Size(100, 20)
        Me.txtIDproducto.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "ID Producto"
        '
        'InventarioProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 410)
        Me.Controls.Add(Me.btnEliminarP)
        Me.Controls.Add(Me.btnModificarP)
        Me.Controls.Add(Me.btnRegresarP)
        Me.Controls.Add(Me.btnRegistrarP)
        Me.Controls.Add(Me.txtVistaP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtIDtipoval)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMaximoEx)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMinimoEx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCantidadEx)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombreP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIDproducto)
        Me.Controls.Add(Me.Label1)
        Me.Name = "InventarioProducto"
        Me.Text = "InventarioProducto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEliminarP As Button
    Friend WithEvents btnModificarP As Button
    Friend WithEvents btnRegresarP As Button
    Friend WithEvents btnRegistrarP As Button
    Friend WithEvents txtVistaP As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtIDtipoval As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMaximoEx As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMinimoEx As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCantidadEx As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombreP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIDproducto As TextBox
    Friend WithEvents Label1 As Label
End Class
