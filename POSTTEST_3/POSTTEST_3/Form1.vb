Imports System.IO

Public Class Form1
	Dim grupHobby() As CheckBox
	Dim grupJK() As RadioButton
	Private Function CekData() As Boolean
		grupHobby = {cbCosplay, cbGaming, cbPhotographer, cbVideographer, cbVlogger, cbKuliner, cbLiburan, cbEditor, cbMembaca, cbJalanJalan}
		grupJK = {rbCowok, rbCewek}
		If Not ValidasiTextBox(txtNama, "Silahkan Isi Nama Anda") Then Return False
		If Not ValidasiTextBox(txtUmur, "Silahkan Isi Umur Anda") Then Return False
		If Not ValidasiTextBox(txtHobby, "Silahkan Isi Hobby Anda") Then Return False
		If Not ValidasiTextBox(txtNomorTelpon, "Silahkan Isi Nomor Telpon Anda") Then Return False
		If Not ValidasiTextBox(txtAlamat, "Silahkan Isi Alamat Anda") Then Return False
		If Not ValidasiRadioButton(grupJK, "Pilih Jenis Kelamin Anda") Then Return False
		If Not ValidasiCheckBox(grupHobby, "Pilih Minimal 1 Hobby") Then Return False
		If Not ValidasiPictureBox(picProfil, "Harap Kirim Foto Gambar") Then Return False
		Return True
	End Function

	Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
		If CekData() Then
			grupHobby = {cbCosplay, cbGaming, cbPhotographer, cbVideographer, cbVlogger, cbKuliner, cbLiburan, cbEditor, cbMembaca, cbJalanJalan}
			grupJK = {rbCowok, rbCewek}
			Dim Hobi_Selected As String = GetSelectedCheckBox(grupHobby)
			Dim jk_Selected As String = GetSelectedRadioButton(grupJK)
			DataModule.Nama = txtNama.Text
			DataModule.Umur = txtUmur.Text
			DataModule.Hobi = Hobi_Selected
            DataModule.JK = jk_Selected
			DataModule.NomorTelpon = txtNomorTelpon.Text
			DataModule.Alamat = txtAlamat.Text
			DataModule.TanggalLahir = dtpTL.Value.ToShortDateString()
			Form2.Show()
		End If
	End Sub

	Private Sub btnGambar_Click(sender As Object, e As EventArgs) Handles btnGambar.Click
		If ValidasiTextBox(txtNama, "Harap Isi Nama Anda") Then
			Dim NamaFile As String = txtNama.Text.Trim()
			Dim openFileDialog As New OpenFileDialog()
			openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
			openFileDialog.Title = "Pilih Foto Anda"
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")
				Dim fileName As String = NamaFile & Path.GetExtension(openFileDialog.FileName)
				Dim destinationPath As String = Path.Combine(folderPath, fileName)
				If Not Directory.Exists(folderPath) Then
					Directory.CreateDirectory(folderPath)
				End If
				File.Copy(openFileDialog.FileName, destinationPath, True)
				DataModule.Foto = destinationPath
				picProfil.Image = Image.FromFile(destinationPath)
				MessageBox.Show("Foto Anda Sudah Diupload!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
		End If
	End Sub
	Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
		ValidationModule.HanyaHuruf(sender, e)
	End Sub
	Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
		ValidationModule.HanyaAngka(sender, e)
	End Sub

	Private Sub txtHobby_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHobby.KeyPress
		ValidationModule.HanyaHuruf(sender, e)
	End Sub

	Private Sub txtNomorTelpon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomorTelpon.KeyPress
		ValidationModule.HanyaAngka(sender, e)
	End Sub

	Private Sub txtAlamat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAlamat.KeyPress
		ValidationModule.HanyaHuruf(sender, e)
	End Sub
End Class
