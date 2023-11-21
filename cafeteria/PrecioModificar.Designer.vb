<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrecioModificar
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
        Me.btnGuardarModPrec = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreProdPrec = New System.Windows.Forms.Label()
        Me.txtprecioPrecioMod = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnGuardarModPrec
        '
        Me.btnGuardarModPrec.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnGuardarModPrec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarModPrec.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarModPrec.ForeColor = System.Drawing.Color.White
        Me.btnGuardarModPrec.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardarModPrec.Location = New System.Drawing.Point(349, 149)
        Me.btnGuardarModPrec.Name = "btnGuardarModPrec"
        Me.btnGuardarModPrec.Size = New System.Drawing.Size(90, 39)
        Me.btnGuardarModPrec.TabIndex = 1
        Me.btnGuardarModPrec.Text = "Guardar"
        Me.btnGuardarModPrec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(13, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Precio: $ "
        '
        'txtNombreProdPrec
        '
        Me.txtNombreProdPrec.AutoSize = True
        Me.txtNombreProdPrec.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtNombreProdPrec.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.txtNombreProdPrec.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtNombreProdPrec.Location = New System.Drawing.Point(13, 13)
        Me.txtNombreProdPrec.Name = "txtNombreProdPrec"
        Me.txtNombreProdPrec.Size = New System.Drawing.Size(68, 26)
        Me.txtNombreProdPrec.TabIndex = 3
        Me.txtNombreProdPrec.Text = "Label2"
        '
        'txtprecioPrecioMod
        '
        Me.txtprecioPrecioMod.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.txtprecioPrecioMod.Location = New System.Drawing.Point(95, 84)
        Me.txtprecioPrecioMod.MaxLength = 8
        Me.txtprecioPrecioMod.Name = "txtprecioPrecioMod"
        Me.txtprecioPrecioMod.Size = New System.Drawing.Size(344, 33)
        Me.txtprecioPrecioMod.TabIndex = 4
        '
        'PrecioModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 197)
        Me.Controls.Add(Me.txtprecioPrecioMod)
        Me.Controls.Add(Me.txtNombreProdPrec)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGuardarModPrec)
        Me.Name = "PrecioModificar"
        Me.Text = "Precio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGuardarModPrec As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombreProdPrec As Label
    Friend WithEvents txtprecioPrecioMod As TextBox
End Class
