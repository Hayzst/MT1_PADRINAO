Public Class Form3
    Dim MSA()
    Dim first_division()
    Dim second_division()

    Dim tempo1
    Dim tempo2

    Private Sub SSA_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Your code here
    End Sub
    '------------------------ CLEAR
    Private Sub clearbutton_Click(sender As Object, e As EventArgs) Handles clearbutton.Click
        index0.Text = ""
        index1.Text = ""
        index2.Text = ""
        index3.Text = ""

        MSA1.Text = ""
        MSA2.Text = ""
        MSA3.Text = ""
    End Sub
    '------------------------ OK button
    Private Sub OKbutton_Click(sender As Object, e As EventArgs) Handles OKbutton.Click
        MSA = {Integer.Parse(index0.Text), Integer.Parse(index1.Text), Integer.Parse(index2.Text), Integer.Parse(index3.Text)}
        first_division = {MSA(0), MSA(1)}
        second_division = {MSA(2), MSA(3)}

        MSA1.Text = $"MSA_1 = [{String.Join(", ", first_division)}] [{String.Join(", ", second_division)}]"
        If first_division(0) > first_division(1) Then
            tempo1 = first_division(1)
            first_division(1) = first_division(0)
            first_division(0) = tempo1
        End If
        If second_division(0) > second_division(1) Then
            tempo2 = second_division(1)
            second_division(1) = second_division(0)
            second_division(0) = tempo2
        End If
        MSA2.Text = $"MSA_2 = [{String.Join(", ", first_division)}] [{String.Join(", ", second_division)}]"
        Array.Sort(MSA)
        MSA3.Text = $"MSA_3 = [{String.Join(", ", MSA)}]"
    End Sub

    '------------------------ show form 4
    Private Sub F4_Click(sender As Object, e As EventArgs) Handles F4.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class