<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventarioComida
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
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtIDtipoval = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdComida = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHoraInicio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtHoraFin = New System.Windows.Forms.TextBox()
        Me.txtVistaC = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnEliminarC = New System.Windows.Forms.Button()
        Me.btnModificarC = New System.Windows.Forms.Button()
        Me.btnRegresarC = New System.Windows.Forms.Button()
        Me.btnRegistrarC = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Image = Global.cafeteria.My.Resources.Resources.limpiar
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiar.Location = New System.Drawing.Point(744, 119)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(153, 53)
        Me.btnLimpiar.TabIndex = 8
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = Global.cafeteria.My.Resources.Resources.buscar
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(744, 55)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(153, 53)
        Me.btnBuscar.TabIndex = 7
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.txtIDtipoval)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtIdComida)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombreC)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtHoraInicio)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtHoraFin)
        Me.GroupBox1.Controls.Add(Me.txtVistaC)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(55, 39)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(643, 320)
        Me.GroupBox1.TabIndex = 80
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comidas"
        '
        'txtIDtipoval
        '
        Me.txtIDtipoval.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDtipoval.Location = New System.Drawing.Point(235, 126)
        Me.txtIDtipoval.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIDtipoval.Name = "txtIDtipoval"
        Me.txtIDtipoval.Size = New System.Drawing.Size(369, 30)
        Me.txtIDtipoval.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 29)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Codigo:"
        '
        'txtIdComida
        '
        Me.txtIdComida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdComida.Location = New System.Drawing.Point(235, 37)
        Me.txtIdComida.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIdComida.Name = "txtIdComida"
        Me.txtIdComida.Size = New System.Drawing.Size(369, 30)
        Me.txtIdComida.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(95, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 29)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Nombre:"
        '
        'txtNombreC
        '
        Me.txtNombreC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreC.Location = New System.Drawing.Point(235, 80)
        Me.txtNombreC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombreC.Name = "txtNombreC"
        Me.txtNombreC.Size = New System.Drawing.Size(369, 30)
        Me.txtNombreC.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 171)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 29)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Hora de Inicio:"
        '
        'txtHoraInicio
        '
        Me.txtHoraInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraInicio.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraInicio.Location = New System.Drawing.Point(235, 171)
        Me.txtHoraInicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtHoraInicio.Name = "txtHoraInicio"
        Me.txtHoraInicio.Size = New System.Drawing.Size(369, 30)
        Me.txtHoraInicio.TabIndex = 4
        Me.txtHoraInicio.Text = "Formato HH:mm"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 213)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 29)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Hora de Fin:"
        '
        'txtHoraFin
        '
        Me.txtHoraFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraFin.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraFin.Location = New System.Drawing.Point(235, 213)
        Me.txtHoraFin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtHoraFin.Name = "txtHoraFin"
        Me.txtHoraFin.Size = New System.Drawing.Size(369, 30)
        Me.txtHoraFin.TabIndex = 5
        Me.txtHoraFin.Text = "Formato HH:mm"
        '
        'txtVistaC
        '
        Me.txtVistaC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVistaC.Location = New System.Drawing.Point(235, 256)
        Me.txtVistaC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtVistaC.Name = "txtVistaC"
        Me.txtVistaC.Size = New System.Drawing.Size(369, 30)
        Me.txtVistaC.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(71, 126)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 29)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Tipo Valor:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(133, 256)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 29)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Vista:"
        '
        'btnEliminarC
        '
        Me.btnEliminarC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarC.Image = Global.cafeteria.My.Resources.Resources.eliminar
        Me.btnEliminarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarC.Location = New System.Drawing.Point(744, 306)
        Me.btnEliminarC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEliminarC.Name = "btnEliminarC"
        Me.btnEliminarC.Size = New System.Drawing.Size(153, 53)
        Me.btnEliminarC.TabIndex = 11
        Me.btnEliminarC.Text = "Eliminar"
        Me.btnEliminarC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminarC.UseVisualStyleBackColor = True
        '
        'btnModificarC
        '
        Me.btnModificarC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarC.Image = Global.cafeteria.My.Resources.Resources.editar
        Me.btnModificarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificarC.Location = New System.Drawing.Point(744, 242)
        Me.btnModificarC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnModificarC.Name = "btnModificarC"
        Me.btnModificarC.Size = New System.Drawing.Size(153, 53)
        Me.btnModificarC.TabIndex = 10
        Me.btnModificarC.Text = "Editar"
        Me.btnModificarC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificarC.UseVisualStyleBackColor = True
        '
        'btnRegresarC
        '
        Me.btnRegresarC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresarC.Image = Global.cafeteria.My.Resources.Resources.salir
        Me.btnRegresarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegresarC.Location = New System.Drawing.Point(55, 378)
        Me.btnRegresarC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRegresarC.Name = "btnRegresarC"
        Me.btnRegresarC.Size = New System.Drawing.Size(165, 52)
        Me.btnRegresarC.TabIndex = 12
        Me.btnRegresarC.Text = "Regresar"
        Me.btnRegresarC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegresarC.UseVisualStyleBackColor = True
        '
        'btnRegistrarC
        '
        Me.btnRegistrarC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarC.Image = Global.cafeteria.My.Resources.Resources.anadir
        Me.btnRegistrarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrarC.Location = New System.Drawing.Point(744, 182)
        Me.btnRegistrarC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRegistrarC.Name = "btnRegistrarC"
        Me.btnRegistrarC.Size = New System.Drawing.Size(153, 53)
        Me.btnRegistrarC.TabIndex = 9
        Me.btnRegistrarC.Text = "Añadir"
        Me.btnRegistrarC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegistrarC.UseVisualStyleBackColor = True
        '
        'InventarioComida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 469)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEliminarC)
        Me.Controls.Add(Me.btnModificarC)
        Me.Controls.Add(Me.btnRegresarC)
        Me.Controls.Add(Me.btnRegistrarC)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "InventarioComida"
        Me.Text = "InventarioComida"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtIDtipoval As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdComida As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreC As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHoraInicio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtHoraFin As TextBox
    Friend WithEvents txtVistaC As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnEliminarC As Button
    Friend WithEvents btnModificarC As Button
    Friend WithEvents btnRegresarC As Button
    Friend WithEvents btnRegistrarC As Button
End Class
