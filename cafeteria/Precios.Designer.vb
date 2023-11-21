<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Precios
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
        Me.dgvPrecio = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPrecio
        '
        Me.dgvPrecio.AllowUserToAddRows = False
        Me.dgvPrecio.AllowUserToDeleteRows = False
        Me.dgvPrecio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPrecio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrecio.Location = New System.Drawing.Point(12, 102)
        Me.dgvPrecio.Name = "dgvPrecio"
        Me.dgvPrecio.ReadOnly = True
        Me.dgvPrecio.Size = New System.Drawing.Size(810, 346)
        Me.dgvPrecio.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.PictureBox1.Image = Global.cafeteria.My.Resources.Resources.editar1
        Me.PictureBox1.Location = New System.Drawing.Point(788, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Precios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 460)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgvPrecio)
        Me.Location = New System.Drawing.Point(0, 35)
        Me.Name = "Precios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Precios"
        CType(Me.dgvPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvPrecio As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
End Class
