<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        SSA3 = New Label()
        SSA2 = New Label()
        SSA1 = New Label()
        clear_button = New Button()
        ok_button = New Button()
        index3 = New TextBox()
        index2 = New TextBox()
        index1 = New TextBox()
        index0 = New TextBox()
        Label1 = New Label()
        F3 = New Button()
        SuspendLayout()
        ' 
        ' SSA3
        ' 
        SSA3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SSA3.Location = New Point(302, 234)
        SSA3.Name = "SSA3"
        SSA3.Size = New Size(211, 34)
        SSA3.TabIndex = 18
        SSA3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' SSA2
        ' 
        SSA2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SSA2.Location = New Point(302, 200)
        SSA2.Name = "SSA2"
        SSA2.Size = New Size(211, 34)
        SSA2.TabIndex = 17
        SSA2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' SSA1
        ' 
        SSA1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SSA1.Location = New Point(302, 166)
        SSA1.Name = "SSA1"
        SSA1.Size = New Size(211, 34)
        SSA1.TabIndex = 16
        SSA1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' clear_button
        ' 
        clear_button.Location = New Point(444, 328)
        clear_button.Name = "clear_button"
        clear_button.Size = New Size(98, 86)
        clear_button.TabIndex = 15
        clear_button.Text = "clear"
        clear_button.UseVisualStyleBackColor = True
        ' 
        ' ok_button
        ' 
        ok_button.Location = New Point(301, 328)
        ok_button.Name = "ok_button"
        ok_button.Size = New Size(98, 86)
        ok_button.TabIndex = 14
        ok_button.Text = "OK"
        ok_button.UseVisualStyleBackColor = True
        ' 
        ' index3
        ' 
        index3.Location = New Point(538, 69)
        index3.Multiline = True
        index3.Name = "index3"
        index3.Size = New Size(81, 72)
        index3.TabIndex = 13
        index3.TextAlign = HorizontalAlignment.Center
        ' 
        ' index2
        ' 
        index2.Location = New Point(431, 69)
        index2.Multiline = True
        index2.Name = "index2"
        index2.Size = New Size(81, 72)
        index2.TabIndex = 12
        index2.TextAlign = HorizontalAlignment.Center
        ' 
        ' index1
        ' 
        index1.Location = New Point(322, 69)
        index1.Multiline = True
        index1.Name = "index1"
        index1.Size = New Size(81, 72)
        index1.TabIndex = 11
        index1.TextAlign = HorizontalAlignment.Center
        ' 
        ' index0
        ' 
        index0.Location = New Point(215, 69)
        index0.Multiline = True
        index0.Name = "index0"
        index0.Size = New Size(81, 72)
        index0.TabIndex = 10
        index0.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(67, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(211, 34)
        Label1.TabIndex = 19
        Label1.Text = "SSA"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' F3
        ' 
        F3.Location = New Point(663, 212)
        F3.Name = "F3"
        F3.Size = New Size(100, 82)
        F3.TabIndex = 20
        F3.Text = "F3"
        F3.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(F3)
        Controls.Add(SSA3)
        Controls.Add(SSA2)
        Controls.Add(SSA1)
        Controls.Add(clear_button)
        Controls.Add(ok_button)
        Controls.Add(index3)
        Controls.Add(index2)
        Controls.Add(index1)
        Controls.Add(index0)
        Controls.Add(Label1)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SSA3 As Label
    Friend WithEvents SSA2 As Label
    Friend WithEvents SSA1 As Label
    Friend WithEvents clear_button As Button
    Friend WithEvents ok_button As Button
    Friend WithEvents index3 As TextBox
    Friend WithEvents index2 As TextBox
    Friend WithEvents index1 As TextBox
    Friend WithEvents index0 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents F3 As Button
End Class
