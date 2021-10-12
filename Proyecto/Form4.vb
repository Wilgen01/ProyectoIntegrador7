Public Class Form4
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
        If (pass.Text = "wilgen" And usuario.Text() = "wilgen") Then
            Me.Hide()
            Form1.Show()
        End If

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class