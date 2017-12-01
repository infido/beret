Public Class Stany
    Public lista As New List(Of Store)
    Private Sub Anuluj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Anuluj.Click
        Me.Close()
    End Sub

    Private Sub Eksportuj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eksportuj.Click
        SaveFileDialog1.CreatePrompt = True
        SaveFileDialog1.FileName = Now.Year.ToString & "-" & Now.Month.ToString & "-" & Now.Day.ToString & "-" & Now.Hour.ToString & "-" & Now.Minute.ToString & "-" & Now.Second.ToString
        SaveFileDialog1.Filter = "(*.csv) |*.csv|(*.txt) |*.txt |(*.*) |*.*"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim fsout As FileStream = File.Create(SaveFileDialog1.FileName)
            Dim sw As StreamWriter = New StreamWriter(fsout)
            Dim komenda As New FbCommand
            Dim fdr As FbDataReader
            Dim sql As String

            komenda.Connection = fcn
            Me.Focus()
            ToolLabel1.Text = "Eksport trwa od " & Now.ToString()

            sql = "select "
            sql += "gm_towary.skrot, "
            sql += "gm_towary.skrot2, "
            sql += "gm_towary.id, "
            sql += "gm_towary.nazwa, "
            sql += "gm_cennik.cena, "
            sql += "gm_cennik.cenab "

            sql += "from gm_towary "
            sql += "left join gm_cennik on gm_towary.id=gm_cennik.id_towaru "
            sql += "left join gm_ceny on gm_cennik.idceny=gm_ceny.id "

            If EksportujTylkoSprzedawane.Checked Then
                ' dodanie join z pozycji dokumentu sprzedaży aby dodać tylko te na których był ruch
                sql += "left join GM_FSPOZ on GM_FSPOZ.ID_TOWARU=GM_TOWARY.ID  "
                sql += "left join GM_FS on GM_FSPOZ.ID_GLOWKI=GM_FS.ID  "
            End If


            sql += "where "
            sql += "gm_ceny.nazwa='" & Cena1.Text & "' "

            If EksportujTylkoSprzedawane.Checked Then
                ' dodanie where na daty dokumentów sprzedaży z pozycji dokumentu sprzedaży aby dodać tylko te na których był ruch
                '
                sql += " and GM_FS.DATA_WYSTAWIENIA BETWEEN '" + Me.DateSelOD.Text + "' AND '" + Me.DateSelDO.Text + "' "
            End If

            sql += "group by "
            sql += "gm_towary.skrot,"
            sql += "gm_towary.skrot2,"
            sql += "gm_towary.id,"
            sql += " gm_towary.nazwa,"
            sql += " gm_cennik.cena,"
            sql += " gm_cennik.cenab"
            If My.Settings.ExportIndex2 = False Then
                sql += " order by gm_towary.skrot"
            Else
                sql += " order by gm_towary.skrot2, gm_towary.skrot"
            End If
            sql += ";"

            komenda.CommandText = sql
            'Try

            fdr = komenda.ExecuteReader
            Try
                Dim store As Store
                While fdr.Read()
                    store = New Store(fdr("skrot").ToString, fdr("skrot2").ToString, fdr("id"), fdr("nazwa").ToString, fdr("cena"), fdr("cenab"))
                    lista.Add(store)
                End While
            Catch
                Console.WriteLine("Nieudane dodanie pozycji do kolekcji")
            Finally
                fdr.Close()
            End Try

            For Each pozycja In lista
                Dim st As String
                If pozycja.skrot = "" Then Console.WriteLine("Brak skrótu dla " + pozycja.nazwa)
                st = pozycja.skrot & ";"
                If My.Settings.ExportIndex2 Then
                    st += pozycja.skrot2 & ";"
                End If
                If My.Settings.ExportNazwy Then
                    st += pozycja.nazwa & ";"
                End If
                If My.Settings.ExportNetto Then
                    st += pozycja.cena.ToString & ";"
                Else
                    st += pozycja.cenab.ToString & ";"
                End If
                st += getCeny2i3(pozycja.id, pozycja.cena, pozycja.cenab)
                st += getMagazynyOrazStan(pozycja.id)
                sw.WriteLine(st)
                Console.WriteLine(st)
                'ToolLabel1.Text = st
                Podglad.Text = st
                Me.Refresh()
            Next




            MsgBox("Eksport danych zakończony.")
            ToolLabel1.Text += " koniec: " & Now.ToString()
            'Catch ex As FbException
            '    MsgBox(ex.Message.ToString)
            'End Try


            sw.Flush()
            sw.Close()
            fsout.Close()

            'zapisanie ustawień okna
            My.Settings.Item("Cena1") = Cena1.Text
            My.Settings.Item("Cena2") = Cena2.Text
            My.Settings.Item("Cena3") = Cena3.Text
            My.Settings.Item("Mag1") = Magazyn1.Text
            My.Settings.Item("Mag2") = Magazyn2.Text
            My.Settings.Item("Mag3") = Magazyn3.Text
            My.Settings.Item("Mag4") = Magazyn4.Text
            My.Settings.Item("Mag5") = magazyn5.Text
            My.Settings.Item("Mag6") = Magazyn6.Text
            My.Settings.Save()
            Close()
        End If

    End Sub

    Private Sub Stany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim komenda As New FbCommand
        Dim fdr As FbDataReader

        'Uzupelninie pól wgzapamiętanego statusu
        Cena1.Text = My.Settings.Item("Cena1")
        Cena2.Text = My.Settings.Item("Cena2")
        Cena3.Text = My.Settings.Item("Cena3")
        Magazyn1.Text = My.Settings.Item("Mag1")
        Magazyn2.Text = My.Settings.Item("Mag2")
        Magazyn3.Text = My.Settings.Item("Mag3")
        Magazyn4.Text = My.Settings.Item("Mag4")
        magazyn5.Text = My.Settings.Item("Mag5")
        Magazyn6.Text = My.Settings.Item("Mag6")

        komenda.Connection = fcn
        komenda.CommandText = "SELECT NAZWA from GM_MAGAZYNY order by NAZWA;"

        Try
            fdr = komenda.ExecuteReader
            While fdr.Read()
                Magazyn1.Items.Add(fdr("NAZWA"))
                Magazyn2.Items.Add(fdr("NAZWA"))
                Magazyn3.Items.Add(fdr("NAZWA"))
                Magazyn4.Items.Add(fdr("NAZWA"))
                magazyn5.Items.Add(fdr("NAZWA"))
            End While
            fdr.Close()

            komenda.CommandText = "SELECT NAZWA from GM_CENY order by NAZWA;"
            fdr = komenda.ExecuteReader
            While fdr.Read()
                Cena1.Items.Add(fdr("NAZWA"))
                Cena2.Items.Add(fdr("NAZWA"))
                Cena3.Items.Add(fdr("NAZWA"))
            End While
            fdr.Close()

        Catch ex As FbException
            MsgBox(ex.Message.ToString)
        End Try

    End Sub
    Private Function getCena(ByVal typceny As String, ByVal indeks As String) As String
        Dim komenda As New FbCommand
        Dim sql As String
        Dim wynik As String = "0"
        komenda.Connection = fcn
        If My.Settings.ExportNetto Then
            sql = "select gm_cennik.cena as cenab "
        Else
            sql = "select gm_cennik.cenab "
        End If
        sql += "from gm_cennik "
        sql += "left join gm_towary on gm_towary.id=gm_cennik.id_towaru "
        sql += "left join gm_ceny on gm_ceny.id=gm_cennik.idceny "
        sql += "where gm_ceny.nazwa='" & typceny & "' "
        sql += "and gm_towary.skrot='" & indeks & "';"

        'Try
        komenda.CommandText = sql
        wynik = komenda.ExecuteScalar
        'Catch ex As FbException
        '    MsgBox("Błąd zapytania SQL: " & ex.Message)
        'End Try

        If wynik = "" Then wynik = "0"

        Return wynik

    End Function
    Private Function getCeny2i3(ByVal _idTowar As Integer, ByVal _cenaBazowaNetto As Double, ByVal _cenaBazowaBrutto As Double) As String
        'Funkcja zwraca ciag do wklejenia do pliku
        Dim komenda As New FbCommand
        Dim fdr As FbDataReader
        Dim sql As String
        Dim cenaA As String = "0"
        Dim cenaB As String = "0"

        komenda.Connection = fcn
        sql = "select "
        sql += "gm_ceny.nazwa as nazwa_ceny, "
        sql += "gm_cennik.cena, "
        sql += "gm_cennik.cenab "
        sql += "from gm_cennik "
        sql += "left join gm_ceny on gm_ceny.id=gm_cennik.idceny "
        sql += "where "
        sql += "gm_cennik.id_towaru=" & _idTowar & ";"

        komenda.CommandText = sql
        Try
            fdr = komenda.ExecuteReader
            While fdr.Read()
                If (Cena2.Text <> "" And fdr("nazwa_ceny") = Cena2.Text) Then
                    'przypisanie 2 ceny 
                    If My.Settings.ExportDodNetto Then
                        If My.Settings.ExportDodRoznica Then
                            cenaA = _cenaBazowaNetto - CDbl(fdr("cena"))
                        Else
                            cenaA = fdr("cena")
                        End If
                    Else
                        If My.Settings.ExportDodRoznica Then
                            cenaA = _cenaBazowaBrutto - CDbl(fdr("cenab"))
                        Else
                            cenaA = fdr("cenab")
                        End If
                    End If
                ElseIf (Cena3.Text <> "" And fdr("nazwa_ceny") = Cena3.Text) Then
                    'przypisanie 3 ceny
                    If My.Settings.ExportDodNetto Then
                        If My.Settings.ExportDodRoznica Then
                            cenaB = _cenaBazowaNetto - CDbl(fdr("cena"))
                        Else
                            cenaB = fdr("cena")
                        End If
                    Else
                        If My.Settings.ExportDodRoznica Then
                            cenaB = _cenaBazowaBrutto - CDbl(fdr("cenab"))
                        Else
                            cenaB = fdr("cenab")
                        End If
                    End If
                End If
            End While
            fdr.Close()
        Catch ex As FbException
            MsgBox("Błąd wykonannia kwerendy: " & ex.Message)
        End Try

        Return "" + cenaA + "; " + cenaB + ";"
    End Function
    Private Function getMagazynyOrazStan(ByVal _idTowar As Integer) As String
        Dim komenda As New FbCommand
        Dim fdr As FbDataReader
        Dim sql As String
        Dim wynik As String = ""
        Dim stan As Double = 0

        komenda.Connection = fcn
        sql = "select "
        sql += "gm_magazyny.nazwa as mag, "
        sql += "sum(gm_magazyn.ilosc) as il "
        sql += "from gm_magazyn "
        sql += "left join gm_magazyny on gm_magazyny.id=gm_magazyn.magnum "
        sql += "where "
        sql += "(gm_magazyn.id_towar=" & _idTowar & ") "
        sql += "group by gm_magazyny.nazwa; "

        komenda.CommandText = sql
        fdr = komenda.ExecuteReader
        Try
            While fdr.Read()
                If Magazyn1.Text = fdr("mag") Then
                    wynik += Magazyn1.Text
                    If My.Settings.ExportStanSzczegolowy Then
                        wynik += "(" + fdr("il").ToString + ")"
                    End If
                    wynik += ","
                    stan += fdr("il")
                ElseIf Magazyn2.Text = fdr("mag") Then
                    wynik += Magazyn2.Text
                    If My.Settings.ExportStanSzczegolowy Then
                        wynik += "(" + fdr("il").ToString + ")"
                    End If
                    wynik += ","
                    stan += fdr("il")
                ElseIf Magazyn3.Text = fdr("mag") Then
                    wynik += Magazyn3.Text
                    If My.Settings.ExportStanSzczegolowy Then
                        wynik += "(" + fdr("il").ToString + ")"
                    End If
                    wynik += ","
                    stan += fdr("il")
                ElseIf Magazyn4.Text = fdr("mag") Then
                    wynik += Magazyn4.Text
                    If My.Settings.ExportStanSzczegolowy Then
                        wynik += "(" + fdr("il").ToString + ")"
                    End If
                    wynik += ","
                    stan += fdr("il")
                ElseIf magazyn5.Text = fdr("mag") Then
                    wynik += magazyn5.Text
                    If My.Settings.ExportStanSzczegolowy Then
                        wynik += "(" + fdr("il").ToString + ")"
                    End If
                    wynik += ","
                    stan += fdr("il")
                ElseIf Magazyn6.Text = fdr("mag") Then
                    wynik += Magazyn6.Text
                    If My.Settings.ExportStanSzczegolowy Then
                        wynik += "(" + fdr("il").ToString + ")"
                    End If
                    stan += fdr("il")
                End If
            End While

        Catch ex As Exception
            Console.WriteLine("Błąd w GetMagazynOrazStan:" + ex.Message)
        Finally
            fdr.Close()
        End Try

        Return " " + wynik + "; " + stan.ToString
    End Function

    Private Sub EksportujTylkoSprzedawane_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EksportujTylkoSprzedawane.CheckedChanged
        If Me.EksportujTylkoSprzedawane.Checked Then
            Me.DateSelOD.Enabled = True
            Me.DateSelDO.Enabled = True
        Else
            Me.DateSelOD.Enabled = False
            Me.DateSelDO.Enabled = False
        End If

    End Sub
End Class