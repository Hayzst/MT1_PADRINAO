Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    Dim index_zero
    Dim index_one
    Dim index_two

    Dim ISA() As Integer
    Dim ISA_one() As Integer
    Dim ISA_two() As Integer



    ' --------------------------- OK BUTTON
    Private Sub OKbutton_Click(sender As Object, e As EventArgs) Handles OKbutton.Click
        index_zero = Integer.Parse(index0.Text)
        index_one = Integer.Parse(index1.Text)
        index_two = Integer.Parse(index2.Text)

        ISA = {index_zero, index_one, index_two}



        '3  21
        '3  12
        If ISA(0) > ISA(1) Then
            If ISA(1) > ISA(2) Then
                '  21
                ISA_one = {ISA(2), ISA(0), ISA(1)}
                ISA_two = {ISA(2), ISA(1), ISA(0)}
                ISA_1.Text = "ISA_1 = [" + String.Join(", ", ISA_one) + "]"
                ISA_2.Text = "ISA_2 = [" + String.Join(", ", ISA_two) + "]"
            ElseIf ISA(0) > ISA(1) Then
                '  2   13
                ISA_one = {ISA(1), ISA(0), ISA(2)}
                ISA_1.Text = "ISA_1 = [" + String.Join(", ", ISA_one) + "]"
                ISA_2.Text = ""

            Else
                '  12

                ISA_one = {ISA(1), ISA(0), ISA(2)}
                ISA_two = {ISA(1), ISA(2), ISA(0)}
                ISA_1.Text = "ISA_1 = [" + String.Join(", ", ISA_one) + "]"
                ISA_2.Text = "ISA_2 = [" + String.Join(", ", ISA_two) + "]"
            End If

            '2   31
            '1   32
        ElseIf ISA(1) > ISA(0) Then
            If ISA(0) > ISA(2) Then
                '  2   31
                ISA_one = {ISA(2), ISA(0), ISA(1)}

                ISA_1.Text = "ISA_1 = [" + String.Join(", ", ISA_one) + "]"
                ISA_2.Text = ""

                '  1   23
            ElseIf ISA(1) > ISA(0) Then
                ISA_one = ISA
                ISA_1.Text = "ISA_1 = [" + String.Join(", ", ISA_one) + "]"
                ISA_2.Text = ""

            Else
                '  1   32

                ISA_one = ISA
                ISA_two = {ISA(0), ISA(2), ISA(1)}
                ISA_1.Text = "ISA_1 = [" + String.Join(", ", ISA_one) + "]"
                ISA_2.Text = "ISA_2 = [" + String.Join(", ", ISA_two) + "]"
            End If
            '123
            '213


        End If


    End Sub
    ' ---------------------------- CLEAR
    Private Sub clearbutton_Click(sender As Object, e As EventArgs) Handles clearbutton.Click
        index0.Text = ""
        index1.Text = ""
        index2.Text = ""
    End Sub
End Class
