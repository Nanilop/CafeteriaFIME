﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario))
        Me.dgvComidas = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.btnActualizarC = New System.Windows.Forms.Button()
        Me.btnActualizarP = New System.Windows.Forms.Button()
        Me.btnEditarC = New System.Windows.Forms.Button()
        Me.btnEditarP = New System.Windows.Forms.Button()
        CType(Me.dgvComidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvComidas
        '
        Me.dgvComidas.AllowUserToAddRows = False
        Me.dgvComidas.AllowUserToDeleteRows = False
        Me.dgvComidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvComidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComidas.Location = New System.Drawing.Point(200, 314)
        Me.dgvComidas.MultiSelect = False
        Me.dgvComidas.Name = "dgvComidas"
        Me.dgvComidas.ReadOnly = True
        Me.dgvComidas.Size = New System.Drawing.Size(612, 139)
        Me.dgvComidas.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.Label2.Location = New System.Drawing.Point(195, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 26)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Inventario de Comidas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.Label1.Location = New System.Drawing.Point(195, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 26)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Inventario de Productos"
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(200, 117)
        Me.dgvProductos.MultiSelect = False
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.Size = New System.Drawing.Size(612, 139)
        Me.dgvProductos.TabIndex = 37
        '
        'btnActualizarC
        '
        Me.btnActualizarC.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.btnActualizarC.Image = CType(resources.GetObject("btnActualizarC.Image"), System.Drawing.Image)
        Me.btnActualizarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizarC.Location = New System.Drawing.Point(559, 262)
        Me.btnActualizarC.Name = "btnActualizarC"
        Me.btnActualizarC.Size = New System.Drawing.Size(140, 46)
        Me.btnActualizarC.TabIndex = 45
        Me.btnActualizarC.Text = "Actualizar"
        Me.btnActualizarC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnActualizarC.UseVisualStyleBackColor = True
        '
        'btnActualizarP
        '
        Me.btnActualizarP.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.btnActualizarP.Image = CType(resources.GetObject("btnActualizarP.Image"), System.Drawing.Image)
        Me.btnActualizarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizarP.Location = New System.Drawing.Point(559, 64)
        Me.btnActualizarP.Name = "btnActualizarP"
        Me.btnActualizarP.Size = New System.Drawing.Size(140, 47)
        Me.btnActualizarP.TabIndex = 44
        Me.btnActualizarP.Text = "Actualizar"
        Me.btnActualizarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnActualizarP.UseVisualStyleBackColor = True
        '
        'btnEditarC
        '
        Me.btnEditarC.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.btnEditarC.Image = CType(resources.GetObject("btnEditarC.Image"), System.Drawing.Image)
        Me.btnEditarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditarC.Location = New System.Drawing.Point(705, 262)
        Me.btnEditarC.Name = "btnEditarC"
        Me.btnEditarC.Size = New System.Drawing.Size(107, 46)
        Me.btnEditarC.TabIndex = 42
        Me.btnEditarC.Text = "Editar"
        Me.btnEditarC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditarC.UseVisualStyleBackColor = True
        '
        'btnEditarP
        '
        Me.btnEditarP.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.btnEditarP.Image = CType(resources.GetObject("btnEditarP.Image"), System.Drawing.Image)
        Me.btnEditarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditarP.Location = New System.Drawing.Point(705, 64)
        Me.btnEditarP.Name = "btnEditarP"
        Me.btnEditarP.Size = New System.Drawing.Size(107, 47)
        Me.btnEditarP.TabIndex = 41
        Me.btnEditarP.Text = "Editar"
        Me.btnEditarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditarP.UseVisualStyleBackColor = True
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 460)
        Me.Controls.Add(Me.btnActualizarC)
        Me.Controls.Add(Me.btnActualizarP)
        Me.Controls.Add(Me.btnEditarC)
        Me.Controls.Add(Me.btnEditarP)
        Me.Controls.Add(Me.dgvComidas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvProductos)
        Me.Location = New System.Drawing.Point(0, 35)
        Me.Name = "Inventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Inventario"
        CType(Me.dgvComidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEditarC As Button
    Friend WithEvents btnEditarP As Button
    Friend WithEvents dgvComidas As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents btnActualizarC As Button
    Friend WithEvents btnActualizarP As Button
End Class
