<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainform
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
        Me.components = New System.ComponentModel.Container()
        Me.FlatButton3 = New Simple_SoundCloud_Downloader.FlatButton()
        Me.FlatButton2 = New Simple_SoundCloud_Downloader.FlatButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tWatcher = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FlatButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray
        Me.FlatButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.FlatButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.FlatButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FlatButton3.Image = Global.Simple_SoundCloud_Downloader.My.Resources.Resources.close
        Me.FlatButton3.Location = New System.Drawing.Point(141, 11)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Size = New System.Drawing.Size(48, 48)
        Me.FlatButton3.TabIndex = 3
        Me.FlatButton3.UseVisualStyleBackColor = False
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FlatButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray
        Me.FlatButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.FlatButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.FlatButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FlatButton2.Image = Global.Simple_SoundCloud_Downloader.My.Resources.Resources.settings
        Me.FlatButton2.Location = New System.Drawing.Point(76, 11)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Size = New System.Drawing.Size(48, 48)
        Me.FlatButton2.TabIndex = 2
        Me.FlatButton2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Simple_SoundCloud_Downloader.My.Resources.Resources.soundcloud
        Me.PictureBox1.Location = New System.Drawing.Point(13, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'tWatcher
        '
        Me.tWatcher.Enabled = True
        '
        'mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(201, 70)
        Me.Controls.Add(Me.FlatButton3)
        Me.Controls.Add(Me.FlatButton2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mainform"
        Me.Text = "Form1"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FlatButton2 As FlatButton
    Friend WithEvents FlatButton3 As FlatButton
    Friend WithEvents tWatcher As Timer
End Class
