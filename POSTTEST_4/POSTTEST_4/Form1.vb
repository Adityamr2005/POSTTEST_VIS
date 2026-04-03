Public Class Form1
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp"
        OpenFileDialog1.Title = "Silahkan Pilih Foto Profil yang Anda pilih!"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            picProfil.ImageLocation = OpenFileDialog1.FileName
            picProfil.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click, btnSimpan.Click
        If Not rbCowok.Checked AndAlso Not rbCewek.Checked Then
            MessageBox.Show("Silahkan Memilih Jenis Kelamin!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not (cbGaming.Checked OrElse cbCosplay.Checked OrElse cbKontenKreator.Checked OrElse
                cbKuliner.Checked OrElse cbPhotographer.Checked OrElse cbVideographer.Checked OrElse
                cbEditor.Checked OrElse cbVlogger.Checked) Then
            MessageBox.Show("Harap Mengisi Peran Anda", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            MessageBox.Show("Harap Mengisi Nama Anda!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtID.Text) Then
            MessageBox.Show("Harap Mengisi ID Anggota Anda!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(mtxtNomorHP.Text) OrElse mtxtNomorHP.Text = "    -    -" Then
            MessageBox.Show("Harap Mengisi Nomor Telepon Anda!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtAlamat.Text) Then
            MessageBox.Show("Harap Mengisi Alamat Anda!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(picProfil.ImageLocation) Then
            MessageBox.Show("Harap Segera Mengirim Foto Profil di file anda!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Form2.Show()

        Dim jenisKelamin As String = ""
        If rbCowok.Checked Then
            jenisKelamin = rbCowok.Text
        Else
            jenisKelamin = rbCewek.Text
        End If

        Form2.Label1.Text = "Nama : " & txtNama.Text & " (" & jenisKelamin & ")"
        Form2.Label2.Text = "ID Anggota : " & txtID.Text
        Form2.Label3.Text = "Komunitas : " & cbKomunitas.Text

        Form2.Label4.Text = "Kontak : " & mtxtNomorHP.Text & " | " & txtEmail.Text

        Dim daftarPeran As New List(Of String)
        If cbGaming.Checked Then daftarPeran.Add(cbGaming.Text)
        If cbCosplay.Checked Then daftarPeran.Add(cbCosplay.Text)
        If cbKontenKreator.Checked Then daftarPeran.Add(cbKontenKreator.Text)
        If cbKuliner.Checked Then daftarPeran.Add(cbKuliner.Text)
        If cbPhotographer.Checked Then daftarPeran.Add(cbPhotographer.Text)
        If cbVideographer.Checked Then daftarPeran.Add(cbVideographer.Text)
        If cbEditor.Checked Then daftarPeran.Add(cbEditor.Text)
        If cbVlogger.Checked Then daftarPeran.Add(cbVlogger.Text)

        Form2.Label5.Text = "Hobby Aktivitas : " & String.Join(", ", daftarPeran)

        Form2.PictureBox1.ImageLocation = picProfil.ImageLocation
    End Sub
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[a-z, A-Z]" OrElse keyascii = Keys.Back OrElse keyascii = Keys.Space OrElse keyascii = Keys.Return) Then
            keyascii = 0
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtAlamat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAlamat.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[a-z, A-Z, 0-9]" OrElse keyascii = Keys.Back OrElse keyascii = Keys.Space OrElse keyascii = Keys.Return) Then
            keyascii = 0
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cbKomunitas.Items.Count = 0 Then
            cbKomunitas.Items.Add("Pengunjung Event")
            cbKomunitas.Items.Add("Pemain Acecraft")
            cbKomunitas.Items.Add("Kameramen")
        End If
    End Sub
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim dialog As DialogResult = MessageBox.Show("Anda Mau Keluar dari Aplikasi Ini? Silahkan Klik Yes, Anda tidak mau keluar dari Aplikasi Ini? Silahkan Klik No", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class