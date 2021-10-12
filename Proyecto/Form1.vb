Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conexion As New MySqlConnection
    Dim cadena As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server=localhost; user=root; password=; database=primerempleo"
            conexion.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("error")
        End Try

        cadena = "SELECT * FROM `profesional` WHERE `user` = '" & autenticacion.usuario & "'"
        Dim comando As MySqlCommand
        comando = New MySqlCommand(cadena, conexion)
        Dim registros As MySqlDataReader
        registros = comando.ExecuteReader()

        If (registros.Read()) Then
            nombre.Text = registros("nombre")
            profesion.Text = registros("profesion")
            edad.Text = registros("nacimiento")
            descripcion.Text = registros("descripcion")
        End If
    End Sub
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub



    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form5.Show()
    End Sub
End Class
