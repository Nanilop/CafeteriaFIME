<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdenVer
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
        Me.labelOrdenVer = New System.Windows.Forms.Label()
        Me.btnCancela = New System.Windows.Forms.PictureBox()
        Me.btnEntrega = New System.Windows.Forms.PictureBox()
        Me.dgvDetalleOrden = New System.Windows.Forms.DataGridView()
        CType(Me.btnCancela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalleOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelOrdenVer
        '
        Me.labelOrdenVer.AutoSize = True
        Me.labelOrdenVer.BackColor = System.Drawing.Color.Transparent
        Me.labelOrdenVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labelOrdenVer.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelOrdenVer.ForeColor = System.Drawing.Color.White
        Me.labelOrdenVer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.labelOrdenVer.Location = New System.Drawing.Point(12, 12)
        Me.labelOrdenVer.Name = "labelOrdenVer"
        Me.labelOrdenVer.Size = New System.Drawing.Size(98, 26)
        Me.labelOrdenVer.TabIndex = 3
        Me.labelOrdenVer.Text = "Inventario"
        '
        'btnCancela
        '
        Me.btnCancela.BackColor = System.Drawing.Color.Transparent
        Me.btnCancela.Image = Global.cafeteria.My.Resources.Resources.cancelaOrden
        Me.btnCancela.Location = New System.Drawing.Point(427, 12)
        Me.btnCancela.Name = "btnCancela"
        Me.btnCancela.Size = New System.Drawing.Size(26, 26)
        Me.btnCancela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCancela.TabIndex = 13
        Me.btnCancela.TabStop = False
        '
        'btnEntrega
        '
        Me.btnEntrega.BackColor = System.Drawing.Color.Transparent
        Me.btnEntrega.Image = Global.cafeteria.My.Resources.Resources.aceptaOrden
        Me.btnEntrega.Location = New System.Drawing.Point(396, 12)
        Me.btnEntrega.Name = "btnEntrega"
        Me.btnEntrega.Size = New System.Drawing.Size(26, 26)
        Me.btnEntrega.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnEntrega.TabIndex = 12
        Me.btnEntrega.TabStop = False
        '
        'dgvDetalleOrden
        '
        Me.dgvDetalleOrden.AllowUserToAddRows = False
        Me.dgvDetalleOrden.AllowUserToDeleteRows = False
        Me.dgvDetalleOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleOrden.Location = New System.Drawing.Point(13, 57)
        Me.dgvDetalleOrden.MultiSelect = False
        Me.dgvDetalleOrden.Name = "dgvDetalleOrden"
        Me.dgvDetalleOrden.ReadOnly = True
        Me.dgvDetalleOrden.RowHeadersVisible = False
        Me.dgvDetalleOrden.Size = New System.Drawing.Size(440, 140)
        Me.dgvDetalleOrden.TabIndex = 14
        '
        'OrdenVer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.cafeteria.My.Resources.Resources.Diapositiva1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(465, 209)
        Me.Controls.Add(Me.dgvDetalleOrden)
        Me.Controls.Add(Me.btnCancela)
        Me.Controls.Add(Me.btnEntrega)
        Me.Controls.Add(Me.labelOrdenVer)
        Me.DoubleBuffered = True
        Me.Name = "OrdenVer"
        Me.Text = "OrdenVer"
        CType(Me.btnCancela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalleOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelOrdenVer As Label
    Friend WithEvents btnCancela As PictureBox
    Friend WithEvents btnEntrega As PictureBox
    Friend WithEvents dgvDetalleOrden As DataGridView
End Class
