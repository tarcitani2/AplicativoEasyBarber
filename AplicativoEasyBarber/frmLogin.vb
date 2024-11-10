Public Class frmLogin
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close() ' Fecha o formulário atual
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim novoForm As New frmCadastro() ' Cria uma nova instância do frmCadastro
        novoForm.Show()              ' Exibe o Form2
        Me.Hide()
    End Sub
End Class