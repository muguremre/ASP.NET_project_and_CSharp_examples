namespace Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDogum_Click(object sender, EventArgs e)
        {
            Bebek bebek = new Bebek();
            bebek.Name = txtBebek.Text;
            MessageBox.Show(bebek.Name + " adl� bebek " + bebek.BirthDate + " tarihinde d�nyaya geldi.");

            Bebek bebek1 = new Bebek(txtBebek.Text);
            MessageBox.Show(bebek1.Name + " adl� bebek " + bebek1.BirthDate + " tarihinde d�nyaya geldi.");
        }

    }
}