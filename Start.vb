Public Class Start

    Private fda As FbDataAdapter
    Private Sub Start_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        rozlacz()
    End Sub

    Private Sub Start_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            polaczFB()
        Catch ex As Exception
            MsgBox("Błąd: " & ex.Message)
        End Try
        Text = "Beret wer. " & My.Application.Info.Version.ToString
        TBKlient.Focus()
    End Sub

    Private Sub BZnajdz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BZnajdz.Click
        Me.TBData.Text = ""
        Me.TBNazwa.Text = ""
        Me.TBSkrot.Text = ""
        Me.TBNetto.Text = ""
        Me.TBBrutto.Text = ""

        Dim komenda As New FbCommand
        Try
            komenda.Connection = fcn
            komenda.CommandText = "SELECT DATA_WYSTAWIENIA from GM_FS where NUMER='" & Me.TBSymbol.Text & "' and TYP_DOK_MAGAZYNOWEGO='PA';"
            Me.TBData.Text = komenda.ExecuteScalar()
            komenda.CommandText = "SELECT NAZWA_PELNA_PLATNIKA from GM_FS where NUMER='" & Me.TBSymbol.Text & "' and TYP_DOK_MAGAZYNOWEGO='PA';"
            Me.TBNazwa.Text = komenda.ExecuteScalar()
            komenda.CommandText = "SELECT NAZWA_SKROCONA_PLATNIKA from GM_FS where NUMER='" & Me.TBSymbol.Text & "' and TYP_DOK_MAGAZYNOWEGO='PA';"
            Me.TBSkrot.Text = komenda.ExecuteScalar()
            komenda.CommandText = "SELECT WAL_WARTOSC_NETTO from GM_FS where NUMER='" & Me.TBSymbol.Text & "' and TYP_DOK_MAGAZYNOWEGO='PA';"
            Me.TBNetto.Text = komenda.ExecuteScalar()
            komenda.CommandText = "SELECT WAL_WARTOSC_BRUTTO from GM_FS where NUMER='" & Me.TBSymbol.Text & "' and TYP_DOK_MAGAZYNOWEGO='PA';"
            Me.TBBrutto.Text = komenda.ExecuteScalar()

        Catch ex As FbException
            Console.WriteLine(ex.Message)
        End Try

        If Me.TBBrutto.Text.Length > 0 Then
            Me.BZapisz.Visible = True
        Else
            Me.BZapisz.Visible = False
        End If
    End Sub

    Private Sub BZakoncz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BZakoncz.Click
        Me.Close()
    End Sub

    Private Sub BZapisz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BZapisz.Click
        If Me.TBNumer.Text.Length > 0 Then
            'ok lecimy z koksem
            Dim komenda As New FbCommand
            Dim fdr As FbDataReader
            Dim sss As String
            Try
                komenda.Connection = fcn
                komenda.CommandText = "SELECT SHORT_NAME from R3_CONTACTS where SHORT_NAME='" & Me.TBNumer.Text & "';"
                If komenda.ExecuteScalar <> "" Then
                    'ok jedziemy
                    komenda.CommandText = "SELECT ID,SHORT_NAME,STREET,FULL_NAME,COUNTRY,BUILDING_NUMBER,APARTMENT_NUMBER,ZIPCODE,PLACE from R3_CONTACTS where SHORT_NAME='" & Me.TBNumer.Text & "';"
                    fdr = komenda.ExecuteReader
                    fdr.Read()
                    If MsgBox("Znaleziono kartę " & fdr("SHORT_NAME") & " zarejestrowaną dla: " & fdr("FULL_NAME") & ".                 Czy przypisać do paragonu?", MsgBoxStyle.YesNo, "Potwierdzenie") = MsgBoxResult.Yes Then
                        sss = "UPDATE GM_FS SET "
                        sss += " ID_PLATNIKA=" & fdr("ID")
                        sss += ", ID_ODBIORCY=" & fdr("ID")
                        sss += ", NAZWA_SKROCONA_PLATNIKA='" & fdr("SHORT_NAME") & "'"
                        sss += ", NAZWA_PELNA_PLATNIKA='" & fdr("FULL_NAME") & "'"
                        sss += ", ULICA_PLATNIKA='" & fdr("STREET") & "'"
                        sss += ", NRDOMU_PLATNIKA='" & fdr("BUILDING_NUMBER") & "'"
                        sss += ", NRLOKALU_PLATNIKA='" & fdr("APARTMENT_NUMBER") & "'"
                        sss += ", MIEJSCOWOSC_PLATNIKA='" & fdr("PLACE") & "'"
                        sss += ", KOD_PLATNIKA='" & fdr("ZIPCODE") & "'"
                        sss += ", PANSTWO_PLATNIKA='" & fdr("COUNTRY") & "'"

                        sss += ", NAZWA_SKROCONA_ODBIORCY='" & fdr("SHORT_NAME") & "'"
                        sss += ", NAZWA_PELNA_ODBIORCY='" & fdr("FULL_NAME") & "'"
                        sss += ", ULICA_ODBIORCY='" & fdr("STREET") & "'"
                        sss += ", NRDOMU_ODBIORCY='" & fdr("BUILDING_NUMBER") & "'"
                        sss += ", NRLOKALU_ODBIORCY='" & fdr("APARTMENT_NUMBER") & "'"
                        sss += ", MIEJSCOWOSC_ODBIORCY='" & fdr("PLACE") & "'"
                        sss += ", KOD_ODBIORCY='" & fdr("ZIPCODE") & "'"
                        sss += ", PANSTWO_ODBIORCY='" & fdr("COUNTRY") & "'"


                        sss += " WHERE NUMER='" & Me.TBSymbol.Text & "';"

                        fdr.Close()

                        komenda.CommandText = sss
                        komenda.ExecuteNonQuery()
                        MsgBox("Wykonano zapis!", MsgBoxStyle.Information)
                        Me.BZnajdz.PerformClick()
                    Else
                        MsgBox("Opreacja przerwana przez użytkownika.", MsgBoxStyle.Information, "Przerwano")
                    End If
                Else
                    MsgBox("Brak karty w systemie!", MsgBoxStyle.Critical)
                End If
                '2008/12/KR/00010



            Catch ex As FbException
                Console.WriteLine(ex.Message)
            End Try
        Else
            MsgBox("Nie wprowadzono numeru karty. Zapisywanie przerwano!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub UstawieniaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UstawieniaToolStripMenuItem.Click
        Seting.Show()
    End Sub

    Private Sub KontrahenciToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KontrahenciToolStripMenuItem.Click
        KH.Show()
    End Sub

    Private Sub PracownicyKontrahentówToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PracownicyKontrahentówToolStripMenuItem.Click
        PRAC.Show()
    End Sub

    Private Sub StanówMagazynowychDoWwwToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StanówMagazynowychDoWwwToolStripMenuItem.Click
        Stany.Show()
    End Sub

    Private Sub BSzukaj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSzukaj.Click
        Dim komenda As New FbCommand
        Dim fdr As FbDataReader
        Dim dt As DataTable
        Dim sql As String
        'Dim tab1 As DataTable = New DataTable()

        Try
            komenda.Connection = fcn
            komenda.CommandText = "SELECT NUMER, DATA_WYSTAWIENIA, NAZWA_SKROCONA_PLATNIKA, NAZWA_PELNA_PLATNIKA,PLN_WARTOSC_NETTO,PLN_WARTOSC_BRUTTO,SYGNATURA from GM_FS"
            komenda.CommandText += " where DATA_WYSTAWIENIA >= '" + OdDaty.Text + "' "
            If TBKlient.Text.Length > 0 Then
                komenda.CommandText += " and NAZWA_SKROCONA_PLATNIKA like '%" + TBKlient.Text + "%'"
            End If
            komenda.CommandText += "UNION ALL SELECT NUMER, DATA_WYSTAWIENIA, NAZWA_SKROCONA_PLATNIKA, NAZWA_PELNA_PLATNIKA, (PLN_WARTOSC_NETTO_PO - PLN_WARTOSC_NETTO_PRZED) as PLN_WARTOSC_NETTO, (PLN_WARTOSC_BRUTTO_PO - PLN_WARTOSC_BRUTTO_PRZED) as PLN_WARTOSC_BRUTTO,SYGNATURA from GM_KS "
            komenda.CommandText += " where DATA_WYSTAWIENIA >= '" + OdDaty.Text + "' "
            If TBKlient.Text.Length > 0 Then
                komenda.CommandText += " and NAZWA_SKROCONA_PLATNIKA like '%" + TBKlient.Text + "%'"
            End If

            fda = New FbDataAdapter(komenda)
            dt = New DataTable
            fda.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Sort(DataGridView1.Columns("DATA_WYSTAWIENIA"), System.ComponentModel.ListSortDirection.Ascending)
            'DataGridView1.bi()
            Dim suma, wybrano, punkty, uzbierano As Double
            suma = 0
            wybrano = 0
            punkty = 0
            uzbierano = 0
            For i = 0 To DataGridView1.RowCount - 1 Step 1

                If DataGridView1.Rows(i).Cells("SYGNATURA").Value.ToString.Contains("WYM") Then
                    wybrano += CDbl(DataGridView1.Rows(i).Cells("SYGNATURA").Value.ToString.Substring(7))
                    punkty -= CDbl(DataGridView1.Rows(i).Cells("SYGNATURA").Value.ToString.Substring(7))
                Else
                    suma += DataGridView1.Rows(i).Cells("PLN_WARTOSC_BRUTTO").Value
                    If suma >= CDbl(Seting.tKwota1.Text.Replace(",", ".")) Then
                        punkty += DataGridView1.Rows(i).Cells("PLN_WARTOSC_BRUTTO").Value * CDbl(Seting.twsp1.Text)
                        uzbierano += DataGridView1.Rows(i).Cells("PLN_WARTOSC_BRUTTO").Value * CDbl(Seting.twsp1.Text)
                    ElseIf suma >= CDbl(Seting.Tkwota2.Text.Replace(",", ".")) And suma < CDbl(Seting.tkwota3.Text.Replace(",", ".")) Then
                        punkty += DataGridView1.Rows(i).Cells("PLN_WARTOSC_BRUTTO").Value * CDbl(Seting.twsp2.Text)
                        uzbierano += DataGridView1.Rows(i).Cells("PLN_WARTOSC_BRUTTO").Value * CDbl(Seting.twsp2.Text)
                    Else
                        punkty += DataGridView1.Rows(i).Cells("PLN_WARTOSC_BRUTTO").Value * CDbl(Seting.twsp3.Text)
                        uzbierano += DataGridView1.Rows(i).Cells("PLN_WARTOSC_BRUTTO").Value * CDbl(Seting.twsp3.Text)
                    End If

                End If
            Next
            LRazemZakupy.Text = " " + suma.ToString + " zł"
            LWymieniono.Text = " " + wybrano.ToString + " zł"
            Lpozostalo.Text = " " + punkty.ToString + " pkt"
            Lzebrano.Text = " " + uzbierano.ToString + " pkt"
        Catch ex As FbException
            MsgBox("Błąd: " + ex.Message)
        End Try


    End Sub

    Private Sub TBKlient_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBKlient.DoubleClick
        TBKlient.Text = "00173"
    End Sub

    Private Sub TBKlient_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBKlient.KeyDown
        If e.KeyCode = Keys.Enter Then
            BSzukaj.PerformClick()
        End If

    End Sub

    Private Sub StanówPunktowychDoWwwToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StanówPunktowychDoWwwToolStripMenuItem.Click
        SaveFileDialog1.CreatePrompt = True
        SaveFileDialog1.FileName = Now.Year.ToString & "-" & Now.Month.ToString & "-" & Now.Day.ToString & "-" & Now.Hour.ToString & "-" & Now.Minute.ToString & "-" & Now.Second.ToString
        SaveFileDialog1.Filter = "(*.csv) |*.csv|(*.txt) |*.txt |(*.*) |*.*"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim fsout As FileStream = File.Create(SaveFileDialog1.FileName)
            Dim sw As StreamWriter = New StreamWriter(fsout)
            Dim komenda As New FbCommand
            Dim fdr As FbDataReader
            Dim dt As DataTable
            Dim sql As String
            'Dim tab1 As DataTable = New DataTable()

            Try
                komenda.Connection = fcn
                komenda.CommandText = "SELECT R3_CONTACTS.ID, R3_CONTACT_WEB_ADDRESSES.ADDRESS FROM R3_CONTACTS "
                komenda.CommandText += " join R3_CONTACT_WEB_ADDRESSES ON R3_CONTACTS.ID=R3_CONTACT_WEB_ADDRESSES.CONTACT_ID "

                fdr = komenda.ExecuteReader
                Try
                    While fdr.Read()
                        sw.WriteLine(fdr("ADDRESS").ToString + ";0.00")
                    End While
                Catch
                    Console.WriteLine("Nieudane dodanie pozycji do kolekcji--")
                Finally
                    fdr.Close()
                    sw.Flush()
                    fsout.Close()
                End Try


            Catch ex As FbException
                MsgBox("Błąd: " + ex.Message)
            End Try
        End If
    End Sub
End Class
