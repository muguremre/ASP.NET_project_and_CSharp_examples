using OOPFirst.Models;

namespace OOPFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Araba araba = new Araba();
            
            araba.Marka = "BMW";
            araba.Model = "M3";
            araba.Hiz = 280;
            araba.Vites = 6;
            araba.Renk = "Siyah";

            MessageBox.Show($"{araba.Marka} markalý araç {araba.Vites}. vites ile e-5 üzerinden {araba.Hiz} ile seyahat etmektedir.");

        }
    }
}