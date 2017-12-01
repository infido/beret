<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start))
        Me.TBSymbol = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BZnajdz = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TBBrutto = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TBNetto = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TBNazwa = New System.Windows.Forms.TextBox
        Me.TBSkrot = New System.Windows.Forms.TextBox
        Me.TBData = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TBNumer = New System.Windows.Forms.TextBox
        Me.BZapisz = New System.Windows.Forms.Button
        Me.BZakoncz = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.UstawieniaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EksportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KontrahenciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PracownicyKontrahentówToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.StanówMagazynowychDoWwwToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Lzebrano = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.OdDaty = New System.Windows.Forms.MaskedTextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Lpozostalo = New System.Windows.Forms.Label
        Me.LWymieniono = New System.Windows.Forms.Label
        Me.LRazemZakupy = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TBKlient = New System.Windows.Forms.TextBox
        Me.BSzukaj = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.StanówPunktowychDoWwwToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBSymbol
        '
        Me.TBSymbol.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBSymbol.Location = New System.Drawing.Point(103, 15)
        Me.TBSymbol.Name = "TBSymbol"
        Me.TBSymbol.Size = New System.Drawing.Size(158, 20)
        Me.TBSymbol.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Symbol paragonu"
        '
        'BZnajdz
        '
        Me.BZnajdz.Location = New System.Drawing.Point(267, 13)
        Me.BZnajdz.Name = "BZnajdz"
        Me.BZnajdz.Size = New System.Drawing.Size(75, 23)
        Me.BZnajdz.TabIndex = 5
        Me.BZnajdz.Text = "&Znajdź"
        Me.BZnajdz.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TBBrutto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TBNetto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TBNazwa)
        Me.GroupBox1.Controls.Add(Me.TBSkrot)
        Me.GroupBox1.Controls.Add(Me.TBData)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1022, 77)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacje o dokumencie"
        '
        'TBBrutto
        '
        Me.TBBrutto.Location = New System.Drawing.Point(284, 45)
        Me.TBBrutto.Name = "TBBrutto"
        Me.TBBrutto.ReadOnly = True
        Me.TBBrutto.Size = New System.Drawing.Size(71, 20)
        Me.TBBrutto.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(188, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Wartość brutto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Wartość netto"
        '
        'TBNetto
        '
        Me.TBNetto.Location = New System.Drawing.Point(103, 45)
        Me.TBNetto.Name = "TBNetto"
        Me.TBNetto.ReadOnly = True
        Me.TBNetto.Size = New System.Drawing.Size(71, 20)
        Me.TBNetto.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(544, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nazwa pełna"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(209, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nazwa skrócona"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data wystawienia"
        '
        'TBNazwa
        '
        Me.TBNazwa.Location = New System.Drawing.Point(640, 19)
        Me.TBNazwa.Name = "TBNazwa"
        Me.TBNazwa.ReadOnly = True
        Me.TBNazwa.Size = New System.Drawing.Size(364, 20)
        Me.TBNazwa.TabIndex = 2
        '
        'TBSkrot
        '
        Me.TBSkrot.Location = New System.Drawing.Point(305, 19)
        Me.TBSkrot.Name = "TBSkrot"
        Me.TBSkrot.ReadOnly = True
        Me.TBSkrot.Size = New System.Drawing.Size(222, 20)
        Me.TBSkrot.TabIndex = 1
        '
        'TBData
        '
        Me.TBData.Location = New System.Drawing.Point(103, 19)
        Me.TBData.Name = "TBData"
        Me.TBData.ReadOnly = True
        Me.TBData.Size = New System.Drawing.Size(100, 20)
        Me.TBData.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Przypisz kartę nr"
        '
        'TBNumer
        '
        Me.TBNumer.Location = New System.Drawing.Point(103, 126)
        Me.TBNumer.Name = "TBNumer"
        Me.TBNumer.Size = New System.Drawing.Size(71, 20)
        Me.TBNumer.TabIndex = 6
        '
        'BZapisz
        '
        Me.BZapisz.Location = New System.Drawing.Point(180, 124)
        Me.BZapisz.Name = "BZapisz"
        Me.BZapisz.Size = New System.Drawing.Size(75, 23)
        Me.BZapisz.TabIndex = 7
        Me.BZapisz.Text = "Zapisz"
        Me.BZapisz.UseVisualStyleBackColor = True
        Me.BZapisz.Visible = False
        '
        'BZakoncz
        '
        Me.BZakoncz.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BZakoncz.Location = New System.Drawing.Point(1055, 108)
        Me.BZakoncz.Name = "BZakoncz"
        Me.BZakoncz.Size = New System.Drawing.Size(75, 35)
        Me.BZakoncz.TabIndex = 3
        Me.BZakoncz.Text = "Z&akończ"
        Me.BZakoncz.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UstawieniaToolStripMenuItem, Me.EksportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1142, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UstawieniaToolStripMenuItem
        '
        Me.UstawieniaToolStripMenuItem.Name = "UstawieniaToolStripMenuItem"
        Me.UstawieniaToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.UstawieniaToolStripMenuItem.Text = "&Ustawienia"
        '
        'EksportToolStripMenuItem
        '
        Me.EksportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KontrahenciToolStripMenuItem, Me.PracownicyKontrahentówToolStripMenuItem, Me.ToolStripSeparator1, Me.StanówMagazynowychDoWwwToolStripMenuItem, Me.StanówPunktowychDoWwwToolStripMenuItem})
        Me.EksportToolStripMenuItem.Name = "EksportToolStripMenuItem"
        Me.EksportToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.EksportToolStripMenuItem.Text = "&Eksport"
        '
        'KontrahenciToolStripMenuItem
        '
        Me.KontrahenciToolStripMenuItem.Name = "KontrahenciToolStripMenuItem"
        Me.KontrahenciToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.KontrahenciToolStripMenuItem.Text = "&Kontrahenci"
        '
        'PracownicyKontrahentówToolStripMenuItem
        '
        Me.PracownicyKontrahentówToolStripMenuItem.Name = "PracownicyKontrahentówToolStripMenuItem"
        Me.PracownicyKontrahentówToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.PracownicyKontrahentówToolStripMenuItem.Text = "&Pracownicy kontrahentów"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(237, 6)
        '
        'StanówMagazynowychDoWwwToolStripMenuItem
        '
        Me.StanówMagazynowychDoWwwToolStripMenuItem.Name = "StanówMagazynowychDoWwwToolStripMenuItem"
        Me.StanówMagazynowychDoWwwToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.StanówMagazynowychDoWwwToolStripMenuItem.Text = "&Stanów magazynowych do www"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TBSymbol)
        Me.Panel1.Controls.Add(Me.BZakoncz)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BZapisz)
        Me.Panel1.Controls.Add(Me.BZnajdz)
        Me.Panel1.Controls.Add(Me.TBNumer)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 547)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1142, 156)
        Me.Panel1.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Lzebrano)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.OdDaty)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Lpozostalo)
        Me.Panel3.Controls.Add(Me.LWymieniono)
        Me.Panel3.Controls.Add(Me.LRazemZakupy)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.TBKlient)
        Me.Panel3.Controls.Add(Me.BSzukaj)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 24)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1142, 83)
        Me.Panel3.TabIndex = 1
        '
        'Lzebrano
        '
        Me.Lzebrano.AutoSize = True
        Me.Lzebrano.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lzebrano.Location = New System.Drawing.Point(991, 8)
        Me.Lzebrano.Name = "Lzebrano"
        Me.Lzebrano.Size = New System.Drawing.Size(42, 24)
        Me.Lzebrano.TabIndex = 14
        Me.Lzebrano.Text = "0 zł"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label15.Location = New System.Drawing.Point(923, 14)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 16)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Zebrano:"
        '
        'OdDaty
        '
        Me.OdDaty.Location = New System.Drawing.Point(159, 43)
        Me.OdDaty.Mask = "0000/00/00"
        Me.OdDaty.Name = "OdDaty"
        Me.OdDaty.Size = New System.Drawing.Size(65, 20)
        Me.OdDaty.TabIndex = 12
        Me.OdDaty.Text = "20080101"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(71, 46)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Liczone od daty"
        '
        'Lpozostalo
        '
        Me.Lpozostalo.AutoSize = True
        Me.Lpozostalo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lpozostalo.ForeColor = System.Drawing.Color.Red
        Me.Lpozostalo.Location = New System.Drawing.Point(991, 52)
        Me.Lpozostalo.Name = "Lpozostalo"
        Me.Lpozostalo.Size = New System.Drawing.Size(42, 24)
        Me.Lpozostalo.TabIndex = 9
        Me.Lpozostalo.Text = "0 zł"
        '
        'LWymieniono
        '
        Me.LWymieniono.AutoSize = True
        Me.LWymieniono.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LWymieniono.Location = New System.Drawing.Point(991, 30)
        Me.LWymieniono.Name = "LWymieniono"
        Me.LWymieniono.Size = New System.Drawing.Size(42, 24)
        Me.LWymieniono.TabIndex = 8
        Me.LWymieniono.Text = "0 zł"
        '
        'LRazemZakupy
        '
        Me.LRazemZakupy.AutoSize = True
        Me.LRazemZakupy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LRazemZakupy.Location = New System.Drawing.Point(773, 8)
        Me.LRazemZakupy.Name = "LRazemZakupy"
        Me.LRazemZakupy.Size = New System.Drawing.Size(42, 24)
        Me.LRazemZakupy.TabIndex = 7
        Me.LRazemZakupy.Text = "0 zł"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label12.Location = New System.Drawing.Point(911, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 16)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Pozostało:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label11.Location = New System.Drawing.Point(899, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 16)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Wymieniono:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label10.Location = New System.Drawing.Point(667, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 16)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Razem zakupy:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.Location = New System.Drawing.Point(435, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(251, 20)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Historia transakcji dla Kontrahenta"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Nr karty lub nazwa skrócona"
        '
        'TBKlient
        '
        Me.TBKlient.Location = New System.Drawing.Point(159, 17)
        Me.TBKlient.Name = "TBKlient"
        Me.TBKlient.Size = New System.Drawing.Size(207, 20)
        Me.TBKlient.TabIndex = 1
        '
        'BSzukaj
        '
        Me.BSzukaj.Location = New System.Drawing.Point(388, 11)
        Me.BSzukaj.Name = "BSzukaj"
        Me.BSzukaj.Size = New System.Drawing.Size(100, 31)
        Me.BSzukaj.TabIndex = 2
        Me.BSzukaj.Text = "Szukaj"
        Me.BSzukaj.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(1142, 440)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 107)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1142, 440)
        Me.Panel2.TabIndex = 12
        '
        'StanówPunktowychDoWwwToolStripMenuItem
        '
        Me.StanówPunktowychDoWwwToolStripMenuItem.Name = "StanówPunktowychDoWwwToolStripMenuItem"
        Me.StanówPunktowychDoWwwToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.StanówPunktowychDoWwwToolStripMenuItem.Text = "Stanów punktowych do www"
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BZakoncz
        Me.ClientSize = New System.Drawing.Size(1142, 703)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Start"
        Me.Text = "Beret 2.1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBSymbol As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BZnajdz As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TBNazwa As System.Windows.Forms.TextBox
    Friend WithEvents TBSkrot As System.Windows.Forms.TextBox
    Friend WithEvents TBData As System.Windows.Forms.TextBox
    Friend WithEvents TBNetto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBBrutto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TBNumer As System.Windows.Forms.TextBox
    Friend WithEvents BZapisz As System.Windows.Forms.Button
    Friend WithEvents BZakoncz As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents UstawieniaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EksportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KontrahenciToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PracownicyKontrahentówToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StanówMagazynowychDoWwwToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TBKlient As System.Windows.Forms.TextBox
    Friend WithEvents BSzukaj As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents OdDaty As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Lpozostalo As System.Windows.Forms.Label
    Friend WithEvents LWymieniono As System.Windows.Forms.Label
    Friend WithEvents LRazemZakupy As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Lzebrano As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents StanówPunktowychDoWwwToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class
