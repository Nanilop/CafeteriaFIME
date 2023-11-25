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
        Me.chkvistaC = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdComida = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEliminarC = New System.Windows.Forms.Button()
        Me.btnModificarC = New System.Windows.Forms.Button()
        Me.btnRegresarC = New System.Windows.Forms.Button()
        Me.btnRegistrarC = New System.Windows.Forms.Button()
        Me.txtHoraFin = New System.Windows.Forms.DateTimePicker()
        Me.txtHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Image = Global.cafeteria.My.Resources.Resources.limpiar
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiar.Location = New System.Drawing.Point(558, 97)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(115, 43)
        Me.btnLimpiar.TabIndex = 8
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = Global.cafeteria.My.Resources.Resources.buscar
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(558, 45)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(115, 43)
        Me.btnBuscar.TabIndex = 7
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.txtHoraInicio)
        Me.GroupBox1.Controls.Add(Me.txtHoraFin)
        Me.GroupBox1.Controls.Add(Me.chkvistaC)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtIdComida)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombreC)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(41, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(482, 260)
        Me.GroupBox1.TabIndex = 80
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comidas"
        '
        'chkvistaC
        '
        Me.chkvistaC.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkvistaC.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.chkvistaC.Location = New System.Drawing.Point(100, 223)
        Me.chkvistaC.Name = "chkvistaC"
        Me.chkvistaC.Size = New System.Drawing.Size(90, 27)
        Me.chkvistaC.TabIndex = 64
        Me.chkvistaC.Text = "Vista: "
        Me.chkvistaC.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 26)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Codigo:"
        '
        'txtIdComida
        '
        Me.txtIdComida.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdComida.Location = New System.Drawing.Point(176, 39)
        Me.txtIdComida.Name = "txtIdComida"
        Me.txtIdComida.Size = New System.Drawing.Size(278, 31)
        Me.txtIdComida.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 26)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Nombre:"
        '
        'txtNombreC
        '
        Me.txtNombreC.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreC.Location = New System.Drawing.Point(176, 85)
        Me.txtNombreC.Name = "txtNombreC"
        Me.txtNombreC.Size = New System.Drawing.Size(278, 31)
        Me.txtNombreC.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 26)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Hora de Inicio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 26)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Hora de Fin:"
        '
        'btnEliminarC
        '
        Me.btnEliminarC.Enabled = False
        Me.btnEliminarC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarC.Image = Global.cafeteria.My.Resources.Resources.eliminar
        Me.btnEliminarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarC.Location = New System.Drawing.Point(408, 307)
        Me.btnEliminarC.Name = "btnEliminarC"
        Me.btnEliminarC.Size = New System.Drawing.Size(115, 43)
        Me.btnEliminarC.TabIndex = 11
        Me.btnEliminarC.Text = "Eliminar"
        Me.btnEliminarC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminarC.UseVisualStyleBackColor = True
        Me.btnEliminarC.Visible = False
        '
        'btnModificarC
        '
        Me.btnModificarC.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarC.Image = Global.cafeteria.My.Resources.Resources.editar
        Me.btnModificarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificarC.Location = New System.Drawing.Point(558, 197)
        Me.btnModificarC.Name = "btnModificarC"
        Me.btnModificarC.Size = New System.Drawing.Size(115, 43)
        Me.btnModificarC.TabIndex = 10
        Me.btnModificarC.Text = "Editar"
        Me.btnModificarC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificarC.UseVisualStyleBackColor = True
        '
        'btnRegresarC
        '
        Me.btnRegresarC.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresarC.Image = Global.cafeteria.My.Resources.Resources.salir
        Me.btnRegresarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegresarC.Location = New System.Drawing.Point(558, 246)
        Me.btnRegresarC.Name = "btnRegresarC"
        Me.btnRegresarC.Size = New System.Drawing.Size(115, 42)
        Me.btnRegresarC.TabIndex = 12
        Me.btnRegresarC.Text = "Regresar"
        Me.btnRegresarC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegresarC.UseVisualStyleBackColor = True
        '
        'btnRegistrarC
        '
        Me.btnRegistrarC.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarC.Image = Global.cafeteria.My.Resources.Resources.anadir
        Me.btnRegistrarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrarC.Location = New System.Drawing.Point(558, 148)
        Me.btnRegistrarC.Name = "btnRegistrarC"
        Me.btnRegistrarC.Size = New System.Drawing.Size(115, 43)
        Me.btnRegistrarC.TabIndex = 9
        Me.btnRegistrarC.Text = "Añadir"
        Me.btnRegistrarC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegistrarC.UseVisualStyleBackColor = True
        '
        'txtHoraFin
        '
        Me.txtHoraFin.CalendarFont = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtHoraFin.CustomFormat = "HH:mm"
        Me.txtHoraFin.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtHoraFin.Location = New System.Drawing.Point(176, 174)
        Me.txtHoraFin.Name = "txtHoraFin"
        Me.txtHoraFin.Size = New System.Drawing.Size(278, 31)
        Me.txtHoraFin.TabIndex = 81
        '
        'txtHoraInicio
        '
        Me.txtHoraInicio.CalendarFont = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtHoraInicio.CustomFormat = "HH:mm"
        Me.txtHoraInicio.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtHoraInicio.Location = New System.Drawing.Point(176, 127)
        Me.txtHoraInicio.Name = "txtHoraInicio"
        Me.txtHoraInicio.Size = New System.Drawing.Size(278, 31)
        Me.txtHoraInicio.TabIndex = 82
        '
        'InventarioComida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 381)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEliminarC)
        Me.Controls.Add(Me.btnModificarC)
        Me.Controls.Add(Me.btnRegresarC)
        Me.Controls.Add(Me.btnRegistrarC)
        Me.Name = "InventarioComida"
        Me.Text = "InventarioComida"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdComida As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreC As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnEliminarC As Button
    Friend WithEvents btnModificarC As Button
    Friend WithEvents btnRegresarC As Button
    Friend WithEvents btnRegistrarC As Button
    Friend WithEvents chkvistaC As CheckBox
    Friend WithEvents txtHoraFin As DateTimePicker
    Friend WithEvents txtHoraInicio As DateTimePicker
End Class
