namespace Heizungsdaten
{
    partial class Form3
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
            BtnClose = new Button();
            Rtb = new RichTextBox();
            SuspendLayout();
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnClose.Location = new Point(628, 538);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(75, 23);
            BtnClose.TabIndex = 0;
            BtnClose.Text = "schließen";
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // Rtb
            // 
            Rtb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Rtb.Location = new Point(-1, -1);
            Rtb.Name = "Rtb";
            Rtb.ReadOnly = true;
            Rtb.Size = new Size(632, 533);
            Rtb.TabIndex = 1;
            Rtb.Text = "";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 573);
            Controls.Add(Rtb);
            Controls.Add(BtnClose);
            Name = "Form3";
            Text = "Heizungsdaten auslesen";
            Load += Form3_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnClose;
        private RichTextBox Rtb;
    }
}