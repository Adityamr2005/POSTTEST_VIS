Module ValidationModule
    Public Function ValidasiKosong(txt As TextBox, ep As ErrorProvider, pesan As String) As Boolean
        If txt.Text = "" Then
            ep.SetError(txt, pesan)
            Return True
        Else
            ep.SetError(txt, "")
            Return False
        End If
    End Function
    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Module
