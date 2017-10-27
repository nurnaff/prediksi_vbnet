Public Class Form1
    Private Sub JaringanBackpropagationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JaringanBackpropagationToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
    End Sub
    Private Sub HasilTrainingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HasilTrainingToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub
    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub
    Private Sub DataNormalisasiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataNormalisasiToolStripMenuItem.Click
        Me.Hide()
        Form4.Show()
    End Sub
    Private Sub ProsesPrediksiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProsesPrediksiToolStripMenuItem.Click
        Me.Hide()
        Form5.Show()
    End Sub
End Class
