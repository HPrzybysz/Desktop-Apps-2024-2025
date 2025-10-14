namespace CaesarCipherApp
{
    public partial class Form1 : Form
    {
        private string currentEncryptedText = "";

        public Form1()
        {
            InitializeComponent();
            encryptButton.Click += EncryptButton_Click;
            encryptToFileButton.Click += EncryptToFileButton_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            encryptedTextPanel.Paint += EncryptedTextPanel_Paint;
        }

        private void EncryptedTextPanel_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(250, 235, 215), 2))
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radius = 15;
                Rectangle rect = new Rectangle(1, 1, encryptedTextPanel.Width - 3, encryptedTextPanel.Height - 3);

                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);

                using (SolidBrush brush = new SolidBrush(Color.AliceBlue))
                using (StringFormat format = new StringFormat())
                {
                    format.Alignment = StringAlignment.Near;
                    format.LineAlignment = StringAlignment.Near;

                    RectangleF textRect = new RectangleF(rect.X + 10, rect.Y + 10, rect.Width - 20, rect.Height - 20);
                    e.Graphics.DrawString(currentEncryptedText, this.Font, brush, textRect, format);
                }
            }
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string inputText = textToCodeTextBox.Text;

            if (!int.TryParse(keyValueTextBox.Text, out int key))
            {
                key = 0;
            }

            currentEncryptedText = CaesarCipher.Encrypt(inputText, key);
            encryptedTextPanel.Invalidate();
        }

        private void EncryptToFileButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentEncryptedText))
            {
                MessageBox.Show("Brak zaszyfrowanego tekstu do zapisania.");
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, currentEncryptedText);
                    MessageBox.Show("Plik zosta³ pomyœlnie zapisany.");
                }
            }
        }
    }
}