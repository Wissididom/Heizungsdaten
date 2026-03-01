Imports System.IO
Imports System.Windows.Forms

Public Class Form1
    Dim filename As String = Application.StartupPath & "\Data\Heizungsdaten.hde"
    Dim filename_Excel As String = Application.StartupPath & "\Data\Heizungsdaten_Excelimport.txt"
    Dim Temp As String
    Dim ExcelTemp As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_witterung.SelectedItem = "Sonnig"
        If MsgBox("Möchten Sie neue Daten speichern?", MsgBoxStyle.YesNo, "lesen oder speichern") = MsgBoxResult.Yes Then
            'MsgBox("Vielleicht müssen Sie jede Datei einzeln speichern, d. h. dass ich nicht sicher bin ob das Programm das vorher geschriebene ersetzt oder nicht", MsgBoxStyle.Information, "Info")
            Oeffnen()
        Else
            Dim f3 = New Form3()
            f3.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        Dim Datum As String = DateTimePicker.Text
        Dim Betriebsstunden As String = txt_Betriebsstunden.Text
        Dim Temperatur As String = txt_temperatur.Text
        Dim Witterung As String = cb_witterung.SelectedItem
        Dim ExcelH As String = "Datum;Betriebsstunden;Temperatur;Witterung;"
        ExcelTemp = Datum & ";" & Betriebsstunden & ";" & Temperatur & ";" & Witterung & ";"
        Temp = "Datum: " & Datum & "; Betriebsstunden: " & Betriebsstunden & "; Temperatur: " & Temperatur & "; Witterung: " & Witterung & ";"
        Dim f2 = New Form2()
        If f2.rtbExcel.Text = "" Then
            f2.rtbExcel.Text = ExcelH & vbCrLf
        End If
        f2.rtbExcel.Text = f2.rtbExcel.Text & ExcelTemp
        f2.rtb.Text = f2.rtb.Text & Temp
        f2.Show()
        f2.btnOk.PerformClick()
        f2.Close()
    End Sub

    Sub Oeffnen()
        Dim allText As String = "", lineOfText As String
        Try
            FileOpen(1, filename, OpenMode.Input)
            Do Until EOF(1)
                lineOfText = LineInput(1)
                allText = allText & lineOfText & vbCrLf
            Loop
            Dim f2 = New Form2()
            f2.rtb.Text = allText
        Catch
        Finally
            FileClose(1)
        End Try
        Oeffnen_Excel()
    End Sub

    Sub Oeffnen_Excel()
        Dim allText As String = "", lineOfText As String
        Try
            FileOpen(1, filename_Excel, OpenMode.Input)
            Do Until EOF(1)
                lineOfText = LineInput(1)
                allText = allText & lineOfText & vbCrLf
            Loop
            Dim f2 = New Form2()
            f2.rtbExcel.Text = allText
        Catch
        Finally
            FileClose(1)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(Path.Combine(Application.StartupPath, "Data"))
    End Sub
End Class
