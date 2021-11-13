Imports MySql.Data.MySqlClient
Public Class Form3
    Dim Conexion As New MySqlConnection
    Dim datos As DataTable
    Dim datos2 As DataTable
    Dim dataTemp As DataTable

    Dim adaptador As New MySqlDataAdapter
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.ConnectionString = "server=localhost;user=root;password=;database=primerempleo"
            Conexion.Open()
            Dim consulta As String
            consulta = "SELECT * FROM `contratosasignados` WHERE idUsuario = '" & autenticacion.usuario & "'"

            adaptador = New MySqlDataAdapter(consulta, Conexion)
            datos = New DataTable
            adaptador.Fill(datos)
            MsgBox(datos.Rows.Count)
            Dim f As Integer
            Conexion.Close()
            datos2 = New DataTable()
            datos2.Columns.Add("id")
            datos2.Columns.Add("nombre")
            datos2.Columns.Add("empresa")
            datos2.Columns.Add("descripcion")


            For f = 0 To datos.Rows.Count - 1
                Conexion.Open()
                Dim consulta2 As String
                consulta2 = "SELECT `id_contratos`,`nombre`, `empresa`, `descripcion` FROM contratos WHERE `id_contratos` = '" & datos.Rows(f).ItemArray(2) & "'"
                adaptador = New MySqlDataAdapter(consulta2, Conexion)
                dataTemp = New DataTable()
                adaptador.Fill(dataTemp)

                datos2.Rows.Add(dataTemp.Rows(0).ItemArray(0), dataTemp.Rows(0).ItemArray(1), dataTemp.Rows(0).ItemArray(2), dataTemp.Rows(0).ItemArray(3))
                Conexion.Close()
            Next
            DataGridView1.DataSource = datos2
            DataGridView1.Columns(0).Visible = False
            'Conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form5.Show()
    End Sub


End Class