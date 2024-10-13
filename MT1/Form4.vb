Public Class Form4
    'Dim QSA As New List(Of Integer)
    Dim QSA() As Integer
    Dim pivot

    Dim smaller_division As New List(Of Integer)
    Dim greater_division As New List(Of Integer)
    Private Sub F1_Click(sender As Object, e As EventArgs) Handles F1.Click
        Me.Hide()
        Form1.Show()
    End Sub


    '------------------------ OK button
    Private Sub OKbutton_Click(sender As Object, e As EventArgs) Handles OKbutton.Click
        QSA = {Integer.Parse(index0.Text), Integer.Parse(index1.Text), Integer.Parse(index2.Text), Integer.Parse(index3.Text), Integer.Parse(index4.Text)}
        QSAQSA.Text = $"QSA = {String.Join(", ", QSA)}"
        'divide'
        pivot = QSA(4)
        For index = 0 To 3
            If QSA(index) < pivot Then
                smaller_division.Add(QSA(index))
            ElseIf QSA(index) > pivot Then
                greater_division.Add(QSA(index))
            Else
                greater_division.Insert(0, QSA(index))
            End If
        Next
        QSA1.Text = $"QSA[1] = [{String.Join(", ", smaller_division)}] [{pivot}, {String.Join(", ", greater_division)}]"

        'last scenario - sorted
        Array.Sort(QSA)
        QSA2.Text = $"QSA[2] = [{QSA(0)}] [{QSA(1)}] [{QSA(2)}] [{QSA(3)}] [{QSA(4)}]"
        '---
        OKbutton.Enabled = False
    End Sub

    '------------------------ CLEAR
    Private Sub clearbutton_Click(sender As Object, e As EventArgs) Handles clearbutton.Click
        index0.Text = ""
        index1.Text = ""
        index2.Text = ""
        index3.Text = ""
        index4.Text = ""

        QSA1.Text = ""
        QSA2.Text = ""
        QSAQSA.Text = ""

        smaller_division.Clear()
        greater_division.Clear()
        OKbutton.Enabled = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles index4.TextChanged

    End Sub
End Class