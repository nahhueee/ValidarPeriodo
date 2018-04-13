Public Class Form1

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "-" Then
            e.Handled = False
        Else
            e.Handled = True
            Exit Sub
        End If

        Dim pos As Integer = TextBox1.SelectionStart
        If e.KeyChar <> "-" And pos = 2 And Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If

        If e.KeyChar = "-" And pos <> 2 Then
            e.Handled = True
            Exit Sub
        End If

    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        Dim mes As Integer = CInt(TextBox1.Text.Substring(0, 2))
        Dim año As Integer = CInt(TextBox1.Text.Substring(3, 4))

        If mes < 1 Or mes > 12 Then MsgBox("Mes incorrecto")
        If año < 1960 Or año > 3000 Then MsgBox("año incorrecto")
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
