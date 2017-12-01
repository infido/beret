Public Class Store
    Public skrot As String
    Public skrot2 As String
    Public id As Integer
    Public nazwa As String
    Public cena As Double
    Public cenab As Double

    Public Sub New()
        ' pusty konstruktor
    End Sub
    Public Sub New(ByVal skrotStr As String, ByVal skrot2Str As String, ByVal idInt As Integer, ByVal nazwaStr As String, ByVal cenaDbl As Double, ByVal cenabDbl As Double)
        skrot = skrotStr
        skrot2 = skrot2Str
        id = idInt
        nazwa = nazwaStr
        cena = cenaDbl
        cenab = cenabDbl
    End Sub

End Class
