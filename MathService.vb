Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class MathService
    Dim reset As Boolean = False
    Dim type As Type = Type.None
    Dim can1 As String = "0"
    Dim can2 As String = "0"
    Dim Screen As String = ""

    Public Function WriteNumber(number As String) As String
        ClearScreen()
        Screen &= number
        reset = False
        Return Screen
    End Function

    Public Function AddDoubleZero() As String
        If Screen = "" Then
            Screen &= "0"
        Else
            Screen &= "00"
        End If
        reset = False
        Return Screen
    End Function

    Public Function AddComma() As String
        ClearScreen()
        If Not Screen.Contains(",") And Screen IsNot "error" Then
            If Screen = "" Then Screen = "0"
            Screen &= ","
        End If
        reset = False
        Return Screen
    End Function

    Public Function InvertSign() As String
        Screen *= -1
        Return Screen
    End Function

    Private Sub ClearScreen()
        If Screen = "0" Or reset Or Screen = "error" Then
            Screen = ""
        End If
        reset = False
    End Sub

    Public Function ResetScreen() As String
        Screen = ""
        Return ""
    End Function

    Public Function ResetAll() As String
        Screen = ""
        can1 = "0"
        can2 = "0"
        reset = True
        Return ""
    End Function

    Public Function ExecuteOperatioon(resultType As Type, Optional ByVal isEqual As Boolean = False) As String
        If Screen = "error" Then
            Screen = ""
            reset = True
            Return Screen
        End If

        If type = Type.Addition Then
            can2 = Screen
            Screen = CDbl(can1) + CDbl(can2)
            can1 = Screen
            reset = True
        ElseIf type = Type.Substraction Then
            can2 = Screen
            Screen = CDbl(can1) - CDbl(can2)
            can1 = Screen
            reset = True
        ElseIf type = Type.Multiplicacion Then
            can2 = Screen
            Screen = CDbl(can1) * CDbl(can2)
            can1 = Screen
            reset = True
        ElseIf type = Type.Division Then
            can2 = Screen
            Screen = CDbl(can1) / CDbl(can2)
            If can2 = "0" Then
                Screen = "error"
            End If
            can1 = Screen
            reset = True
        Else
            can1 = Screen
            type = resultType
            reset = True
        End If

        If isEqual Then reset = False
        type = resultType

        Return Screen
    End Function
End Class
