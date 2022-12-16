<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Perpustakaan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HapusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnDetail = New System.Windows.Forms.Button()
        Me.DataGridKoleksi = New System.Windows.Forms.DataGridView()
        Me.ListBoxKoleksi = New System.Windows.Forms.ListBox()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.Transparent
        Me.BtnHapus.BackgroundImage = Global.AplikasiPerpus.My.Resources.Resources.icons8_minus_48
        Me.BtnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHapus.FlatAppearance.BorderSize = 0
        Me.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapus.ForeColor = System.Drawing.Color.Transparent
        Me.BtnHapus.Location = New System.Drawing.Point(50, 30)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(32, 38)
        Me.BtnHapus.TabIndex = 2
        Me.BtnHapus.UseMnemonic = False
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KoleksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(624, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KoleksiToolStripMenuItem
        '
        Me.KoleksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahToolStripMenuItem, Me.HapusToolStripMenuItem})
        Me.KoleksiToolStripMenuItem.Name = "KoleksiToolStripMenuItem"
        Me.KoleksiToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.KoleksiToolStripMenuItem.Text = "Koleksi"
        '
        'TambahToolStripMenuItem
        '
        Me.TambahToolStripMenuItem.Name = "TambahToolStripMenuItem"
        Me.TambahToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.TambahToolStripMenuItem.Text = "Tambah Koleksi"
        '
        'HapusToolStripMenuItem
        '
        Me.HapusToolStripMenuItem.Name = "HapusToolStripMenuItem"
        Me.HapusToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.HapusToolStripMenuItem.Text = "Hapus Koleksi"
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.Transparent
        Me.BtnTambah.BackgroundImage = Global.AplikasiPerpus.My.Resources.Resources.icons8_plus_482
        Me.BtnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTambah.FlatAppearance.BorderSize = 0
        Me.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambah.ForeColor = System.Drawing.Color.Transparent
        Me.BtnTambah.Location = New System.Drawing.Point(12, 30)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(32, 38)
        Me.BtnTambah.TabIndex = 4
        Me.BtnTambah.UseMnemonic = False
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'BtnDetail
        '
        Me.BtnDetail.Location = New System.Drawing.Point(537, 46)
        Me.BtnDetail.Name = "BtnDetail"
        Me.BtnDetail.Size = New System.Drawing.Size(75, 23)
        Me.BtnDetail.TabIndex = 5
        Me.BtnDetail.Text = "Detail"
        Me.BtnDetail.UseVisualStyleBackColor = True
        '
        'DataGridKoleksi
        '
        Me.DataGridKoleksi.AllowUserToAddRows = False
        Me.DataGridKoleksi.AllowUserToDeleteRows = False
        Me.DataGridKoleksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridKoleksi.Location = New System.Drawing.Point(189, 75)
        Me.DataGridKoleksi.Name = "DataGridKoleksi"
        Me.DataGridKoleksi.RowTemplate.Height = 25
        Me.DataGridKoleksi.Size = New System.Drawing.Size(423, 301)
        Me.DataGridKoleksi.TabIndex = 6
        '
        'ListBoxKoleksi
        '
        Me.ListBoxKoleksi.FormattingEnabled = True
        Me.ListBoxKoleksi.ItemHeight = 15
        Me.ListBoxKoleksi.Location = New System.Drawing.Point(12, 74)
        Me.ListBoxKoleksi.Name = "ListBoxKoleksi"
        Me.ListBoxKoleksi.Size = New System.Drawing.Size(171, 304)
        Me.ListBoxKoleksi.TabIndex = 7
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(456, 45)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 8
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'Perpustakaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(624, 388)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.ListBoxKoleksi)
        Me.Controls.Add(Me.DataGridKoleksi)
        Me.Controls.Add(Me.BtnDetail)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Perpustakaan"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnHapus As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HapusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnDetail As Button
    Friend WithEvents DataGridKoleksi As DataGridView
    Friend WithEvents ListBoxKoleksi As ListBox
    Friend WithEvents BtnUpdate As Button
End Class
