'Hello and welcom to Alarmy
'a very simple alarm clock
'for your desktop :)

Imports System.Drawing.Text


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadFont()
        Timer1.Enabled = True




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim currentTime As String
        currentTime = Now.Hour.ToString + ":" + Now.Minute.ToString + ":" + Now.Second.ToString


        lblCurrentTime.Text = currentTime


    End Sub

    Private Sub loadFont()
        Dim digitalFont As New PrivateFontCollection


    End Sub
End Class
