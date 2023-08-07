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
            MessageBox.Show(bebek.Name + " adlý bebek " + bebek.BirthDate + " tarihinde dünyaya geldi.");

            Bebek bebek1 = new Bebek(txtBebek.Text);
            MessageBox.Show(bebek1.Name + " adlý bebek " + bebek1.BirthDate + " tarihinde dünyaya geldi.");
        }

    }
}