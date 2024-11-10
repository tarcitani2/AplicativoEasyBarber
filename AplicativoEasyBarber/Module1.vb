Module Module1
    Public diretorio, SQL As String
    Public dbConnection As New ADODB.Connection
    Public dbRecordset As New ADODB.Recordset
    Public dbCommand As New ADODB.Command
    Public cont As Integer

    Sub conectar_banco_sql_server()
        Try
            dbConnection = CreateObject("ADODB.Connection")
            dbConnection.Open("Provider=SQLOLEDB;Data Source=DESKTOP-1VJ2J2V;Initial Catalog=cadastro_adsva2;trusted_connection=yes;")
            MsgBox("banco de dados conectado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao conectar ao banco de dados: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
End Module
