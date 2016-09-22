<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMastermind
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvPlayer = New System.Windows.Forms.DataGridView()
        Me.colColor1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colColor2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colColor3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colColor4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.lblPerfect0 = New System.Windows.Forms.Label()
        Me.lblColor0 = New System.Windows.Forms.Label()
        Me.lblColor1 = New System.Windows.Forms.Label()
        Me.lblPerfect1 = New System.Windows.Forms.Label()
        Me.lblColor2 = New System.Windows.Forms.Label()
        Me.lblPerfect2 = New System.Windows.Forms.Label()
        Me.lblColor3 = New System.Windows.Forms.Label()
        Me.lblPerfect3 = New System.Windows.Forms.Label()
        Me.lblColor4 = New System.Windows.Forms.Label()
        Me.lblPerfect4 = New System.Windows.Forms.Label()
        Me.lblColor5 = New System.Windows.Forms.Label()
        Me.lblPerfect5 = New System.Windows.Forms.Label()
        Me.lblColor6 = New System.Windows.Forms.Label()
        Me.lblPerfect6 = New System.Windows.Forms.Label()
        Me.lblColor7 = New System.Windows.Forms.Label()
        Me.lblPerfect7 = New System.Windows.Forms.Label()
        Me.lblColor8 = New System.Windows.Forms.Label()
        Me.lblPerfect8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWins = New System.Windows.Forms.Label()
        Me.lblLoses = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(445, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.NewGameToolStripMenuItem.Text = "New Game"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'dgvPlayer
        '
        Me.dgvPlayer.AllowUserToResizeColumns = False
        Me.dgvPlayer.AllowUserToResizeRows = False
        Me.dgvPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlayer.ColumnHeadersVisible = False
        Me.dgvPlayer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colColor1, Me.colColor2, Me.colColor3, Me.colColor4})
        Me.dgvPlayer.Cursor = System.Windows.Forms.Cursors.Cross
        Me.dgvPlayer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPlayer.EnableHeadersVisualStyles = False
        Me.dgvPlayer.Location = New System.Drawing.Point(12, 27)
        Me.dgvPlayer.MultiSelect = False
        Me.dgvPlayer.Name = "dgvPlayer"
        Me.dgvPlayer.ReadOnly = True
        Me.dgvPlayer.RowHeadersVisible = False
        Me.dgvPlayer.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvPlayer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvPlayer.ShowEditingIcon = False
        Me.dgvPlayer.Size = New System.Drawing.Size(243, 540)
        Me.dgvPlayer.TabIndex = 1
        '
        'colColor1
        '
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.colColor1.DefaultCellStyle = DataGridViewCellStyle2
        Me.colColor1.HeaderText = "Color 1"
        Me.colColor1.Name = "colColor1"
        Me.colColor1.ReadOnly = True
        Me.colColor1.Width = 60
        '
        'colColor2
        '
        Me.colColor2.HeaderText = "Color 2"
        Me.colColor2.Name = "colColor2"
        Me.colColor2.ReadOnly = True
        Me.colColor2.Width = 60
        '
        'colColor3
        '
        Me.colColor3.HeaderText = "Color3"
        Me.colColor3.Name = "colColor3"
        Me.colColor3.ReadOnly = True
        Me.colColor3.Width = 60
        '
        'colColor4
        '
        Me.colColor4.HeaderText = "Color 4"
        Me.colColor4.Name = "colColor4"
        Me.colColor4.ReadOnly = True
        Me.colColor4.Width = 60
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(261, 27)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 60)
        Me.btnCheck.TabIndex = 2
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'lblPerfect0
        '
        Me.lblPerfect0.AutoSize = True
        Me.lblPerfect0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerfect0.Location = New System.Drawing.Point(261, 27)
        Me.lblPerfect0.Name = "lblPerfect0"
        Me.lblPerfect0.Size = New System.Drawing.Size(0, 20)
        Me.lblPerfect0.TabIndex = 3
        '
        'lblColor0
        '
        Me.lblColor0.AutoSize = True
        Me.lblColor0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor0.ForeColor = System.Drawing.Color.Blue
        Me.lblColor0.Location = New System.Drawing.Point(261, 56)
        Me.lblColor0.Name = "lblColor0"
        Me.lblColor0.Size = New System.Drawing.Size(0, 20)
        Me.lblColor0.TabIndex = 4
        '
        'lblColor1
        '
        Me.lblColor1.AutoSize = True
        Me.lblColor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor1.ForeColor = System.Drawing.Color.Blue
        Me.lblColor1.Location = New System.Drawing.Point(261, 119)
        Me.lblColor1.Name = "lblColor1"
        Me.lblColor1.Size = New System.Drawing.Size(0, 20)
        Me.lblColor1.TabIndex = 6
        '
        'lblPerfect1
        '
        Me.lblPerfect1.AutoSize = True
        Me.lblPerfect1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerfect1.Location = New System.Drawing.Point(261, 90)
        Me.lblPerfect1.Name = "lblPerfect1"
        Me.lblPerfect1.Size = New System.Drawing.Size(0, 20)
        Me.lblPerfect1.TabIndex = 5
        '
        'lblColor2
        '
        Me.lblColor2.AutoSize = True
        Me.lblColor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor2.ForeColor = System.Drawing.Color.Blue
        Me.lblColor2.Location = New System.Drawing.Point(261, 179)
        Me.lblColor2.Name = "lblColor2"
        Me.lblColor2.Size = New System.Drawing.Size(0, 20)
        Me.lblColor2.TabIndex = 8
        '
        'lblPerfect2
        '
        Me.lblPerfect2.AutoSize = True
        Me.lblPerfect2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerfect2.Location = New System.Drawing.Point(261, 150)
        Me.lblPerfect2.Name = "lblPerfect2"
        Me.lblPerfect2.Size = New System.Drawing.Size(0, 20)
        Me.lblPerfect2.TabIndex = 7
        '
        'lblColor3
        '
        Me.lblColor3.AutoSize = True
        Me.lblColor3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor3.ForeColor = System.Drawing.Color.Blue
        Me.lblColor3.Location = New System.Drawing.Point(261, 236)
        Me.lblColor3.Name = "lblColor3"
        Me.lblColor3.Size = New System.Drawing.Size(0, 20)
        Me.lblColor3.TabIndex = 10
        '
        'lblPerfect3
        '
        Me.lblPerfect3.AutoSize = True
        Me.lblPerfect3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerfect3.Location = New System.Drawing.Point(261, 207)
        Me.lblPerfect3.Name = "lblPerfect3"
        Me.lblPerfect3.Size = New System.Drawing.Size(0, 20)
        Me.lblPerfect3.TabIndex = 9
        '
        'lblColor4
        '
        Me.lblColor4.AutoSize = True
        Me.lblColor4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor4.ForeColor = System.Drawing.Color.Blue
        Me.lblColor4.Location = New System.Drawing.Point(261, 296)
        Me.lblColor4.Name = "lblColor4"
        Me.lblColor4.Size = New System.Drawing.Size(0, 20)
        Me.lblColor4.TabIndex = 12
        '
        'lblPerfect4
        '
        Me.lblPerfect4.AutoSize = True
        Me.lblPerfect4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerfect4.Location = New System.Drawing.Point(261, 267)
        Me.lblPerfect4.Name = "lblPerfect4"
        Me.lblPerfect4.Size = New System.Drawing.Size(0, 20)
        Me.lblPerfect4.TabIndex = 11
        '
        'lblColor5
        '
        Me.lblColor5.AutoSize = True
        Me.lblColor5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor5.ForeColor = System.Drawing.Color.Blue
        Me.lblColor5.Location = New System.Drawing.Point(261, 356)
        Me.lblColor5.Name = "lblColor5"
        Me.lblColor5.Size = New System.Drawing.Size(0, 20)
        Me.lblColor5.TabIndex = 14
        '
        'lblPerfect5
        '
        Me.lblPerfect5.AutoSize = True
        Me.lblPerfect5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerfect5.Location = New System.Drawing.Point(261, 327)
        Me.lblPerfect5.Name = "lblPerfect5"
        Me.lblPerfect5.Size = New System.Drawing.Size(0, 20)
        Me.lblPerfect5.TabIndex = 13
        '
        'lblColor6
        '
        Me.lblColor6.AutoSize = True
        Me.lblColor6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor6.ForeColor = System.Drawing.Color.Blue
        Me.lblColor6.Location = New System.Drawing.Point(261, 416)
        Me.lblColor6.Name = "lblColor6"
        Me.lblColor6.Size = New System.Drawing.Size(0, 20)
        Me.lblColor6.TabIndex = 16
        '
        'lblPerfect6
        '
        Me.lblPerfect6.AutoSize = True
        Me.lblPerfect6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerfect6.Location = New System.Drawing.Point(261, 387)
        Me.lblPerfect6.Name = "lblPerfect6"
        Me.lblPerfect6.Size = New System.Drawing.Size(0, 20)
        Me.lblPerfect6.TabIndex = 15
        '
        'lblColor7
        '
        Me.lblColor7.AutoSize = True
        Me.lblColor7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor7.ForeColor = System.Drawing.Color.Blue
        Me.lblColor7.Location = New System.Drawing.Point(261, 476)
        Me.lblColor7.Name = "lblColor7"
        Me.lblColor7.Size = New System.Drawing.Size(0, 20)
        Me.lblColor7.TabIndex = 18
        '
        'lblPerfect7
        '
        Me.lblPerfect7.AutoSize = True
        Me.lblPerfect7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerfect7.Location = New System.Drawing.Point(261, 447)
        Me.lblPerfect7.Name = "lblPerfect7"
        Me.lblPerfect7.Size = New System.Drawing.Size(0, 20)
        Me.lblPerfect7.TabIndex = 17
        '
        'lblColor8
        '
        Me.lblColor8.AutoSize = True
        Me.lblColor8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor8.ForeColor = System.Drawing.Color.Blue
        Me.lblColor8.Location = New System.Drawing.Point(261, 536)
        Me.lblColor8.Name = "lblColor8"
        Me.lblColor8.Size = New System.Drawing.Size(0, 20)
        Me.lblColor8.TabIndex = 20
        '
        'lblPerfect8
        '
        Me.lblPerfect8.AutoSize = True
        Me.lblPerfect8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerfect8.Location = New System.Drawing.Point(261, 507)
        Me.lblPerfect8.Name = "lblPerfect8"
        Me.lblPerfect8.Size = New System.Drawing.Size(0, 20)
        Me.lblPerfect8.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(342, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Score"
        '
        'lblWins
        '
        Me.lblWins.AutoSize = True
        Me.lblWins.Location = New System.Drawing.Point(343, 40)
        Me.lblWins.Name = "lblWins"
        Me.lblWins.Size = New System.Drawing.Size(34, 13)
        Me.lblWins.TabIndex = 22
        Me.lblWins.Text = "Wins:"
        '
        'lblLoses
        '
        Me.lblLoses.AutoSize = True
        Me.lblLoses.Location = New System.Drawing.Point(343, 56)
        Me.lblLoses.Name = "lblLoses"
        Me.lblLoses.Size = New System.Drawing.Size(41, 13)
        Me.lblLoses.TabIndex = 23
        Me.lblLoses.Text = "Loses: "
        '
        'frmMastermind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 573)
        Me.Controls.Add(Me.lblLoses)
        Me.Controls.Add(Me.lblWins)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.lblColor8)
        Me.Controls.Add(Me.lblPerfect8)
        Me.Controls.Add(Me.lblColor7)
        Me.Controls.Add(Me.lblPerfect7)
        Me.Controls.Add(Me.lblColor6)
        Me.Controls.Add(Me.lblPerfect6)
        Me.Controls.Add(Me.lblColor5)
        Me.Controls.Add(Me.lblPerfect5)
        Me.Controls.Add(Me.lblColor4)
        Me.Controls.Add(Me.lblPerfect4)
        Me.Controls.Add(Me.lblColor3)
        Me.Controls.Add(Me.lblPerfect3)
        Me.Controls.Add(Me.lblColor2)
        Me.Controls.Add(Me.lblPerfect2)
        Me.Controls.Add(Me.lblColor1)
        Me.Controls.Add(Me.lblPerfect1)
        Me.Controls.Add(Me.lblColor0)
        Me.Controls.Add(Me.lblPerfect0)
        Me.Controls.Add(Me.dgvPlayer)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMastermind"
        Me.Text = "MasterMind"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NewGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvPlayer As DataGridView
    Friend WithEvents btnCheck As Button
    Friend WithEvents colColor4 As DataGridViewTextBoxColumn
    Friend WithEvents colColor3 As DataGridViewTextBoxColumn
    Friend WithEvents colColor2 As DataGridViewTextBoxColumn
    Friend WithEvents colColor1 As DataGridViewTextBoxColumn
    Friend WithEvents lblPerfect0 As Label
    Friend WithEvents lblColor0 As Label
    Friend WithEvents lblColor1 As Label
    Friend WithEvents lblPerfect1 As Label
    Friend WithEvents lblColor2 As Label
    Friend WithEvents lblPerfect2 As Label
    Friend WithEvents lblColor3 As Label
    Friend WithEvents lblPerfect3 As Label
    Friend WithEvents lblColor4 As Label
    Friend WithEvents lblPerfect4 As Label
    Friend WithEvents lblColor5 As Label
    Friend WithEvents lblPerfect5 As Label
    Friend WithEvents lblColor6 As Label
    Friend WithEvents lblPerfect6 As Label
    Friend WithEvents lblColor7 As Label
    Friend WithEvents lblPerfect7 As Label
    Friend WithEvents lblColor8 As Label
    Friend WithEvents lblPerfect8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblWins As Label
    Friend WithEvents lblLoses As Label
End Class
