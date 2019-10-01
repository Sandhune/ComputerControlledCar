Module Module1

    Public f2 As New Form2
    Public f3 As New Form3
    Public Declare Sub out Lib "Inpout32.dll" Alias "Out32" (ByVal PortAddress As Integer, ByVal Value As Integer)
    Sub delay(ByVal dblSecs As Double)
        Const Onesec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblwaitil As Date
        Now.AddSeconds(Onesec)
        dblwaitil = Now.AddSeconds(Onesec).AddSeconds(dblSecs)
        Do Until Now > dblwaitil
            Application.DoEvents()
        Loop
    End Sub
End Module

