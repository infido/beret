Public Class PRAC
    Private fda1 As FbDataAdapter
    Private fds1 As DataSet
    Private fDataView1 As DataView
    Private kolzrd, kolcel As Integer
    Private schowek As String
    Private Sub BZamknij_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BZamknij.Click
        Me.Close()
    End Sub

    Private Sub PRAC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strQuery As String
        strQuery = "select"
        strQuery += " r3_persons.firstname as imie,"
        strQuery += " r3_persons.surname as nazwisko,"
        strQuery += " r3_contacts.short_name as skrot,"
        strQuery += " '' as nazwa_departamentu,"
        strQuery += " '' as telefon_stac,"
        strQuery += " '' as telefon_kom,"
        strQuery += " '' as fax,"
        strQuery += " '' as email,"
        strQuery += " '' as http_adres,"
        strQuery += " r3_contact_business.job_title as stanowisko,"
        strQuery += " r3_contact_business.sc_title as tytul,"
        strQuery += " r3_persons.id,"
        strQuery += " case r3_persons.archive when 0 then 'tak' else 'nie' end as aktywna,"
        strQuery += " '' as uwagi "
        strQuery += " from r3_persons "
        strQuery += " left join r3_contacts on r3_persons.contact_id=r3_contacts.id"
        strQuery += " left join r3_contact_business on r3_persons.business_id=r3_contact_business.id;"
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

    Private Sub BUzup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUzup.Click
        Dim s As String = ""
        Dim fdr As FbDataReader
        Dim kom As New FbCommand
        'For i = 0 To Me.DataGridView1.RowCount - 1
        For i = 0 To 10
            Me.DataGridView1.CurrentCell() = Me.DataGridView1.Rows(i).Cells(0)
            Dim strQuery As String
            strQuery = "select name as typ_adresu, number as numer "
            strQuery += "from r3_contact_phones left join r3_ext_types on r3_ext_types.id=r3_contact_phones.type_id "
            strQuery += "where person_id=" & Me.DataGridView1.CurrentRow.Cells("ID").Value & ";"
            kom.Connection = fcn
            kom.CommandText = strQuery

            Try
                fdr = kom.ExecuteReader
                While fdr.Read
                    If fdr("numer").ToString.Length > 0 Then
                        If fdr("typ_adresu").ToString.ToLower.Contains("kom") Then
                            DataGridView1.CurrentRow.Cells("telefon_kom").Value = (DataGridView1.CurrentRow.Cells("telefon_kom").Value & fdr("numer") & "; ")
                        ElseIf fdr("typ_adresu").ToString.ToLower.Contains("tel") Then
                            DataGridView1.CurrentRow.Cells("telefon_stac").Value = (DataGridView1.CurrentRow.Cells("telefon_stac").Value & fdr("numer") & "; ")
                            If fdr("typ_adresu").ToString.ToLower.Contains("faks") Then
                                DataGridView1.CurrentRow.Cells("fax").Value = (DataGridView1.CurrentRow.Cells("fax").Value & fdr("numer") & "; ")
                            End If
                        ElseIf fdr("typ_adresu").ToString.ToLower.Contains("faks") Then
                            DataGridView1.CurrentRow.Cells("fax").Value = (DataGridView1.CurrentRow.Cells("fax").Value & fdr("numer") & "; ")
                        End If
                    End If
                End While
                fdr.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try



            strQuery = "select name as typ_adresu, address as kontakt, DEFAULT_ADDRESS as domyslny "
            strQuery += "from R3_CONTACT_WEB_ADDRESSES left join r3_ext_types on r3_ext_types.id=R3_CONTACT_WEB_ADDRESSES.type_id "
            strQuery += "where person_id=" & Me.DataGridView1.CurrentRow.Cells("ID").Value & ";"
            kom.Connection = fcn
            kom.CommandText = strQuery
            Try
                fdr = kom.ExecuteReader
                While fdr.Read
                    If fdr("kontakt").ToString.Length > 0 Then
                        If fdr("typ_adresu").ToString.ToLower.Contains("mail") Then
                            DataGridView1.CurrentRow.Cells("email").Value = (DataGridView1.CurrentRow.Cells("email").Value & fdr("kontakt") & "; ")
                        ElseIf fdr("typ_adresu").ToString.ToLower.Contains("www") Then
                            DataGridView1.CurrentRow.Cells("http_adres").Value = (DataGridView1.CurrentRow.Cells("http_adres").Value & fdr("kontakt") & "; ")
                        End If
                    End If
                End While
                fdr.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

        Next
    End Sub

    Private Sub BExportXLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BExportXLS.Click

        Dim ile_rekordow As Integer = fDataView1.Table.Rows.Count
        Dim ile_kolumn As Integer = fDataView1.Table.Columns.Count
        Dim fpath As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\Pracownicy.xls"



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

    Private Sub UsuńWierszToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuńWierszToolStripMenuItem.Click
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

    Private Sub UsuńKolumnęToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuńKolumnęToolStripMenuItem.Click
        Me.fds1.Tables("TAB").Columns.RemoveAt(Me.DataGridView1.CurrentCell.ColumnIndex)
        Me.fds1.Tables("TAB").AcceptChanges()
        Me.DataGridView1.Refresh()
    End Sub

    Private Sub KopiujCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KopiujCToolStripMenuItem.Click
        schowek = DataGridView1.CurrentCell.Value.ToString
    End Sub

    Private Sub WkjejvToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WkjejvToolStripMenuItem.Click
        DataGridView1.CurrentCell.Value = schowek
    End Sub
End Class