namespace CaesarCipherApp
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
            keyValueTextBox = new TextBox();
            label2 = new Label();
            textToCodeTextBox = new TextBox();
            encryptButton = new Button();
            label3 = new Label();
            encryptedTextPanel = new Panel();
            encryptToFileButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(34, 22);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 0;
            label1.Text = "Podaj wartość klucza";
            // 
            // keyValueTextBox
            // 
            keyValueTextBox.Location = new Point(72, 56);
            keyValueTextBox.Name = "keyValueTextBox";
            keyValueTextBox.Size = new Size(53, 23);
            keyValueTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.AntiqueWhite;
            label2.Location = new Point(34, 151);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Podaj tekst";
            // 
            // textToCodeTextBox
            // 
            textToCodeTextBox.Location = new Point(34, 211);
            textToCodeTextBox.Multiline = true;
            textToCodeTextBox.Name = "textToCodeTextBox";
            textToCodeTextBox.Size = new Size(348, 256);
            textToCodeTextBox.TabIndex = 3;
            // 
            // encryptButton
            // 
            encryptButton.BackColor = Color.LightBlue;
            encryptButton.Location = new Point(424, 298);
            encryptButton.Name = "encryptButton";
            encryptButton.Size = new Size(104, 26);
            encryptButton.TabIndex = 4;
            encryptButton.Text = "Zaszyfruj";
            encryptButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.AntiqueWhite;
            label3.Location = new Point(594, 22);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 5;
            label3.Text = "Tekst zaszyfrowany";
            // 
            // encryptedTextPanel
            // 
            encryptedTextPanel.ForeColor = Color.AliceBlue;
            encryptedTextPanel.Location = new Point(567, 94);
            encryptedTextPanel.Name = "encryptedTextPanel";
            encryptedTextPanel.Size = new Size(375, 349);
            encryptedTextPanel.TabIndex = 6;
            // 
            // encryptToFileButton
            // 
            encryptToFileButton.BackColor = Color.LightBlue;
            encryptToFileButton.Location = new Point(670, 475);
            encryptToFileButton.Name = "encryptToFileButton";
            encryptToFileButton.Size = new Size(202, 34);
            encryptToFileButton.TabIndex = 7;
            encryptToFileButton.Text = "Zaszyfruj w pliku";
            encryptToFileButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(972, 545);
            Controls.Add(encryptToFileButton);
            Controls.Add(encryptedTextPanel);
            Controls.Add(label3);
            Controls.Add(encryptButton);
            Controls.Add(textToCodeTextBox);
            Controls.Add(label2);
            Controls.Add(keyValueTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Wykonane przez 000000000";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox keyValueTextBox;
        private Label label2;
        private TextBox textToCodeTextBox;
        private Button encryptButton;
        private Label label3;
        private Panel encryptedTextPanel;
        private Button encryptToFileButton;
    }
}
