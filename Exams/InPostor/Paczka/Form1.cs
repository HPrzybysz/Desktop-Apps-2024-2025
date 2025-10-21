namespace Paczka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkPrice_Clicked(object sender, EventArgs e)
        {
            string price = "Cena: 1,5 z³";
            if (radioPacage.Checked)
            {
                price = "Cena: 10 z³";
                pictureBox1.Image = Properties.Resources.paczka;
            }
            else if (radioList.Checked)
            {
                price = "Cena: 1,5 z³";
                pictureBox1.Image = Properties.Resources.list;
            }
            else if (radioPostCard.Checked)
            {
                price = "Cena: 1 z³";
                pictureBox1.Image = Properties.Resources.pocztowka;
            }

            priceLabel.Text = price;
        }

        private void confrimButton_Clicked(object sender, EventArgs e)
        {
            string postCode = postCodeBox.Text.ToString().Trim();

            if (string.IsNullOrEmpty(postCode)){
                MessageBox.Show("WprowadŸ kod pocztowy", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if(postCode.Length != 5)
            {
                MessageBox.Show("Nieprawid³owa liczba cyfr w kodzie pocztowym", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }else
            {
                foreach(char c in postCode)
                {
                    if (!char.IsDigit(c))
                    {
                        MessageBox.Show("Kod pocztowy powinien siê sk³adaæ z samych cyfr", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                }
                MessageBox.Show("Dane przesy³ki zosta³y wprowadzone", "YES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
