Imports MySql.Data.MySqlClient
Public Class Form4
    Dim conexion As New MySqlConnection
    Dim cadena As String
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server=localhost; user=root; password=; database=primerempleo"
            conexion.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles pass.GotFocus
        If (pass.Text = "*****") Then
            pass.Text = ""
        End If
    End Sub
    Private Sub usuario_GotFocus(sender As Object, e As EventArgs) Handles usuario.GotFocus
        If (usuario.Text = "Nombre de usuario") Then
            usuario.Text = ""
            usuario.ForeColor = Color.Black
        End If
    End Sub
    Private Sub usuario_LostFocus(sender As Object, e As EventArgs) Handles usuario.LostFocus
        If (usuario.Text = Nothing) Then
            usuario.Text = "Nombre de usuario"
            usuario.ForeColor = Color.LightGray

        End If
    End Sub

    Private Sub pass_GotFocus(sender As Object, e As EventArgs) Handles pass.GotFocus
        If (pass.Text = "Contraseña") Then
            pass.Text = ""
            pass.ForeColor = Color.Black
        End If
    End Sub

    Private Sub pass_LostFocus(sender As Object, e As EventArgs) Handles pass.LostFocus
        If (pass.Text = "") Then
            pass.Text = "Contraseña"
            pass.ForeColor = Color.LightGray

        End If
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        cadena = "SELECT * FROM `profesional` WHERE `user` = '" & usuario.Text & "' AND `password` = '" & pass.Text & "'"
        Dim comando As MySqlCommand
        comando = New MySqlCommand(cadena, conexion)
        Dim registros As MySqlDataReader
        registros = comando.ExecuteReader()


        If (registros.Read()) Then
            autenticacion.usuario = usuario.Text
            conexion.Close()
            Me.Hide()
            Form1.Show()
        Else
            MsgBox("Usuario o contraseña incorrecto")
            registros.Close()
        End If
 

    End Sub

    Private Sub registro_Click(sender As Object, e As EventArgs) Handles registro.Click
        Me.Hide()
        Registros.Show()

    End Sub
End Class