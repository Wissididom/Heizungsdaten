Imports System.IO
Imports System.Windows.Forms

Public Class Form2
    Dim filename As String = Path.Combine(Application.StartupPath, "Data", "Heizungsdaten.hde")
    Dim filenameExcel As String = Path.Combine(Application.StartupPath, "Data", "Heizungsdaten_Excelimport.txt")
    Dim dataPath As String = Path.Combine(Application.StartupPath, "Data")

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Btn_OK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Speichern()
        Me.Close()
        Dim f1 = New Form1()
        f1.Close()
    End Sub

    Sub Speichern()
        If Not Directory.Exists(dataPath) Then
            Directory.CreateDirectory(dataPath)
        End If
        Try
            rtb.SaveFile(filename, RichTextBoxStreamType.PlainText)
            rtbExcel.SaveFile(filenameExcel, RichTextBoxStreamType.PlainText)
        Catch ex As Exception
            MsgBox("Fehler beim Speichern", MsgBoxStyle.Critical, "Fehler")
        End Try
        'Dim SFD As New SaveFileDialog
        'SFD.Filter = "Textdatei|*.txt|Alle Dateien|*.*"
        'If SFD.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    File.WriteAllText(SFD.FileName, rtb.Text)
        'End If
        'Try
        '    Dim SFD As New SaveFileDialog
        '    SFD.Filter = "Textdatei|*.txt|Alle Dateien|*.*"
        '    If SFD.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '        FileOpen(1, SFD.FileName, OpenMode.Output)
        '        PrintLine(1, CType(rtb, RichTextBox).Text)
        '        FileClose(1)
        '    End If
        'Catch ex As Exception
        '    MsgBox("Fehler beim Speichern")
        'End Try
        'Dim SFD As New SaveFileDialog
        'SFD.Filter = "Textdatei|*.txt|Alle Dateien|*.*"
        'If SFD.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    Dim SW As StreamWriter
        '    If SFD.FileName <> "" Then
        '        SW = New StreamWriter(SFD.FileName, false)
        '        For Each line As String In Split(rtb.Text, Chr(13))
        '            SW.WriteLine(line)
        '        Next
        '        SW.Close()
        '    End If
        'End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        If MsgBox("Wollen Sie noch mehr Daten eintragen?", MsgBoxStyle.YesNo, "mehr Daten") = MsgBoxResult.Yes Then
            Application.Restart()
        End If
    End Sub
End Class
