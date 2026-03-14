<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        picProfil = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btnGambar = New Button()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtHobby = New TextBox()
        txtNomorTelpon = New TextBox()
        txtAlamat = New TextBox()
        dtpTL = New DateTimePicker()
        GroupBox1 = New GroupBox()
        rbCewek = New RadioButton()
        rbCowok = New RadioButton()
        GroupBox2 = New GroupBox()
        cbJalanJalan = New CheckBox()
        cbMembaca = New CheckBox()
        cbEditor = New CheckBox()
        cbLiburan = New CheckBox()
        cbKuliner = New CheckBox()
        cbVlogger = New CheckBox()
        cbVideographer = New CheckBox()
        cbPhotographer = New CheckBox()
        cbGaming = New CheckBox()
        cbCosplay = New CheckBox()
        btnCetak = New Button()
        CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' picProfil
        ' 
        picProfil.Location = New Point(12, 12)
        picProfil.Name = "picProfil"
        picProfil.Size = New Size(242, 419)
        picProfil.SizeMode = PictureBoxSizeMode.StretchImage
        picProfil.TabIndex = 0
        picProfil.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(287, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 1
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(287, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 25)
        Label2.TabIndex = 2
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(287, 168)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 25)
        Label3.TabIndex = 3
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(287, 243)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 25)
        Label4.TabIndex = 4
        Label4.Text = "Hobby"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(287, 315)
        Label5.Name = "Label5"
        Label5.Size = New Size(126, 25)
        Label5.TabIndex = 5
        Label5.Text = "Nomor Telpon"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(288, 388)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 25)
        Label6.TabIndex = 6
        Label6.Text = "Alamat"
        ' 
        ' btnGambar
        ' 
        btnGambar.Location = New Point(71, 467)
        btnGambar.Name = "btnGambar"
        btnGambar.Size = New Size(112, 34)
        btnGambar.TabIndex = 7
        btnGambar.Text = "Gambar"
        btnGambar.UseVisualStyleBackColor = True
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(497, 19)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(150, 31)
        txtNama.TabIndex = 8
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(497, 90)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(150, 31)
        txtUmur.TabIndex = 9
        ' 
        ' txtHobby
        ' 
        txtHobby.Location = New Point(497, 237)
        txtHobby.Name = "txtHobby"
        txtHobby.Size = New Size(150, 31)
        txtHobby.TabIndex = 10
        ' 
        ' txtNomorTelpon
        ' 
        txtNomorTelpon.Location = New Point(497, 315)
        txtNomorTelpon.Name = "txtNomorTelpon"
        txtNomorTelpon.Size = New Size(150, 31)
        txtNomorTelpon.TabIndex = 11
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(497, 385)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(150, 31)
        txtAlamat.TabIndex = 12
        ' 
        ' dtpTL
        ' 
        dtpTL.Location = New Point(497, 168)
        dtpTL.Name = "dtpTL"
        dtpTL.Size = New Size(300, 31)
        dtpTL.TabIndex = 13
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbCewek)
        GroupBox1.Controls.Add(rbCowok)
        GroupBox1.Location = New Point(291, 453)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(300, 150)
        GroupBox1.TabIndex = 14
        GroupBox1.TabStop = False
        GroupBox1.Text = "Jenis Kelamin"
        ' 
        ' rbCewek
        ' 
        rbCewek.AutoSize = True
        rbCewek.Location = New Point(15, 65)
        rbCewek.Name = "rbCewek"
        rbCewek.Size = New Size(126, 29)
        rbCewek.TabIndex = 1
        rbCewek.TabStop = True
        rbCewek.Text = "Perempuan"
        rbCewek.UseVisualStyleBackColor = True
        ' 
        ' rbCowok
        ' 
        rbCowok.AutoSize = True
        rbCowok.Location = New Point(15, 30)
        rbCowok.Name = "rbCowok"
        rbCowok.Size = New Size(104, 29)
        rbCowok.TabIndex = 0
        rbCowok.TabStop = True
        rbCowok.Text = "Laki-Laki"
        rbCowok.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(cbJalanJalan)
        GroupBox2.Controls.Add(cbMembaca)
        GroupBox2.Controls.Add(cbEditor)
        GroupBox2.Controls.Add(cbLiburan)
        GroupBox2.Controls.Add(cbKuliner)
        GroupBox2.Controls.Add(cbVlogger)
        GroupBox2.Controls.Add(cbVideographer)
        GroupBox2.Controls.Add(cbPhotographer)
        GroupBox2.Controls.Add(cbGaming)
        GroupBox2.Controls.Add(cbCosplay)
        GroupBox2.Location = New Point(748, 453)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(360, 214)
        GroupBox2.TabIndex = 15
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hobby"
        ' 
        ' cbJalanJalan
        ' 
        cbJalanJalan.AutoSize = True
        cbJalanJalan.Location = New Point(210, 172)
        cbJalanJalan.Name = "cbJalanJalan"
        cbJalanJalan.Size = New Size(121, 29)
        cbJalanJalan.TabIndex = 9
        cbJalanJalan.Text = "Jalan-Jalan"
        cbJalanJalan.UseVisualStyleBackColor = True
        ' 
        ' cbMembaca
        ' 
        cbMembaca.AutoSize = True
        cbMembaca.Location = New Point(210, 137)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(116, 29)
        cbMembaca.TabIndex = 8
        cbMembaca.Text = "Membaca"
        cbMembaca.UseVisualStyleBackColor = True
        ' 
        ' cbEditor
        ' 
        cbEditor.AutoSize = True
        cbEditor.Location = New Point(210, 102)
        cbEditor.Name = "cbEditor"
        cbEditor.Size = New Size(85, 29)
        cbEditor.TabIndex = 7
        cbEditor.Text = "Editor"
        cbEditor.UseVisualStyleBackColor = True
        ' 
        ' cbLiburan
        ' 
        cbLiburan.AutoSize = True
        cbLiburan.Location = New Point(210, 67)
        cbLiburan.Name = "cbLiburan"
        cbLiburan.Size = New Size(96, 29)
        cbLiburan.TabIndex = 6
        cbLiburan.Text = "Liburan"
        cbLiburan.UseVisualStyleBackColor = True
        ' 
        ' cbKuliner
        ' 
        cbKuliner.AutoSize = True
        cbKuliner.Location = New Point(210, 32)
        cbKuliner.Name = "cbKuliner"
        cbKuliner.Size = New Size(91, 29)
        cbKuliner.TabIndex = 5
        cbKuliner.Text = "Kuliner"
        cbKuliner.UseVisualStyleBackColor = True
        ' 
        ' cbVlogger
        ' 
        cbVlogger.AutoSize = True
        cbVlogger.Location = New Point(10, 172)
        cbVlogger.Name = "cbVlogger"
        cbVlogger.Size = New Size(101, 29)
        cbVlogger.TabIndex = 4
        cbVlogger.Text = "Vlogger"
        cbVlogger.UseVisualStyleBackColor = True
        ' 
        ' cbVideographer
        ' 
        cbVideographer.AutoSize = True
        cbVideographer.Location = New Point(10, 137)
        cbVideographer.Name = "cbVideographer"
        cbVideographer.Size = New Size(146, 29)
        cbVideographer.TabIndex = 3
        cbVideographer.Text = "Videographer"
        cbVideographer.UseVisualStyleBackColor = True
        ' 
        ' cbPhotographer
        ' 
        cbPhotographer.AutoSize = True
        cbPhotographer.Location = New Point(10, 102)
        cbPhotographer.Name = "cbPhotographer"
        cbPhotographer.Size = New Size(148, 29)
        cbPhotographer.TabIndex = 2
        cbPhotographer.Text = "Photographer"
        cbPhotographer.UseVisualStyleBackColor = True
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Location = New Point(10, 67)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(100, 29)
        cbGaming.TabIndex = 1
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' cbCosplay
        ' 
        cbCosplay.AutoSize = True
        cbCosplay.Location = New Point(10, 32)
        cbCosplay.Name = "cbCosplay"
        cbCosplay.Size = New Size(101, 29)
        cbCosplay.TabIndex = 0
        cbCosplay.Text = "Cosplay"
        cbCosplay.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(613, 706)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(112, 34)
        btnCetak.TabIndex = 16
        btnCetak.Text = "Cetak"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Aqua
        ClientSize = New Size(1135, 769)
        Controls.Add(btnCetak)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(dtpTL)
        Controls.Add(txtAlamat)
        Controls.Add(txtNomorTelpon)
        Controls.Add(txtHobby)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(btnGambar)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(picProfil)
        Name = "Form1"
        Text = "Form1"
        CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picProfil As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnGambar As Button
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtHobby As TextBox
    Friend WithEvents txtNomorTelpon As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents dtpTL As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbCewek As RadioButton
    Friend WithEvents rbCowok As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbLiburan As CheckBox
    Friend WithEvents cbKuliner As CheckBox
    Friend WithEvents cbVlogger As CheckBox
    Friend WithEvents cbVideographer As CheckBox
    Friend WithEvents cbPhotographer As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents cbCosplay As CheckBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents cbJalanJalan As CheckBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbEditor As CheckBox

End Class
