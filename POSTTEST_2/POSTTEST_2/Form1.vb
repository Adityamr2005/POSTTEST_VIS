Public Class Form1
    Sub TambahBuku(ByVal jdl As String, ByVal penulisBuku As String, ByVal jenis As String)

        judul(jumlahData) = jdl
        penulis(jumlahData) = penulisBuku
        genre(jumlahData) = jenis

        jumlahData += 1

        TampilBuku()

    End Sub
    Sub TampilBuku()

        lstBuku.Items.Clear()

        For i As Integer = 0 To jumlahData - 1

            lstBuku.Items.Add(judul(i) & " | " & penulis(i) & " | " & genre(i))

        Next

    End Sub
    Function CariBuku(ByVal jdl As String) As Integer

        For i As Integer = 0 To jumlahData - 1

            If judul(i).ToLower = jdl.ToLower Then
                Return i
            End If

        Next

        Return -1

    End Function
    Sub HapusBuku(ByVal jdl As String)

        Dim index As Integer = CariBuku(jdl)

        If index <> -1 Then

            For i As Integer = index To jumlahData - 2

                judul(i) = judul(i + 1)
                penulis(i) = penulis(i + 1)
                genre(i) = genre(i + 1)

            Next

            jumlahData -= 1

            TampilBuku()

            MessageBox.Show("Data Buku Sudah Dihapus")

        Else

            MessageBox.Show("Data Buku Tidak Ditemukan")

        End If

    End Sub
    Function ValidasiInput() As Boolean

        If txtJudul1.Text = "" Or txtJudul2.Text = "" Or txtGenre.Text = "" Then

            MessageBox.Show("Silahkan Isi Data Buku")

            Return False

        End If

        Return True

    End Function
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click

        If ValidasiInput() Then

            TambahBuku(txtJudul1.Text, txtJudul2.Text, txtGenre.Text)

            txtJudul1.Clear()
            txtJudul2.Clear()
            txtGenre.Clear()

        End If

    End Sub
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click

        If txtJudul1.Text = "" Then

            MessageBox.Show("Silahkan Isi Judul Buku Terlebih Dahulu")

        Else

            HapusBuku(txtJudul1.Text)

        End If

    End Sub

End Class
