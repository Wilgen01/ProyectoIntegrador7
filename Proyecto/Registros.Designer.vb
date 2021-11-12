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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registros))
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'usuario
        '
        Me.usuario.Location = New System.Drawing.Point(140, 78)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(240, 20)
        Me.usuario.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(33, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(33, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña"
        '
        'contrasena
        '
        Me.contrasena.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.contrasena.Location = New System.Drawing.Point(140, 104)
        Me.contrasena.Name = "contrasena"
        Me.contrasena.Size = New System.Drawing.Size(240, 20)
        Me.contrasena.TabIndex = 12
        Me.contrasena.Text = "********"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(33, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombre:"
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(140, 130)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(240, 20)
        Me.nombre.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(33, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Apellidos:"
        '
        'apellidos
        '
        Me.apellidos.Location = New System.Drawing.Point(140, 156)
        Me.apellidos.Name = "apellidos"
        Me.apellidos.Size = New System.Drawing.Size(240, 20)
        Me.apellidos.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(33, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Correo:"
        '
        'correo
        '
        Me.correo.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.correo.Location = New System.Drawing.Point(140, 182)
        Me.correo.Name = "correo"
        Me.correo.Size = New System.Drawing.Size(240, 20)
        Me.correo.TabIndex = 11
        Me.correo.Text = "example@gmail.com"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(33, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Edad:"
        '
        'edad
        '
        Me.edad.Location = New System.Drawing.Point(140, 208)
        Me.edad.Name = "edad"
        Me.edad.Size = New System.Drawing.Size(240, 20)
        Me.edad.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(33, 338)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 16)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Descripcion:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'descripcion
        '
        Me.descripcion.Location = New System.Drawing.Point(140, 335)
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(240, 20)
        Me.descripcion.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(33, 312)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 16)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Terjeta:"
        '
        'tarjeta
        '
        Me.tarjeta.Location = New System.Drawing.Point(140, 309)
        Me.tarjeta.Name = "tarjeta"
        Me.tarjeta.Size = New System.Drawing.Size(240, 20)
        Me.tarjeta.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(33, 286)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 16)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Universidad:"
        '
        'universidad
        '
        Me.universidad.Location = New System.Drawing.Point(140, 283)
        Me.universidad.Name = "universidad"
        Me.universidad.Size = New System.Drawing.Size(240, 20)
        Me.universidad.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(33, 260)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 16)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Egreso:"
        '
        'egreso
        '
        Me.egreso.Location = New System.Drawing.Point(140, 257)
        Me.egreso.Name = "egreso"
        Me.egreso.Size = New System.Drawing.Size(240, 20)
        Me.egreso.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(33, 234)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 16)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Profesion:"
        '
        'profesion
        '
        Me.profesion.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.profesion.Location = New System.Drawing.Point(140, 231)
        Me.profesion.Name = "profesion"
        Me.profesion.Size = New System.Drawing.Size(240, 20)
        Me.profesion.TabIndex = 23
        Me.profesion.Text = "Tecnico"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightCyan
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(140, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 37)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(49, 24)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Atras"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(111, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(223, 20)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Registro Como Profesional"
        '
        'Registros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto.My.Resources.Resources.R__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(404, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button2)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(420, 489)
        Me.MinimumSize = New System.Drawing.Size(420, 486)
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
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
End Class
