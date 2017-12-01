<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Seting))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TBSerwer = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TBpath = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TBUser = New System.Windows.Forms.TextBox
        Me.TBPass = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TBPort = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ExportIndeksu2 = New System.Windows.Forms.CheckBox
        Me.ExportStanuSzcegolowego = New System.Windows.Forms.CheckBox
        Me.ExportNettoCenDodatkowych = New System.Windows.Forms.CheckBox
        Me.ExportCenDodJakoRoznicaDoBazowej = New System.Windows.Forms.CheckBox
        Me.ExportNazwy = New System.Windows.Forms.CheckBox
        Me.ExportNetto = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.twsp3 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.tkwota3 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.twsp2 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Tkwota2 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.twsp1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.tKwota1 = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 516)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(292, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(204, 490)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "&Zamknij"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Serwer"
        '
        'TBSerwer
        '
        Me.TBSerwer.Location = New System.Drawing.Point(49, 19)
        Me.TBSerwer.Name = "TBSerwer"
        Me.TBSerwer.Size = New System.Drawing.Size(132, 20)
        Me.TBSerwer.TabIndex = 3
        Me.TBSerwer.Text = "localhost"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ścieżka"
        '
        'TBpath
        '
        Me.TBpath.Location = New System.Drawing.Point(49, 45)
        Me.TBpath.Name = "TBpath"
        Me.TBpath.Size = New System.Drawing.Size(211, 20)
        Me.TBpath.TabIndex = 5
        Me.TBpath.Text = "C:\dane\ide\F00001.gdb"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Użytkownik"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Hasło"
        '
        'TBUser
        '
        Me.TBUser.Location = New System.Drawing.Point(69, 71)
        Me.TBUser.Name = "TBUser"
        Me.TBUser.Size = New System.Drawing.Size(77, 20)
        Me.TBUser.TabIndex = 8
        Me.TBUser.Text = "SYSDBA"
        Me.TBUser.UseSystemPasswordChar = True
        '
        'TBPass
        '
        Me.TBPass.Location = New System.Drawing.Point(69, 97)
        Me.TBPass.Name = "TBPass"
        Me.TBPass.Size = New System.Drawing.Size(77, 20)
        Me.TBPass.TabIndex = 9
        Me.TBPass.Text = "masterkey"
        Me.TBPass.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Port"
        '
        'TBPort
        '
        Me.TBPort.Location = New System.Drawing.Point(69, 126)
        Me.TBPort.Name = "TBPort"
        Me.TBPort.Size = New System.Drawing.Size(35, 20)
        Me.TBPort.TabIndex = 11
        Me.TBPort.Text = "3050"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TBSerwer)
        Me.GroupBox1.Controls.Add(Me.TBPort)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TBPass)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TBpath)
        Me.GroupBox1.Controls.Add(Me.TBUser)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(267, 155)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ustawienia połączenia"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ExportIndeksu2)
        Me.GroupBox2.Controls.Add(Me.ExportStanuSzcegolowego)
        Me.GroupBox2.Controls.Add(Me.ExportNettoCenDodatkowych)
        Me.GroupBox2.Controls.Add(Me.ExportCenDodJakoRoznicaDoBazowej)
        Me.GroupBox2.Controls.Add(Me.ExportNazwy)
        Me.GroupBox2.Controls.Add(Me.ExportNetto)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 163)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(266, 186)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ustawienia eksportu danych"
        '
        'ExportIndeksu2
        '
        Me.ExportIndeksu2.AutoSize = True
        Me.ExportIndeksu2.Location = New System.Drawing.Point(6, 134)
        Me.ExportIndeksu2.Name = "ExportIndeksu2"
        Me.ExportIndeksu2.Size = New System.Drawing.Size(182, 17)
        Me.ExportIndeksu2.TabIndex = 5
        Me.ExportIndeksu2.Text = "Eksport Indeksu 2 z sortowaniem"
        Me.ExportIndeksu2.UseVisualStyleBackColor = True
        '
        'ExportStanuSzcegolowego
        '
        Me.ExportStanuSzcegolowego.AutoSize = True
        Me.ExportStanuSzcegolowego.Location = New System.Drawing.Point(6, 111)
        Me.ExportStanuSzcegolowego.Name = "ExportStanuSzcegolowego"
        Me.ExportStanuSzcegolowego.Size = New System.Drawing.Size(227, 17)
        Me.ExportStanuSzcegolowego.TabIndex = 4
        Me.ExportStanuSzcegolowego.Text = "Eksport ilość stanu dla każdego magazynu"
        Me.ExportStanuSzcegolowego.UseVisualStyleBackColor = True
        '
        'ExportNettoCenDodatkowych
        '
        Me.ExportNettoCenDodatkowych.AutoSize = True
        Me.ExportNettoCenDodatkowych.Location = New System.Drawing.Point(6, 42)
        Me.ExportNettoCenDodatkowych.Name = "ExportNettoCenDodatkowych"
        Me.ExportNettoCenDodatkowych.Size = New System.Drawing.Size(227, 17)
        Me.ExportNettoCenDodatkowych.TabIndex = 3
        Me.ExportNettoCenDodatkowych.Text = "Eksport cen dodatkowych w cenach netto"
        Me.ExportNettoCenDodatkowych.UseVisualStyleBackColor = True
        '
        'ExportCenDodJakoRoznicaDoBazowej
        '
        Me.ExportCenDodJakoRoznicaDoBazowej.AutoSize = True
        Me.ExportCenDodJakoRoznicaDoBazowej.Location = New System.Drawing.Point(6, 65)
        Me.ExportCenDodJakoRoznicaDoBazowej.Name = "ExportCenDodJakoRoznicaDoBazowej"
        Me.ExportCenDodJakoRoznicaDoBazowej.Size = New System.Drawing.Size(246, 17)
        Me.ExportCenDodJakoRoznicaDoBazowej.TabIndex = 2
        Me.ExportCenDodJakoRoznicaDoBazowej.Text = "Ceny dodatkowe jako różnica do podstawowej"
        Me.ExportCenDodJakoRoznicaDoBazowej.UseVisualStyleBackColor = True
        '
        'ExportNazwy
        '
        Me.ExportNazwy.AutoSize = True
        Me.ExportNazwy.Location = New System.Drawing.Point(6, 88)
        Me.ExportNazwy.Name = "ExportNazwy"
        Me.ExportNazwy.Size = New System.Drawing.Size(202, 17)
        Me.ExportNazwy.TabIndex = 1
        Me.ExportNazwy.Text = "Eksport nazwy towarów w cennikach"
        Me.ExportNazwy.UseVisualStyleBackColor = True
        '
        'ExportNetto
        '
        Me.ExportNetto.AutoSize = True
        Me.ExportNetto.Location = New System.Drawing.Point(6, 19)
        Me.ExportNetto.Name = "ExportNetto"
        Me.ExportNetto.Size = New System.Drawing.Size(230, 17)
        Me.ExportNetto.TabIndex = 0
        Me.ExportNetto.Text = "Eksport ceny podstawowej w cenach netto"
        Me.ExportNetto.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.twsp3)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.tkwota3)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.twsp2)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Tkwota2)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.twsp1)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.tKwota1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 356)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(267, 128)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Program Lojalnościowy"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(171, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "wsp."
        '
        'twsp3
        '
        Me.twsp3.Location = New System.Drawing.Point(206, 80)
        Me.twsp3.Name = "twsp3"
        Me.twsp3.Size = New System.Drawing.Size(47, 20)
        Me.twsp3.TabIndex = 25
        Me.twsp3.Text = "0,08"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Próg 3 powyżej "
        '
        'tkwota3
        '
        Me.tkwota3.Location = New System.Drawing.Point(102, 80)
        Me.tkwota3.Name = "tkwota3"
        Me.tkwota3.Size = New System.Drawing.Size(63, 20)
        Me.tkwota3.TabIndex = 23
        Me.tkwota3.Text = "5000"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(171, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "wsp."
        '
        'twsp2
        '
        Me.twsp2.Location = New System.Drawing.Point(206, 54)
        Me.twsp2.Name = "twsp2"
        Me.twsp2.Size = New System.Drawing.Size(47, 20)
        Me.twsp2.TabIndex = 21
        Me.twsp2.Text = "0,05"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Próg 2 od kwoty:"
        '
        'Tkwota2
        '
        Me.Tkwota2.Location = New System.Drawing.Point(102, 54)
        Me.Tkwota2.Name = "Tkwota2"
        Me.Tkwota2.Size = New System.Drawing.Size(63, 20)
        Me.Tkwota2.TabIndex = 19
        Me.Tkwota2.Text = "3000"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(171, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "wsp."
        '
        'twsp1
        '
        Me.twsp1.Location = New System.Drawing.Point(206, 28)
        Me.twsp1.Name = "twsp1"
        Me.twsp1.Size = New System.Drawing.Size(47, 20)
        Me.twsp1.TabIndex = 17
        Me.twsp1.Text = "0,03"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Próg 1 od kwoty:"
        '
        'tKwota1
        '
        Me.tKwota1.Location = New System.Drawing.Point(102, 28)
        Me.tKwota1.Name = "tKwota1"
        Me.tKwota1.Size = New System.Drawing.Size(63, 20)
        Me.tKwota1.TabIndex = 15
        Me.tKwota1.Text = "0"
        '
        'Seting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 538)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Seting"
        Me.Text = "Ustawienia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBSerwer As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBpath As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBUser As System.Windows.Forms.TextBox
    Friend WithEvents TBPass As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TBPort As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ExportNazwy As System.Windows.Forms.CheckBox
    Friend WithEvents ExportNetto As System.Windows.Forms.CheckBox
    Friend WithEvents ExportNettoCenDodatkowych As System.Windows.Forms.CheckBox
    Friend WithEvents ExportCenDodJakoRoznicaDoBazowej As System.Windows.Forms.CheckBox
    Friend WithEvents ExportStanuSzcegolowego As System.Windows.Forms.CheckBox
    Friend WithEvents ExportIndeksu2 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents twsp3 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tkwota3 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents twsp2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Tkwota2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents twsp1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tKwota1 As System.Windows.Forms.TextBox
End Class
