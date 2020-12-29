Module loginInfo
    Private iNama, iOpr, iLoket, iNamaLoket As String
    Private numCetak As Integer

    Public Sub sLoginInfo(ByVal nama As String, ByVal opr As String, ByVal loket As String, ByVal nmLoket As String, ByVal n As Integer)
        iNama = nama
        iOpr = opr
        iLoket = loket
        iNamaLoket = nmLoket
        numCetak = n
    End Sub
    Public Function getNama()
        Return iNama
    End Function
    Public Function getOpr()
        Return iOpr
    End Function
    Public Function getLoket()
        Return iLoket
    End Function

    Public Function getNamaLoket()
        Return iNamaLoket
    End Function

    Public Function getNumCetak()
        Return numCetak
    End Function

    Public Sub updateNumCetak(ByVal n As Integer)
        numCetak = n
    End Sub
End Module
