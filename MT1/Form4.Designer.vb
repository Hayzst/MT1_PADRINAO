<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        F1 = New Button()
        QSAQSA = New Label()
        QSA2 = New Label()
        QSA1 = New Label()
        index3 = New TextBox()
        index2 = New TextBox()
        index1 = New TextBox()
        index0 = New TextBox()
        Label1 = New Label()
        clearbutton = New Button()
        OKbutton = New Button()
        index4 = New TextBox()
        SuspendLayout()
        ' 
        ' F1
        ' 
        F1.Location = New Point(667, 231)
        F1.Name = "F1"
        F1.Size = New Size(100, 82)
        F1.TabIndex = 21
        F1.Text = "F1"
        F1.UseVisualStyleBackColor = True
        ' 
        ' QSAQSA
        ' 
        QSAQSA.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        QSAQSA.Location = New Point(304, 157)
        QSAQSA.Name = "QSAQSA"
        QSAQSA.Size = New Size(211, 34)
        QSAQSA.TabIndex = 43
        QSAQSA.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' QSA2
        ' 
        QSA2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        QSA2.Location = New Point(304, 242)
        QSA2.Name = "QSA2"
        QSA2.Size = New Size(211, 34)
        QSA2.TabIndex = 42
        QSA2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' QSA1
        ' 
        QSA1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        QSA1.Location = New Point(304, 208)
        QSA1.Name = "QSA1"
        QSA1.Size = New Size(211, 34)
        QSA1.TabIndex = 41
        QSA1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' index3
        ' 
        index3.Location = New Point(507, 66)
        index3.Multiline = True
        index3.Name = "index3"
        index3.Size = New Size(81, 72)
        index3.TabIndex = 40
        index3.TextAlign = HorizontalAlignment.Center
        ' 
        ' index2
        ' 
        index2.Location = New Point(400, 66)
        index2.Multiline = True
        index2.Name = "index2"
        index2.Size = New Size(81, 72)
        index2.TabIndex = 39
        index2.TextAlign = HorizontalAlignment.Center
        ' 
        ' index1
        ' 
        index1.Location = New Point(291, 66)
        index1.Multiline = True
        index1.Name = "index1"
        index1.Size = New Size(81, 72)
        index1.TabIndex = 38
        index1.TextAlign = HorizontalAlignment.Center
        ' 
        ' index0
        ' 
        index0.Location = New Point(184, 66)
        index0.Multiline = True
        index0.Name = "index0"
        index0.Size = New Size(81, 72)
        index0.TabIndex = 37
        index0.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(36, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(211, 34)
        Label1.TabIndex = 44
        Label1.Text = "QSA"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' clearbutton
        ' 
        clearbutton.Location = New Point(436, 315)
        clearbutton.Name = "clearbutton"
        clearbutton.Size = New Size(100, 82)
        clearbutton.TabIndex = 36
        clearbutton.Text = "clear"
        clearbutton.UseVisualStyleBackColor = True
        ' 
        ' OKbutton
        ' 
        OKbutton.Location = New Point(296, 315)
        OKbutton.Name = "OKbutton"
        OKbutton.Size = New Size(100, 82)
        OKbutton.TabIndex = 34
        OKbutton.Text = "OK"
        OKbutton.UseVisualStyleBackColor = True
        ' 
        ' index4
        ' 
        index4.Location = New Point(607, 66)
        index4.Multiline = True
        index4.Name = "index4"
        index4.Size = New Size(81, 72)
        index4.TabIndex = 45
        index4.TextAlign = HorizontalAlignment.Center
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(index4)
        Controls.Add(QSAQSA)
        Controls.Add(QSA2)
        Controls.Add(QSA1)
        Controls.Add(index3)
        Controls.Add(index2)
        Controls.Add(index1)
        Controls.Add(index0)
        Controls.Add(Label1)
        Controls.Add(clearbutton)
        Controls.Add(OKbutton)
        Controls.Add(F1)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents F1 As Button
    Friend WithEvents QSAQSA As Label
    Friend WithEvents QSA2 As Label
    Friend WithEvents QSA1 As Label
    Friend WithEvents index3 As TextBox
    Friend WithEvents index2 As TextBox
    Friend WithEvents index1 As TextBox
    Friend WithEvents index0 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents clearbutton As Button
    Friend WithEvents OKbutton As Button
    Friend WithEvents index4 As TextBox
End Class
