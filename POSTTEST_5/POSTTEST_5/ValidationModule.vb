Imports MySqlConnector
Module ValidationModule
    Public Function IsEmpty(txt As TextBox, ep As ErrorProvider, pesan As String) As Boolean
        If Trim(txt.Text) = "" Then
            ep.SetError(txt, pesan)
            txt.Focus()
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
    Public Sub BersihkanForm(frm As Form, ep As ErrorProvider)
        For Each ctrl As Control In frm.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
        ep.Clear()
    End Sub
End Module