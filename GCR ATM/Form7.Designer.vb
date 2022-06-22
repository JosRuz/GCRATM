<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lstTipo = New System.Windows.Forms.ListBox()
        Me.lstMonto = New System.Windows.Forms.ListBox()
        Me.lstFecha = New System.Windows.Forms.ListBox()
        Me.lstDescripcion = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightYellow
        Me.Button1.Location = New System.Drawing.Point(488, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(22, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Ivory
        Me.GroupBox1.Controls.Add(Me.lstDescripcion)
        Me.GroupBox1.Controls.Add(Me.lstFecha)
        Me.GroupBox1.Controls.Add(Me.lstMonto)
        Me.GroupBox1.Controls.Add(Me.lstTipo)
        Me.GroupBox1.Location = New System.Drawing.Point(-1, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(519, 311)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identificación"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.MintCream
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(173, 381)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(188, 48)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Regresar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'lstTipo
        '
        Me.lstTipo.FormattingEnabled = True
        Me.lstTipo.Location = New System.Drawing.Point(10, 19)
        Me.lstTipo.Name = "lstTipo"
        Me.lstTipo.Size = New System.Drawing.Size(120, 277)
        Me.lstTipo.TabIndex = 0
        '
        'lstMonto
        '
        Me.lstMonto.FormattingEnabled = True
        Me.lstMonto.Location = New System.Drawing.Point(136, 19)
        Me.lstMonto.Name = "lstMonto"
        Me.lstMonto.Size = New System.Drawing.Size(120, 277)
        Me.lstMonto.TabIndex = 1
        '
        'lstFecha
        '
        Me.lstFecha.FormattingEnabled = True
        Me.lstFecha.Location = New System.Drawing.Point(262, 19)
        Me.lstFecha.Name = "lstFecha"
        Me.lstFecha.Size = New System.Drawing.Size(120, 277)
        Me.lstFecha.TabIndex = 2
        '
        'lstDescripcion
        '
        Me.lstDescripcion.FormattingEnabled = True
        Me.lstDescripcion.Location = New System.Drawing.Point(388, 19)
        Me.lstDescripcion.Name = "lstDescripcion"
        Me.lstDescripcion.Size = New System.Drawing.Size(120, 277)
        Me.lstDescripcion.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 56)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(164, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 50)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Consultar"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(530, 437)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form7"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstFecha As ListBox
    Friend WithEvents lstMonto As ListBox
    Friend WithEvents lstTipo As ListBox
    Friend WithEvents Button3 As Button
    Friend WithEvents lstDescripcion As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
