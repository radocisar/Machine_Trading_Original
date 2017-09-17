Public Class Form1
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click

        Dim scrn As Screen

        Dim screens() As Screen

        screens = Screen.AllScreens

        For Each scrn In screens

            Debug.Print(scrn.DeviceName)

        Next

    End Sub
End Class
