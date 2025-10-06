namespace RGBPicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            textBox1 = new TextBox();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar3 = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(61, 46);
            panel1.Margin = new Padding(57, 63, 57, 63);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(1699, 253);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Cornsilk;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Papyrus", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(61, 366);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(535, 34);
            textBox1.TabIndex = 1;
            textBox1.Text = "Dobierz kolor suwakami i zapisz przyciskiem:";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 1;
            trackBar1.Location = new Point(136, 422);
            trackBar1.Margin = new Padding(3, 4, 3, 4);
            trackBar1.Maximum = 255;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(1517, 45);
            trackBar1.TabIndex = 3;
            trackBar1.Value = 255;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // trackBar2
            // 
            trackBar2.LargeChange = 1;
            trackBar2.Location = new Point(136, 532);
            trackBar2.Margin = new Padding(3, 4, 3, 4);
            trackBar2.Maximum = 255;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(1517, 45);
            trackBar2.TabIndex = 6;
            trackBar2.Value = 255;
            // 
            // trackBar3
            // 
            trackBar3.LargeChange = 1;
            trackBar3.Location = new Point(136, 650);
            trackBar3.Margin = new Padding(3, 4, 3, 4);
            trackBar3.Maximum = 255;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(1517, 45);
            trackBar3.TabIndex = 9;
            trackBar3.Value = 255;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 423);
            label1.Name = "label1";
            label1.Size = new Size(18, 19);
            label1.TabIndex = 11;
            label1.Text = "R";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 532);
            label2.Name = "label2";
            label2.Size = new Size(21, 19);
            label2.TabIndex = 12;
            label2.Text = "G";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 651);
            label3.Name = "label3";
            label3.Size = new Size(20, 19);
            label3.TabIndex = 13;
            label3.Text = "B";
            // 
            // button1
            // 
            button1.BackColor = Color.Peru;
            button1.Font = new Font("Papyrus", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(658, 769);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(439, 89);
            button1.TabIndex = 14;
            button1.Text = "Pobierz";
            button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Papyrus", 12F);
            label4.Location = new Point(1693, 423);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Papyrus", 12F);
            label5.Location = new Point(1693, 532);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Papyrus", 12F);
            label6.Location = new Point(1693, 651);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 17;
            // 
            // label7
            // 
            label7.Font = new Font("Papyrus", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(658, 934);
            label7.Name = "label7";
            label7.Size = new Size(439, 108);
            label7.TabIndex = 18;
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1878, 1145);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBar3);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Font = new Font("Papyrus", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Wzornik kolorów RGB. Wykonał 00000002137";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TrackBar trackBar3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
