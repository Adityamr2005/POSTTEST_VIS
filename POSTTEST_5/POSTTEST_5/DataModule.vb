Imports System.Data
Imports MySql.Data.MySqlClient
Module DataModule
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dr As MySqlDataReader
    Public dt As DataTable
    Public Sub BukaKoneksi()
        Try
            Dim str As String = "server=localhost;user id=root;password=;database=db_acecraft"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi Gagal: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Function JalankanQuery(query As String) As DataTable
        BukaKoneksi()
        dt = New DataTable
        da = New MySqlDataAdapter(query, conn)
        da.Fill(dt)
        Return dt
    End Function
    Public Sub EksekusiSQL(query As String)
        Try
            BukaKoneksi()
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Operasi Gagal: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub
End Module
