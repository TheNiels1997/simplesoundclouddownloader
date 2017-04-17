Public Class FlatButton
    Inherits Button

    Public Sub New()
        Me.Size = New Size(80, 30)
        Me.FlatStyle = FlatStyle.Flat
        Me.BackColor = Color.WhiteSmoke
        Me.Font = SystemFonts.IconTitleFont

        With Me.FlatAppearance
            .CheckedBackColor = Color.DimGray
            .MouseDownBackColor = Color.DimGray
            .MouseOverBackColor = Color.LightGray
        End With
    End Sub

    Public Overloads Sub NotifyDefault(value As Boolean)
        MyBase.NotifyDefault(False)
    End Sub
End Class
