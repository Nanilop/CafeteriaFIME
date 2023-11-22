<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Usuarios
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
        Me.dgvusuarios = New System.Windows.Forms.DataGridView()
        Me.btnModifica = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvusuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnModifica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvusuarios
        '
        Me.dgvusuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvusuarios.Location = New System.Drawing.Point(12, 104)
        Me.dgvusuarios.Name = "dgvusuarios"
        Me.dgvusuarios.Size = New System.Drawing.Size(810, 378)
        Me.dgvusuarios.TabIndex = 0
        '
        'btnModifica
        '
        Me.btnModifica.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnModifica.Image = Global.cafeteria.My.Resources.Resources.editar1
        Me.btnModifica.Location = New System.Drawing.Point(788, 64)
        Me.btnModifica.Name = "btnModifica"
        Me.btnModifica.Size = New System.Drawing.Size(34, 34)
        Me.btnModifica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnModifica.TabIndex = 2
        Me.btnModifica.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.PictureBox2.Image = Global.cafeteria.My.Resources.Resources.agregar1
        Me.PictureBox2.Location = New System.Drawing.Point(748, 64)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 494)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnModifica)
        Me.Controls.Add(Me.dgvusuarios)
        Me.Location = New System.Drawing.Point(0, 35)
        Me.Name = "Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Tag = "Contraseña"
        Me.Text = "Usuarios"
        CType(Me.dgvusuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnModifica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvusuarios As DataGridView
    Friend WithEvents btnModifica As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
