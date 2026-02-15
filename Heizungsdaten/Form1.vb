Imports System.IO
Public Class Form1
    Dim filename As String = Application.StartupPath & "\Data\Heizungsdaten.hde"
    Dim filename_Excel As String = Application.StartupPath & "\Data\Heizungsdaten_Excelimport.txt"
    Dim Temp As String
    Dim ExcelTemp As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_witterung.SelectedItem = "Sonnig"
        If MsgBox("Möchten Sie neue Daten speichern?", MsgBoxStyle.YesNo, "lesen oder speichern") = MsgBoxResult.Yes Then
            'MsgBox("Vielleicht müssen Sie jede Datei eizeln speichern, d. h. dass ich nicht sicher bin ob das Programm das vorher geschriebene ersetzt oder nicht", MsgBoxStyle.Information, "Info")
            öffnen()
        Else
            Form3.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        Dim Datum As String = DateTimePicker.Text
        Dim Betriebsstunden As String = txt_Betriebsstunden.Text
        Dim Temperatur As String = txt_temperatur.Text
        Dim Witterung As String = cb_witterung.SelectedItem
        Dim ExcelÜ As String = "Datum;Betriebsstunden;Temperatur;Witterung;"
        ExcelTemp = Datum & ";" & Betriebsstunden & ";" & Temperatur & ";" & Witterung & ";"
        Temp = "Datum: " & Datum & "; Betriebsstunden: " & Betriebsstunden & "; Temperatur: " & Temperatur & "; Witterung: " & Witterung & ";"
        If Form2.rtb_Excel.Text = "" Then
            Form2.rtb_Excel.Text = ExcelÜ & vbCrLf
        End If
        Form2.rtb_Excel.Text = Form2.rtb_Excel.Text & ExcelTemp
        Form2.rtb.Text = Form2.rtb.Text & Temp
        Form2.Show()
        Form2.btn_OK.PerformClick()
        Form2.Close()
    End Sub

    Sub öffnen()
        Dim AllText As String = "", LineOfText As String = ""
        Try
            FileOpen(1, filename, OpenMode.Input)
            Do Until EOF(1)
                LineOfText = LineInput(1)
                AllText = AllText & LineOfText & vbCrLf
            Loop
            Form2.rtb.Text = AllText
        Catch
        Finally
            FileClose(1)
        End Try
        öffnen_Excel()
    End Sub

    Sub öffnen_Excel()
        Dim AllText As String = "", LineOfText As String = ""
        Try
            FileOpen(1, filename_Excel, OpenMode.Input)
            Do Until EOF(1)
                LineOfText = LineInput(1)
                AllText = AllText & LineOfText & vbCrLf
            Loop
            Form2.rtb_Excel.Text = AllText
        Catch
        Finally
            FileClose(1)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start(Application.StartupPath & "\Data")
    End Sub
End Class