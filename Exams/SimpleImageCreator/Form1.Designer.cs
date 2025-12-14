namespace SimpleImageCreator
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            cyanBtn = new Button();
            magentaBtn = new Button();
            redBtn = new Button();
            yellowBtn = new Button();
            whiteBtn = new Button();
            blackBtn = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            openBtn = new Button();
            saveBtn = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 19);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Top text";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 121);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Bottom text";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 48);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(414, 58);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cyanBtn);
            groupBox1.Controls.Add(magentaBtn);
            groupBox1.Controls.Add(redBtn);
            groupBox1.Controls.Add(yellowBtn);
            groupBox1.Controls.Add(whiteBtn);
            groupBox1.Controls.Add(blackBtn);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(435, 450);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // cyanBtn
            // 
            cyanBtn.BackColor = Color.Cyan;
            cyanBtn.Location = new Point(122, 325);
            cyanBtn.Name = "cyanBtn";
            cyanBtn.Size = new Size(32, 32);
            cyanBtn.TabIndex = 10;
            cyanBtn.UseVisualStyleBackColor = false;
            cyanBtn.Click += cyanBtn_Click;
            // 
            // magentaBtn
            // 
            magentaBtn.BackColor = Color.Magenta;
            magentaBtn.Location = new Point(71, 325);
            magentaBtn.Name = "magentaBtn";
            magentaBtn.Size = new Size(32, 32);
            magentaBtn.TabIndex = 9;
            magentaBtn.UseVisualStyleBackColor = false;
            magentaBtn.Click += magentaBtn_Click;
            // 
            // redBtn
            // 
            redBtn.BackColor = Color.Red;
            redBtn.Location = new Point(19, 325);
            redBtn.Name = "redBtn";
            redBtn.Size = new Size(32, 32);
            redBtn.TabIndex = 8;
            redBtn.UseVisualStyleBackColor = false;
            redBtn.Click += redBtn_Click;
            // 
            // yellowBtn
            // 
            yellowBtn.BackColor = Color.Yellow;
            yellowBtn.Location = new Point(122, 270);
            yellowBtn.Name = "yellowBtn";
            yellowBtn.Size = new Size(32, 32);
            yellowBtn.TabIndex = 7;
            yellowBtn.UseVisualStyleBackColor = false;
            yellowBtn.Click += yellowBtn_Click;
            // 
            // whiteBtn
            // 
            whiteBtn.BackColor = Color.White;
            whiteBtn.Location = new Point(71, 270);
            whiteBtn.Name = "whiteBtn";
            whiteBtn.Size = new Size(32, 32);
            whiteBtn.TabIndex = 6;
            whiteBtn.UseVisualStyleBackColor = false;
            whiteBtn.Click += whiteBtn_Click;
            // 
            // blackBtn
            // 
            blackBtn.BackColor = Color.Black;
            blackBtn.Location = new Point(19, 270);
            blackBtn.Name = "blackBtn";
            blackBtn.Size = new Size(32, 32);
            blackBtn.TabIndex = 5;
            blackBtn.UseVisualStyleBackColor = false;
            blackBtn.Click += blackBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 240);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 4;
            label3.Text = "Change Colour";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(19, 153);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(414, 58);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // openBtn
            // 
            openBtn.Location = new Point(134, 507);
            openBtn.Name = "openBtn";
            openBtn.Size = new Size(140, 67);
            openBtn.TabIndex = 5;
            openBtn.Text = "Open";
            openBtn.UseVisualStyleBackColor = true;
            openBtn.Click += openBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(516, 507);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(140, 67);
            saveBtn.TabIndex = 6;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(453, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(389, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(453, 12);
            label4.Name = "label4";
            label4.Size = new Size(389, 63);
            label4.TabIndex = 8;
            label4.Text = "Sample Top Text";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(453, 383);
            label5.Name = "label5";
            label5.Size = new Size(389, 79);
            label5.TabIndex = 9;
            label5.Text = "Sample Bottom Text";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 611);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(saveBtn);
            Controls.Add(openBtn);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Simple Image Creator";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox textBox2;
        private Button cyanBtn;
        private Button magentaBtn;
        private Button redBtn;
        private Button yellowBtn;
        private Button whiteBtn;
        private Button blackBtn;
        private Button openBtn;
        private Button saveBtn;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
    }
}
