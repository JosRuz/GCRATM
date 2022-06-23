<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.txtPin = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cbBanco = New System.Windows.Forms.ComboBox()
        Me.Chb = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 92)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 144)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightYellow
        Me.Button1.Location = New System.Drawing.Point(650, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(22, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(274, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 50)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Entrar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(182, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 38)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cuenta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(182, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 38)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Pin"
        '
        'txtCuenta
        '
        Me.txtCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.Location = New System.Drawing.Point(324, 117)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(293, 40)
        Me.txtCuenta.TabIndex = 10
        '
        'txtPin
        '
        Me.txtPin.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPin.Location = New System.Drawing.Point(324, 171)
        Me.txtPin.Name = "txtPin"
        Me.txtPin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPin.Size = New System.Drawing.Size(293, 40)
        Me.txtPin.TabIndex = 11
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(484, 228)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(188, 48)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Entrar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.MintCream
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(484, 282)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(188, 48)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Registrarse"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'cbBanco
        '
        Me.cbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBanco.FormattingEnabled = True
        Me.cbBanco.Items.AddRange(New Object() {"GCR Private", "Scorpio", "Wolves", "CRM", "Rinobanco", "Paybank", "money cash", "SMH", "FEDIMA", "Bank Bros", "AVA"})
        Me.cbBanco.Location = New System.Drawing.Point(78, 265)
        Me.cbBanco.Name = "cbBanco"
        Me.cbBanco.Size = New System.Drawing.Size(293, 32)
        Me.cbBanco.TabIndex = 14
        '
        'Chb
        '
        Me.Chb.AutoSize = True
        Me.Chb.Location = New System.Drawing.Point(629, 17)
        Me.Chb.Name = "Chb"
        Me.Chb.Size = New System.Drawing.Size(15, 14)
        Me.Chb.TabIndex = 15
        Me.Chb.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(703, 352)
        Me.Controls.Add(Me.Chb)
        Me.Controls.Add(Me.cbBanco)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtPin)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCuenta As TextBox
    Friend WithEvents txtPin As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents cbBanco As ComboBox
    Friend WithEvents Chb As CheckBox
End Class
