<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.rtb = New System.Windows.Forms.RichTextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.rtbExcel = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'rtb
        '
        Me.rtb.Location = New System.Drawing.Point(12, 12)
        Me.rtb.Name = "rtb"
        Me.rtb.ReadOnly = True
        Me.rtb.Size = New System.Drawing.Size(775, 593)
        Me.rtb.TabIndex = 0
        Me.rtb.Text = ""
        '
        'btn_OK
        '
        Me.btnOk.Location = New System.Drawing.Point(321, 611)
        Me.btnOk.Name = "btn_OK"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "speichern"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(402, 611)
        Me.btnCancel.Name = "btn_Cancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "abbrechen"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'rtb_Excel
        '
        Me.rtbExcel.Location = New System.Drawing.Point(12, 12)
        Me.rtbExcel.Name = "rtb_Excel"
        Me.rtbExcel.ReadOnly = True
        Me.rtbExcel.Size = New System.Drawing.Size(775, 593)
        Me.rtbExcel.TabIndex = 3
        Me.rtbExcel.Text = ""
        '
        'Form2
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(799, 646)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.rtb)
        Me.Controls.Add(Me.rtbExcel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtb As System.Windows.Forms.RichTextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents rtbExcel As System.Windows.Forms.RichTextBox
End Class
