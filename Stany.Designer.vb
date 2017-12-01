<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stany
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stany))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.Cena1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Cena2 = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Cena3 = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Magazyn6 = New System.Windows.Forms.ComboBox
        Me.magazyn5 = New System.Windows.Forms.ComboBox
        Me.Magazyn4 = New System.Windows.Forms.ComboBox
        Me.Magazyn3 = New System.Windows.Forms.ComboBox
        Me.Magazyn2 = New System.Windows.Forms.ComboBox
        Me.Magazyn1 = New System.Windows.Forms.ComboBox
        Me.Anuluj = New System.Windows.Forms.Button
        Me.Eksportuj = New System.Windows.Forms.Button
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.Podglad = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.EksportujTylkoSprzedawane = New System.Windows.Forms.CheckBox
        Me.DateSelOD = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.DateSelDO = New System.Windows.Forms.DateTimePicker
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 258)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(540, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolLabel1
        '
        Me.ToolLabel1.Name = "ToolLabel1"
        Me.ToolLabel1.Size = New System.Drawing.Size(128, 17)
        Me.ToolLabel1.Text = "Przygotowanie danych..."
        '
        'Cena1
        '
        Me.Cena1.FormattingEnabled = True
        Me.Cena1.Location = New System.Drawing.Point(120, 19)
        Me.Cena1.Name = "Cena1"
        Me.Cena1.Size = New System.Drawing.Size(169, 21)
        Me.Cena1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cena bazowa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cena dodatkowa"
        '
        'Cena2
        '
        Me.Cena2.FormattingEnabled = True
        Me.Cena2.Location = New System.Drawing.Point(120, 46)
        Me.Cena2.Name = "Cena2"
        Me.Cena2.Size = New System.Drawing.Size(169, 21)
        Me.Cena2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cena dodatkowa"
        '
        'Cena3
        '
        Me.Cena3.FormattingEnabled = True
        Me.Cena3.Location = New System.Drawing.Point(120, 73)
        Me.Cena3.Name = "Cena3"
        Me.Cena3.Size = New System.Drawing.Size(169, 21)
        Me.Cena3.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cena1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Cena3)
        Me.GroupBox1.Controls.Add(Me.Cena2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 109)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ceny"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Magazyn6)
        Me.GroupBox2.Controls.Add(Me.magazyn5)
        Me.GroupBox2.Controls.Add(Me.Magazyn4)
        Me.GroupBox2.Controls.Add(Me.Magazyn3)
        Me.GroupBox2.Controls.Add(Me.Magazyn2)
        Me.GroupBox2.Controls.Add(Me.Magazyn1)
        Me.GroupBox2.Location = New System.Drawing.Point(328, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(206, 184)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Uwzględnienie magazynów do stanów"
        '
        'Magazyn6
        '
        Me.Magazyn6.FormattingEnabled = True
        Me.Magazyn6.Location = New System.Drawing.Point(17, 154)
        Me.Magazyn6.Name = "Magazyn6"
        Me.Magazyn6.Size = New System.Drawing.Size(169, 21)
        Me.Magazyn6.TabIndex = 7
        '
        'magazyn5
        '
        Me.magazyn5.FormattingEnabled = True
        Me.magazyn5.Location = New System.Drawing.Point(17, 127)
        Me.magazyn5.Name = "magazyn5"
        Me.magazyn5.Size = New System.Drawing.Size(169, 21)
        Me.magazyn5.TabIndex = 6
        '
        'Magazyn4
        '
        Me.Magazyn4.FormattingEnabled = True
        Me.Magazyn4.Location = New System.Drawing.Point(17, 100)
        Me.Magazyn4.Name = "Magazyn4"
        Me.Magazyn4.Size = New System.Drawing.Size(169, 21)
        Me.Magazyn4.TabIndex = 5
        '
        'Magazyn3
        '
        Me.Magazyn3.FormattingEnabled = True
        Me.Magazyn3.Location = New System.Drawing.Point(17, 73)
        Me.Magazyn3.Name = "Magazyn3"
        Me.Magazyn3.Size = New System.Drawing.Size(169, 21)
        Me.Magazyn3.TabIndex = 4
        '
        'Magazyn2
        '
        Me.Magazyn2.FormattingEnabled = True
        Me.Magazyn2.Location = New System.Drawing.Point(17, 46)
        Me.Magazyn2.Name = "Magazyn2"
        Me.Magazyn2.Size = New System.Drawing.Size(169, 21)
        Me.Magazyn2.TabIndex = 3
        '
        'Magazyn1
        '
        Me.Magazyn1.FormattingEnabled = True
        Me.Magazyn1.Location = New System.Drawing.Point(17, 19)
        Me.Magazyn1.Name = "Magazyn1"
        Me.Magazyn1.Size = New System.Drawing.Size(169, 21)
        Me.Magazyn1.TabIndex = 2
        '
        'Anuluj
        '
        Me.Anuluj.Location = New System.Drawing.Point(371, 227)
        Me.Anuluj.Name = "Anuluj"
        Me.Anuluj.Size = New System.Drawing.Size(75, 23)
        Me.Anuluj.TabIndex = 9
        Me.Anuluj.Text = "&Anuluj"
        Me.Anuluj.UseVisualStyleBackColor = True
        '
        'Eksportuj
        '
        Me.Eksportuj.Location = New System.Drawing.Point(452, 227)
        Me.Eksportuj.Name = "Eksportuj"
        Me.Eksportuj.Size = New System.Drawing.Size(75, 23)
        Me.Eksportuj.TabIndex = 10
        Me.Eksportuj.Text = "&Eksportuj"
        Me.Eksportuj.UseVisualStyleBackColor = True
        '
        'Podglad
        '
        Me.Podglad.AutoSize = True
        Me.Podglad.Location = New System.Drawing.Point(12, 199)
        Me.Podglad.Name = "Podglad"
        Me.Podglad.Size = New System.Drawing.Size(10, 13)
        Me.Podglad.TabIndex = 11
        Me.Podglad.Text = "."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DateSelDO)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.DateSelOD)
        Me.GroupBox3.Controls.Add(Me.EksportujTylkoSprzedawane)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 128)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(293, 68)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ograniczenie ze sprzedaży"
        '
        'EksportujTylkoSprzedawane
        '
        Me.EksportujTylkoSprzedawane.AutoSize = True
        Me.EksportujTylkoSprzedawane.Location = New System.Drawing.Point(16, 19)
        Me.EksportujTylkoSprzedawane.Name = "EksportujTylkoSprzedawane"
        Me.EksportujTylkoSprzedawane.Size = New System.Drawing.Size(249, 17)
        Me.EksportujTylkoSprzedawane.TabIndex = 0
        Me.EksportujTylkoSprzedawane.Text = "Eksport tylko z towarów sprzedanych w okresie"
        Me.EksportujTylkoSprzedawane.UseVisualStyleBackColor = True
        '
        'DateSelOD
        '
        Me.DateSelOD.Enabled = False
        Me.DateSelOD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateSelOD.Location = New System.Drawing.Point(41, 39)
        Me.DateSelOD.Name = "DateSelOD"
        Me.DateSelOD.Size = New System.Drawing.Size(85, 20)
        Me.DateSelOD.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Od"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(153, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Do"
        '
        'DateSelDO
        '
        Me.DateSelDO.Enabled = False
        Me.DateSelDO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateSelDO.Location = New System.Drawing.Point(180, 39)
        Me.DateSelDO.Name = "DateSelDO"
        Me.DateSelDO.Size = New System.Drawing.Size(85, 20)
        Me.DateSelDO.TabIndex = 4
        '
        'Stany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 280)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Podglad)
        Me.Controls.Add(Me.Eksportuj)
        Me.Controls.Add(Me.Anuluj)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Stany"
        Me.Text = "Eksport cen i stanów magazynowych "
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Cena1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cena2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cena3 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Magazyn6 As System.Windows.Forms.ComboBox
    Friend WithEvents magazyn5 As System.Windows.Forms.ComboBox
    Friend WithEvents Magazyn4 As System.Windows.Forms.ComboBox
    Friend WithEvents Magazyn3 As System.Windows.Forms.ComboBox
    Friend WithEvents Magazyn2 As System.Windows.Forms.ComboBox
    Friend WithEvents Magazyn1 As System.Windows.Forms.ComboBox
    Friend WithEvents Anuluj As System.Windows.Forms.Button
    Friend WithEvents Eksportuj As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Podglad As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DateSelDO As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateSelOD As System.Windows.Forms.DateTimePicker
    Friend WithEvents EksportujTylkoSprzedawane As System.Windows.Forms.CheckBox
End Class
