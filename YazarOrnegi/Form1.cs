namespace YazarOrnegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KitapYaz_Click(object sender, EventArgs e)
        {
            Yazar yazar1 = new Yazar();
            yazar1.YazarIsmi = "Jules";
            yazar1.YazarSoyismi = "Verne";
            yazar1.Yaz("Denizler Alt�nda 20.000 Fersah");

            Yazar yazar2 = new Yazar();
            yazar2.YazarIsmi = "Sait Faik";
            yazar2.YazarSoyismi = "Abas�yan�k";
            yazar2.Yaz("Alemda�'da Var Bir Y�lan");

        }
    }
}