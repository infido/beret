Module ogolny
    Public fcs As New FbConnectionStringBuilder
    Public fcn As New FbConnection
    Public nowyWiersz As DataRow
    Public curUserID As String = ""
    Public curUserLogin As String = ""
    Public curUserName As String = ""
    Public curOddID As String = ""
    Public wersjaPrg As String = "0.66"
    Public dataWazLicDEMO As New Date(2014, 12, 31)
    Public typypojazdow(13) As String
    Public Function polaczFB() As Boolean
        Dim fileName As String = "prgloj.dat"
        If File.Exists(fileName) Then
            Dim ser As New System.Xml.Serialization.XmlSerializer(GetType(Ustawienia))
            Using fs As New IO.StreamReader(fileName)
                Dim ust As Ustawienia = CType(ser.Deserialize(fs), Ustawienia)
                fcs.DataSource() = ust.ser
                fcs.Database() = ust.baz
            End Using
        Else
            fcs.DataSource() = My.Settings.Server
            fcs.Database() = My.Settings.Baza
        End If

        'Public Function polaczFB() As Boolean

        ' próba połączenia do linux
        'fcs.DataSource() = "89.174.232.164"
        'fcs.Database() = "89.174.23.164://usr//rakssql//AGENTSQL.FDB"

        'do pracy lokalnej
        'fcs.DataSource() = Seting.TBSerwer.Text
        'fcs.Database() = Seting.TBpath.Text


        'do pracy z serwerem testowym
        'fcs.DataSource() = "10.0.0.100"
        'fcs.Database() = "D:\Raks\data\F00001.gdb"

        'fcs.UserID() = Seting.TBUser.Text
        'fcs.Password() = Seting.TBPass.Text
        fcs.UserID() = My.Settings.User
        fcs.Password() = My.Settings.Pass

        fcs.Dialect() = 3
        fcs.Charset() = "WIN1250"
        fcs.Port = My.Settings.Port

        fcn = New FbConnection(fcs.ToString)
        Try
            fcn.Open()
            If fcn.State > 0 Then
                'MsgBox("Prawidłowo połączono z serwerem", MsgBoxStyle.Information, "Beret")
            Else
                MsgBox("Brak połączenia z serwerem, aplikacja zostanie zamknięta", MsgBoxStyle.Critical, "Beret")
                Application.Exit()
            End If
            'MsgBox("Serwer version: " & fcn.ServerVersion)
            Return True
        Catch ex As FbException
            Console.WriteLine(ex.Message)
            MsgBox("Błąd połaczenia z bazą: " & ex.Message)
            Seting.ShowDialog()
            Return False
        End Try
    End Function
    Public Sub rozlacz()
        Try
            fcn.Close()
        Catch ex As FbException
            Console.WriteLine(ex.Message)
        End Try
    End Sub
End Module
