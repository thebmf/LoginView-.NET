Imports MySql.Data.MySqlClient

Public Class DTconection
    Dim conect As New MySqlConnection("server='localhost';uid='root';pwd=''; database='authentication")
    Public Function open() As MysqlConnection
        Try
            conect.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return conect
    End Function

    Public Function close() As MysqlConnection
        Try
            conect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return conect
    End Function

End Class