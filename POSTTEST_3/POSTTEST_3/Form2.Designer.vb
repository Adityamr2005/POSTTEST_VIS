<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        lblNama = New Label()
        lblUmur = New Label()
        lblTL = New Label()
        lblHobby = New Label()
        lblNomorTelpon = New Label()
        lblAlamat = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(26, 33)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(286, 505)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(375, 44)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(59, 25)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Location = New Point(375, 128)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(56, 25)
        lblUmur.TabIndex = 2
        lblUmur.Text = "Umur"
        ' 
        ' lblTL
        ' 
        lblTL.AutoSize = True
        lblTL.Location = New Point(375, 218)
        lblTL.Name = "lblTL"
        lblTL.Size = New Size(115, 25)
        lblTL.TabIndex = 3
        lblTL.Text = "Tanggal Lahir"
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.Location = New Point(375, 316)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(67, 25)
        lblHobby.TabIndex = 4
        lblHobby.Text = "Hobby"
        ' 
        ' lblNomorTelpon
        ' 
        lblNomorTelpon.AutoSize = True
        lblNomorTelpon.Location = New Point(375, 397)
        lblNomorTelpon.Name = "lblNomorTelpon"
        lblNomorTelpon.Size = New Size(126, 25)
        lblNomorTelpon.TabIndex = 5
        lblNomorTelpon.Text = "Nomor Telpon"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(375, 486)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(68, 25)
        lblAlamat.TabIndex = 6
        lblAlamat.Text = "Alamat"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Aqua
        ClientSize = New Size(994, 652)
        Controls.Add(lblAlamat)
        Controls.Add(lblNomorTelpon)
        Controls.Add(lblHobby)
        Controls.Add(lblTL)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(PictureBox1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTL As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents lblNomorTelpon As Label
    Friend WithEvents lblAlamat As Label
End Class
