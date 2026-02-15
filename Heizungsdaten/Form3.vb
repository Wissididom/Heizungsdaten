Public Class Form3
    Dim filename As String = Application.StartupPath & "\Data\Heizungsdaten.hde"

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If sender = Form1 Then
            öffnen()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub öffnen()
        Dim AllText As String = "", LineOfText As String = ""
        Try
            FileOpen(1, filename, OpenMode.Input)
            Do Until EOF(1)
                LineOfText = LineInput(1)
                AllText = AllText & LineOfText & vbCrLf
            Loop
            rtb.Text = AllText
        Catch
        Finally
            FileClose(1)
        End Try
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class