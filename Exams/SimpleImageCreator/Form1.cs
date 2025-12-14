using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing;

namespace SimpleImageCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            pictureBox1.Controls.Add(label4);
            pictureBox1.Controls.Add(label5);

            label4.Location = new Point(0,0);
            label5.Location = new Point(0,350);

            pictureBox1.SendToBack();
        }

        protected override void OnPaintBackground(PaintEventArgs e) { }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label4.Text = textBox1.Text;
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            label5.Text = textBox2.Text;
        }

        private void blackBtn_Click(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
        }

        private void whiteBtn_Click(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
        }

        private void yellowBtn_Click(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Yellow;
            label5.ForeColor = Color.Yellow;
        }

        private void redBtn_Click(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Red;
            label5.ForeColor = Color.Red;
        }

        private void magentaBtn_Click(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Magenta;
            label5.ForeColor = Color.Magenta;
        }

        private void cyanBtn_Click(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Cyan;
            label5.ForeColor = Color.Cyan;
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "Open Image";
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
            dialog.FilterIndex = 1;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.FileName = "Meme made with maker";
            saveDialog.DefaultExt = "*jpg";
            saveDialog.Filter = "JPG Image | *.jpg";
            saveDialog.ValidateNames = true;

            if(saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int width = Convert.ToInt32(pictureBox1.Width);
                    int height = Convert.ToInt32(pictureBox1.Height);
                    Bitmap bmp = new Bitmap(width, height);
                    pictureBox1.DrawToBitmap(bmp, new Rectangle(0,0, width, height));
                    bmp.Save(saveDialog.FileName, ImageFormat.Jpeg);
                }catch 
                {
                    MessageBox.Show("Error saving image");
                }

            }
        }
    }
}
