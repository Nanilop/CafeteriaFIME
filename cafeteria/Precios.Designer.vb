<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Precios
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
        Me.btnrecargaprecio = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnrecargaprecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 102)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(810, 346)
        Me.DataGridView1.TabIndex = 0
        '
        'btnrecargaprecio
        '
        Me.btnrecargaprecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnrecargaprecio.Image = Global.cafeteria.My.Resources.Resources.recargar
        Me.btnrecargaprecio.Location = New System.Drawing.Point(748, 62)
        Me.btnrecargaprecio.Name = "btnrecargaprecio"
        Me.btnrecargaprecio.Size = New System.Drawing.Size(34, 34)
        Me.btnrecargaprecio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnrecargaprecio.TabIndex = 2
        Me.btnrecargaprecio.TabStop = False
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
        Me.Controls.Add(Me.btnrecargaprecio)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Location = New System.Drawing.Point(0, 35)
        Me.Name = "Precios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Precios"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnrecargaprecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnrecargaprecio As PictureBox
End Class
