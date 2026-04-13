Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData(dgvData, GetConnection())
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        Dim isReady As Boolean = True
        If txtUID.Text = "" Then
            ErrorProvider1.SetError(txtUID, "Harap UID diisi!")
            isReady = False
        ElseIf Not IsNumeric(txtUID.Text) Then
            ErrorProvider1.SetError(txtUID, "Harap UID isi dengan angka!")
            isReady = False
        ElseIf IsUIDDuplicate(txtUID.Text) Then
            ErrorProvider1.SetError(txtUID, "UID Anda sudah didaftar!")
            isReady = False
        End If

        If txtUsername.Text = "" Then
            ErrorProvider1.SetError(txtUsername, "Harap Isi Username Anda!")
            isReady = False
        End If

        If txtLevel.Text = "" Or Not IsNumeric(txtLevel.Text) Then
            ErrorProvider1.SetError(txtLevel, "Harap Ketik Level dengan angka!")
            isReady = False
        End If

        If isReady Then
            SimpanData(txtUID.Text, txtUsername.Text, txtLevel.Text, txtServer.Text, GetConnection())
            TampilData(dgvData, GetConnection())
            BersihForm()
        End If
    End Sub
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        CariData(dgvData, txtCari.Text, GetConnection())
    End Sub
    Private Sub dgvData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvData.Rows(e.RowIndex)
                txtUID.Text = row.Cells("UID").Value.ToString()
                txtUsername.Text = row.Cells("Username").Value.ToString()
                txtLevel.Text = row.Cells("Level").Value.ToString()
                txtServer.Text = row.Cells("Server").Value.ToString()
                txtUID.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub BersihForm()
        txtUID.Clear()
        txtUsername.Clear()
        txtLevel.Clear()
        txtServer.Clear()
        txtUID.Enabled = True
        txtUID.Focus()
        ErrorProvider1.Clear()
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        BersihForm()
        TampilData(dgvData, GetConnection())
    End Sub
End Class
