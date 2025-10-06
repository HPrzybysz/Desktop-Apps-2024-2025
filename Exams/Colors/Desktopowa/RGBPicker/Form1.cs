namespace RGBPicker

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label4.DataBindings.Add("Text", trackBar1, "Value");
            label5.DataBindings.Add("Text", trackBar2, "Value");
            label6.DataBindings.Add("Text", trackBar3, "Value");

            trackBar1.ValueChanged += UpdateRGBDisplay;
            trackBar2.ValueChanged += UpdateRGBDisplay;
            trackBar3.ValueChanged += UpdateRGBDisplay;

            button1.Click += Button1_Click;

            label7.Text = $"{trackBar1.Value};{trackBar2.Value};{trackBar3.Value}";
            label7.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void UpdateRGBDisplay(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void Button1_Click (object sender, EventArgs e)
        {
            label7.Text = $"{trackBar1.Value};{trackBar2.Value};{trackBar3.Value}";

            label7.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

    }
}
