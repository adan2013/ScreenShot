﻿<Serializable()>
Public Class MAGAZYN

    Public ShiftMOD As Boolean = False
    Public CtrlMOD As Boolean = False
    Public AltMOD As Boolean = False
    Public key As String = ""
    Public savemode As Boolean = False
    Public savepath As String = ""
    Public roz As Byte = 0
    Public opendir As Boolean = False
    Public deftool As Byte = 0
    Public defcolor As Byte = 0
    Public defcolorpicker As Boolean = False

    Public Sub New()

    End Sub

    Public Function GetKey(ByVal theKey As String) As Keys
        Dim kc As KeysConverter = New KeysConverter()
        Return CType(kc.ConvertFrom(theKey), Keys)
    End Function
End Class
