Public Class frmCadastro
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim novoForm As New frmLogin() ' Cria uma nova instância do frmCadastro
        novoForm.Show()              ' Exibe o Form2
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim novoForm As New frmLogin() ' Cria uma nova instância do frmCadastro
        novoForm.Show()              ' Exibe o Form2
        Me.Hide()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Conectar ao banco de dados
            Module1.conectar_banco_sql_server()

            ' Preparar o comando SQL para inserção
            SQL = "INSERT INTO tb_cad_adsva2 (nome, cpf, email, senha) VALUES ('" & txt_nome.Text & "', '" & txt_cpf.Text & "', '" & txt_email.Text & "', '" & txt_senha.Text & "')"

            ' Executar o comando SQL
            Module1.dbCommand.CommandText = SQL
            Module1.dbCommand.ActiveConnection = Module1.dbConnection
            Module1.dbCommand.Execute()

            ' Exibir mensagem de sucesso
            MsgBox("Cadastro realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso")
        Catch ex As Exception
            ' Exibir mensagem de erro
            MsgBox("Erro ao cadastrar: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try

    End Sub
End Class