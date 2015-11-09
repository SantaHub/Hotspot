Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("runas /user:administrator""C:\Windows\System32\cmd.exe / k netsh wlan start hostednetwork ssid=" + "myHoty" + " key=" + "cooolcool" + "  && netsh wlan start hostednetwork && netsh wlan show hostednetwork")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell("cmd.exe /k netsh wlan stop hostednetwork && netsh wlan show hostednetwork")
    End Sub
End Class
