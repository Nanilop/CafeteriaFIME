<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inventario
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
        Me.btnEditarC = New System.Windows.Forms.Button()
        Me.btnEditarP = New System.Windows.Forms.Button()
        Me.dgvComidas = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvInventario = New System.Windows.Forms.DataGridView()
        CType(Me.dgvComidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEditarC
        '
        Me.btnEditarC.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarC.Location = New System.Drawing.Point(710, 302)
        Me.btnEditarC.Name = "btnEditarC"
        Me.btnEditarC.Size = New System.Drawing.Size(102, 26)
        Me.btnEditarC.TabIndex = 42
        Me.btnEditarC.Text = "Editar"
        Me.btnEditarC.UseVisualStyleBackColor = True
        '
        'btnEditarP
        '
        Me.btnEditarP.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarP.Location = New System.Drawing.Point(710, 79)
        Me.btnEditarP.Name = "btnEditarP"
        Me.btnEditarP.Size = New System.Drawing.Size(102, 26)
        Me.btnEditarP.TabIndex = 41
        Me.btnEditarP.Text = "Editar"
        Me.btnEditarP.UseVisualStyleBackColor = True
        '
        'dgvComidas
        '
        Me.dgvComidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComidas.Location = New System.Drawing.Point(200, 334)
        Me.dgvComidas.Name = "dgvComidas"
        Me.dgvComidas.Size = New System.Drawing.Size(612, 165)
        Me.dgvComidas.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(206, 303)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 23)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Inventario de Comidas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(206, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 23)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Inventario de Productos"
        '
        'dgvInventario
        '
        Me.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventario.Location = New System.Drawing.Point(200, 111)
        Me.dgvInventario.Name = "dgvInventario"
        Me.dgvInventario.Size = New System.Drawing.Size(612, 165)
        Me.dgvInventario.TabIndex = 37
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 511)
        Me.Controls.Add(Me.btnEditarC)
        Me.Controls.Add(Me.btnEditarP)
        Me.Controls.Add(Me.dgvComidas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvInventario)
        Me.Location = New System.Drawing.Point(0, 60)
        Me.Name = "Inventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Inventario"
        CType(Me.dgvComidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEditarC As Button
    Friend WithEvents btnEditarP As Button
    Friend WithEvents dgvComidas As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvInventario As DataGridView
End Class
