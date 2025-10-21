namespace Paczka
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
            groupBox1 = new GroupBox();
            radioPacage = new RadioButton();
            radioList = new RadioButton();
            radioPostCard = new RadioButton();
            groupBox2 = new GroupBox();
            cityBox = new TextBox();
            postCodeBox = new TextBox();
            streetBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            checkPriceButton = new Button();
            priceLabel = new Label();
            confirmButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioPacage);
            groupBox1.Controls.Add(radioList);
            groupBox1.Controls.Add(radioPostCard);
            groupBox1.Location = new Point(64, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 300);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rodzaj przesyłki";
            // 
            // radioPacage
            // 
            radioPacage.AutoSize = true;
            radioPacage.Cursor = Cursors.NoMove2D;
            radioPacage.Location = new Point(25, 165);
            radioPacage.Name = "radioPacage";
            radioPacage.Size = new Size(65, 23);
            radioPacage.TabIndex = 2;
            radioPacage.Text = "Paczka";
            radioPacage.UseVisualStyleBackColor = true;
            // 
            // radioList
            // 
            radioList.AutoSize = true;
            radioList.Cursor = Cursors.Help;
            radioList.Location = new Point(25, 104);
            radioList.Name = "radioList";
            radioList.Size = new Size(50, 23);
            radioList.TabIndex = 1;
            radioList.Text = "List";
            radioList.UseVisualStyleBackColor = true;
            // 
            // radioPostCard
            // 
            radioPostCard.AutoSize = true;
            radioPostCard.Checked = true;
            radioPostCard.Cursor = Cursors.WaitCursor;
            radioPostCard.Location = new Point(25, 45);
            radioPostCard.Name = "radioPostCard";
            radioPostCard.Size = new Size(84, 23);
            radioPostCard.TabIndex = 0;
            radioPostCard.TabStop = true;
            radioPostCard.Text = "Pocztówka";
            radioPostCard.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cityBox);
            groupBox2.Controls.Add(postCodeBox);
            groupBox2.Controls.Add(streetBox);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(559, 44);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(610, 300);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dane adresowe";
            // 
            // cityBox
            // 
            cityBox.Location = new Point(41, 237);
            cityBox.Name = "cityBox";
            cityBox.Size = new Size(538, 26);
            cityBox.TabIndex = 5;
            // 
            // postCodeBox
            // 
            postCodeBox.Location = new Point(41, 151);
            postCodeBox.Name = "postCodeBox";
            postCodeBox.Size = new Size(538, 26);
            postCodeBox.TabIndex = 4;
            // 
            // streetBox
            // 
            streetBox.Location = new Point(41, 71);
            streetBox.Name = "streetBox";
            streetBox.Size = new Size(538, 26);
            streetBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 206);
            label3.Name = "label3";
            label3.Size = new Size(49, 19);
            label3.TabIndex = 2;
            label3.Text = "Miasto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 108);
            label2.Name = "label2";
            label2.Size = new Size(88, 19);
            label2.TabIndex = 1;
            label2.Text = "Kod pocztowy";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 36);
            label1.Name = "label1";
            label1.Size = new Size(99, 19);
            label1.TabIndex = 0;
            label1.Text = "Ulica z numerem";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pocztowka;
            pictureBox1.Location = new Point(64, 412);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // checkPriceButton
            // 
            checkPriceButton.Cursor = Cursors.No;
            checkPriceButton.Location = new Point(64, 366);
            checkPriceButton.Name = "checkPriceButton";
            checkPriceButton.Size = new Size(353, 23);
            checkPriceButton.TabIndex = 3;
            checkPriceButton.Text = "Sprawdź Cenę";
            checkPriceButton.UseVisualStyleBackColor = true;
            checkPriceButton.Click += checkPrice_Clicked;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Papyrus", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            priceLabel.Location = new Point(289, 412);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(157, 44);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "Cena: 1 zł";
            // 
            // confirmButton
            // 
            confirmButton.Cursor = Cursors.AppStarting;
            confirmButton.Location = new Point(67, 613);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(1102, 59);
            confirmButton.TabIndex = 5;
            confirmButton.Text = "Zatwierdź";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confrimButton_Clicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1225, 723);
            Controls.Add(confirmButton);
            Controls.Add(priceLabel);
            Controls.Add(checkPriceButton);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Papyrus", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Nadaj Przesyłkę, PESEL: 00000000000";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioPacage;
        private RadioButton radioList;
        private RadioButton radioPostCard;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox cityBox;
        private TextBox postCodeBox;
        private TextBox streetBox;
        private PictureBox pictureBox1;
        private Button checkPriceButton;
        private Label priceLabel;
        private Button button1;
        private Button confirmButton;
    }
}
