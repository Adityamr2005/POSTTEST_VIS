Imports MySqlConnector
Imports MySql.Data.MySqlClient
Module ModuleKoneksi
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As DataTable
    Public ds As DataSet

    Public Sub Koneksi()
        Dim str As String = "server=localhost;user id=root;password=;database=db_acecraft"
        conn = New MySqlConnection(str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module