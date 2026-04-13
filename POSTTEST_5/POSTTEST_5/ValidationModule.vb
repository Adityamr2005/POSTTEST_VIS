Imports MySqlConnector
Module ValidationModule
    Function IsFormatValid(uid As String, user As String, lvl As String, srv As String) As Boolean
        If uid = "" Or user = "" Or lvl = "" Or srv = "" Then Return False
        Dim tmp As Integer
        If Not Integer.TryParse(uid, tmp) Then Return False
        If Not Integer.TryParse(lvl, tmp) Then Return False
        Return True
    End Function

    Function IsUIDDuplicate(uid As String) As Boolean
        Dim duplicate As Boolean = False
        Using conn As MySqlConnector.MySqlConnection = GetConnection()
            Try
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM tbl_akun WHERE UID = @uid"
                Using cmd As New MySqlConnector.MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@uid", uid)
                    duplicate = Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            Catch ex As Exception
                MsgBox("Cek UID error: " & ex.Message)
            End Try
        End Using
        Return duplicate
    End Function
End Module