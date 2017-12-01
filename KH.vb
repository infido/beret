Public Class KH
    Private fda1, fda2, fda3, fda4 As FbDataAdapter
    Private fds1, fds2, fds3, fds4 As DataSet
    Private fDataView1, fDataView2, fDataView3, fDataView4 As DataView
    Private kolzrd, kolcel As Integer
    Private schowek As String
    Private Sub BClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BClose.Click
        Me.Close()
    End Sub

    Private Sub KH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strQuery As String
        strQuery = "select"
        strQuery += " r3_contacts.full_name as nazwa_firmy,"
        strQuery += " r3_contacts.short_name as skrot,"
        strQuery += " r3_contacts.place as miasto,"
        strQuery += " r3_contacts.poczta as miasto_poczta,"
        strQuery += " r3_contacts.zipcode as kod_pocztowy,"
        strQuery += " '' as skrytka_pocztowa,"
        strQuery += " r3_contacts.street as ulica,"
        strQuery += " r3_contacts.building_number as nr_domu,"
        strQuery += " r3_contacts.apartment_number as nr_lok,"
        strQuery += " '' as koresp_miasto,"
        strQuery += " '' as koresp_miasto_poczta,"
        strQuery += " '' as koresp_kod_pocztowy,"
        strQuery += " '' as koresp_skrytka_pocztowa,"
        strQuery += " '' as koresp_ulica ,"
        strQuery += " '' as koresp_nr_domu,"
        strQuery += " '' as telefon_stac,"
        strQuery += " '' as telefon_kom,"
        strQuery += " '' as fax,"
        strQuery += " '' as email,"
        strQuery += " '' as http_adres,"
        strQuery += " r3_contacts.province as wojewodztwo,"
        strQuery += " r3_contacts.country as kraj,"
        strQuery += " r3_contacts.taxid as nip,"
        strQuery += " r3_contacts_firms.regon as regon,"
        strQuery += " 'Nieznana' as wiarygodnosc,"
        strQuery += " case r3_CONTACTS.purchaser when 1 then 'Klient' else 'Dostawca' end as funkcja,"
        strQuery += " 'Inna' as branza,"
        strQuery += " 'PLN' as domyslna_waluta,"
        strQuery += " 'DETAL' as typ_ceny,"
        strQuery += " gm_sposoby_zap.termin as okres_platnosci,"
        strQuery += " GM_KONTRAHENCI.MAXKRED as maks_kredyt,"
        strQuery += " gm_kontrahenci.maxdlug as ostrzezenie_kredyt,"
        strQuery += " 'nie' as dziala_w_UE,"
        strQuery += " case r3_contacts.archiwalny when 0 then 'tak' else 'nie' end as aktywna,"
        strQuery += " r3_descriptions.content as uwagi,"
        strQuery += " r3_contacts.id as id,"
        strQuery += " case gm_sposoby_zap.typ when 1 then 'przelew' else 'gotówka' end as sposob_zaplaty,"
        strQuery += " case r3_contacts.contact_type when 0 then 'Yes' else 'No' end as firma,"
        strQuery += " r3_contact_groups.name as Atrybuty "
        strQuery += " from r3_contacts "
        strQuery += " left join r3_contacts_firms on r3_contacts_firms.contact_id=r3_contacts.id"
        strQuery += " left join r3_descriptions on r3_descriptions.id=r3_contacts.description_id"
        strQuery += " left join gm_kontrahenci on gm_kontrahenci.idk=r3_contacts.id"
        strQuery += " left join gm_sposoby_zap on gm_kontrahenci.SPOSOB_ZAP=gm_sposoby_zap.id"
        strQuery += " left join r3_contact_groups on r3_contact_groups.id=r3_contacts.group_id;"
        Try
            fda1 = New FbDataAdapter(strQuery, fcn)
            fds1 = New DataSet
            fDataView1 = New DataView
            fds1.Tables.Add("TAB")
            fda1.Fill(fds1.Tables("TAB"))
            fDataView1.Table = fds1.Tables("TAB")
            DataGridView1.DataSource = fDataView1
            'DataGridView1.Columns.Item(0).Visible = False
            'DataGridView1.Columns.Item(1).Visible = False
            'DataGridView1.Columns.Item(8).Visible = False
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        Dim strQuery As String
        strQuery = "select name as typ_adresu, STREET as ulica, BUILDING_NUMBER as nr_domu, APARTMENT_NUMBER as nr_lok, place as miasto, poczta, zipcode as kod_pocztowy,  powiat, country as kraj "
        strQuery += "from r3_contact_addresses left join r3_ext_types on r3_ext_types.id=r3_contact_addresses.type_id "
        strQuery += "where contact_id=" & Me.DataGridView1.CurrentRow.Cells("ID").Value & ";"
        Try
            fda2 = New FbDataAdapter(strQuery, fcn)
            fds2 = New DataSet
            fDataView2 = New DataView
            fds2.Tables.Add("TAB")
            fda2.Fill(fds2.Tables("TAB"))
            fDataView2.Table = fds2.Tables("TAB")
            DataGridView2.DataSource = fDataView2
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        strQuery = "select name as typ_adresu, number as numer "
        strQuery += "from r3_contact_phones left join r3_ext_types on r3_ext_types.id=r3_contact_phones.type_id "
        strQuery += "where contact_id=" & Me.DataGridView1.CurrentRow.Cells("ID").Value & ";"

        Try
            fda3 = New FbDataAdapter(strQuery, fcn)
            fds3 = New DataSet
            fDataView3 = New DataView
            fds3.Tables.Add("TAB")
            fda3.Fill(fds3.Tables("TAB"))
            fDataView3.Table = fds3.Tables("TAB")
            DataGridView3.DataSource = fDataView3
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        strQuery = "select name as typ_adresu, address as kontakt, DEFAULT_ADDRESS as domyslny "
        strQuery += "from R3_CONTACT_WEB_ADDRESSES left join r3_ext_types on r3_ext_types.id=R3_CONTACT_WEB_ADDRESSES.type_id "
        strQuery += "where contact_id=" & Me.DataGridView1.CurrentRow.Cells("ID").Value & ";"
        Try
            fda4 = New FbDataAdapter(strQuery, fcn)
            fds4 = New DataSet
            fDataView4 = New DataView
            fds4.Tables.Add("TAB")
            fda4.Fill(fds4.Tables("TAB"))
            fDataView4.Table = fds4.Tables("TAB")
            DataGridView4.DataSource = fDataView4
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub Menu1Usun_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Menu1Usun.Click
        Dim row As DataRow
        For Each row In Me.fds1.Tables("TAB").Rows
            If Me.DataGridView1.CurrentRow.Cells("ID").Value.ToString <> "" Then
                If row.Item("ID") = Me.DataGridView1.CurrentRow.Cells("ID").Value Then
                    row.Delete()
                    Me.fds1.Tables("TAB").AcceptChanges()
                    Exit For
                End If
            Else
                If row.Item("ID").ToString = "" Then
                    row.Delete()
                    Me.fds1.Tables("TAB").AcceptChanges()
                    Exit For
                End If

            End If
        Next
        Me.DataGridView1.Refresh()

    End Sub

    Private Sub KolumnaŹródłowaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KolumnaŹródłowaToolStripMenuItem.Click
        Try
            kolzrd = Me.DataGridView1.CurrentCell.ColumnIndex
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub

    Private Sub WklejDoKolumnyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WklejDoKolumnyToolStripMenuItem.Click
        kolcel = Me.DataGridView1.CurrentCell.ColumnIndex
        Dim sep As String = InputBox("Wprowadź seperator sklejenia komórek. Jeżeli jest wartość w komórce źródłowej.", "Seperator sklejenia")
        Dim row As DataRow
        For Each row In Me.fds1.Tables("TAB").Rows
            If row.Item(kolzrd).ToString <> "" Then
                row.Item(kolcel) = row.Item(kolcel) & sep & row.Item(kolzrd)
            End If
        Next
        Me.fds1.Tables("TAB").AcceptChanges()
        Me.DataGridView1.Refresh()

    End Sub

    Private Sub UsuńkolumnęToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuńkolumnęToolStripMenuItem.Click
        Me.fds1.Tables("TAB").Columns.RemoveAt(Me.DataGridView1.CurrentCell.ColumnIndex)
        Me.fds1.Tables("TAB").AcceptChanges()
        Me.DataGridView1.Refresh()
    End Sub

    Private Sub JakoAdresDokorespondecjiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JakoAdresDokorespondecjiToolStripMenuItem.Click
        DataGridView1.CurrentRow.Cells("koresp_ulica").Value = DataGridView2.CurrentRow.Cells("ulica").Value
        DataGridView1.CurrentRow.Cells("koresp_miasto").Value = DataGridView2.CurrentRow.Cells("miasto").Value
        DataGridView1.CurrentRow.Cells("koresp_miasto_poczta").Value = DataGridView2.CurrentRow.Cells("poczta").Value
        DataGridView1.CurrentRow.Cells("koresp_kod_pocztowy").Value = DataGridView2.CurrentRow.Cells("kod_pocztowy").Value
        If Me.DataGridView2.CurrentRow.Cells("nr_lok").Value.ToString.Trim.Length > 0 Then
            DataGridView1.CurrentRow.Cells("koresp_nr_domu").Value = DataGridView2.CurrentRow.Cells("nr_domu").Value & "/" & DataGridView2.CurrentRow.Cells("nr_lok").Value
        Else
            DataGridView1.CurrentRow.Cells("koresp_nr_domu").Value = DataGridView2.CurrentRow.Cells("nr_domu").Value
        End If
    End Sub

    Private Sub TelstacjonarnyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TelstacjonarnyToolStripMenuItem.Click
        DataGridView1.CurrentRow.Cells("telefon_stac").Value = DataGridView3.CurrentRow.Cells("NUMER").Value
    End Sub

    Private Sub TelkomórkowyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TelkomórkowyToolStripMenuItem.Click
        DataGridView1.CurrentRow.Cells("telefon_kom").Value = DataGridView3.CurrentRow.Cells("NUMER").Value
    End Sub

    Private Sub FaxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FaxToolStripMenuItem.Click
        DataGridView1.CurrentRow.Cells("fax").Value = DataGridView3.CurrentRow.Cells("NUMER").Value
    End Sub

    Private Sub DodajDoPolaUwagiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DodajDoPolaUwagiToolStripMenuItem.Click
        DataGridView1.CurrentRow.Cells("uwagi").Value = DataGridView1.CurrentRow.Cells("uwagi").Value & DataGridView3.CurrentRow.Cells("typ_adresu").Value & " " & DataGridView3.CurrentRow.Cells("NUMER").Value
    End Sub

    Private Sub AdresemailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdresemailToolStripMenuItem.Click
        DataGridView1.CurrentRow.Cells("email").Value = DataGridView4.CurrentRow.Cells("kontakt").Value
    End Sub

    Private Sub AdreshttpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdreshttpToolStripMenuItem.Click
        DataGridView1.CurrentRow.Cells("http_adres").Value = DataGridView4.CurrentRow.Cells("kontakt").Value
    End Sub

    Private Sub DodajDoPolaUwagiToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DodajDoPolaUwagiToolStripMenuItem1.Click
        DataGridView1.CurrentRow.Cells("uwagi").Value = DataGridView1.CurrentRow.Cells("uwagi").Value & DataGridView4.CurrentRow.Cells("typ_adresu").Value & " " & DataGridView4.CurrentRow.Cells("kontakt").Value
    End Sub

    Private Sub DodajDoPolaUwagiToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DodajDoPolaUwagiToolStripMenuItem2.Click
        Dim s As String = ""
        s += DataGridView2.CurrentRow.Cells("typ_adresu").Value & ": "
        s += DataGridView2.CurrentRow.Cells("ulica").Value & " "
        If Me.DataGridView2.CurrentRow.Cells("nr_lok").Value.ToString.Trim.Length > 0 Then
            DataGridView1.CurrentRow.Cells("koresp_nr_domu").Value = DataGridView2.CurrentRow.Cells("nr_domu").Value & "/" & DataGridView2.CurrentRow.Cells("nr_lok").Value
        Else
            DataGridView1.CurrentRow.Cells("koresp_nr_domu").Value = DataGridView2.CurrentRow.Cells("nr_domu").Value
        End If
        s += " Miasto: " & DataGridView2.CurrentRow.Cells("miasto").Value
        s += " Poczta: " & DataGridView2.CurrentRow.Cells("kod_pocztowy").Value & " " & DataGridView2.CurrentRow.Cells("poczta").Value
        DataGridView1.CurrentRow.Cells("uwagi").Value = DataGridView1.CurrentRow.Cells("uwagi").Value & s
    End Sub

    Private Sub BExportXLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BExportXLS.Click

        Dim ile_rekordow As Integer = fDataView1.Table.Rows.Count
        Dim ile_kolumn As Integer = fDataView1.Table.Columns.Count
        Dim fpath As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\Firmy.xls"



        Dim fsout As FileStream = File.Create(fpath)
        Dim sw As StreamWriter = New StreamWriter(fsout)
        sw.WriteLine("<meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" />")
        sw.WriteLine("<table border=""1"">")
        sw.WriteLine("  <tr>")

        'zapis nagłówka tabeli
        For i = 0 To ile_kolumn - 1
            sw.WriteLine("    <td>" & fDataView1.Table.Columns(i).ColumnName.ToString & "</td>")
        Next
        sw.WriteLine("  </tr>")

        'zapis wierszy tabeli
        For i = 0 To ile_rekordow - 1
            sw.WriteLine("  <tr>")
            For j = 0 To ile_kolumn - 1
                sw.WriteLine("    <td>" & fDataView1.Table.Rows(i).Item(j).ToString & "</td>")
            Next
            sw.WriteLine("  </tr>")
        Next

        sw.WriteLine("</table>")
        sw.Flush()
        sw.Close()
        fsout.Close()

        System.Diagnostics.Process.Start(fpath)

    End Sub

    Private Sub Buzup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buzup.Click
        Dim s As String = ""
        For i = 0 To Me.DataGridView1.RowCount - 1
            'For i = 0 To 10
            Me.DataGridView1.CurrentCell() = Me.DataGridView1.Rows(i).Cells(0)
            Dim strQuery As String
            strQuery = "select name as typ_adresu, STREET as ulica, BUILDING_NUMBER as nr_domu, APARTMENT_NUMBER as nr_lok, place as miasto, poczta, zipcode as kod_pocztowy,  powiat, country as kraj "
            strQuery += "from r3_contact_addresses left join r3_ext_types on r3_ext_types.id=r3_contact_addresses.type_id "
            strQuery += "where contact_id=" & Me.DataGridView1.CurrentRow.Cells("ID").Value & ";"
            Try
                fda2 = New FbDataAdapter(strQuery, fcn)
                fds2 = New DataSet
                fDataView2 = New DataView
                fds2.Tables.Add("TAB")
                fda2.Fill(fds2.Tables("TAB"))
                fDataView2.Table = fds2.Tables("TAB")
                DataGridView2.DataSource = fDataView2
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

            If Me.DataGridView2.Rows.Count = 1 Then
                'jest tylko jeden
            ElseIf Me.DataGridView2.Rows.Count = 0 Then
                'nie ma wogóle
            Else
                'jest kilka
            End If
            ' a teraz wszystko wpisujemy w uwagi


            strQuery = "select name as typ_adresu, number as numer "
            strQuery += "from r3_contact_phones left join r3_ext_types on r3_ext_types.id=r3_contact_phones.type_id "
            strQuery += "where contact_id=" & Me.DataGridView1.CurrentRow.Cells("ID").Value & ";"

            Try
                fda3 = New FbDataAdapter(strQuery, fcn)
                fds3 = New DataSet
                fDataView3 = New DataView
                fds3.Tables.Add("TAB")
                fda3.Fill(fds3.Tables("TAB"))
                fDataView3.Table = fds3.Tables("TAB")
                DataGridView3.DataSource = fDataView3
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

            Try
                If DataGridView3.RowCount > 0 Then
                    For m = 0 To DataGridView3.RowCount - 2
                        If DataGridView3.Rows(m).Cells("numer").Value.ToString.Length > 0 Then
                            If DataGridView3.Rows(m).Cells("typ_adresu").Value.ToString.Contains("kom") Or DataGridView3.Rows(m).Cells("typ_adresu").Value.ToString.Contains("Kom") Then
                                DataGridView1.CurrentRow.Cells("telefon_kom").Value = (DataGridView1.CurrentRow.Cells("telefon_kom").Value & DataGridView3.Rows(m).Cells("numer").Value & "; ")
                            ElseIf DataGridView3.Rows(m).Cells("typ_adresu").Value.ToString.Contains("tel") Or DataGridView3.Rows(m).Cells("typ_adresu").Value.ToString.Contains("Tel") Then
                                DataGridView1.CurrentRow.Cells("telefon_stac").Value = (DataGridView1.CurrentRow.Cells("telefon_stac").Value & DataGridView3.Rows(m).Cells("numer").Value & "; ")
                                If DataGridView3.Rows(m).Cells("typ_adresu").Value.ToString.Contains("faks") Or DataGridView3.Rows(m).Cells("typ_adresu").Value.ToString.Contains("Faks") Then
                                    DataGridView1.CurrentRow.Cells("fax").Value = (DataGridView1.CurrentRow.Cells("fax").Value & DataGridView3.Rows(m).Cells("numer").Value & "; ")
                                End If
                            ElseIf DataGridView3.Rows(m).Cells("typ_adresu").Value.ToString.Contains("faks") Or DataGridView3.Rows(m).Cells("typ_adresu").Value.ToString.Contains("Faks") Then
                                DataGridView1.CurrentRow.Cells("fax").Value = (DataGridView1.CurrentRow.Cells("fax").Value & DataGridView3.Rows(m).Cells("numer").Value & "; ")
                            End If
                            DataGridView1.CurrentRow.Cells("uwagi").Value = (DataGridView1.CurrentRow.Cells("uwagi").Value & "  " & DataGridView3.Rows(m).Cells("typ_adresu").Value & ":" & DataGridView3.Rows(m).Cells("numer").Value & ";")
                        End If
                    Next
                End If
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try


            strQuery = "select name as typ_adresu, address as kontakt, DEFAULT_ADDRESS as domyslny "
            strQuery += "from R3_CONTACT_WEB_ADDRESSES left join r3_ext_types on r3_ext_types.id=R3_CONTACT_WEB_ADDRESSES.type_id "
            strQuery += "where contact_id=" & Me.DataGridView1.CurrentRow.Cells("ID").Value & ";"
            Try
                fda4 = New FbDataAdapter(strQuery, fcn)
                fds4 = New DataSet
                fDataView4 = New DataView
                fds4.Tables.Add("TAB")
                fda4.Fill(fds4.Tables("TAB"))
                fDataView4.Table = fds4.Tables("TAB")
                DataGridView4.DataSource = fDataView4
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

            Try
                If DataGridView4.RowCount > 0 Then
                    For m = 0 To DataGridView4.RowCount - 2
                        If DataGridView4.Rows(m).Cells("kontakt").Value.ToString.Length > 0 Then
                            If DataGridView4.Rows(m).Cells("typ_adresu").Value.ToString.Contains("mail") Or DataGridView3.Rows(m).Cells("typ_adresu").Value.ToString.Contains("Mail") Then
                                DataGridView1.CurrentRow.Cells("email").Value = (DataGridView1.CurrentRow.Cells("email").Value & DataGridView4.Rows(m).Cells("kontakt").Value & "; ")
                            ElseIf DataGridView4.Rows(m).Cells("typ_adresu").Value.ToString.Contains("www") Or DataGridView3.Rows(m).Cells("typ_adresu").Value.ToString.Contains("WWW") Then
                                DataGridView1.CurrentRow.Cells("http_adres").Value = (DataGridView1.CurrentRow.Cells("http_adres").Value & DataGridView4.Rows(m).Cells("kontakt").Value & "; ")
                            End If
                            DataGridView1.CurrentRow.Cells("uwagi").Value = (DataGridView1.CurrentRow.Cells("uwagi").Value & "  " & DataGridView4.Rows(m).Cells("typ_adresu").Value & ":" & DataGridView4.Rows(m).Cells("kontakt").Value & ";")
                        End If
                    Next
                End If
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

            strQuery = "select name as typ_adresu, STREET as ulica, BUILDING_NUMBER as nr_domu, APARTMENT_NUMBER as nr_lok, place as miasto, poczta, zipcode as kod_pocztowy,  powiat, country as kraj "
            strQuery += "from r3_contact_addresses left join r3_ext_types on r3_ext_types.id=r3_contact_addresses.type_id "
            strQuery += "where contact_id=" & Me.DataGridView1.CurrentRow.Cells("ID").Value & ";"
            Try
                fda2 = New FbDataAdapter(strQuery, fcn)
                fds2 = New DataSet
                fDataView2 = New DataView
                fds2.Tables.Add("TAB")
                fda2.Fill(fds2.Tables("TAB"))
                fDataView2.Table = fds2.Tables("TAB")
                DataGridView2.DataSource = fDataView2
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try


            For k = 0 To DataGridView2.Rows.Count - 1
                If DataGridView2.Rows(k).Cells("typ_adresu").Value.ToString.Contains("koresp") Or DataGridView2.Rows(k).Cells("typ_adresu").Value.ToString.Contains("Koresp") Or DataGridView2.RowCount = 1 Then
                    DataGridView1.CurrentRow.Cells("koresp_ulica").Value = DataGridView2.CurrentRow.Cells("ulica").Value
                    DataGridView1.CurrentRow.Cells("koresp_miasto").Value = DataGridView2.CurrentRow.Cells("miasto").Value
                    DataGridView1.CurrentRow.Cells("koresp_miasto_poczta").Value = DataGridView2.CurrentRow.Cells("poczta").Value
                    DataGridView1.CurrentRow.Cells("koresp_kod_pocztowy").Value = DataGridView2.CurrentRow.Cells("kod_pocztowy").Value
                    If Me.DataGridView2.CurrentRow.Cells("nr_lok").Value.ToString.Trim.Length > 0 Then
                        DataGridView1.CurrentRow.Cells("koresp_nr_domu").Value = DataGridView2.CurrentRow.Cells("nr_domu").Value & "/" & DataGridView2.CurrentRow.Cells("nr_lok").Value
                    Else
                        DataGridView1.CurrentRow.Cells("koresp_nr_domu").Value = DataGridView2.CurrentRow.Cells("nr_domu").Value
                    End If
                End If
                s = ""
                s += DataGridView2.CurrentRow.Cells("typ_adresu").Value & ": "
                s += DataGridView2.CurrentRow.Cells("ulica").Value & " "
                If Me.DataGridView2.CurrentRow.Cells("nr_lok").Value.ToString.Trim.Length > 0 Then
                    DataGridView1.CurrentRow.Cells("koresp_nr_domu").Value = DataGridView2.CurrentRow.Cells("nr_domu").Value & "/" & DataGridView2.CurrentRow.Cells("nr_lok").Value
                Else
                    DataGridView1.CurrentRow.Cells("koresp_nr_domu").Value = DataGridView2.CurrentRow.Cells("nr_domu").Value
                End If
                s += " Miasto: " & DataGridView2.CurrentRow.Cells("miasto").Value
                s += " Poczta: " & DataGridView2.CurrentRow.Cells("kod_pocztowy").Value & " " & DataGridView2.CurrentRow.Cells("poczta").Value
                DataGridView1.CurrentRow.Cells("uwagi").Value = DataGridView1.CurrentRow.Cells("uwagi").Value & s

            Next

        Next
    End Sub

    Private Sub BBrak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBrak.Click
        If DataGridView1.CurrentRow.Cells("nazwa_firmy").Value.ToString = "" Then DataGridView1.CurrentRow.Cells("nazwa_firmy").Value = "Brak"
        If DataGridView1.CurrentRow.Cells("skrot").Value.ToString = "" Then DataGridView1.CurrentRow.Cells("skrot").Value = "Brak"
        If DataGridView1.CurrentRow.Cells("miasto").Value.ToString = "" Then DataGridView1.CurrentRow.Cells("miasto").Value = "Brak"
        If DataGridView1.CurrentRow.Cells("miasto_poczta").Value.ToString = "" Then DataGridView1.CurrentRow.Cells("miasto_poczta").Value = "Brak"
        If DataGridView1.CurrentRow.Cells("kod_pocztowy").Value.ToString = "" Then DataGridView1.CurrentRow.Cells("kod_pocztowy").Value = "00-000"
        If DataGridView1.CurrentRow.Cells("ulica").Value.ToString = "" Then DataGridView1.CurrentRow.Cells("ulica").Value = "Brak"
        If DataGridView1.CurrentRow.Cells("koresp_miasto").Value.ToString = "" Then DataGridView1.CurrentRow.Cells("koresp_miasto").Value = "Brak"
        If DataGridView1.CurrentRow.Cells("koresp_miasto_poczta").Value.ToString = "" Then DataGridView1.CurrentRow.Cells("koresp_miasto_poczta").Value = "Brak"
        If DataGridView1.CurrentRow.Cells("koresp_kod_pocztowy").Value.ToString = "" Then DataGridView1.CurrentRow.Cells("koresp_miasto_poczta").Value = "00-000"
        If DataGridView1.CurrentRow.Cells("koresp_ulica").Value.ToString = "" Then DataGridView1.CurrentRow.Cells("koresp_ulica").Value = "Brak"
        If DataGridView1.CurrentRow.Cells("kraj").Value.ToString = "" Then DataGridView1.CurrentRow.Cells("kraj").Value = "Polska"
    End Sub

    Private Sub KopiujToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KopiujToolStripMenuItem.Click
        schowek = DataGridView1.CurrentCell.Value.ToString
    End Sub

    Private Sub WklejToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WklejToolStripMenuItem.Click
        DataGridView1.CurrentCell.Value = schowek
    End Sub
End Class