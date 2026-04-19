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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtUID = New TextBox()
        txtUsername = New TextBox()
        txtLevel = New TextBox()
        txtRank = New TextBox()
        cbLevel = New ComboBox()
        dgvData = New DataGridView()
        txtSearch = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        CType(dgvData, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(45, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 25)
        Label1.TabIndex = 0
        Label1.Text = "UID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(45, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 25)
        Label2.TabIndex = 1
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(45, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 25)
        Label3.TabIndex = 2
        Label3.Text = "Level"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(45, 230)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 25)
        Label4.TabIndex = 3
        Label4.Text = "Rank"
        ' 
        ' txtUID
        ' 
        txtUID.Location = New Point(189, 21)
        txtUID.Name = "txtUID"
        txtUID.Size = New Size(260, 31)
        txtUID.TabIndex = 5
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(189, 85)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(260, 31)
        txtUsername.TabIndex = 6
        ' 
        ' txtLevel
        ' 
        txtLevel.Location = New Point(189, 156)
        txtLevel.Name = "txtLevel"
        txtLevel.Size = New Size(260, 31)
        txtLevel.TabIndex = 7
        ' 
        ' txtRank
        ' 
        txtRank.Location = New Point(189, 230)
        txtRank.Name = "txtRank"
        txtRank.Size = New Size(260, 31)
        txtRank.TabIndex = 8
        ' 
        ' cbLevel
        ' 
        cbLevel.FormattingEnabled = True
        cbLevel.Location = New Point(508, 18)
        cbLevel.Name = "cbLevel"
        cbLevel.Size = New Size(182, 33)
        cbLevel.TabIndex = 9
        ' 
        ' dgvData
        ' 
        dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvData.Location = New Point(45, 466)
        dgvData.Name = "dgvData"
        dgvData.RowHeadersWidth = 62
        dgvData.Size = New Size(931, 234)
        dgvData.TabIndex = 10
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(45, 397)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(645, 31)
        txtSearch.TabIndex = 11
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(45, 316)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(112, 34)
        btnSimpan.TabIndex = 12
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(248, 316)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(112, 34)
        btnUbah.TabIndex = 13
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(443, 316)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(112, 34)
        btnHapus.TabIndex = 14
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        ClientSize = New Size(1021, 712)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtSearch)
        Controls.Add(dgvData)
        Controls.Add(cbLevel)
        Controls.Add(txtRank)
        Controls.Add(txtLevel)
        Controls.Add(txtUsername)
        Controls.Add(txtUID)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(dgvData, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtUID As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtLevel As TextBox
    Friend WithEvents txtRank As TextBox
    Friend WithEvents cbLevel As ComboBox
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
