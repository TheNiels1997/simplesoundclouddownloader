Public Class Colors
    Public Shared Property SoundCloudOrange As Color = Color.FromArgb(255, 136, 0)
    Public Shared Property LightBlack As Color = Color.FromArgb(22, 21, 28)
    Public Shared Property Black As Color = Color.FromArgb(8, 8, 11)
    Public Shared Property SlightlyGray As Color = Color.FromArgb(154, 154, 134)
    Public Shared Property DarkerGray As Color = Color.FromArgb(75, 75, 76)

    Public Shared Function Darken(ByVal color As Color) As Color
        Dim r As Integer = color.R - 45
        Dim g As Integer = color.G - 45
        Dim b As Integer = color.B - 45

        If r < 0 Then
            r = color.R
        End If

        If g < 0 Then
            g = color.G
        End If

        If b < 0 Then
            b = color.B
        End If

        Return Color.FromArgb(r, g, b)
    End Function

    Public Shared Function Brighten(ByVal color As Color) As Color
        Dim r As Integer = color.R + 45
        Dim g As Integer = color.G + 45
        Dim b As Integer = color.B + 45

        If r > 255 Then
            r = color.R
        End If

        If g > 255 Then
            g = color.G
        End If

        If b > 255 Then
            b = color.B
        End If

        Return Color.FromArgb(r, g, b)
    End Function
End Class
