<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectColor
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
        Me.btnYellow = New System.Windows.Forms.Button()
        Me.btnGreen = New System.Windows.Forms.Button()
        Me.btnBlue = New System.Windows.Forms.Button()
        Me.btnAqua = New System.Windows.Forms.Button()
        Me.btnRed = New System.Windows.Forms.Button()
        Me.btnSilver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnYellow
        '
        Me.btnYellow.BackColor = System.Drawing.Color.Yellow
        Me.btnYellow.Location = New System.Drawing.Point(1, 12)
        Me.btnYellow.Name = "btnYellow"
        Me.btnYellow.Size = New System.Drawing.Size(56, 23)
        Me.btnYellow.TabIndex = 0
        Me.btnYellow.UseVisualStyleBackColor = False
        '
        'btnGreen
        '
        Me.btnGreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGreen.Location = New System.Drawing.Point(1, 62)
        Me.btnGreen.Name = "btnGreen"
        Me.btnGreen.Size = New System.Drawing.Size(56, 23)
        Me.btnGreen.TabIndex = 1
        Me.btnGreen.UseVisualStyleBackColor = False
        '
        'btnBlue
        '
        Me.btnBlue.BackColor = System.Drawing.Color.Blue
        Me.btnBlue.Location = New System.Drawing.Point(1, 112)
        Me.btnBlue.Name = "btnBlue"
        Me.btnBlue.Size = New System.Drawing.Size(56, 23)
        Me.btnBlue.TabIndex = 2
        Me.btnBlue.UseVisualStyleBackColor = False
        '
        'btnAqua
        '
        Me.btnAqua.BackColor = System.Drawing.Color.Aqua
        Me.btnAqua.Location = New System.Drawing.Point(1, 37)
        Me.btnAqua.Name = "btnAqua"
        Me.btnAqua.Size = New System.Drawing.Size(56, 23)
        Me.btnAqua.TabIndex = 3
        Me.btnAqua.UseVisualStyleBackColor = False
        '
        'btnRed
        '
        Me.btnRed.BackColor = System.Drawing.Color.Red
        Me.btnRed.Location = New System.Drawing.Point(1, 87)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(56, 23)
        Me.btnRed.TabIndex = 4
        Me.btnRed.UseVisualStyleBackColor = False
        '
        'btnSilver
        '
        Me.btnSilver.BackColor = System.Drawing.Color.Silver
        Me.btnSilver.Location = New System.Drawing.Point(1, 137)
        Me.btnSilver.Name = "btnSilver"
        Me.btnSilver.Size = New System.Drawing.Size(56, 23)
        Me.btnSilver.TabIndex = 5
        Me.btnSilver.UseVisualStyleBackColor = False
        '
        'frmSelectColor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(60, 169)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSilver)
        Me.Controls.Add(Me.btnRed)
        Me.Controls.Add(Me.btnAqua)
        Me.Controls.Add(Me.btnBlue)
        Me.Controls.Add(Me.btnGreen)
        Me.Controls.Add(Me.btnYellow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(100, 0)
        Me.MaximumSize = New System.Drawing.Size(60, 169)
        Me.MinimumSize = New System.Drawing.Size(60, 169)
        Me.Name = "frmSelectColor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Select Color"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnYellow As Button
    Friend WithEvents btnGreen As Button
    Friend WithEvents btnBlue As Button
    Friend WithEvents btnAqua As Button
    Friend WithEvents btnRed As Button
    Friend WithEvents btnSilver As Button
End Class
