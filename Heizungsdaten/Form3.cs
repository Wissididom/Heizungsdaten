namespace Heizungsdaten
{
    public partial class Form3 : Form
    {
        private readonly string filename = Path.Combine(Application.StartupPath, "Data", "Heizungsdaten.hde");

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (sender is Form1)
            {
                Open();
            }
            else
            {
                Close();
            }
        }

        private void Open()
        {
            Rtb.Text = File.ReadAllText(filename);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
