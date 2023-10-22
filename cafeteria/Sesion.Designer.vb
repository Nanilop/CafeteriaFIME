<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sesion
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
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.look = New System.Windows.Forms.PictureBox()
        Me.btnAcceder = New System.Windows.Forms.Button()
        Me.advcontra = New System.Windows.Forms.Label()
        Me.advusuario = New System.Windows.Forms.Label()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.look, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Dock = System.Windows.Forms.DockStyle.Left
        Me.picLogo.Location = New System.Drawing.Point(0, 0)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(424, 460)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(455, 178)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(332, 32)
        Me.txtUsuario.TabIndex = 1
        '
        'txtContraseña
        '
        Me.txtContraseña.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.Location = New System.Drawing.Point(455, 247)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(332, 32)
        Me.txtContraseña.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(450, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(450, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contraseña:"
        '
        'look
        '
        Me.look.BackColor = System.Drawing.SystemColors.Window
        Me.look.Location = New System.Drawing.Point(759, 252)
        Me.look.Name = "look"
        Me.look.Size = New System.Drawing.Size(24, 21)
        Me.look.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.look.TabIndex = 5
        Me.look.TabStop = False
        '
        'btnAcceder
        '
        Me.btnAcceder.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btnAcceder.FlatAppearance.BorderSize = 0
        Me.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAcceder.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcceder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAcceder.Location = New System.Drawing.Point(703, 285)
        Me.btnAcceder.Name = "btnAcceder"
        Me.btnAcceder.Size = New System.Drawing.Size(118, 35)
        Me.btnAcceder.TabIndex = 6
        Me.btnAcceder.Text = "Acceder"
        Me.btnAcceder.UseVisualStyleBackColor = False
        '
        'advcontra
        '
        Me.advcontra.AutoSize = True
        Me.advcontra.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.advcontra.Location = New System.Drawing.Point(664, 231)
        Me.advcontra.Name = "advcontra"
        Me.advcontra.Size = New System.Drawing.Size(123, 13)
        Me.advcontra.TabIndex = 7
        Me.advcontra.Text = "*Ingrese una contraseña"
        '
        'advusuario
        '
        Me.advusuario.AutoSize = True
        Me.advusuario.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.advusuario.Location = New System.Drawing.Point(684, 162)
        Me.advusuario.Name = "advusuario"
        Me.advusuario.Size = New System.Drawing.Size(99, 13)
        Me.advusuario.TabIndex = 8
        Me.advusuario.Text = "*Ingrese un usuario"
        '
        'Sesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 460)
        Me.Controls.Add(Me.advusuario)
        Me.Controls.Add(Me.advcontra)
        Me.Controls.Add(Me.btnAcceder)
        Me.Controls.Add(Me.look)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.picLogo)
        Me.Location = New System.Drawing.Point(0, 35)
        Me.Name = "Sesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.look, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents look As PictureBox
    Friend WithEvents btnAcceder As Button
    Friend WithEvents advcontra As Label
    Friend WithEvents advusuario As Label
End Class
