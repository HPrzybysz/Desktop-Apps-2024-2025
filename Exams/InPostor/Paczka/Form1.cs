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
            string price = "Cena: 1,5 z�";
            if (radioPacage.Checked)
            {
                price = "Cena: 10 z�";
                pictureBox1.Image = Properties.Resources.paczka;
            }
            else if (radioList.Checked)
            {
                price = "Cena: 1,5 z�";
                pictureBox1.Image = Properties.Resources.list;
            }
            else if (radioPostCard.Checked)
            {
                price = "Cena: 1 z�";
                pictureBox1.Image = Properties.Resources.pocztowka;
            }

            priceLabel.Text = price;
        }

        private void confrimButton_Clicked(object sender, EventArgs e)
        {
            string postCode = postCodeBox.Text.ToString().Trim();

            if (string.IsNullOrEmpty(postCode)){
                MessageBox.Show("Wprowad� kod pocztowy", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if(postCode.Length != 5)
            {
                MessageBox.Show("Nieprawid�owa liczba cyfr w kodzie pocztowym", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }else
            {
                foreach(char c in postCode)
                {
                    if (!char.IsDigit(c))
                    {
                        MessageBox.Show("Kod pocztowy powinien si� sk�ada� z samych cyfr", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                }
                MessageBox.Show("Dane przesy�ki zosta�y wprowadzone", "YES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
