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
        btnCalc = New Button()
        txtFirst = New TextBox()
        txtSecond = New TextBox()
        cmb1 = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        lblResult = New Label()
        lblAnswer = New Label()
        SuspendLayout()
        ' 
        ' btnCalc
        ' 
        btnCalc.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        btnCalc.Location = New Point(89, 212)
        btnCalc.Name = "btnCalc"
        btnCalc.Size = New Size(247, 143)
        btnCalc.TabIndex = 0
        btnCalc.Text = "Calculate"
        btnCalc.UseVisualStyleBackColor = True
        ' 
        ' txtFirst
        ' 
        txtFirst.Location = New Point(53, 145)
        txtFirst.Name = "txtFirst"
        txtFirst.Size = New Size(100, 23)
        txtFirst.TabIndex = 1
        ' 
        ' txtSecond
        ' 
        txtSecond.Location = New Point(276, 145)
        txtSecond.Name = "txtSecond"
        txtSecond.Size = New Size(100, 23)
        txtSecond.TabIndex = 2
        ' 
        ' cmb1
        ' 
        cmb1.FormattingEnabled = True
        cmb1.Items.AddRange(New Object() {"+", "-", "*", "/"})
        cmb1.Location = New Point(191, 145)
        cmb1.Name = "cmb1"
        cmb1.Size = New Size(39, 23)
        cmb1.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(76, 120)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 15)
        Label1.TabIndex = 4
        Label1.Text = "Input 1:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(302, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 15)
        Label2.TabIndex = 5
        Label2.Text = "Input 2:"
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.BackColor = SystemColors.ControlLightLight
        lblResult.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblResult.Location = New Point(155, 56)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(0, 50)
        lblResult.TabIndex = 6
        ' 
        ' lblAnswer
        ' 
        lblAnswer.AutoSize = True
        lblAnswer.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lblAnswer.Location = New Point(53, 56)
        lblAnswer.Name = "lblAnswer"
        lblAnswer.Size = New Size(96, 32)
        lblAnswer.TabIndex = 7
        lblAnswer.Text = "Answer:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(424, 410)
        Controls.Add(lblAnswer)
        Controls.Add(lblResult)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cmb1)
        Controls.Add(txtSecond)
        Controls.Add(txtFirst)
        Controls.Add(btnCalc)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCalc As Button
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtSecond As TextBox
    Friend WithEvents cmb1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents lblAnswer As Label
End Class
