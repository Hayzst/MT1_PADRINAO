<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        index0 = New TextBox()
        index1 = New TextBox()
        index2 = New TextBox()
        ISA_1 = New Label()
        ISAISA = New Label()
        F2 = New Button()
        OKbutton = New Button()
        ISA_2 = New Label()
        clearbutton = New Button()
        SuspendLayout()
        ' 
        ' index0
        ' 
        index0.Location = New Point(222, 66)
        index0.Multiline = True
        index0.Name = "index0"
        index0.Size = New Size(108, 74)
        index0.TabIndex = 0
        index0.TextAlign = HorizontalAlignment.Center
        ' 
        ' index1
        ' 
        index1.Location = New Point(347, 66)
        index1.Multiline = True
        index1.Name = "index1"
        index1.Size = New Size(108, 74)
        index1.TabIndex = 1
        index1.TextAlign = HorizontalAlignment.Center
        ' 
        ' index2
        ' 
        index2.Location = New Point(473, 66)
        index2.Multiline = True
        index2.Name = "index2"
        index2.Size = New Size(108, 74)
        index2.TabIndex = 2
        index2.TextAlign = HorizontalAlignment.Center
        ' 
        ' ISA_1
        ' 
        ISA_1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ISA_1.Location = New Point(320, 171)
        ISA_1.Name = "ISA_1"
        ISA_1.Size = New Size(170, 38)
        ISA_1.TabIndex = 4
        ISA_1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ISAISA
        ' 
        ISAISA.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ISAISA.Location = New Point(78, 85)
        ISAISA.Name = "ISAISA"
        ISAISA.Size = New Size(170, 38)
        ISAISA.TabIndex = 7
        ISAISA.Text = "ISA"
        ISAISA.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' F2
        ' 
        F2.Location = New Point(662, 198)
        F2.Name = "F2"
        F2.Size = New Size(100, 82)
        F2.TabIndex = 8
        F2.Text = "F2"
        F2.UseVisualStyleBackColor = True
        ' 
        ' OKbutton
        ' 
        OKbutton.Location = New Point(301, 321)
        OKbutton.Name = "OKbutton"
        OKbutton.Size = New Size(100, 82)
        OKbutton.TabIndex = 3
        OKbutton.Text = "OK"
        OKbutton.UseVisualStyleBackColor = True
        ' 
        ' ISA_2
        ' 
        ISA_2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ISA_2.Location = New Point(320, 218)
        ISA_2.Name = "ISA_2"
        ISA_2.Size = New Size(170, 38)
        ISA_2.TabIndex = 5
        ISA_2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' clearbutton
        ' 
        clearbutton.Location = New Point(436, 321)
        clearbutton.Name = "clearbutton"
        clearbutton.Size = New Size(100, 82)
        clearbutton.TabIndex = 6
        clearbutton.Text = "clear"
        clearbutton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(F2)
        Controls.Add(clearbutton)
        Controls.Add(ISA_2)
        Controls.Add(ISA_1)
        Controls.Add(OKbutton)
        Controls.Add(index2)
        Controls.Add(index1)
        Controls.Add(index0)
        Controls.Add(ISAISA)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents index0 As TextBox
    Friend WithEvents index1 As TextBox
    Friend WithEvents index2 As TextBox
    Friend WithEvents ISA_1 As Label
    Friend WithEvents ISAISA As Label
    Friend WithEvents F2 As Button
    Friend WithEvents OKbutton As Button
    Friend WithEvents ISA_2 As Label
    Friend WithEvents clearbutton As Button

End Class
