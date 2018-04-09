Public Class fMain
    Dim bookmarks As New ArrayList

    Private Sub fMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bookmarks.AddRange(My.Settings.bookmarks.Split())

        For i = 0 To bookmarks.Count - 1
            If bookmarks(i) IsNot "" Then
                cbBookmarks.Items.Add(bookmarks(i))
            End If

        Next

        wbMain.GoHome()
    End Sub

    Private Sub tbSearchox_KeyDown(sender As Object, e As KeyEventArgs) Handles tbSearchox.KeyDown
        If e.KeyValue = Keys.Return Then
            Call Navigate(tbSearchox.Text)
        End If
    End Sub

    Private Sub bSearch_Click(sender As Object, e As EventArgs) Handles bSearch.Click
        Call Navigate(tbSearchox.Text)
    End Sub

    Private Sub bBackwards_Click(sender As Object, e As EventArgs) Handles bBackwards.Click
        wbMain.GoBack()
    End Sub

    Private Sub bForwards_Click(sender As Object, e As EventArgs) Handles bForwards.Click
        wbMain.GoForward()
    End Sub

    Private Sub bHome_Click(sender As Object, e As EventArgs) Handles bHome.Click
        wbMain.GoHome()
    End Sub

    Private Sub Navigate(uri As String)
        wbMain.Navigate(uri)
    End Sub

    Private Sub bBookmark_Click(sender As Object, e As EventArgs) Handles bBookmark.Click
        If cbBookmarks.Items.Contains(tbSearchox.Text) = False Then
            cbBookmarks.Items.Add(tbSearchox.Text)
            cbBookmarks.SelectedIndex = cbBookmarks.Items.Count - 1

            bookmarks.Add(cbBookmarks.Text)
        Else
            cbBookmarks.Text = ""
            bookmarks.Remove(tbSearchox.Text)
            cbBookmarks.Items.Remove(tbSearchox.Text)
        End If
    End Sub

    Private Sub bRefresh_Click(sender As Object, e As EventArgs) Handles bRefresh.Click
        wbMain.Refresh()
    End Sub

    Private Sub wbMain_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles wbMain.Navigated
        tbSearchox.Text = wbMain.Url.ToString()
    End Sub

    Private Sub cbBookmarks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBookmarks.SelectedIndexChanged
        wbMain.Navigate(cbBookmarks.Text)
    End Sub

    Private Sub fMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim data As String = ""

        For i = 0 To bookmarks.Count - 1
            data += bookmarks(i) + " "
        Next

        My.Settings.bookmarks = Data
        My.Settings.Save()
    End Sub
End Class
