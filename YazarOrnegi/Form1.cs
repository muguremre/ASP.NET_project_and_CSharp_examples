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
            yazar1.Yaz("Denizler Altýnda 20.000 Fersah");

            Yazar yazar2 = new Yazar();
            yazar2.YazarIsmi = "Sait Faik";
            yazar2.YazarSoyismi = "Abasýyanýk";
            yazar2.Yaz("Alemdað'da Var Bir Yýlan");

        }
    }
}