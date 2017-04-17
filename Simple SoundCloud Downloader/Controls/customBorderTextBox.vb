Public Class customBorderTextBox
    Inherits UserControl

    Dim _txt As MaskedTextBox
    Public Property Content As String
        Get
            Return _txt.Text
        End Get
        Set(value As String)
            _txt.Text = value
        End Set
    End Property

    Dim _userSystemChar As Boolean
    Public Property UseSystemChar As Boolean
        Get
            Return _txt.UseSystemPasswordChar
        End Get
        Set(value As Boolean)
            _txt.UseSystemPasswordChar = value
        End Set
    End Property

    Public Sub New()
        Me.Padding = New Padding(5)
        Me.BackColor = Colors.LightBlack
        Me.DoubleBuffered = True

        _txt = New MaskedTextBox
        _txt.AutoSize = False
        _txt.Dock = DockStyle.Fill
        _txt.BorderStyle = BorderStyle.None
        _txt.Margin = Padding.Empty
        _txt.Padding = Padding.Empty
        _txt.Text = "Sample text"
        _txt.BackColor = Colors.LightBlack
        _txt.ForeColor = Colors.SlightlyGray
        _txt.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        Me.Controls.Add(_txt)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim rect As Rectangle = Me.ClientRectangle
        Dim g As Graphics = e.Graphics

        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic

        rect.Width -= 1
        rect.Height -= 1

        Using p As New Pen(Colors.DarkerGray, 1)
            g.DrawRectangle(p, rect)
        End Using
    End Sub
End Class
