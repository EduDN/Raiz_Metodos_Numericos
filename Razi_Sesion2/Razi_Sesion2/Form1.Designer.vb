<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Li = New System.Windows.Forms.Label()
        Me.Lc = New System.Windows.Forms.Label()
        Me.Ti = New System.Windows.Forms.TextBox()
        Me.Tc = New System.Windows.Forms.TextBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Li
        '
        Me.Li.AutoSize = True
        Me.Li.Location = New System.Drawing.Point(68, 68)
        Me.Li.Name = "Li"
        Me.Li.Size = New System.Drawing.Size(78, 16)
        Me.Li.TabIndex = 0
        Me.Li.Text = "Dame inicio"
        '
        'Lc
        '
        Me.Lc.AutoSize = True
        Me.Lc.Location = New System.Drawing.Point(71, 127)
        Me.Lc.Name = "Lc"
        Me.Lc.Size = New System.Drawing.Size(79, 16)
        Me.Lc.TabIndex = 1
        Me.Lc.Text = "Dame cifras"
        '
        'Ti
        '
        Me.Ti.Location = New System.Drawing.Point(194, 71)
        Me.Ti.Name = "Ti"
        Me.Ti.Size = New System.Drawing.Size(100, 22)
        Me.Ti.TabIndex = 2
        '
        'Tc
        '
        Me.Tc.Location = New System.Drawing.Point(194, 127)
        Me.Tc.Name = "Tc"
        Me.Tc.Size = New System.Drawing.Size(100, 22)
        Me.Tc.TabIndex = 3
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(562, 71)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(95, 34)
        Me.Calcular.TabIndex = 4
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(562, 121)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(95, 35)
        Me.Salir.TabIndex = 5
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'salida
        '
        Me.salida.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.salida.Location = New System.Drawing.Point(119, 219)
        Me.salida.Name = "salida"
        Me.salida.RowHeadersWidth = 51
        Me.salida.RowTemplate.Height = 24
        Me.salida.Size = New System.Drawing.Size(403, 173)
        Me.salida.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.HeaderText = "Índice"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Raíz"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Error"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.salida)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.Tc)
        Me.Controls.Add(Me.Ti)
        Me.Controls.Add(Me.Lc)
        Me.Controls.Add(Me.Li)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Li As Label
    Friend WithEvents Lc As Label
    Friend WithEvents Ti As TextBox
    Friend WithEvents Tc As TextBox
    Friend WithEvents Calcular As Button
    Friend WithEvents Salir As Button
    Friend WithEvents salida As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
