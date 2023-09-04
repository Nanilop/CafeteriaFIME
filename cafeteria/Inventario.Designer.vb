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
        Me.btnComidas = New System.Windows.Forms.PictureBox()
        Me.btnProductos = New System.Windows.Forms.PictureBox()
        CType(Me.btnComidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnComidas
        '
        Me.btnComidas.Location = New System.Drawing.Point(276, 107)
        Me.btnComidas.Name = "btnComidas"
        Me.btnComidas.Size = New System.Drawing.Size(258, 283)
        Me.btnComidas.TabIndex = 1
        Me.btnComidas.TabStop = False
        '
        'btnProductos
        '
        Me.btnProductos.Location = New System.Drawing.Point(12, 107)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(258, 283)
        Me.btnProductos.TabIndex = 0
        Me.btnProductos.TabStop = False
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 460)
        Me.Controls.Add(Me.btnComidas)
        Me.Controls.Add(Me.btnProductos)
        Me.Location = New System.Drawing.Point(0, 60)
        Me.Name = "Inventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Inventario"
        CType(Me.btnComidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnProductos As PictureBox
    Friend WithEvents btnComidas As PictureBox
End Class
