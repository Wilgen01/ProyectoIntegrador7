Imports MySql.Data.MySqlClient
Public Class Form2
    Dim Conexion As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Realizar consulta de datos cuando cargue la pagina
        Try
            Conexion.ConnectionString = "server=localhost;user=root;password=;database=primerempleo"
            Conexion.Open()
            Dim consulta As String
            consulta = "SELECT `id_contratos`,`nombre`, `empresa`, `descripcion` FROM contratos"

            adaptador = New MySqlDataAdapter(consulta, Conexion)
            datos = New DataSet
            adaptador.Fill(datos, "contratos")
            DataGridView1.DataSource = datos
            DataGridView1.DataMember = "contratos"
            DataGridView1.Columns(0).Visible = False
            Conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim id As String = CInt(DataGridView1.Item(0, e.RowIndex).Value)
        autenticacion.contratoactual = id
        Me.Close()
        vistaContratos.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (TextBox1.Text.Length = 0) Then
            MsgBox("No hay parametros para buscar")
            Try
                Conexion.Open()
                Dim consulta As String
                consulta = "SELECT `id_contratos`,`nombre`, `empresa`, `descripcion` FROM contratos"
                adaptador = New MySqlDataAdapter(consulta, Conexion)
                datos = New DataSet
                adaptador.Fill(datos, "contratos")
                DataGridView1.DataSource = datos
                DataGridView1.DataMember = "contratos"
                DataGridView1.Columns(0).Visible = False
                Conexion.Close()
            Catch ex As Exception
                MsgBox("Error inesperado, intentelo mas tarde")
            End Try
            Return
        End If
        Dim parametro As String
        parametro = TextBox1.Text
        Try
            Conexion.Open()
            Dim consulta As String
            consulta = "SELECT `id_contratos`,`nombre`, `empresa`, `descripcion` FROM contratos WHERE `nombre` LIKE '%" & parametro & "%' OR `empresa` LIKE '%" & parametro & "%'"
            adaptador = New MySqlDataAdapter(consulta, Conexion)
            datos = New DataSet
            adaptador.Fill(datos, "contratos")
            DataGridView1.DataSource = datos
            DataGridView1.DataMember = "contratos"
            DataGridView1.Columns(0).Visible = False
            Conexion.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        autenticacion.usuario = ""
        Me.Close()
        Form4.Show()
    End Sub
End Class