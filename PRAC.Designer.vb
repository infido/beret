<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRAC
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PRAC))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BUzup = New System.Windows.Forms.Button
        Me.BZamknij = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.BExportXLS = New System.Windows.Forms.Button
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UsuńWierszToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UsuńKolumnęToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.KopiujCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WkjejvToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 518)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(774, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BExportXLS)
        Me.Panel1.Controls.Add(Me.BUzup)
        Me.Panel1.Controls.Add(Me.BZamknij)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 479)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(774, 39)
        Me.Panel1.TabIndex = 1
        '
        'BUzup
        '
        Me.BUzup.Location = New System.Drawing.Point(474, 7)
        Me.BUzup.Name = "BUzup"
        Me.BUzup.Size = New System.Drawing.Size(75, 23)
        Me.BUzup.TabIndex = 1
        Me.BUzup.Text = "&Uzupełnij"
        Me.BUzup.UseVisualStyleBackColor = True
        '
        'BZamknij
        '
        Me.BZamknij.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BZamknij.Location = New System.Drawing.Point(675, 7)
        Me.BZamknij.Name = "BZamknij"
        Me.BZamknij.Size = New System.Drawing.Size(75, 23)
        Me.BZamknij.TabIndex = 0
        Me.BZamknij.Text = "&Zamknij"
        Me.BZamknij.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(774, 479)
        Me.DataGridView1.TabIndex = 2
        '
        'BExportXLS
        '
        Me.BExportXLS.Location = New System.Drawing.Point(555, 7)
        Me.BExportXLS.Name = "BExportXLS"
        Me.BExportXLS.Size = New System.Drawing.Size(114, 23)
        Me.BExportXLS.TabIndex = 2
        Me.BExportXLS.Text = "Eksport do &xls"
        Me.BExportXLS.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuńWierszToolStripMenuItem, Me.UsuńKolumnęToolStripMenuItem, Me.ToolStripSeparator1, Me.KopiujCToolStripMenuItem, Me.WkjejvToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 120)
        '
        'UsuńWierszToolStripMenuItem
        '
        Me.UsuńWierszToolStripMenuItem.Name = "UsuńWierszToolStripMenuItem"
        Me.UsuńWierszToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UsuńWierszToolStripMenuItem.Text = "&Usuń wiersz"
        '
        'UsuńKolumnęToolStripMenuItem
        '
        Me.UsuńKolumnęToolStripMenuItem.Name = "UsuńKolumnęToolStripMenuItem"
        Me.UsuńKolumnęToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UsuńKolumnęToolStripMenuItem.Text = "usuń &Kolumnę"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'KopiujCToolStripMenuItem
        '
        Me.KopiujCToolStripMenuItem.Name = "KopiujCToolStripMenuItem"
        Me.KopiujCToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.KopiujCToolStripMenuItem.Text = "kopiuj &c"
        '
        'WkjejvToolStripMenuItem
        '
        Me.WkjejvToolStripMenuItem.Name = "WkjejvToolStripMenuItem"
        Me.WkjejvToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.WkjejvToolStripMenuItem.Text = "wklej &v"
        '
        'PRAC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BZamknij
        Me.ClientSize = New System.Drawing.Size(774, 540)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PRAC"
        Me.Text = "Import pracowników"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BZamknij As System.Windows.Forms.Button
    Friend WithEvents BUzup As System.Windows.Forms.Button
    Friend WithEvents BExportXLS As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents UsuńWierszToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuńKolumnęToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KopiujCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WkjejvToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
