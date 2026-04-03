Module Module1
    Public pathData As String = Application.StartupPath & "\DataAnggota.txt"
    Public dataTersimpan As Boolean = False
    Public Sub BersihkanInput(ByVal frm As Form)
        For Each ctrl As Control In frm.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            ElseIf TypeOf ctrl Is ComboBox Then
                Dim cb As ComboBox = CType(ctrl, ComboBox)
                cb.SelectedIndex = -1
            ElseIf TypeOf ctrl Is PictureBox Then
                Dim pic As PictureBox = CType(ctrl, PictureBox)
                pic.ImageLocation = Nothing
            End If
        Next
    End Sub
End Module