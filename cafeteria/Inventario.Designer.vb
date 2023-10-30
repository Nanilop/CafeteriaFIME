<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario
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
        Me.txtVistaP = New System.Windows.Forms.TextBox()
        Me.btnRegistrarP = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIDtipoval = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMaxExP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMinExP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtExistenciaP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIDproducto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvInventario = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnActualizarP = New System.Windows.Forms.Button()
        Me.btnEditarP = New System.Windows.Forms.Button()
        Me.btnEliminarP = New System.Windows.Forms.Button()
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtVistaP
        '
        Me.txtVistaP.Location = New System.Drawing.Point(696, 87)
        Me.txtVistaP.Name = "txtVistaP"
        Me.txtVistaP.Size = New System.Drawing.Size(58, 20)
        Me.txtVistaP.TabIndex = 32
        '
        'btnRegistrarP
        '
        Me.btnRegistrarP.Location = New System.Drawing.Point(152, 136)
        Me.btnRegistrarP.Name = "btnRegistrarP"
        Me.btnRegistrarP.Size = New System.Drawing.Size(102, 26)
        Me.btnRegistrarP.TabIndex = 31
        Me.btnRegistrarP.Text = "Registrar"
        Me.btnRegistrarP.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(660, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Vista"
        '
        'txtIDtipoval
        '
        Me.txtIDtipoval.Location = New System.Drawing.Point(544, 83)
        Me.txtIDtipoval.Name = "txtIDtipoval"
        Me.txtIDtipoval.Size = New System.Drawing.Size(100, 20)
        Me.txtIDtipoval.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(447, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Codigo Tipo Valor"
        '
        'txtMaxExP
        '
        Me.txtMaxExP.Location = New System.Drawing.Point(323, 83)
        Me.txtMaxExP.Name = "txtMaxExP"
        Me.txtMaxExP.Size = New System.Drawing.Size(100, 20)
        Me.txtMaxExP.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(222, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Maximo Existencia"
        '
        'txtMinExP
        '
        Me.txtMinExP.Location = New System.Drawing.Point(105, 82)
        Me.txtMinExP.Name = "txtMinExP"
        Me.txtMinExP.Size = New System.Drawing.Size(100, 20)
        Me.txtMinExP.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Minimo Existencia"
        '
        'txtExistenciaP
        '
        Me.txtExistenciaP.Location = New System.Drawing.Point(544, 42)
        Me.txtExistenciaP.Name = "txtExistenciaP"
        Me.txtExistenciaP.Size = New System.Drawing.Size(100, 20)
        Me.txtExistenciaP.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(438, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Cantidad Existencia"
        '
        'txtNombreP
        '
        Me.txtNombreP.Location = New System.Drawing.Point(323, 42)
        Me.txtNombreP.Name = "txtNombreP"
        Me.txtNombreP.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreP.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(222, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nombre Producto"
        '
        'txtIDproducto
        '
        Me.txtIDproducto.Location = New System.Drawing.Point(105, 42)
        Me.txtIDproducto.Name = "txtIDproducto"
        Me.txtIDproducto.Size = New System.Drawing.Size(100, 20)
        Me.txtIDproducto.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Codigo Producto"
        '
        'dgvInventario
        '
        Me.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventario.Location = New System.Drawing.Point(8, 177)
        Me.dgvInventario.Name = "dgvInventario"
        Me.dgvInventario.Size = New System.Drawing.Size(764, 271)
        Me.dgvInventario.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(640, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Label8"
        '
        'btnActualizarP
        '
        Me.btnActualizarP.Location = New System.Drawing.Point(284, 136)
        Me.btnActualizarP.Name = "btnActualizarP"
        Me.btnActualizarP.Size = New System.Drawing.Size(102, 26)
        Me.btnActualizarP.TabIndex = 34
        Me.btnActualizarP.Text = "Actualizar"
        Me.btnActualizarP.UseVisualStyleBackColor = True
        '
        'btnEditarP
        '
        Me.btnEditarP.Location = New System.Drawing.Point(409, 136)
        Me.btnEditarP.Name = "btnEditarP"
        Me.btnEditarP.Size = New System.Drawing.Size(102, 26)
        Me.btnEditarP.TabIndex = 35
        Me.btnEditarP.Text = "Editar"
        Me.btnEditarP.UseVisualStyleBackColor = True
        '
        'btnEliminarP
        '
        Me.btnEliminarP.Location = New System.Drawing.Point(533, 136)
        Me.btnEliminarP.Name = "btnEliminarP"
        Me.btnEliminarP.Size = New System.Drawing.Size(102, 26)
        Me.btnEliminarP.TabIndex = 36
        Me.btnEliminarP.Text = "Eliminar"
        Me.btnEliminarP.UseVisualStyleBackColor = True
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 460)
        Me.Controls.Add(Me.btnEliminarP)
        Me.Controls.Add(Me.btnEditarP)
        Me.Controls.Add(Me.btnActualizarP)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtVistaP)
        Me.Controls.Add(Me.btnRegistrarP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtIDtipoval)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMaxExP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMinExP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtExistenciaP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombreP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIDproducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvInventario)
        Me.Location = New System.Drawing.Point(0, 60)
        Me.Name = "Inventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Inventario"
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtVistaP As TextBox
    Friend WithEvents btnRegistrarP As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtIDtipoval As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMaxExP As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMinExP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtExistenciaP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombreP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIDproducto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvInventario As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents btnActualizarP As Button
    Friend WithEvents btnEditarP As Button
    Friend WithEvents btnEliminarP As Button
End Class
