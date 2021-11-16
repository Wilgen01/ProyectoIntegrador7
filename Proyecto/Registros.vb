Imports MySql.Data.MySqlClient
Public Class Registros
    Dim conexion As New MySqlConnection
    Dim cadena As String
    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.egreso.Format = DateTimePickerFormat.Custom
        Me.egreso.CustomFormat = "yyyy/MM/dd"
        Try
            conexion.ConnectionString = "server=localhost; user=root; password=; database=primerempleo"
            conexion.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usuario As String
        Dim contrasena As String
        Dim nombre As String
        Dim apellido As String
        Dim correo As String
        Dim nacimiento As String
        Dim profesion As String
        Dim egreso As Date
        Dim universidad As String
        Dim tarjeta As String
        Dim descripcion As String

        Me.egreso.Format = DateTimePickerFormat.Custom
        Me.egreso.CustomFormat = "yyyy/MM/dd"

        usuario = Me.usuario.Text
        contrasena = Me.contrasena.Text
        nombre = Me.nombre.Text
        apellido = Me.apellidos.Text
        correo = Me.correo.Text
        nacimiento = Me.edad.Text
        profesion = Me.profesion.Text
        egreso = Me.egreso.Value
        universidad = Me.universidad.Text
        tarjeta = Me.tarjeta.Text
        descripcion = Me.descripcion.Text

        cadena = "INSERT INTO `profesional` (`idProfesional`, `user`, `password`, `nombre`, `apellido`, `correo`, `nacimiento`, `profesion`, `egreso`, `universidad`, `tarjeta`, `descripcion`, `valoracion`) VALUES (NULL, '" & usuario & "', '" & contrasena & "', '" & nombre & "', '" & apellido & "', '" & correo & "', '" & nacimiento & "', '" & profesion & "', '" & egreso & "', '" & universidad & "', '" & tarjeta & "', '" & descripcion & "', NULL);"

        Dim comando As MySqlCommand
        comando = New MySqlCommand(cadena, conexion)
        Try
            comando.ExecuteNonQuery()
            MsgBox("Usuario registrado con exito")
            Me.Hide()
            Form4.Show()
        Catch ex As Exception
            MsgBox("Error inesperado, por favor intentelo mas tarde")
        End Try

    End Sub
    Private Sub correo_GotFocus(sender As Object, e As EventArgs) Handles correo.GotFocus
        If (correo.Text = "example@gmail.com") Then
            correo.Text = ""
            correo.ForeColor = Color.LightGray
        End If
    End Sub
    Private Sub correo_LostFocus(sender As Object, e As EventArgs) Handles correo.LostFocus
        If (correo.Text = "") Then
            correo.Text = "example.@gmail.com"
            correo.ForeColor = Color.LightGray
        End If
    End Sub
    Private Sub contrasena_GotFocus(sender As Object, e As EventArgs) Handles contrasena.GotFocus
        If (contrasena.Text = "********") Then
            contrasena.Text = ""
            contrasena.ForeColor = Color.Black
        End If
    End Sub
    Private Sub contrasena_LostFocus(sender As Object, e As EventArgs) Handles contrasena.LostFocus
        If (contrasena.Text = "") Then
            contrasena.Text = "********"
            contrasena.ForeColor = Color.LightGray
        End If
    End Sub
    Private Sub profesion_GotFocus(sender As Object, e As EventArgs) Handles profesion.GotFocus
        If (profesion.Text = "Tecnico") Then
            profesion.Text = ""
            profesion.ForeColor = Color.LightGray
        End If
    End Sub
    Private Sub profesion_LostFocus(sender As Object, e As EventArgs) Handles profesion.LostFocus
        If (profesion.Text = "") Then
            profesion.Text = "Tecnico"
            profesion.ForeColor = Color.LightGray
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close()
        Form4.Show()
    End Sub
End Class