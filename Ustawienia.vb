<Serializable()> _
Public Class Ustawienia
    Public wartosc1 As String
    Public wartosc2 As String
    Public wartosc3 As String
    Public wsp1 As String
    Public wsp2 As String
    Public wsp3 As String
    Public ser As String
    Public baz As String

    Public Sub New(ByVal war1 As String, ByVal ws1 As String, ByVal war2 As String, ByVal ws2 As String, ByVal war3 As String, ByVal ws3 As String, ByVal baza As String, ByVal serwer As String)
        wartosc1 = war1
        wartosc2 = war2
        wartosc3 = war3
        wsp1 = ws1
        wsp2 = ws2
        wsp3 = ws3
        baz = baza
        ser = serwer
    End Sub

    Public Sub New()

    End Sub


End Class
