<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KH))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.BBrak = New System.Windows.Forms.Button
        Me.Buzup = New System.Windows.Forms.Button
        Me.BExportXLS = New System.Windows.Forms.Button
        Me.BClose = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.JakoAdresDokorespondecjiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DodajDoPolaUwagiToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.DataGridView3 = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TelstacjonarnyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TelkomórkowyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FaxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DodajDoPolaUwagiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataGridView4 = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip4 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AdresemailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdreshttpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DodajDoPolaUwagiToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Menu1Usun = New System.Windows.Forms.ToolStripMenuItem
        Me.UsuńkolumnęToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.KolumnaŹródłowaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WklejDoKolumnyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.KopiujToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WklejToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip3.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip4.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 525)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1026, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1026, 27)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BBrak)
        Me.Panel2.Controls.Add(Me.Buzup)
        Me.Panel2.Controls.Add(Me.BExportXLS)
        Me.Panel2.Controls.Add(Me.BClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 486)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1026, 39)
        Me.Panel2.TabIndex = 2
        '
        'BBrak
        '
        Me.BBrak.Location = New System.Drawing.Point(739, 7)
        Me.BBrak.Name = "BBrak"
        Me.BBrak.Size = New System.Drawing.Size(75, 23)
        Me.BBrak.TabIndex = 3
        Me.BBrak.Text = "Wpisz &Brak"
        Me.BBrak.UseVisualStyleBackColor = True
        '
        'Buzup
        '
        Me.Buzup.Location = New System.Drawing.Point(658, 7)
        Me.Buzup.Name = "Buzup"
        Me.Buzup.Size = New System.Drawing.Size(75, 23)
        Me.Buzup.TabIndex = 2
        Me.Buzup.Text = "&Uzupełnij"
        Me.Buzup.UseVisualStyleBackColor = True
        '
        'BExportXLS
        '
        Me.BExportXLS.Location = New System.Drawing.Point(819, 7)
        Me.BExportXLS.Name = "BExportXLS"
        Me.BExportXLS.Size = New System.Drawing.Size(114, 23)
        Me.BExportXLS.TabIndex = 1
        Me.BExportXLS.Text = "Eksport do &xls"
        Me.BExportXLS.UseVisualStyleBackColor = True
        '
        'BClose
        '
        Me.BClose.Location = New System.Drawing.Point(939, 6)
        Me.BClose.Name = "BClose"
        Me.BClose.Size = New System.Drawing.Size(75, 23)
        Me.BClose.TabIndex = 0
        Me.BClose.Text = "&Zamknij"
        Me.BClose.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.SplitContainer1)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 27)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1026, 459)
        Me.Panel3.TabIndex = 3
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 271)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridView2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1026, 188)
        Me.SplitContainer1.SplitterDistance = 441
        Me.SplitContainer1.TabIndex = 1
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.ContextMenuStrip = Me.ContextMenuStrip2
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(441, 188)
        Me.DataGridView2.TabIndex = 0
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JakoAdresDokorespondecjiToolStripMenuItem, Me.DodajDoPolaUwagiToolStripMenuItem2})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(222, 48)
        '
        'JakoAdresDokorespondecjiToolStripMenuItem
        '
        Me.JakoAdresDokorespondecjiToolStripMenuItem.Name = "JakoAdresDokorespondecjiToolStripMenuItem"
        Me.JakoAdresDokorespondecjiToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.JakoAdresDokorespondecjiToolStripMenuItem.Text = "Jako adres do &korespondecji"
        '
        'DodajDoPolaUwagiToolStripMenuItem2
        '
        Me.DodajDoPolaUwagiToolStripMenuItem2.Name = "DodajDoPolaUwagiToolStripMenuItem2"
        Me.DodajDoPolaUwagiToolStripMenuItem2.Size = New System.Drawing.Size(221, 22)
        Me.DodajDoPolaUwagiToolStripMenuItem2.Text = "Dodaj do pola Uwagi"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.DataGridView3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.DataGridView4)
        Me.SplitContainer2.Size = New System.Drawing.Size(581, 188)
        Me.SplitContainer2.SplitterDistance = 290
        Me.SplitContainer2.TabIndex = 0
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.ContextMenuStrip = Me.ContextMenuStrip3
        Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView3.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.Size = New System.Drawing.Size(290, 188)
        Me.DataGridView3.TabIndex = 0
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TelstacjonarnyToolStripMenuItem, Me.TelkomórkowyToolStripMenuItem, Me.FaxToolStripMenuItem, Me.DodajDoPolaUwagiToolStripMenuItem})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(183, 92)
        '
        'TelstacjonarnyToolStripMenuItem
        '
        Me.TelstacjonarnyToolStripMenuItem.Name = "TelstacjonarnyToolStripMenuItem"
        Me.TelstacjonarnyToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.TelstacjonarnyToolStripMenuItem.Text = "Tel &stacjonarny"
        '
        'TelkomórkowyToolStripMenuItem
        '
        Me.TelkomórkowyToolStripMenuItem.Name = "TelkomórkowyToolStripMenuItem"
        Me.TelkomórkowyToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.TelkomórkowyToolStripMenuItem.Text = "Tel &komórkowy"
        '
        'FaxToolStripMenuItem
        '
        Me.FaxToolStripMenuItem.Name = "FaxToolStripMenuItem"
        Me.FaxToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.FaxToolStripMenuItem.Text = "fax"
        '
        'DodajDoPolaUwagiToolStripMenuItem
        '
        Me.DodajDoPolaUwagiToolStripMenuItem.Name = "DodajDoPolaUwagiToolStripMenuItem"
        Me.DodajDoPolaUwagiToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.DodajDoPolaUwagiToolStripMenuItem.Text = "dodaj do pola Uwagi"
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.ContextMenuStrip = Me.ContextMenuStrip4
        Me.DataGridView4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView4.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowHeadersVisible = False
        Me.DataGridView4.Size = New System.Drawing.Size(287, 188)
        Me.DataGridView4.TabIndex = 0
        '
        'ContextMenuStrip4
        '
        Me.ContextMenuStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdresemailToolStripMenuItem, Me.AdreshttpToolStripMenuItem, Me.DodajDoPolaUwagiToolStripMenuItem1})
        Me.ContextMenuStrip4.Name = "ContextMenuStrip4"
        Me.ContextMenuStrip4.Size = New System.Drawing.Size(183, 70)
        '
        'AdresemailToolStripMenuItem
        '
        Me.AdresemailToolStripMenuItem.Name = "AdresemailToolStripMenuItem"
        Me.AdresemailToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.AdresemailToolStripMenuItem.Text = "Adres &email"
        '
        'AdreshttpToolStripMenuItem
        '
        Me.AdreshttpToolStripMenuItem.Name = "AdreshttpToolStripMenuItem"
        Me.AdreshttpToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.AdreshttpToolStripMenuItem.Text = "Adres &http"
        '
        'DodajDoPolaUwagiToolStripMenuItem1
        '
        Me.DodajDoPolaUwagiToolStripMenuItem1.Name = "DodajDoPolaUwagiToolStripMenuItem1"
        Me.DodajDoPolaUwagiToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.DodajDoPolaUwagiToolStripMenuItem1.Text = "dodaj do pola &Uwagi"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.DataGridView1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1026, 271)
        Me.Panel4.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(1026, 271)
        Me.DataGridView1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu1Usun, Me.UsuńkolumnęToolStripMenuItem, Me.ToolStripSeparator1, Me.KolumnaŹródłowaToolStripMenuItem, Me.WklejDoKolumnyToolStripMenuItem, Me.ToolStripSeparator2, Me.KopiujToolStripMenuItem, Me.WklejToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(174, 170)
        '
        'Menu1Usun
        '
        Me.Menu1Usun.Name = "Menu1Usun"
        Me.Menu1Usun.Size = New System.Drawing.Size(173, 22)
        Me.Menu1Usun.Text = "&Usuń wiersz"
        '
        'UsuńkolumnęToolStripMenuItem
        '
        Me.UsuńkolumnęToolStripMenuItem.Name = "UsuńkolumnęToolStripMenuItem"
        Me.UsuńkolumnęToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.UsuńkolumnęToolStripMenuItem.Text = "Usuń &kolumnę"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(170, 6)
        '
        'KolumnaŹródłowaToolStripMenuItem
        '
        Me.KolumnaŹródłowaToolStripMenuItem.Name = "KolumnaŹródłowaToolStripMenuItem"
        Me.KolumnaŹródłowaToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.KolumnaŹródłowaToolStripMenuItem.Text = "Kolumna Ź&ródłowa"
        '
        'WklejDoKolumnyToolStripMenuItem
        '
        Me.WklejDoKolumnyToolStripMenuItem.Name = "WklejDoKolumnyToolStripMenuItem"
        Me.WklejDoKolumnyToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.WklejDoKolumnyToolStripMenuItem.Text = "&Wklej do kolumny"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(170, 6)
        '
        'KopiujToolStripMenuItem
        '
        Me.KopiujToolStripMenuItem.Name = "KopiujToolStripMenuItem"
        Me.KopiujToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.KopiujToolStripMenuItem.Text = "kopiuj &c"
        '
        'WklejToolStripMenuItem
        '
        Me.WklejToolStripMenuItem.Name = "WklejToolStripMenuItem"
        Me.WklejToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.WklejToolStripMenuItem.Text = "wklej &v"
        '
        'KH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 547)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KH"
        Me.Text = "Kontrahenci"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip3.ResumeLayout(False)
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip4.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BClose As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Menu1Usun As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KolumnaŹródłowaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WklejDoKolumnyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuńkolumnęToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ContextMenuStrip3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ContextMenuStrip4 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents JakoAdresDokorespondecjiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TelstacjonarnyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TelkomórkowyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FaxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DodajDoPolaUwagiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdresemailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdreshttpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DodajDoPolaUwagiToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DodajDoPolaUwagiToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BExportXLS As System.Windows.Forms.Button
    Friend WithEvents Buzup As System.Windows.Forms.Button
    Friend WithEvents BBrak As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KopiujToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WklejToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
