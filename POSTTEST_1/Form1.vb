Public Class Form1
    Dim Semester As Integer
    Dim totalIP As Double
    Private Sub ValidateInput()
        If Integer.TryParse(txtInput.Text, Semester) Then

        Else
            MessageBox.Show("Input Angka Semester Tidak Valid")
        End If
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim ipSemester As Double
        Dim IP As Integer

        If Double.TryParse(txtInput.Text, ipSemester) Then
            Dim total As Double = ipSemester + Val(TextBox2.Text)
            TextBox2.Text = total.ToString()
            Dim totalIP As Double = totalIP / Semester
            txtInput.Text = totalIP.ToString()
            Dim Predikat As String

            If IP = 2.0 And IP = 2.75 Then
                Predikat = "Cukup"
            ElseIf IP = 2.76 And IP = 3.0 Then
                Predikat = "Memuaskan"
            ElseIf IP = 3.01 Then
                Predikat = "Sangat Memuaskan"
            Else
                Predikat = "-"
            End If

            txtInput.Clear()
            txtInput.Focus()
        Else
            MessageBox.Show("IP Semester Wajib Harus Angka")
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Semester = 0

        txtInput.Clear()
        txtInput.Focus()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim IP As Integer
        Dim Predikat As String
        If IP = 2.0 And IP = 2.75 Then
            Predikat = "Cukup"
        ElseIf IP = 2.76 And IP = 3.0 Then
            Predikat = "Memuaskan"
        ElseIf IP = 3.01 Then
            Predikat = "Sangat Memuaskan"
        Else
            MessageBox.Show("Sangat Memuaskan")
        End If
    End Sub
End Class