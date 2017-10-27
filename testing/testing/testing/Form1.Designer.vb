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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.HasilTrainingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataTrainingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataNormalisasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProsesPrediksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HasilTrainingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.DataTrainingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.DataNormalisasiToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.HasilPrediksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.JaringanBackpropagationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HasilTrainingToolStripMenuItem, Me.DataTrainingToolStripMenuItem, Me.DataNormalisasiToolStripMenuItem, Me.ProsesPrediksiToolStripMenuItem, Me.LToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(551, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HasilTrainingToolStripMenuItem
        '
        Me.HasilTrainingToolStripMenuItem.Name = "HasilTrainingToolStripMenuItem"
        Me.HasilTrainingToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.HasilTrainingToolStripMenuItem.Text = "Hasil Training"
        '
        'DataTrainingToolStripMenuItem
        '
        Me.DataTrainingToolStripMenuItem.Name = "DataTrainingToolStripMenuItem"
        Me.DataTrainingToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.DataTrainingToolStripMenuItem.Text = "Data Training"
        '
        'DataNormalisasiToolStripMenuItem
        '
        Me.DataNormalisasiToolStripMenuItem.Name = "DataNormalisasiToolStripMenuItem"
        Me.DataNormalisasiToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.DataNormalisasiToolStripMenuItem.Text = "Data Normalisasi"
        '
        'ProsesPrediksiToolStripMenuItem
        '
        Me.ProsesPrediksiToolStripMenuItem.Name = "ProsesPrediksiToolStripMenuItem"
        Me.ProsesPrediksiToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.ProsesPrediksiToolStripMenuItem.Text = "Proses Prediksi"
        '
        'LToolStripMenuItem
        '
        Me.LToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HasilTrainingToolStripMenuItem1, Me.DataTrainingToolStripMenuItem1, Me.DataNormalisasiToolStripMenuItem1, Me.HasilPrediksiToolStripMenuItem, Me.JaringanBackpropagationToolStripMenuItem})
        Me.LToolStripMenuItem.Name = "LToolStripMenuItem"
        Me.LToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LToolStripMenuItem.Text = "Laporan"
        '
        'HasilTrainingToolStripMenuItem1
        '
        Me.HasilTrainingToolStripMenuItem1.Name = "HasilTrainingToolStripMenuItem1"
        Me.HasilTrainingToolStripMenuItem1.Size = New System.Drawing.Size(211, 22)
        Me.HasilTrainingToolStripMenuItem1.Text = "Hasil Training"
        '
        'DataTrainingToolStripMenuItem1
        '
        Me.DataTrainingToolStripMenuItem1.Name = "DataTrainingToolStripMenuItem1"
        Me.DataTrainingToolStripMenuItem1.Size = New System.Drawing.Size(211, 22)
        Me.DataTrainingToolStripMenuItem1.Text = "Data Training"
        '
        'DataNormalisasiToolStripMenuItem1
        '
        Me.DataNormalisasiToolStripMenuItem1.Name = "DataNormalisasiToolStripMenuItem1"
        Me.DataNormalisasiToolStripMenuItem1.Size = New System.Drawing.Size(211, 22)
        Me.DataNormalisasiToolStripMenuItem1.Text = "Data Normalisasi"
        '
        'HasilPrediksiToolStripMenuItem
        '
        Me.HasilPrediksiToolStripMenuItem.Name = "HasilPrediksiToolStripMenuItem"
        Me.HasilPrediksiToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.HasilPrediksiToolStripMenuItem.Text = "Hasil Prediksi"
        '
        'JaringanBackpropagationToolStripMenuItem
        '
        Me.JaringanBackpropagationToolStripMenuItem.Name = "JaringanBackpropagationToolStripMenuItem"
        Me.JaringanBackpropagationToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.JaringanBackpropagationToolStripMenuItem.Text = "Jaringan Backpropagation"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 287)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HasilTrainingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataTrainingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataNormalisasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProsesPrediksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HasilTrainingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataTrainingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataNormalisasiToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HasilPrediksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JaringanBackpropagationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
