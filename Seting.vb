Public Class Seting
    Dim fileName As String = "prgloj.dat"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        My.Settings.User = TBUser.Text
        My.Settings.Pass = TBPass.Text
        My.Settings.Port = TBPort.Text
        My.Settings.ExportNetto = ExportNetto.Checked
        My.Settings.ExportNazwy = ExportNazwy.Checked
        My.Settings.ExportDodNetto = ExportNettoCenDodatkowych.Checked
        My.Settings.ExportDodRoznica = ExportCenDodJakoRoznicaDoBazowej.Checked
        My.Settings.ExportStanSzczegolowy = ExportStanuSzcegolowego.Checked
        My.Settings.ExportIndex2 = ExportIndeksu2.Checked
        My.Settings.Save()

        Dim ust As Ustawienia
        ust = New Ustawienia(tKwota1.Text, twsp1.Text, Tkwota2.Text, twsp2.Text, tkwota3.Text, twsp3.Text, TBpath.Text, TBSerwer.Text)
        IO.File.Delete(fileName)
        Dim ser As New System.Xml.Serialization.XmlSerializer(ust.GetType)
        Using fs As New IO.StreamWriter(fileName)
            ser.Serialize(fs, ust)
        End Using
        My.Settings.Server = TBSerwer.Text
        My.Settings.Baza = TBpath.Text

        MsgBox("Program zostanie zamknięty i należy go ponownie uruchomić...")
        'Me.Visible = False
        Application.Exit()
    End Sub

    Private Sub Seting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If File.Exists(fileName) Then
            Dim ser As New System.Xml.Serialization.XmlSerializer(GetType(Ustawienia))
            Using fs As New IO.StreamReader(fileName)
                Dim ust As Ustawienia = CType(ser.Deserialize(fs), Ustawienia)
                tKwota1.Text = ust.wartosc1
                Tkwota2.Text = ust.wartosc2
                tkwota3.Text = ust.wartosc3
                twsp1.Text = ust.wsp1
                twsp2.Text = ust.wsp2
                twsp3.Text = ust.wsp3
                TBSerwer.Text = ust.ser
                TBpath.Text = ust.baz
            End Using
        Else
            TBSerwer.Text = My.Settings.Server
            TBpath.Text = My.Settings.Baza
        End If
        TBUser.Text = My.Settings.User
        TBPass.Text = My.Settings.Pass
        TBPort.Text = My.Settings.Port
        ExportNazwy.Checked = My.Settings.ExportNazwy
        ExportNetto.Checked = My.Settings.ExportNetto
        ExportNettoCenDodatkowych.Checked = My.Settings.ExportDodNetto
        ExportCenDodJakoRoznicaDoBazowej.Checked = My.Settings.ExportDodRoznica
        ExportStanuSzcegolowego.Checked = My.Settings.ExportStanSzczegolowy
        ExportIndeksu2.Checked = My.Settings.ExportIndex2
    End Sub
End Class