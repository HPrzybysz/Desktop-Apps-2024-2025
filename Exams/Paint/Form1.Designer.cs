namespace SimplePaintApp
{
    partial class PaintForm
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Panel panelTools;
        private Button btnPencil;
        private Button btnEraser;
        private Button btnFill;
        private Button btnClear;
        private Label lblBrushSize;
        private TrackBar trackBarSize;
        private Button btnColorPicker;
        private Label lblCurrentColor;
        private FlowLayoutPanel flowLayoutPanelColors;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pictureBox = new PictureBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            panelTools = new Panel();
            flowLayoutPanelColors = new FlowLayoutPanel();
            btnColorPicker = new Button();
            lblCurrentColor = new Label();
            btnClear = new Button();
            btnFill = new Button();
            btnEraser = new Button();
            btnPencil = new Button();
            trackBarSize = new TrackBar();
            lblBrushSize = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            menuStrip1.SuspendLayout();
            panelTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarSize).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox.BackColor = Color.White;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(14, 173);
            pictureBox.Margin = new Padding(4, 3, 4, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(886, 461);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.MouseDown += pictureBox_MouseDown;
            pictureBox.MouseMove += pictureBox_MouseMove;
            pictureBox.MouseUp += pictureBox_MouseUp;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(915, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(146, 22);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(146, 22);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(146, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // panelTools
            // 
            panelTools.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTools.BackColor = SystemColors.ControlLight;
            panelTools.Controls.Add(flowLayoutPanelColors);
            panelTools.Controls.Add(btnColorPicker);
            panelTools.Controls.Add(lblCurrentColor);
            panelTools.Controls.Add(btnClear);
            panelTools.Controls.Add(btnFill);
            panelTools.Controls.Add(btnEraser);
            panelTools.Controls.Add(btnPencil);
            panelTools.Controls.Add(trackBarSize);
            panelTools.Controls.Add(lblBrushSize);
            panelTools.Location = new Point(14, 31);
            panelTools.Margin = new Padding(4, 3, 4, 3);
            panelTools.Name = "panelTools";
            panelTools.Size = new Size(887, 135);
            panelTools.TabIndex = 2;
            // 
            // flowLayoutPanelColors
            // 
            flowLayoutPanelColors.Location = new Point(12, 46);
            flowLayoutPanelColors.Margin = new Padding(4, 3, 4, 3);
            flowLayoutPanelColors.Name = "flowLayoutPanelColors";
            flowLayoutPanelColors.Size = new Size(467, 40);
            flowLayoutPanelColors.TabIndex = 8;
            // 
            // btnColorPicker
            // 
            btnColorPicker.Location = new Point(490, 46);
            btnColorPicker.Margin = new Padding(4, 3, 4, 3);
            btnColorPicker.Name = "btnColorPicker";
            btnColorPicker.Size = new Size(105, 35);
            btnColorPicker.TabIndex = 7;
            btnColorPicker.Text = "More Colors...";
            btnColorPicker.UseVisualStyleBackColor = true;
            btnColorPicker.Click += btnColorPicker_Click;
            // 
            // lblCurrentColor
            // 
            lblCurrentColor.BackColor = Color.Black;
            lblCurrentColor.BorderStyle = BorderStyle.FixedSingle;
            lblCurrentColor.Location = new Point(607, 46);
            lblCurrentColor.Margin = new Padding(4, 0, 4, 0);
            lblCurrentColor.Name = "lblCurrentColor";
            lblCurrentColor.Size = new Size(46, 34);
            lblCurrentColor.TabIndex = 6;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(766, 6);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(105, 35);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear Canvas";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnFill
            // 
            btnFill.BackgroundImage = SimplePaintApp.Properties.Resources.paint_bucket;
            btnFill.BackgroundImageLayout = ImageLayout.Zoom;
            btnFill.Location = new Point(104, 6);
            btnFill.Margin = new Padding(4, 3, 4, 3);
            btnFill.Name = "btnFill";
            btnFill.Size = new Size(38, 38);
            btnFill.TabIndex = 4;
            btnFill.UseVisualStyleBackColor = true;
            btnFill.Click += btnFill_Click;
            // 
            // btnEraser
            // 
            btnEraser.BackgroundImage = SimplePaintApp.Properties.Resources.eraser;
            btnEraser.BackgroundImageLayout = ImageLayout.Zoom;
            btnEraser.Location = new Point(58, 6);
            btnEraser.Margin = new Padding(4, 3, 4, 3);
            btnEraser.Name = "btnEraser";
            btnEraser.Size = new Size(38, 38);
            btnEraser.TabIndex = 3;
            btnEraser.UseVisualStyleBackColor = true;
            btnEraser.Click += btnEraser_Click;
            // 
            // btnPencil
            // 
            btnPencil.BackgroundImage = SimplePaintApp.Properties.Resources.brush;
            btnPencil.BackgroundImageLayout = ImageLayout.Zoom;
            btnPencil.Location = new Point(12, 4);
            btnPencil.Margin = new Padding(4, 3, 4, 3);
            btnPencil.Name = "btnPencil";
            btnPencil.Size = new Size(38, 38);
            btnPencil.TabIndex = 2;
            btnPencil.UseVisualStyleBackColor = true;
            btnPencil.Click += btnPencil_Click;
            // 
            // trackBarSize
            // 
            trackBarSize.Location = new Point(12, 87);
            trackBarSize.Margin = new Padding(4, 3, 4, 3);
            trackBarSize.Maximum = 64;
            trackBarSize.Minimum = 1;
            trackBarSize.Name = "trackBarSize";
            trackBarSize.Size = new Size(233, 45);
            trackBarSize.TabIndex = 1;
            trackBarSize.Value = 3;
            trackBarSize.Scroll += trackBarSize_Scroll;
            // 
            // lblBrushSize
            // 
            lblBrushSize.AutoSize = true;
            lblBrushSize.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBrushSize.Location = new Point(253, 99);
            lblBrushSize.Margin = new Padding(4, 0, 4, 0);
            lblBrushSize.Name = "lblBrushSize";
            lblBrushSize.Size = new Size(57, 15);
            lblBrushSize.TabIndex = 0;
            lblBrushSize.Text = "Size: 3px";
            // 
            // PaintForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 648);
            Controls.Add(panelTools);
            Controls.Add(pictureBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(931, 686);
            Name = "PaintForm";
            Text = "Baint";
            Load += PaintForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelTools.ResumeLayout(false);
            panelTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}