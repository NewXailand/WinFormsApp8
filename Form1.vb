Imports System.ComponentModel.Design
Imports System.Windows.Input

Public Class Form1
    Dim a As Boolean
    Dim tipo As String
    Dim can1 As String
    Dim can2 As String
    Dim signo As String
    Private Sub Button1_Click() Handles Button1.Click
        If TextBox1.Text = "0" Then TextBox1.Text = ""
        If a = True Then
            TextBox1.Text = "1"
            a = False
        Else
            TextBox1.Text = TextBox1.Text & "1"
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If a = True Then
            TextBox1.Text = "0"
            a = False
        Else
            TextBox1.Text = TextBox1.Text & "0"
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If a = True Then
            TextBox1.Text = "00"

            a = False
        Else
            TextBox1.Text = TextBox1.Text & "00"
        End If



    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If tipo = "suma" Then
            can2 = TextBox1.Text
            TextBox1.Text = CDbl(can1) + CDbl(can2)
            can1 = TextBox1.Text
            a = True
            tipo = "suma"
        ElseIf tipo = "resta" Then
            can2 = TextBox1.Text
            TextBox1.Text = CDbl(can1) - CDbl(can2)
            can1 = TextBox1.Text
            a = True
            tipo = "suma"
        ElseIf tipo = "multi" Then
            can2 = TextBox1.Text
            TextBox1.Text = CDbl(can1) * CDbl(can2)
            can1 = TextBox1.Text
            a = True
            tipo = "suma"
        ElseIf tipo = "divi" Then
            can2 = TextBox1.Text
            TextBox1.Text = CDbl(can1) / CDbl(can2)
            can1 = TextBox1.Text
            a = True
            tipo = "suma"
        ElseIf tipo = "" Then
            can1 = TextBox1.Text
            a = True
            tipo = "suma"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If tipo = "suma" Then
            can2 = TextBox1.Text
            TextBox1.Text = CDbl(can1) + CDbl(can2)
            can1 = TextBox1.Text
            a = True
            tipo = "resta"
        ElseIf tipo = "resta" Then
            can2 = TextBox1.Text
            TextBox1.Text = CDbl(can1) - CDbl(can2)
            can1 = TextBox1.Text
            a = True
            tipo = "resta"
        ElseIf tipo = "multi" Then
            can2 = TextBox1.Text
            TextBox1.Text = CDbl(can1) * CDbl(can2)
            can1 = TextBox1.Text
            a = True
            tipo = "resta"
        ElseIf tipo = "divi" Then
            can2 = TextBox1.Text
            TextBox1.Text = CDbl(can1) / CDbl(can2)
            can1 = TextBox1.Text
            a = True
            tipo = "resta"
        ElseIf tipo = "" Then
            can1 = TextBox1.Text
            a = True
            tipo = "resta"
        End If

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If tipo = "suma" Then
            can2 = TextBox1.Text
            TextBox1.Text = CDbl(can1) + CDbl(can2)
            can1 = TextBox1.Text
            a = True
            tipo = "multi"
        ElseIf tipo = "resta" Then
            can2 = TextBox1.Text
            TextBox1.Text = CDbl(can1) - CDbl(can2)
            can1 = TextBox1.Text
            a = True
            tipo = "multi"
        ElseIf tipo = "multi" Then
            can2 = TextBox1.Text
            TextBox1.Text = CDbl(can1) * CDbl(can2)
            can1 = TextBox1.Text
            a = True
            tipo = "multi"
        ElseIf tipo = "divi" Then
            can2 = TextBox1.Text
            TextBox1.Text = CDbl(can1) / CDbl(can2)
            can1 = TextBox1.Text
            a = True
            tipo = "multi"
        ElseIf tipo = "" Then
            can1 = TextBox1.Text
            a = True
            tipo = "multi"
        End If

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If tipo = "suma" Then
            can2 = TextBox1.Text
            TextBox1.Text = CDbl(can1) + CDbl(can2)
            can1 = TextBox1.Text
            a = True
            tipo = "divi"
        ElseIf tipo = "resta" Then
            can2 = TextBox1.Text
            TextBox1.Text = CDbl(can1) - CDbl(can2)
            can1 = TextBox1.Text
            a = True
            tipo = "divi"
        ElseIf tipo = "multi" Then
            can2 = TextBox1.Text
            TextBox1.Text = CDbl(can1) * CDbl(can2)
            can1 = TextBox1.Text
            a = True
            tipo = "divi"
        ElseIf tipo = "divi" Then
            can2 = TextBox1.Text
            TextBox1.Text = CDbl(can1) / CDbl(can2)
            can1 = TextBox1.Text
            a = True
            tipo = "divi"
        ElseIf tipo = "" Then
            can1 = TextBox1.Text
            a = True
            tipo = "divi"
        End If





    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If tipo = "suma" Then
            can2 = TextBox1.Text
            TextBox1.Text = CDbl(can1) + CDbl(can2)
            can1 = TextBox1.Text
            a = True
            tipo = ""
        ElseIf tipo = "resta" Then
            can2 = TextBox1.Text
            TextBox1.Text = CDbl(can1) - CDbl(can2)
            can1 = TextBox1.Text
            a = True
            tipo = ""
        ElseIf tipo = "multi" Then
            can2 = TextBox1.Text
            TextBox1.Text = CDbl(can1) * CDbl(can2)
            can1 = TextBox1.Text
            a = True
            tipo = ""
        ElseIf tipo = "divi" Then
            can2 = TextBox1.Text
            TextBox1.Text = CDbl(can1) / CDbl(can2)
            If can2 = "0" Then
                TextBox1.Text = "error"
            End If
            can1 = TextBox1.Text
            a = True
            tipo = ""
        ElseIf tipo = "" Then
            can1 = TextBox1.Text
            a = True
            tipo = ""
        End If


    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        a = False
        TextBox1.Text = ""
        can1 = "0"
        can2 = "0"
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        Button10.Enabled = False
        Button11.Enabled = False
        Button12.Enabled = False
        Button13.Enabled = False
        Button14.Enabled = False
        Button15.Enabled = False
        Button16.Enabled = False
        Button17.Enabled = False
        Button18.Enabled = False
        Button19.Enabled = False
        Button20.Enabled = True
        Button21.Enabled = False
        Button22.Enabled = False
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        a = False
        TextBox1.Text = "0"
        can1 = "0"
        can2 = "0"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "0" Then TextBox1.Text = ""
        If a = True Then
            TextBox1.Text = "2"
            a = False
        Else
            TextBox1.Text = TextBox1.Text & "2"
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TextBox1.Text = "0"
        a = False
        can1 = "0"
        can2 = "0"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        Button10.Enabled = True
        Button11.Enabled = True
        Button12.Enabled = True
        Button13.Enabled = True
        Button14.Enabled = True
        Button15.Enabled = True
        Button16.Enabled = True
        Button17.Enabled = True
        Button18.Enabled = True
        Button19.Enabled = True
        Button20.Enabled = True
        Button21.Enabled = True
        Button22.Enabled = True

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If TextBox1.Text > 0 Then
            TextBox1.Text = TextBox1.Text * -1
        Else
            TextBox1.Text = TextBox1.Text * -1
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TextBox1.Text = "0"
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If a = True Then
            TextBox1.Text = ","
            a = False
        Else
            TextBox1.Text = TextBox1.Text & ","
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "0" Then TextBox1.Text = ""
        If a = True Then
            TextBox1.Text = "3"
            a = False
        Else
            TextBox1.Text = TextBox1.Text & "3"
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = "0" Then TextBox1.Text = ""
        If a = True Then
            TextBox1.Text = "4"
            a = False
        Else
            TextBox1.Text = TextBox1.Text & "4"
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text = "0" Then TextBox1.Text = ""
        If a = True Then
            TextBox1.Text = "5"
            a = False
        Else
            TextBox1.Text = TextBox1.Text & "5"
        End If

    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text = "0" Then TextBox1.Text = ""
        If a = True Then
            TextBox1.Text = "6"
            a = False
        Else
            TextBox1.Text = TextBox1.Text & "6"
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text = "0" Then TextBox1.Text = ""
        If a = True Then
            TextBox1.Text = "7"
            a = False
        Else
            TextBox1.Text = TextBox1.Text & "7"
        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox1.Text = "0" Then TextBox1.Text = ""
        If a = True Then
            TextBox1.Text = "8"
            a = False
        Else
            TextBox1.Text = TextBox1.Text & "8"
        End If
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox1.Text = "0" Then TextBox1.Text = ""
        If a = True Then
            TextBox1.Text = "9"
            a = False
        Else
            TextBox1.Text = TextBox1.Text & "9"
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        a = False
        can1 = "0"
        can2 = "0"
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        Button10.Enabled = False
        Button11.Enabled = False
        Button12.Enabled = False
        Button13.Enabled = False
        Button14.Enabled = False
        Button15.Enabled = False
        Button16.Enabled = False
        Button17.Enabled = False
        Button18.Enabled = False
        Button19.Enabled = False
        Button20.Enabled = True
        Button21.Enabled = False
        Button22.Enabled = False
    End Sub
End Class

