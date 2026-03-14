Public Class Form2
	Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		lblNama.Text = DataModule.Nama
        lblUmur.Text = DataModule.Nim
		lblTL.Text = DataModule.TanggalLahir
		lblAlamat.Text = DataModule.Alamat
		lblNomorTelpon.Text = DataModule.NomorTelpon
		lblHobby.Text = DataModule.Hobi
		PictureBox1.Image = Image.FromFile(DataModule.Foto)
	End Sub
End Class