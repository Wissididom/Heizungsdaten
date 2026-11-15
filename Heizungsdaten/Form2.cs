namespace Heizungsdaten
{
    public partial class Form2 : Form
    {
        private string filename = Path.Combine(Application.StartupPath, "Data", "Heizungsdaten.hde");
        private string filenameExcel = Path.Combine(Application.StartupPath, "Data", "Heizungsdaten_Excelimport.txt");
        private string dataPath = Path.Combine(Application.StartupPath, "Data");

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wollen Sie noch mehr Daten eintragen?", "Mehr Daten", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Save();
            Close();
            var f1 = new Form1();
            f1.Close();
        }

        private void Save()
        {
            if (!Directory.Exists(dataPath))
            {
                Directory.CreateDirectory(dataPath);
            }
            try
            {
                RtbExcel.SaveFile(filename, RichTextBoxStreamType.PlainText);
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler beim Speichern", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
