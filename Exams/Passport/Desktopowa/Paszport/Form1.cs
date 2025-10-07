using System.IO;
namespace Paszport
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string number = textBox1.Text.Trim();
            string assetsPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "assets");

            if(number == "000")
            {
                pictureBox1.BackgroundImage = System.Drawing.Image.FromFile(assetsPath + "\\000-zdjecie.jpg");
                pictureBox2.BackgroundImage = System.Drawing.Image.FromFile(assetsPath + "\\000-odcisk.jpg");
            }else if (number == "111")
            {
                pictureBox1.BackgroundImage = System.Drawing.Image.FromFile(assetsPath + "\\111-zdjecie.jpg");
                pictureBox2.BackgroundImage = System.Drawing.Image.FromFile(assetsPath + "\\111-odcisk.jpg");
            }
            else if (number == "333")
            {
                pictureBox1.BackgroundImage = System.Drawing.Image.FromFile(assetsPath + "\\333-zdjecie.jpg");
                pictureBox2.BackgroundImage = System.Drawing.Image.FromFile(assetsPath + "\\333-odcisk.jpg");
            }
            else
            {
                pictureBox1.BackgroundImage = null;
                pictureBox2.BackgroundImage = null;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text.Trim();
            string surname = textBox3.Text.Trim();

            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname)){

                MessageBox.Show("Wprowadü dane", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string eyeColor = "";
            if (radioButton1.Checked) eyeColor = "niebieskie";
            else if (radioButton2.Checked) eyeColor = "zielone";
            else if (radioButton3.Checked) eyeColor = "piwne";

            string message = $"{name} {surname} kolor oczu {eyeColor}";

            MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
