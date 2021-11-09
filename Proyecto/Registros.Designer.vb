<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registros
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
        Me.usuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.contrasena = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.apellidos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.correo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.edad = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.descripcion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tarjeta = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.universidad = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.egreso = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.profesion = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'usuario
        '
        Me.usuario.Location = New System.Drawing.Point(140, 39)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(100, 20)
        Me.usuario.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña"
        '
        'contrasena
        '
        Me.contrasena.Location = New System.Drawing.Point(140, 65)
        Me.contrasena.Name = "contrasena"
        Me.contrasena.Size = New System.Drawing.Size(100, 20)
        Me.contrasena.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombre:"
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(140, 91)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(100, 20)
        Me.nombre.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Apellidos:"
        '
        'apellidos
        '
        Me.apellidos.Location = New System.Drawing.Point(140, 117)
        Me.apellidos.Name = "apellidos"
        Me.apellidos.Size = New System.Drawing.Size(100, 20)
        Me.apellidos.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Correo:"
        '
        'correo
        '
        Me.correo.Location = New System.Drawing.Point(140, 143)
        Me.correo.Name = "correo"
        Me.correo.Size = New System.Drawing.Size(100, 20)
        Me.correo.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Edad:"
        '
        'edad
        '
        Me.edad.Location = New System.Drawing.Point(140, 169)
        Me.edad.Name = "edad"
        Me.edad.Size = New System.Drawing.Size(100, 20)
        Me.edad.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 299)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Descripcion"
        '
        'descripcion
        '
        Me.descripcion.Location = New System.Drawing.Point(140, 296)
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(100, 20)
        Me.descripcion.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 273)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Terjeta:"
        '
        'tarjeta
        '
        Me.tarjeta.Location = New System.Drawing.Point(140, 270)
        Me.tarjeta.Name = "tarjeta"
        Me.tarjeta.Size = New System.Drawing.Size(100, 20)
        Me.tarjeta.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(33, 247)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Universidad"
        '
        'universidad
        '
        Me.universidad.Location = New System.Drawing.Point(140, 244)
        Me.universidad.Name = "universidad"
        Me.universidad.Size = New System.Drawing.Size(100, 20)
        Me.universidad.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(33, 221)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Egreso"
        '
        'egreso
        '
        Me.egreso.Location = New System.Drawing.Point(140, 218)
        Me.egreso.Name = "egreso"
        Me.egreso.Size = New System.Drawing.Size(200, 20)
        Me.egreso.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Profesion"
        '
        'profesion
        '
        Me.profesion.Location = New System.Drawing.Point(140, 192)
        Me.profesion.Name = "profesion"
        Me.profesion.Size = New System.Drawing.Size(100, 20)
        Me.profesion.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightCyan
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(127, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 37)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Registros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto.My.Resources.Resources.R__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(404, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.profesion)
        Me.Controls.Add(Me.egreso)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.descripcion)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tarjeta)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.universidad)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.edad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.correo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.apellidos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.contrasena)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.usuario)
        Me.MaximumSize = New System.Drawing.Size(420, 489)
        Me.MinimumSize = New System.Drawing.Size(420, 489)
        Me.Name = "Registros"
        Me.Text = "Registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents usuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents contrasena As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents apellidos As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents correo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents edad As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents descripcion As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tarjeta As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents universidad As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents egreso As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents profesion As TextBox
    Friend WithEvents Button1 As Button
End Class
