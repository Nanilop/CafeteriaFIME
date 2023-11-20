<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informes
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
        Me.dgvInformes = New System.Windows.Forms.DataGridView()
        Me.cbInformes = New System.Windows.Forms.ComboBox()
        Me.btnBuscarInformes = New System.Windows.Forms.PictureBox()
        Me.btnExportaInfo = New System.Windows.Forms.PictureBox()
        Me.dtFinInfo = New System.Windows.Forms.DateTimePicker()
        Me.dtInicioInfome = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkInicioInfo = New System.Windows.Forms.CheckBox()
        Me.chkfinInfo = New System.Windows.Forms.CheckBox()
        CType(Me.dgvInformes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBuscarInformes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExportaInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvInformes
        '
        Me.dgvInformes.AllowUserToAddRows = False
        Me.dgvInformes.AllowUserToDeleteRows = False
        Me.dgvInformes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInformes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInformes.Location = New System.Drawing.Point(12, 101)
        Me.dgvInformes.Name = "dgvInformes"
        Me.dgvInformes.ReadOnly = True
        Me.dgvInformes.RowHeadersVisible = False
        Me.dgvInformes.Size = New System.Drawing.Size(810, 384)
        Me.dgvInformes.TabIndex = 0
        '
        'cbInformes
        '
        Me.cbInformes.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbInformes.FormattingEnabled = True
        Me.cbInformes.Items.AddRange(New Object() {"Reporte de Venta", "Reporte de Historial de Usuarios", "Reporte de Inventario"})
        Me.cbInformes.Location = New System.Drawing.Point(512, 63)
        Me.cbInformes.Name = "cbInformes"
        Me.cbInformes.Size = New System.Drawing.Size(225, 27)
        Me.cbInformes.TabIndex = 2
        '
        'btnBuscarInformes
        '
        Me.btnBuscarInformes.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnBuscarInformes.Image = Global.cafeteria.My.Resources.Resources.buscar1
        Me.btnBuscarInformes.Location = New System.Drawing.Point(743, 59)
        Me.btnBuscarInformes.Name = "btnBuscarInformes"
        Me.btnBuscarInformes.Size = New System.Drawing.Size(34, 34)
        Me.btnBuscarInformes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnBuscarInformes.TabIndex = 3
        Me.btnBuscarInformes.TabStop = False
        '
        'btnExportaInfo
        '
        Me.btnExportaInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnExportaInfo.Image = Global.cafeteria.My.Resources.Resources.excel
        Me.btnExportaInfo.Location = New System.Drawing.Point(788, 59)
        Me.btnExportaInfo.Name = "btnExportaInfo"
        Me.btnExportaInfo.Size = New System.Drawing.Size(34, 34)
        Me.btnExportaInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnExportaInfo.TabIndex = 1
        Me.btnExportaInfo.TabStop = False
        '
        'dtFinInfo
        '
        Me.dtFinInfo.Enabled = False
        Me.dtFinInfo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFinInfo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFinInfo.Location = New System.Drawing.Point(314, 63)
        Me.dtFinInfo.Name = "dtFinInfo"
        Me.dtFinInfo.Size = New System.Drawing.Size(101, 27)
        Me.dtFinInfo.TabIndex = 4
        '
        'dtInicioInfome
        '
        Me.dtInicioInfome.Enabled = False
        Me.dtInicioInfome.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtInicioInfome.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInicioInfome.Location = New System.Drawing.Point(144, 63)
        Me.dtInicioInfome.Name = "dtInicioInfome"
        Me.dtInicioInfome.Size = New System.Drawing.Size(101, 27)
        Me.dtInicioInfome.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(421, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 26)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Informe:"
        '
        'chkInicioInfo
        '
        Me.chkInicioInfo.AutoSize = True
        Me.chkInicioInfo.BackColor = System.Drawing.Color.Transparent
        Me.chkInicioInfo.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.chkInicioInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.chkInicioInfo.Location = New System.Drawing.Point(61, 61)
        Me.chkInicioInfo.Name = "chkInicioInfo"
        Me.chkInicioInfo.Size = New System.Drawing.Size(77, 30)
        Me.chkInicioInfo.TabIndex = 9
        Me.chkInicioInfo.Text = "Inicio"
        Me.chkInicioInfo.UseVisualStyleBackColor = False
        '
        'chkfinInfo
        '
        Me.chkfinInfo.AutoSize = True
        Me.chkfinInfo.BackColor = System.Drawing.Color.Transparent
        Me.chkfinInfo.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.chkfinInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.chkfinInfo.Location = New System.Drawing.Point(251, 61)
        Me.chkfinInfo.Name = "chkfinInfo"
        Me.chkfinInfo.Size = New System.Drawing.Size(57, 30)
        Me.chkfinInfo.TabIndex = 10
        Me.chkfinInfo.Text = "Fin"
        Me.chkfinInfo.UseVisualStyleBackColor = False
        '
        'Informes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 494)
        Me.Controls.Add(Me.chkfinInfo)
        Me.Controls.Add(Me.chkInicioInfo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtInicioInfome)
        Me.Controls.Add(Me.dtFinInfo)
        Me.Controls.Add(Me.btnBuscarInformes)
        Me.Controls.Add(Me.cbInformes)
        Me.Controls.Add(Me.btnExportaInfo)
        Me.Controls.Add(Me.dgvInformes)
        Me.Location = New System.Drawing.Point(0, 35)
        Me.Name = "Informes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Informes"
        CType(Me.dgvInformes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBuscarInformes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExportaInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvInformes As DataGridView
    Friend WithEvents btnExportaInfo As PictureBox
    Friend WithEvents cbInformes As ComboBox
    Friend WithEvents btnBuscarInformes As PictureBox
    Friend WithEvents dtFinInfo As DateTimePicker
    Friend WithEvents dtInicioInfome As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents chkInicioInfo As CheckBox
    Friend WithEvents chkfinInfo As CheckBox
End Class
