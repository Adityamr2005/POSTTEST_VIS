Imports Mysqlx.Notice
Public Class Form1
    Private epWarning As ErrorProvider
    Sub TampilAkun()
        Dim sql As String = "SELECT akun.uid, akun.username, level_akses.nama_level, akun.rank_game " &
                           "FROM akun INNER JOIN level_akses ON akun.id_level = level_akses.id_level"
        dgvData.DataSource = GetDataTable(sql)
    End Sub
    Sub IsiComboLevel()
        cbLevel.DataSource = GetDataTable("SELECT * FROM level_akses")
        cbLevel.DisplayMember = "nama_level"
        cbLevel.ValueMember = "id_level"
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilAkun()
        IsiComboLevel()
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If ValidasiKosong(txtUID, ep:=epWarning, pesan:="Harap Isi UID Anda Dulu!") Then Exit Sub

        Dim sql As String = "INSERT INTO akun VALUES ('" & txtUID.Text & "', '" & txtUsername.Text & "', " &
                            "'" & cbLevel.SelectedValue & "', '" & txtRank.Text & "')"
        EksekusiSQL(sql)
        MsgBox("Akun Anda Sudah Berhasil Terdaftar!")
        TampilAkun()
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim sql As String = "SELECT akun.uid, akun.username, level_akses.nama_level, akun.rank_game " &
                           "FROM akun INNER JOIN level_akses ON akun.id_level = level_akses.id_level " &
                           "WHERE akun.username LIKE '%" & txtSearch.Text & "%' OR akun.uid LIKE '%" & txtSearch.Text & "%'"
        dgvData.DataSource = GetDataTable(sql)
    End Sub
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Dim sql As String = "UPDATE akun SET username='" & txtUsername.Text & "', " &
                            "id_level='" & cbLevel.SelectedValue & "', rank_game='" & txtRank.Text & "' " &
                            "WHERE uid='" & txtUID.Text & "'"
        EksekusiSQL(sql)
        TampilAkun()
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MsgBox("Apakah Anda Hapus data UID?: " & txtUID.Text & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            EksekusiSQL("DELETE FROM akun WHERE uid='" & txtUID.Text & "'")
            TampilAkun()
        End If
    End Sub
End Class
