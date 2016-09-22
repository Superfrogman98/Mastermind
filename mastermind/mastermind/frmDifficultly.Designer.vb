<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDifficultly
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
        Me.btnNormal = New System.Windows.Forms.Button()
        Me.btnHard = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNormal
        '
        Me.btnNormal.Location = New System.Drawing.Point(12, 12)
        Me.btnNormal.Name = "btnNormal"
        Me.btnNormal.Size = New System.Drawing.Size(257, 56)
        Me.btnNormal.TabIndex = 0
        Me.btnNormal.Text = "Normal"
        Me.btnNormal.UseVisualStyleBackColor = True
        '
        'btnHard
        '
        Me.btnHard.Location = New System.Drawing.Point(12, 74)
        Me.btnHard.Name = "btnHard"
        Me.btnHard.Size = New System.Drawing.Size(257, 57)
        Me.btnHard.TabIndex = 1
        Me.btnHard.Text = "Hard"
        Me.btnHard.UseVisualStyleBackColor = True
        '
        'frmDifficultly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 145)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnHard)
        Me.Controls.Add(Me.btnNormal)
        Me.Name = "frmDifficultly"
        Me.Text = "Select Difficultly"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNormal As Button
    Friend WithEvents btnHard As Button
End Class
