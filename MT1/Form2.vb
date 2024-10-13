Imports System.Runtime.Intrinsics.X86

Public Class Form2

    'smallest number then swap
    Dim SSA() As Integer
    Dim pivot
    Dim tempo
    Dim smallest_number = 0
    Dim index_of_smallest = 0

    Dim SSA_one(3) As Integer
    Dim SSA_two(3) As Integer
    Dim SSA_three(3) As Integer

    Private Sub clear_button_Click(sender As Object, e As EventArgs) Handles clear_button.Click
        index0.Text = ""
        index1.Text = ""
        index2.Text = ""
        index3.Text = ""

        SSA1.Text = ""
        SSA2.Text = ""
        SSA3.Text = ""

    End Sub

    Private Sub ok_button_Click(sender As Object, e As EventArgs) Handles ok_button.Click
        SSA = {Integer.Parse(index0.Text), Integer.Parse(index1.Text), Integer.Parse(index2.Text), Integer.Parse(index3.Text)}

        For index = 0 To 3
            '------ finds the least number
            pivot = SSA(index)
            For counter = index To 3
                If pivot > SSA(counter) Then
                    index_of_smallest = counter
                    pivot = SSA(counter)
                End If
            Next
            smallest_number = pivot
            '------ swaps the least number to current index
            If smallest_number = SSA(index) Then
            Else
                tempo = SSA(index)
                SSA(index) = smallest_number
                SSA(index_of_smallest) = tempo
            End If



            If index = 0 Then
                Array.Copy(SSA, SSA_one, SSA.Length)
                SSA1.Text = "SSA_1 = [" + String.Join(", ", SSA) + "]"
            ElseIf index = 1 Then
                Array.Copy(SSA, SSA_two, SSA.Length)
                If Integer.Parse(String.Join("", SSA_two)) <> Integer.Parse(String.Join("", SSA_one)) Then
                    SSA2.Text = "SSA_2 = [" + String.Join(", ", SSA) + "]"
                End If
            Else
                Array.Copy(SSA, SSA_three, SSA.Length)
                If String.Join("", SSA) <> String.Join("", SSA_two) AndAlso SSA2.Text <> "" Then
                    SSA3.Text = "SSA_3 = [" + String.Join(", ", SSA) + "]"
                ElseIf SSA2.Text = "" AndAlso String.Join("", SSA_three) <> String.Join("", SSA_one) Then
                    SSA3.Text = "SSA_2 = [" + String.Join(", ", SSA) + "]"
                End If
            End If
        Next


    End Sub

    Private Sub F3_Click(sender As Object, e As EventArgs) Handles F3.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    '2 4 1 3 example

End Class
