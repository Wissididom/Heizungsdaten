namespace Heizungsdaten
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnOk = new Button();
            BtnCancel = new Button();
            RtbExcel = new RichTextBox();
            SuspendLayout();
            // 
            // BtnOk
            // 
            BtnOk.DialogResult = DialogResult.OK;
            BtnOk.Location = new Point(322, 605);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(75, 23);
            BtnOk.TabIndex = 0;
            BtnOk.Text = "speichern";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.DialogResult = DialogResult.Cancel;
            BtnCancel.Location = new Point(403, 605);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 23);
            BtnCancel.TabIndex = 1;
            BtnCancel.Text = "abbrechen";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // RtbExcel
            // 
            RtbExcel.Location = new Point(12, 12);
            RtbExcel.Name = "RtbExcel";
            RtbExcel.Size = new Size(776, 587);
            RtbExcel.TabIndex = 2;
            RtbExcel.Text = "";
            // 
            // Form2
            // 
            AcceptButton = BtnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnCancel;
            ClientSize = new Size(800, 640);
            Controls.Add(RtbExcel);
            Controls.Add(BtnCancel);
            Controls.Add(BtnOk);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form2";
            Text = "Text";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        internal Button BtnOk;
        internal Button BtnCancel;
        internal RichTextBox RtbExcel;
    }
}
