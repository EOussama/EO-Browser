<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fSplash
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
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.lSlogan = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbLogo
        '
        Me.pbLogo.Image = Global.EO_Browser.My.Resources.Resources.icon_browser
        Me.pbLogo.Location = New System.Drawing.Point(12, 12)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(202, 150)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogo.TabIndex = 0
        Me.pbLogo.TabStop = False
        '
        'lSlogan
        '
        Me.lSlogan.AutoSize = True
        Me.lSlogan.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lSlogan.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lSlogan.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lSlogan.Location = New System.Drawing.Point(229, 12)
        Me.lSlogan.Name = "lSlogan"
        Me.lSlogan.Size = New System.Drawing.Size(179, 34)
        Me.lSlogan.TabIndex = 1
        Me.lSlogan.Text = "EO Browser"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(232, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 52)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Made by Eoussama a.k.a Compton" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "on 4/8/2018, just an experimental" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "project servin" &
    "g as my first ever written" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in Visual basic."
        '
        'fSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(420, 255)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lSlogan)
        Me.Controls.Add(Me.pbLogo)
        Me.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fSplash"
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents lSlogan As Label
    Friend WithEvents Label1 As Label
End Class
