<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fMain))
        Me.pToolbar = New System.Windows.Forms.Panel()
        Me.bRefresh = New System.Windows.Forms.Button()
        Me.bHome = New System.Windows.Forms.Button()
        Me.bBookmark = New System.Windows.Forms.Button()
        Me.pBookmarks = New System.Windows.Forms.Panel()
        Me.lBookmarks = New System.Windows.Forms.Label()
        Me.cbBookmarks = New System.Windows.Forms.ComboBox()
        Me.bSearch = New System.Windows.Forms.Button()
        Me.pSearchBox = New System.Windows.Forms.Panel()
        Me.tbSearchox = New System.Windows.Forms.TextBox()
        Me.bForwards = New System.Windows.Forms.Button()
        Me.bBackwards = New System.Windows.Forms.Button()
        Me.wbMain = New System.Windows.Forms.WebBrowser()
        Me.pToolbar.SuspendLayout()
        Me.pBookmarks.SuspendLayout()
        Me.pSearchBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'pToolbar
        '
        Me.pToolbar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pToolbar.BackColor = System.Drawing.Color.Gainsboro
        Me.pToolbar.Controls.Add(Me.bRefresh)
        Me.pToolbar.Controls.Add(Me.bHome)
        Me.pToolbar.Controls.Add(Me.bBookmark)
        Me.pToolbar.Controls.Add(Me.pBookmarks)
        Me.pToolbar.Controls.Add(Me.bSearch)
        Me.pToolbar.Controls.Add(Me.pSearchBox)
        Me.pToolbar.Controls.Add(Me.bForwards)
        Me.pToolbar.Controls.Add(Me.bBackwards)
        Me.pToolbar.Location = New System.Drawing.Point(0, 0)
        Me.pToolbar.Name = "pToolbar"
        Me.pToolbar.Size = New System.Drawing.Size(1066, 48)
        Me.pToolbar.TabIndex = 0
        '
        'bRefresh
        '
        Me.bRefresh.BackgroundImage = Global.EO_Browser.My.Resources.Resources.icon_refresh
        Me.bRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bRefresh.Location = New System.Drawing.Point(130, 7)
        Me.bRefresh.Name = "bRefresh"
        Me.bRefresh.Size = New System.Drawing.Size(35, 35)
        Me.bRefresh.TabIndex = 7
        Me.bRefresh.UseVisualStyleBackColor = True
        '
        'bHome
        '
        Me.bHome.BackgroundImage = Global.EO_Browser.My.Resources.Resources.icon_browser
        Me.bHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bHome.Location = New System.Drawing.Point(89, 7)
        Me.bHome.Name = "bHome"
        Me.bHome.Size = New System.Drawing.Size(35, 35)
        Me.bHome.TabIndex = 6
        Me.bHome.UseVisualStyleBackColor = True
        '
        'bBookmark
        '
        Me.bBookmark.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bBookmark.BackgroundImage = Global.EO_Browser.My.Resources.Resources.icon_favourite
        Me.bBookmark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bBookmark.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bBookmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBookmark.Location = New System.Drawing.Point(806, 7)
        Me.bBookmark.Name = "bBookmark"
        Me.bBookmark.Size = New System.Drawing.Size(35, 35)
        Me.bBookmark.TabIndex = 4
        Me.bBookmark.UseVisualStyleBackColor = True
        '
        'pBookmarks
        '
        Me.pBookmarks.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pBookmarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pBookmarks.Controls.Add(Me.lBookmarks)
        Me.pBookmarks.Controls.Add(Me.cbBookmarks)
        Me.pBookmarks.Location = New System.Drawing.Point(847, 7)
        Me.pBookmarks.Name = "pBookmarks"
        Me.pBookmarks.Size = New System.Drawing.Size(212, 35)
        Me.pBookmarks.TabIndex = 2
        '
        'lBookmarks
        '
        Me.lBookmarks.AutoSize = True
        Me.lBookmarks.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lBookmarks.Location = New System.Drawing.Point(7, 9)
        Me.lBookmarks.Name = "lBookmarks"
        Me.lBookmarks.Size = New System.Drawing.Size(74, 16)
        Me.lBookmarks.TabIndex = 7
        Me.lBookmarks.Text = "Bookmarks"
        '
        'cbBookmarks
        '
        Me.cbBookmarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbBookmarks.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBookmarks.FormattingEnabled = True
        Me.cbBookmarks.Location = New System.Drawing.Point(86, 5)
        Me.cbBookmarks.Name = "cbBookmarks"
        Me.cbBookmarks.Size = New System.Drawing.Size(120, 24)
        Me.cbBookmarks.TabIndex = 6
        '
        'bSearch
        '
        Me.bSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bSearch.BackgroundImage = Global.EO_Browser.My.Resources.Resources.icon_search
        Me.bSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSearch.Location = New System.Drawing.Point(765, 7)
        Me.bSearch.Name = "bSearch"
        Me.bSearch.Size = New System.Drawing.Size(35, 35)
        Me.bSearch.TabIndex = 5
        Me.bSearch.UseVisualStyleBackColor = True
        '
        'pSearchBox
        '
        Me.pSearchBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pSearchBox.BackColor = System.Drawing.Color.White
        Me.pSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pSearchBox.Controls.Add(Me.tbSearchox)
        Me.pSearchBox.Location = New System.Drawing.Point(171, 7)
        Me.pSearchBox.Name = "pSearchBox"
        Me.pSearchBox.Size = New System.Drawing.Size(587, 35)
        Me.pSearchBox.TabIndex = 4
        '
        'tbSearchox
        '
        Me.tbSearchox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSearchox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbSearchox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSearchox.Location = New System.Drawing.Point(15, 8)
        Me.tbSearchox.Name = "tbSearchox"
        Me.tbSearchox.Size = New System.Drawing.Size(555, 19)
        Me.tbSearchox.TabIndex = 0
        '
        'bForwards
        '
        Me.bForwards.BackgroundImage = Global.EO_Browser.My.Resources.Resources.icon_forwards
        Me.bForwards.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bForwards.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bForwards.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bForwards.Location = New System.Drawing.Point(48, 7)
        Me.bForwards.Name = "bForwards"
        Me.bForwards.Size = New System.Drawing.Size(35, 35)
        Me.bForwards.TabIndex = 3
        Me.bForwards.UseVisualStyleBackColor = True
        '
        'bBackwards
        '
        Me.bBackwards.BackgroundImage = Global.EO_Browser.My.Resources.Resources.icon_backwards
        Me.bBackwards.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bBackwards.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bBackwards.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBackwards.Location = New System.Drawing.Point(7, 7)
        Me.bBackwards.Name = "bBackwards"
        Me.bBackwards.Size = New System.Drawing.Size(35, 35)
        Me.bBackwards.TabIndex = 2
        Me.bBackwards.UseVisualStyleBackColor = True
        '
        'wbMain
        '
        Me.wbMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wbMain.Location = New System.Drawing.Point(0, 49)
        Me.wbMain.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbMain.Name = "wbMain"
        Me.wbMain.Size = New System.Drawing.Size(1066, 485)
        Me.wbMain.TabIndex = 1
        Me.wbMain.Url = New System.Uri("", System.UriKind.Relative)
        '
        'fMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 536)
        Me.Controls.Add(Me.wbMain)
        Me.Controls.Add(Me.pToolbar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EO Browser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pToolbar.ResumeLayout(False)
        Me.pBookmarks.ResumeLayout(False)
        Me.pBookmarks.PerformLayout()
        Me.pSearchBox.ResumeLayout(False)
        Me.pSearchBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pToolbar As Panel
    Friend WithEvents wbMain As WebBrowser
    Friend WithEvents bBackwards As Button
    Friend WithEvents bForwards As Button
    Friend WithEvents pSearchBox As Panel
    Friend WithEvents tbSearchox As TextBox
    Friend WithEvents cbBookmarks As ComboBox
    Friend WithEvents bBookmark As Button
    Friend WithEvents bSearch As Button
    Friend WithEvents pBookmarks As Panel
    Friend WithEvents lBookmarks As Label
    Friend WithEvents bHome As Button
    Friend WithEvents bRefresh As Button
End Class
