using Savas.Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using Savas.Models;
using System.Reflection.Emit;

namespace Savas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Instance (�rnek) almak
        Buyucu oyuncu1 = new Buyucu();
        int DusmanCani;

        private void btnSec_Click(object sender, EventArgs e)
        {
            oyuncu1.OyuncuIsmi = txtOyuncu.Text;
            oyuncu1.Silah = txtSilah.Text;
            oyuncu1.Brans = txtBrans.Text;
            oyuncu1.Irk = txtIrk.Text;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DusmanCani = lblDusmanCani.Width;
            //lblDusmanCani.Width = DusmanCani;
        }

        private void btnSaldir_Click(object sender, EventArgs e)
        {
            oyuncu1.Saldir();
            DusmanCani -= oyuncu1.Sald�r�Gucu;
            lblDusmanCani.Width = DusmanCani;
            MessageBox.Show($"D��mana {oyuncu1.Sald�r�Gucu} kadar vurdunuz.");
            if (DusmanCani <= 0)
            {
                MessageBox.Show("D��man �ld�");
            }

        }

    }
}