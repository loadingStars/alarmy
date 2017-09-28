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
        Dim hour As String
        Dim minute As String
        Dim second As String

        hour = Now.Hour.ToString
        minute = Now.Minute.ToString
        second = Now.Second.ToString

        If hour.Length = 1 Then hour = "0" + hour
        If minute.Length = 1 Then minute = "0" + minute
        If second.Length = 1 Then second = "0" + second


        currentTime = hour + ":" + minute + ":" + second


        lblCurrentTime.Text = currentTime


    End Sub

    Private Sub loadFont()
        Dim digitalFont As New PrivateFontCollection


    End Sub
End Class
