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
        components = New ComponentModel.Container()
        tclData = New TabControl()
        TabPage1 = New TabPage()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        cbKomunitas = New ComboBox()
        rbCewek = New RadioButton()
        rbCowok = New RadioButton()
        DateTimePicker1 = New DateTimePicker()
        txtID = New TextBox()
        txtNama = New TextBox()
        tclKontak = New TabPage()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        mtxtNomorHP = New MaskedTextBox()
        tclProfil = New TabPage()
        btnBrowse = New Button()
        btnCetak = New Button()
        btnSimpan = New Button()
        GroupBox1 = New GroupBox()
        cbGaming = New CheckBox()
        cbVlogger = New CheckBox()
        cbCosplay = New CheckBox()
        cbEditor = New CheckBox()
        cbKontenKreator = New CheckBox()
        cbVideographer = New CheckBox()
        cbKuliner = New CheckBox()
        cbPhotographer = New CheckBox()
        picProfil = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        Label1 = New Label()
        SaveFileDialog1 = New SaveFileDialog()
        ErrorProvider1 = New ErrorProvider(components)
        MenuStrip1 = New MenuStrip()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        tclData.SuspendLayout()
        TabPage1.SuspendLayout()
        tclKontak.SuspendLayout()
        tclProfil.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' tclData
        ' 
        tclData.Controls.Add(TabPage1)
        tclData.Controls.Add(tclKontak)
        tclData.Controls.Add(tclProfil)
        tclData.Location = New Point(50, 151)
        tclData.Name = "tclData"
        tclData.SelectedIndex = 0
        tclData.Size = New Size(1024, 495)
        tclData.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Red
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(cbKomunitas)
        TabPage1.Controls.Add(rbCewek)
        TabPage1.Controls.Add(rbCowok)
        TabPage1.Controls.Add(DateTimePicker1)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Location = New Point(4, 34)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1016, 457)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(32, 344)
        Label6.Name = "Label6"
        Label6.Size = New Size(187, 25)
        Label6.TabIndex = 10
        Label6.Text = "Jenis Komunitas/Divisi"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(268, 208)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 25)
        Label5.TabIndex = 9
        Label5.Text = "Jenis Kelamin"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(32, 152)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 25)
        Label4.TabIndex = 8
        Label4.Text = "Tanggal Lahir"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(32, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 25)
        Label3.TabIndex = 7
        Label3.Text = "ID Anggota"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(32, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 25)
        Label2.TabIndex = 6
        Label2.Text = "Nama"
        ' 
        ' cbKomunitas
        ' 
        cbKomunitas.FormattingEnabled = True
        cbKomunitas.Location = New Point(268, 341)
        cbKomunitas.Name = "cbKomunitas"
        cbKomunitas.Size = New Size(300, 33)
        cbKomunitas.TabIndex = 5
        ' 
        ' rbCewek
        ' 
        rbCewek.AutoSize = True
        rbCewek.Location = New Point(268, 290)
        rbCewek.Name = "rbCewek"
        rbCewek.Size = New Size(126, 29)
        rbCewek.TabIndex = 4
        rbCewek.TabStop = True
        rbCewek.Text = "Perempuan"
        rbCewek.UseVisualStyleBackColor = True
        ' 
        ' rbCowok
        ' 
        rbCowok.AutoSize = True
        rbCowok.Location = New Point(268, 246)
        rbCowok.Name = "rbCowok"
        rbCowok.Size = New Size(104, 29)
        rbCowok.TabIndex = 3
        rbCowok.TabStop = True
        rbCowok.Text = "Laki-Laki"
        rbCowok.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(268, 152)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(300, 31)
        DateTimePicker1.TabIndex = 2
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(268, 88)
        txtID.Name = "txtID"
        txtID.Size = New Size(300, 31)
        txtID.TabIndex = 1
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(268, 18)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(300, 31)
        txtNama.TabIndex = 0
        ' 
        ' tclKontak
        ' 
        tclKontak.BackColor = Color.Yellow
        tclKontak.Controls.Add(Label9)
        tclKontak.Controls.Add(Label8)
        tclKontak.Controls.Add(Label7)
        tclKontak.Controls.Add(txtAlamat)
        tclKontak.Controls.Add(txtEmail)
        tclKontak.Controls.Add(mtxtNomorHP)
        tclKontak.Location = New Point(4, 34)
        tclKontak.Name = "tclKontak"
        tclKontak.Padding = New Padding(3)
        tclKontak.Size = New Size(1016, 457)
        tclKontak.TabIndex = 1
        tclKontak.Text = "Kontak & Info"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(62, 238)
        Label9.Name = "Label9"
        Label9.Size = New Size(68, 25)
        Label9.TabIndex = 5
        Label9.Text = "Alamat"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(62, 143)
        Label8.Name = "Label8"
        Label8.Size = New Size(54, 25)
        Label8.TabIndex = 4
        Label8.Text = "Email"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(62, 50)
        Label7.Name = "Label7"
        Label7.Size = New Size(135, 25)
        Label7.TabIndex = 3
        Label7.Text = "Nomor Telepon"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(240, 232)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(233, 31)
        txtAlamat.TabIndex = 2
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(240, 143)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(233, 31)
        txtEmail.TabIndex = 1
        ' 
        ' mtxtNomorHP
        ' 
        mtxtNomorHP.Location = New Point(240, 50)
        mtxtNomorHP.Mask = "0000-0000-0000"
        mtxtNomorHP.Name = "mtxtNomorHP"
        mtxtNomorHP.Size = New Size(233, 31)
        mtxtNomorHP.TabIndex = 0
        ' 
        ' tclProfil
        ' 
        tclProfil.BackColor = Color.Blue
        tclProfil.Controls.Add(btnBrowse)
        tclProfil.Controls.Add(btnCetak)
        tclProfil.Controls.Add(btnSimpan)
        tclProfil.Controls.Add(GroupBox1)
        tclProfil.Controls.Add(picProfil)
        tclProfil.Location = New Point(4, 34)
        tclProfil.Name = "tclProfil"
        tclProfil.Padding = New Padding(3)
        tclProfil.Size = New Size(1016, 457)
        tclProfil.TabIndex = 2
        tclProfil.Text = "Profil & Aktivitas"
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(49, 330)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(112, 34)
        btnBrowse.TabIndex = 12
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(418, 352)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(112, 34)
        btnCetak.TabIndex = 3
        btnCetak.Text = "Cetak"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(258, 352)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(112, 34)
        btnSimpan.TabIndex = 2
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cbGaming)
        GroupBox1.Controls.Add(cbVlogger)
        GroupBox1.Controls.Add(cbCosplay)
        GroupBox1.Controls.Add(cbEditor)
        GroupBox1.Controls.Add(cbKontenKreator)
        GroupBox1.Controls.Add(cbVideographer)
        GroupBox1.Controls.Add(cbKuliner)
        GroupBox1.Controls.Add(cbPhotographer)
        GroupBox1.Location = New Point(242, 15)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(407, 237)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Hobby"
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Location = New Point(16, 30)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(100, 29)
        cbGaming.TabIndex = 4
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' cbVlogger
        ' 
        cbVlogger.AutoSize = True
        cbVlogger.Location = New Point(253, 135)
        cbVlogger.Name = "cbVlogger"
        cbVlogger.Size = New Size(101, 29)
        cbVlogger.TabIndex = 11
        cbVlogger.Text = "Vlogger"
        cbVlogger.UseVisualStyleBackColor = True
        ' 
        ' cbCosplay
        ' 
        cbCosplay.AutoSize = True
        cbCosplay.Location = New Point(16, 65)
        cbCosplay.Name = "cbCosplay"
        cbCosplay.Size = New Size(101, 29)
        cbCosplay.TabIndex = 5
        cbCosplay.Text = "Cosplay"
        cbCosplay.UseVisualStyleBackColor = True
        ' 
        ' cbEditor
        ' 
        cbEditor.AutoSize = True
        cbEditor.Location = New Point(253, 100)
        cbEditor.Name = "cbEditor"
        cbEditor.Size = New Size(85, 29)
        cbEditor.TabIndex = 10
        cbEditor.Text = "Editor"
        cbEditor.UseVisualStyleBackColor = True
        ' 
        ' cbKontenKreator
        ' 
        cbKontenKreator.AutoSize = True
        cbKontenKreator.Location = New Point(16, 100)
        cbKontenKreator.Name = "cbKontenKreator"
        cbKontenKreator.Size = New Size(156, 29)
        cbKontenKreator.TabIndex = 6
        cbKontenKreator.Text = "Konten Kreator"
        cbKontenKreator.UseVisualStyleBackColor = True
        ' 
        ' cbVideographer
        ' 
        cbVideographer.AutoSize = True
        cbVideographer.Location = New Point(253, 65)
        cbVideographer.Name = "cbVideographer"
        cbVideographer.Size = New Size(146, 29)
        cbVideographer.TabIndex = 9
        cbVideographer.Text = "Videographer"
        cbVideographer.UseVisualStyleBackColor = True
        ' 
        ' cbKuliner
        ' 
        cbKuliner.AutoSize = True
        cbKuliner.Location = New Point(16, 135)
        cbKuliner.Name = "cbKuliner"
        cbKuliner.Size = New Size(91, 29)
        cbKuliner.TabIndex = 7
        cbKuliner.Text = "Kuliner"
        cbKuliner.UseVisualStyleBackColor = True
        ' 
        ' cbPhotographer
        ' 
        cbPhotographer.AutoSize = True
        cbPhotographer.Location = New Point(253, 30)
        cbPhotographer.Name = "cbPhotographer"
        cbPhotographer.Size = New Size(148, 29)
        cbPhotographer.TabIndex = 8
        cbPhotographer.Text = "Photographer"
        cbPhotographer.UseVisualStyleBackColor = True
        ' 
        ' picProfil
        ' 
        picProfil.Location = New Point(17, 15)
        picProfil.Name = "picProfil"
        picProfil.Size = New Size(188, 284)
        picProfil.TabIndex = 0
        picProfil.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DarkOrange
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(50, 106)
        Label1.Name = "Label1"
        Label1.Size = New Size(200, 25)
        Label1.TabIndex = 1
        Label1.Text = "Sistem Kartu Komunitas"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.SpringGreen
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1099, 33)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(76, 29)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Cyan
        ClientSize = New Size(1099, 679)
        Controls.Add(Label1)
        Controls.Add(tclData)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        tclData.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        tclKontak.ResumeLayout(False)
        tclKontak.PerformLayout()
        tclProfil.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tclData As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents tclKontak As TabPage
    Friend WithEvents tclProfil As TabPage
    Friend WithEvents cbKomunitas As ComboBox
    Friend WithEvents rbCewek As RadioButton
    Friend WithEvents rbCowok As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents mtxtNomorHP As MaskedTextBox
    Friend WithEvents cbVlogger As CheckBox
    Friend WithEvents cbEditor As CheckBox
    Friend WithEvents cbVideographer As CheckBox
    Friend WithEvents cbPhotographer As CheckBox
    Friend WithEvents cbKuliner As CheckBox
    Friend WithEvents cbKontenKreator As CheckBox
    Friend WithEvents cbCosplay As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents picProfil As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem

End Class
