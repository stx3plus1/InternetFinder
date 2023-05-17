Public Class main

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewTab()
    End Sub

    Public Sub NewTab()
        Dim t As New TabPage
        Dim newtab As New page
        newtab.Show()
        newtab.Anchor = AnchorStyles.Top
        newtab.Dock = DockStyle.Fill
        newtab.TopLevel = False
        t.Controls.Add(newtab)
        TabControl1.TabPages.Add(t)
        TabControl1.SelectTab(t)
    End Sub

    Public Sub CloseTab()
        TabControl1.TabPages.Remove(TabControl1.SelectedTab)
    End Sub
End Class