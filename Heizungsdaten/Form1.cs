using System.Diagnostics;

namespace Heizungsdaten
{
    public partial class Form1 : Form
    {
        private readonly string filename = Path.Combine(Application.StartupPath, "Data", "Heizungsdaten.hde");
        private readonly string filename_Excel = Path.Combine(Application.StartupPath, "Data", "Heizungsdaten_Excelimport.txt");
        private string? Temp;
        private string? ExcelTemp;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CbWitterung.SelectedItem = "Sonnig";
            if (MessageBox.Show("Möchten Sie neue Daten speichern?", "lesen oder speichern", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Open();
            }
            else
            {
                var f3 = new Form3();
                f3.Show();
                Close();
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            var datum = Dtp.Text;
            var betriebsstunden = TxtBetriebsstunden.Text;
            var temperature = TxtTemperatur.Text;
            var witterung = CbWitterung.SelectedItem?.ToString();
            var excelH = "Datum;Betriebsstunden;Temperatur;Witterung;";
            ExcelTemp = $"{datum};{betriebsstunden};{temperature};{witterung};";
            Temp = $"Datum: {datum}; Betriebsstunden: {betriebsstunden}; Temperatur: {temperature}; Witterung: {witterung};";
            var f2 = new Form2();
            if (f2.RtbExcel.Text == "")
            {
                f2.RtbExcel.Text = $"{excelH}\r\n";
            }
            f2.RtbExcel.Text += ExcelTemp;
            f2.RtbExcel.Text += Temp;
            f2.Show();
            f2.BtnOk.PerformClick();
            f2.Close();
        }

        private void Open()
        {
            var f2 = new Form2();
            f2.RtbExcel.Text = File.ReadAllText(filename);
            f2.RtbExcel.Text = File.ReadAllText(filename_Excel);
        }

        private void LlblOpenFilepath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var filepath = Path.Combine(Application.StartupPath, "Data");
            Directory.CreateDirectory(filepath);
            Process.Start(filepath);
        }
    }
}
