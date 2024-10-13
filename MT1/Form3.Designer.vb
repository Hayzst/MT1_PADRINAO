<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        F4 = New Button()
        clearbutton = New Button()
        OKbutton = New Button()
        MSA3 = New Label()
        MSA2 = New Label()
        MSA1 = New Label()
        index3 = New TextBox()
        index2 = New TextBox()
        index1 = New TextBox()
        index0 = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' F4
        ' 
        F4.Location = New Point(665, 225)
        F4.Name = "F4"
        F4.Size = New Size(100, 82)
        F4.TabIndex = 21
        F4.Text = "F4"
        F4.UseVisualStyleBackColor = True
        ' 
        ' clearbutton
        ' 
        clearbutton.Location = New Point(445, 324)
        clearbutton.Name = "clearbutton"
        clearbutton.Size = New Size(100, 82)
        clearbutton.TabIndex = 24
        clearbutton.Text = "clear"
        clearbutton.UseVisualStyleBackColor = True
        ' 
        ' OKbutton
        ' 
        OKbutton.Location = New Point(305, 324)
        OKbutton.Name = "OKbutton"
        OKbutton.Size = New Size(100, 82)
        OKbutton.TabIndex = 22
        OKbutton.Text = "OK"
        OKbutton.UseVisualStyleBackColor = True
        ' 
        ' MSA3
        ' 
        MSA3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MSA3.Location = New Point(291, 250)
        MSA3.Name = "MSA3"
        MSA3.Size = New Size(211, 34)
        MSA3.TabIndex = 31
        MSA3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MSA2
        ' 
        MSA2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MSA2.Location = New Point(291, 216)
        MSA2.Name = "MSA2"
        MSA2.Size = New Size(211, 34)
        MSA2.TabIndex = 30
        MSA2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MSA1
        ' 
        MSA1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MSA1.Location = New Point(291, 182)
        MSA1.Name = "MSA1"
        MSA1.Size = New Size(211, 34)
        MSA1.TabIndex = 29
        MSA1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' index3
        ' 
        index3.Location = New Point(540, 62)
        index3.Multiline = True
        index3.Name = "index3"
        index3.Size = New Size(81, 72)
        index3.TabIndex = 28
        index3.TextAlign = HorizontalAlignment.Center
        ' 
        ' index2
        ' 
        index2.Location = New Point(433, 62)
        index2.Multiline = True
        index2.Name = "index2"
        index2.Size = New Size(81, 72)
        index2.TabIndex = 27
        index2.TextAlign = HorizontalAlignment.Center
        ' 
        ' index1
        ' 
        index1.Location = New Point(324, 62)
        index1.Multiline = True
        index1.Name = "index1"
        index1.Size = New Size(81, 72)
        index1.TabIndex = 26
        index1.TextAlign = HorizontalAlignment.Center
        ' 
        ' index0
        ' 
        index0.Location = New Point(217, 62)
        index0.Multiline = True
        index0.Name = "index0"
        index0.Size = New Size(81, 72)
        index0.TabIndex = 25
        index0.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(69, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(211, 34)
        Label1.TabIndex = 32
        Label1.Text = "MSA"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MSA3)
        Controls.Add(MSA2)
        Controls.Add(MSA1)
        Controls.Add(index3)
        Controls.Add(index2)
        Controls.Add(index1)
        Controls.Add(index0)
        Controls.Add(Label1)
        Controls.Add(clearbutton)
        Controls.Add(OKbutton)
        Controls.Add(F4)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents F4 As Button
    Friend WithEvents clearbutton As Button
    Friend WithEvents OKbutton As Button
    Friend WithEvents MSA3 As Label
    Friend WithEvents MSA2 As Label
    Friend WithEvents MSA1 As Label
    Friend WithEvents index3 As TextBox
    Friend WithEvents index2 As TextBox
    Friend WithEvents index1 As TextBox
    Friend WithEvents index0 As TextBox
    Friend WithEvents Label1 As Label
End Class
