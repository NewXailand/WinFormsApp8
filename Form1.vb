Imports System.ComponentModel.Design
Imports System.Windows.Input

Public Class Form1
    Dim mathService As MathService = New MathService

    Private Sub Button1_Click()
        TextBox1.Text = mathService.WriteNumber("1")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Text = mathService.WriteNumber("0")
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox1.Text = mathService.AddDoubleZero()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = mathService.ExecuteOperatioon(Type.Addition)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = mathService.ExecuteOperatioon(Type.Substraction)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = mathService.ExecuteOperatioon(Type.Multiplicacion)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text = mathService.ExecuteOperatioon(Type.Division)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox1.Text = mathService.ExecuteOperatioon(Type.None, True)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox1.Text = mathService.ResetAll()
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
        TextBox1.Text = mathService.ResetAll()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = mathService.WriteNumber("2")
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TextBox1.Text = mathService.WriteNumber("0")
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
        Button20.Enabled = False
        Button21.Enabled = True
        Button22.Enabled = True
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text = mathService.InvertSign()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TextBox1.Text = mathService.ResetScreen()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TextBox1.Text = mathService.AddComma()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = mathService.WriteNumber("3")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = mathService.WriteNumber("1")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = mathService.WriteNumber("4")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = mathService.WriteNumber("5")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = mathService.WriteNumber("6")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = mathService.WriteNumber("7")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = mathService.WriteNumber("8")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = mathService.WriteNumber("9")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = mathService.ResetScreen()
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
End Class

