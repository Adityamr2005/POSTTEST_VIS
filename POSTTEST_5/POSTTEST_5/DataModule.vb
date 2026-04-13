Imports System.Data
Module DataModule
    Public Function GetMySqlConnection() As MySqlConnector.MySqlConnection
        Return GetConnection()
    End Function

    Sub TampilData(dgv As DataGridView, mySqlConnection As MySqlConnector.MySqlConnection)
        Dim conn As MySqlConnector.MySqlConnection = mySqlConnection
        Try
            If conn Is Nothing Then
                Throw New ArgumentNullException(NameOf(mySqlConnection))
            End If
            If conn.State <> ConnectionState.Open Then conn.Open()
            Dim da As New MySqlConnector.MySqlDataAdapter("SELECT * FROM tbl_akun", conn)
            Dim ds As New DataSet
            da.Fill(ds, "tbl_akun")
            dgv.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox("Tampilan Data Error: " & ex.Message)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Sub SimpanData(uid As String, user As String, lvl As String, srv As String, mySqlConnection As MySqlConnector.MySqlConnection)
        Dim conn As MySqlConnector.MySqlConnection = mySqlConnection
        Try
            If conn Is Nothing Then
                Throw New ArgumentNullException(NameOf(mySqlConnection))
            End If
            If conn.State <> ConnectionState.Open Then conn.Open()
            Dim sql As String = "INSERT INTO tbl_akun (UID, Username, `Level`, Server) VALUES (@uid, @user, @lvl, @srv)"
            Using cmd As New MySqlConnector.MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@uid", uid)
                cmd.Parameters.AddWithValue("@user", user)
                cmd.Parameters.AddWithValue("@lvl", lvl)
                cmd.Parameters.AddWithValue("@srv", srv)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil ditambahkan!")
            End Using
        Catch ex As Exception
            MsgBox("Gagal simpan: " & ex.Message)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Sub HapusData(uid As String, mySqlConnection As MySqlConnector.MySqlConnection)
        Dim conn As MySqlConnector.MySqlConnection = mySqlConnection
        Try
            If conn Is Nothing Then
                Throw New ArgumentNullException(NameOf(mySqlConnection))
            End If
            If conn.State <> ConnectionState.Open Then conn.Open()
            Dim sql As String = "DELETE FROM tbl_akun WHERE UID = @uid"
            Using cmd As New MySqlConnector.MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@uid", uid)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus!")
            End Using
        Catch ex As Exception
            MsgBox("Gagal hapus: " & ex.Message)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Sub CariData(dgv As DataGridView, keyword As String, mySqlConnection As MySqlConnector.MySqlConnection)
        Dim conn As MySqlConnector.MySqlConnection = mySqlConnection
        Try
            If conn Is Nothing Then
                Throw New ArgumentNullException(NameOf(mySqlConnection))
            End If
            If conn.State <> ConnectionState.Open Then conn.Open()
            Dim sql As String = "SELECT * FROM tbl_akun WHERE UID LIKE @key OR Username LIKE @key"
            Using cmd As New MySqlConnector.MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@key", "%" & keyword & "%")
                Dim da As New MySqlConnector.MySqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "tbl_akun")
                dgv.DataSource = ds.Tables(0)
            End Using
        Catch ex As Exception
            MsgBox("Pencarian UID Tidak Ada: " & ex.Message)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
End Module
