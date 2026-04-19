Imports MySql.Data.MySqlClient
Module DataModule
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As DataTable
    Public Sub Koneksi()
        Try
            Dim str As String = "server=localhost;user id=root;password=;database=db_acecraft"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then conn.Open()
        Catch ex As Exception
            MsgBox("Koneksi Gagal: " & ex.Message)
        End Try
    End Sub
    Public Function GetDataTable(query As String) As DataTable
        Koneksi()
        dt = New DataTable
        da = New MySqlDataAdapter(query, conn)
        da.Fill(dt)
        Return dt
    End Function
    Public Sub EksekusiSQL(query As String)
        Koneksi()
        cmd = New MySqlCommand(query, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
End Module
