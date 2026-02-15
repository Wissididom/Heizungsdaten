<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Betriebsstunden = New System.Windows.Forms.Label()
        Me.txt_Betriebsstunden = New System.Windows.Forms.TextBox()
        Me.lbl_temperatur = New System.Windows.Forms.Label()
        Me.lbl_witterung = New System.Windows.Forms.Label()
        Me.txt_temperatur = New System.Windows.Forms.TextBox()
        Me.cb_witterung = New System.Windows.Forms.ComboBox()
        Me.btn_OK = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Location = New System.Drawing.Point(12, 12)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(184, 20)
        Me.DateTimePicker.TabIndex = 0
        '
        'lbl_Betriebsstunden
        '
        Me.lbl_Betriebsstunden.AutoSize = True
        Me.lbl_Betriebsstunden.Location = New System.Drawing.Point(12, 41)
        Me.lbl_Betriebsstunden.Name = "lbl_Betriebsstunden"
        Me.lbl_Betriebsstunden.Size = New System.Drawing.Size(86, 13)
        Me.lbl_Betriebsstunden.TabIndex = 1
        Me.lbl_Betriebsstunden.Text = "Betriebsstunden:"
        '
        'txt_Betriebsstunden
        '
        Me.txt_Betriebsstunden.Location = New System.Drawing.Point(104, 38)
        Me.txt_Betriebsstunden.Name = "txt_Betriebsstunden"
        Me.txt_Betriebsstunden.Size = New System.Drawing.Size(213, 20)
        Me.txt_Betriebsstunden.TabIndex = 2
        '
        'lbl_temperatur
        '
        Me.lbl_temperatur.AutoSize = True
        Me.lbl_temperatur.Location = New System.Drawing.Point(12, 67)
        Me.lbl_temperatur.Name = "lbl_temperatur"
        Me.lbl_temperatur.Size = New System.Drawing.Size(64, 13)
        Me.lbl_temperatur.TabIndex = 3
        Me.lbl_temperatur.Text = "Temperatur:"
        '
        'lbl_witterung
        '
        Me.lbl_witterung.AutoSize = True
        Me.lbl_witterung.Location = New System.Drawing.Point(12, 93)
        Me.lbl_witterung.Name = "lbl_witterung"
        Me.lbl_witterung.Size = New System.Drawing.Size(56, 13)
        Me.lbl_witterung.TabIndex = 4
        Me.lbl_witterung.Text = "Witterung:"
        '
        'txt_temperatur
        '
        Me.txt_temperatur.Location = New System.Drawing.Point(104, 64)
        Me.txt_temperatur.Name = "txt_temperatur"
        Me.txt_temperatur.Size = New System.Drawing.Size(213, 20)
        Me.txt_temperatur.TabIndex = 5
        '
        'cb_witterung
        '
        Me.cb_witterung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_witterung.FormattingEnabled = True
        Me.cb_witterung.Items.AddRange(New Object() {"Sonnig", "Regen", "Schnee", "Bewölkt"})
        Me.cb_witterung.Location = New System.Drawing.Point(104, 90)
        Me.cb_witterung.Name = "cb_witterung"
        Me.cb_witterung.Size = New System.Drawing.Size(213, 21)
        Me.cb_witterung.TabIndex = 6
        '
        'btn_OK
        '
        Me.btn_OK.Location = New System.Drawing.Point(129, 117)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(75, 23)
        Me.btn_OK.TabIndex = 7
        Me.btn_OK.Text = "OK"
        Me.btn_OK.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(234, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(86, 13)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Dateipfad öffnen"
        '
        'Form1
        '
        Me.AcceptButton = Me.btn_OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 152)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btn_OK)
        Me.Controls.Add(Me.cb_witterung)
        Me.Controls.Add(Me.txt_temperatur)
        Me.Controls.Add(Me.lbl_witterung)
        Me.Controls.Add(Me.lbl_temperatur)
        Me.Controls.Add(Me.txt_Betriebsstunden)
        Me.Controls.Add(Me.lbl_Betriebsstunden)
        Me.Controls.Add(Me.DateTimePicker)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Heizungsdaten erfassen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Betriebsstunden As System.Windows.Forms.Label
    Friend WithEvents txt_Betriebsstunden As System.Windows.Forms.TextBox
    Friend WithEvents lbl_temperatur As System.Windows.Forms.Label
    Friend WithEvents lbl_witterung As System.Windows.Forms.Label
    Friend WithEvents txt_temperatur As System.Windows.Forms.TextBox
    Friend WithEvents cb_witterung As System.Windows.Forms.ComboBox
    Friend WithEvents btn_OK As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
