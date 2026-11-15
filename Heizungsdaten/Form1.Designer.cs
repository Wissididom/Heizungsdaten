namespace Heizungsdaten
{
    partial class Form1
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
            Dtp = new DateTimePicker();
            LblBetriebsstunden = new Label();
            TxtBetriebsstunden = new TextBox();
            LblTemperatur = new Label();
            TxtTemperatur = new TextBox();
            LblWitterung = new Label();
            CbWitterung = new ComboBox();
            BtnOk = new Button();
            LlblOpenFilepath = new LinkLabel();
            SuspendLayout();
            // 
            // Dtp
            // 
            Dtp.Location = new Point(12, 12);
            Dtp.Name = "Dtp";
            Dtp.Size = new Size(200, 23);
            Dtp.TabIndex = 0;
            // 
            // LblBetriebsstunden
            // 
            LblBetriebsstunden.AutoSize = true;
            LblBetriebsstunden.Location = new Point(12, 44);
            LblBetriebsstunden.Name = "LblBetriebsstunden";
            LblBetriebsstunden.Size = new Size(95, 15);
            LblBetriebsstunden.TabIndex = 1;
            LblBetriebsstunden.Text = "Betriebsstunden:";
            // 
            // TxtBetriebsstunden
            // 
            TxtBetriebsstunden.Location = new Point(113, 41);
            TxtBetriebsstunden.Name = "TxtBetriebsstunden";
            TxtBetriebsstunden.Size = new Size(100, 23);
            TxtBetriebsstunden.TabIndex = 2;
            // 
            // LblTemperatur
            // 
            LblTemperatur.AutoSize = true;
            LblTemperatur.Location = new Point(12, 77);
            LblTemperatur.Name = "LblTemperatur";
            LblTemperatur.Size = new Size(71, 15);
            LblTemperatur.TabIndex = 3;
            LblTemperatur.Text = "Temperatur:";
            // 
            // TxtTemperatur
            // 
            TxtTemperatur.Location = new Point(113, 74);
            TxtTemperatur.Name = "TxtTemperatur";
            TxtTemperatur.Size = new Size(100, 23);
            TxtTemperatur.TabIndex = 4;
            // 
            // LblWitterung
            // 
            LblWitterung.AutoSize = true;
            LblWitterung.Location = new Point(12, 106);
            LblWitterung.Name = "LblWitterung";
            LblWitterung.Size = new Size(63, 15);
            LblWitterung.TabIndex = 5;
            LblWitterung.Text = "Witterung:";
            // 
            // CbWitterung
            // 
            CbWitterung.DropDownStyle = ComboBoxStyle.DropDownList;
            CbWitterung.FormattingEnabled = true;
            CbWitterung.Items.AddRange(new object[] { "Sonnig", "Regen", "Schnee", "Bewölkt" });
            CbWitterung.Location = new Point(113, 103);
            CbWitterung.Name = "CbWitterung";
            CbWitterung.Size = new Size(121, 23);
            CbWitterung.TabIndex = 6;
            // 
            // BtnOk
            // 
            BtnOk.Location = new Point(128, 132);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(75, 23);
            BtnOk.TabIndex = 7;
            BtnOk.Text = "OK";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // LlblOpenFilepath
            // 
            LlblOpenFilepath.AutoSize = true;
            LlblOpenFilepath.Location = new Point(218, 18);
            LlblOpenFilepath.Name = "LlblOpenFilepath";
            LlblOpenFilepath.Size = new Size(96, 15);
            LlblOpenFilepath.TabIndex = 8;
            LlblOpenFilepath.TabStop = true;
            LlblOpenFilepath.Text = "Dateipfad öffnen";
            LlblOpenFilepath.LinkClicked += LlblOpenFilepath_LinkClicked;
            // 
            // Form1
            // 
            AcceptButton = BtnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 167);
            Controls.Add(LlblOpenFilepath);
            Controls.Add(BtnOk);
            Controls.Add(CbWitterung);
            Controls.Add(LblWitterung);
            Controls.Add(TxtTemperatur);
            Controls.Add(LblTemperatur);
            Controls.Add(TxtBetriebsstunden);
            Controls.Add(LblBetriebsstunden);
            Controls.Add(Dtp);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Heizungsdaten erfassen";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker Dtp;
        private Label LblBetriebsstunden;
        private TextBox TxtBetriebsstunden;
        private Label LblTemperatur;
        private TextBox TxtTemperatur;
        private Label LblWitterung;
        private ComboBox CbWitterung;
        private Button BtnOk;
        private LinkLabel LlblOpenFilepath;
    }
}