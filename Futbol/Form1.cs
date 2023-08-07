using Futbol.Models;

namespace Futbol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        Kaleci kaleci = new Kaleci();
        Futbolcu futbolcu1;
        private void btnSec_Click(object sender, EventArgs e)
        {
            string Ulke = cmdUlke.SelectedItem.ToString();


            futbolcu1 = new Futbolcu(txtIsim.Text, Ulke);
            MessageBox.Show($"{futbolcu1.Isim} adlý {futbolcu1.Ulke} ülkesinden futbolcu oluþturuldu");

        }

        private void btnSutAt_Click(object sender, EventArgs e)
        {
            futbolcu1.Moral = rnd.Next(1, 10);
            futbolcu1.SutGucu += futbolcu1.Moral;
            kaleci.Savunma = rnd.Next(60, 100);

            if (futbolcu1.SutGucu > kaleci.Savunma)
            {
                MessageBox.Show("Gol oldu");
            }
            else
            {
                MessageBox.Show("Kaleci kurtardý");
            }
        }
    }
}