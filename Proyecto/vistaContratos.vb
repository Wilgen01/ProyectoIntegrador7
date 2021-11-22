Imports MySql.Data.MySqlClient
Imports System.IO
Public Class vistaContratos
    Dim conexion As New MySqlConnection
    Dim cadena As String
    Private Sub vistaContratos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server=localhost; user=root; password=; database=primerempleo"
            conexion.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("error")
        End Try

        cadena = "SELECT * FROM `contratos` WHERE `id_contratos` = '" & autenticacion.contratoactual & "'"
        Dim imgDB As Byte()
        Dim comando As MySqlCommand
        comando = New MySqlCommand(cadena, conexion)
        Dim registros As MySqlDataReader
        registros = comando.ExecuteReader()

        If (registros.Read()) Then
            nombre.Text = registros("empresa")
            cargo.Text = registros("nombre")
            tiempo.Text = registros("tiempo")
            salario.Text = registros("salario")
            descripcion.Text = registros("descripcion")
            imgDB = registros("imagen")
            Dim ms As New MemoryStream(imgDB)
            imagenEmpresa.Image = System.Drawing.Image.FromStream(ms)
            conexion.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Form5.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        conexion.Open()
        cadena = "SELECT * FROM `contratosasignados` WHERE idUsuario = '" & autenticacion.usuario & "' && idContrato='" & autenticacion.contratoactual & "'"
        Dim comando As MySqlCommand
        comando = New MySqlCommand(cadena, conexion)
        Dim registros As MySqlDataReader
        registros = comando.ExecuteReader()


        If (registros.Read()) Then
            MsgBox("Ya aplicaste a este contrato")
            conexion.Close()
        Else
            conexion.Close()
            conexion.Open()
            cadena = "INSERT INTO `contratosasignados` (`idUsuario`, `idContrato`) VALUES ('" & autenticacion.usuario & "', ' " & autenticacion.contratoactual & " ')"
            comando = New MySqlCommand(cadena, conexion)
            Try
                comando.ExecuteNonQuery()
                MsgBox("Contrato Agregado con exito")
                conexion.Close()
            Catch ex As Exception
                MsgBox("Error inesperado, por favor intentelo mas tarde")
                conexion.Close()
            End Try
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        conexion.Open()
        cadena = "SELECT * FROM `contratosasignados` WHERE idUsuario = '" & autenticacion.usuario & "' && idContrato='" & autenticacion.contratoactual & "'"
        Dim comando As MySqlCommand
        comando = New MySqlCommand(cadena, conexion)
        Dim registros As MySqlDataReader
        registros = comando.ExecuteReader()


        If (registros.Read()) Then
            conexion.Close()
            conexion.Open()
            cadena = "DELETE FROM `contratosasignados` WHERE idUsuario = '" & autenticacion.usuario & "' && idContrato='" & autenticacion.contratoactual & "'"
            comando = New MySqlCommand(cadena, conexion)
            Try
                comando.ExecuteNonQuery()
                MsgBox("Cancelaste la aplicaion a este contrato con exito")
                conexion.Close()
            Catch ex As Exception
                MsgBox("Error inesperado, por favor intentelo mas tarde")
                conexion.Close()
            End Try
        Else
            MsgBox("Aun no has aplicado a este contrato")
            conexion.Close()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        autenticacion.usuario = ""
        Me.Close()
        Form4.Show()
    End Sub
End Class