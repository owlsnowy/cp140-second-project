<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblJoke = New System.Windows.Forms.Label()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.btnPunch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblJoke
        '
        Me.lblJoke.AutoSize = True
        Me.lblJoke.Location = New System.Drawing.Point(12, 29)
        Me.lblJoke.Name = "lblJoke"
        Me.lblJoke.Size = New System.Drawing.Size(0, 13)
        Me.lblJoke.TabIndex = 0
        '
        'btnSet
        '
        Me.btnSet.Location = New System.Drawing.Point(15, 64)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(75, 23)
        Me.btnSet.TabIndex = 1
        Me.btnSet.Text = "Setup"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'btnPunch
        '
        Me.btnPunch.Location = New System.Drawing.Point(262, 64)
        Me.btnPunch.Name = "btnPunch"
        Me.btnPunch.Size = New System.Drawing.Size(75, 23)
        Me.btnPunch.TabIndex = 2
        Me.btnPunch.Text = "Punchline"
        Me.btnPunch.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 114)
        Me.Controls.Add(Me.btnPunch)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.lblJoke)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblJoke As System.Windows.Forms.Label
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents btnPunch As System.Windows.Forms.Button

End Class
