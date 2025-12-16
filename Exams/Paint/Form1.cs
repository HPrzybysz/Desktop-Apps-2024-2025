using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SimplePaintApp
{
    public partial class PaintForm : Form
    {
        private Bitmap canvas;
        private Graphics graphics;
        private Pen currentPen;
        private SolidBrush fillBrush;
        private bool isDrawing = false;
        private bool isErasing = false;
        private bool isFilling = false;
        private Point previousPoint;
        private ToolMode currentMode = ToolMode.Pencil;
        private Color currentColor = Color.Black;
        private int brushSize = 3;

        private enum ToolMode
        {
            Pencil,
            Eraser,
            Fill
        }

        public PaintForm()
        {
            InitializeComponent();
            InitializeCanvas();
            SetupColorButtons();

            //tools:
            trackBarSize.Value = brushSize;
            lblBrushSize.Text = $"Size: {brushSize}px";

            btnPencil.BackColor = Color.LightBlue;
        }

        private void InitializeCanvas()
        {
            canvas = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(canvas);
            graphics.Clear(Color.White);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pictureBox.Image = canvas;

            currentPen = new Pen(currentColor, brushSize);
            currentPen.StartCap = LineCap.Round;
            currentPen.EndCap = LineCap.Round;

            fillBrush = new SolidBrush(currentColor);
        }

        private void SetupColorButtons()
        {
            Color[] colors = {
                Color.Black, Color.White, Color.Red, Color.Green, Color.Blue,
                Color.Yellow, Color.Magenta, Color.Cyan, Color.Orange,
                Color.Purple, Color.Brown, Color.Gray
            };

            int buttonSize = 25;
            int margin = 5;
            int x = margin;

            foreach (var color in colors)
            {
                var btn = new Button
                {
                    Size = new Size(buttonSize, buttonSize),
                    Location = new Point(x, 5),
                    BackColor = color,
                    FlatStyle = FlatStyle.Flat
                };

                if (color == Color.White || color == Color.Yellow)
                {
                    btn.FlatAppearance.BorderColor = Color.Gray;
                    btn.FlatAppearance.BorderSize = 1;
                }

                btn.Click += (s, e) =>
                {
                    currentColor = color;
                    //paint updt
                    /*currentPen.Color = currentColor;
                    fillBrush.Color = currentColor;*/
                    UpdatePenAndBrush();
                    lblCurrentColor.BackColor = color;
                };

                flowLayoutPanelColors.Controls.Add(btn);
                x += buttonSize + margin;
            }
        }

        //draw mechanics
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            previousPoint = e.Location;

            if (currentMode == ToolMode.Fill)
            {
                FloodFill(e.Location);
                pictureBox.Refresh();
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;

            if (currentMode == ToolMode.Pencil || currentMode == ToolMode.Eraser)
            {
                using (Graphics g = Graphics.FromImage(canvas))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;

                    if (currentMode == ToolMode.Eraser)
                    {
                        using (Pen eraser = new Pen(Color.White, brushSize * 2))
                        {
                            eraser.StartCap = LineCap.Round;
                            eraser.EndCap = LineCap.Round;
                            g.DrawLine(eraser, previousPoint, e.Location);
                        }
                    }
                    else
                    {
                        g.DrawLine(currentPen, previousPoint, e.Location);
                    }
                }

                previousPoint = e.Location;
                pictureBox.Refresh();
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }
        ////////////////////////////////////////////////////////
        private void FloodFill(Point startPoint)
        {
            Color targetColor = canvas.GetPixel(startPoint.X, startPoint.Y);
            if (targetColor.ToArgb() == currentColor.ToArgb()) return;

            Stack<Point> pixels = new Stack<Point>();
            pixels.Push(startPoint);

            while (pixels.Count > 0)
            {
                Point pt = pixels.Pop();
                if (pt.X < 0 || pt.X >= canvas.Width || pt.Y < 0 || pt.Y >= canvas.Height)
                    continue;

                if (canvas.GetPixel(pt.X, pt.Y) != targetColor)
                    continue;

                canvas.SetPixel(pt.X, pt.Y, currentColor);

                pixels.Push(new Point(pt.X - 1, pt.Y));
                pixels.Push(new Point(pt.X + 1, pt.Y));
                pixels.Push(new Point(pt.X, pt.Y - 1));
                pixels.Push(new Point(pt.X, pt.Y + 1));
            }
        }

        //tools selection & colors stuff
        private void btnPencil_Click(object sender, EventArgs e)
        {
            currentMode = ToolMode.Pencil;
            UpdateToolButtons(btnPencil);
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            currentMode = ToolMode.Eraser;
            UpdateToolButtons(btnEraser);
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            currentMode = ToolMode.Fill;
            UpdateToolButtons(btnFill);
        }

        private void UpdateToolButtons(Button activeButton)
        {
            btnPencil.BackColor = Color.LightGray;
            btnEraser.BackColor = Color.LightGray;
            btnFill.BackColor = Color.LightGray;
            activeButton.BackColor = Color.LightBlue;
        }

        private void trackBarSize_Scroll(object sender, EventArgs e)
        {
            brushSize = trackBarSize.Value;
            currentPen.Width = brushSize;
            lblBrushSize.Text = $"Size: {brushSize}px";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            pictureBox.Refresh();
        }

        private void btnColorPicker_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = currentColor;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    currentColor = colorDialog.Color;
                    UpdatePenAndBrush();
                    lblCurrentColor.BackColor = currentColor;
                }
            }
        }

        private void UpdatePenAndBrush()
        {
            currentPen.Color = currentColor;
            fillBrush.Color = currentColor;
        }

        //open
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif|All Files|*.*";
                openFileDialog.Title = "Open Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Bitmap loadedImage = new Bitmap(openFileDialog.FileName);
                        canvas = new Bitmap(loadedImage, pictureBox.Size);
                        graphics = Graphics.FromImage(canvas);
                        pictureBox.Image = canvas;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error opening file: {ex.Message}", "Error",
                            MessageBoxButtons.OK);
                    }
                }
            }
        }

        //save
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                saveFileDialog.Title = "Save Image";
                saveFileDialog.DefaultExt = "png";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        canvas.Save(saveFileDialog.FileName);
                        MessageBox.Show("Image saved successfully!", "Success",
                            MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving file: {ex.Message}", "Error",
                            MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            currentPen.Dispose();
            fillBrush.Dispose();
            graphics.Dispose();
            base.OnFormClosing(e);
        }

        private void PaintForm_Load(object sender, EventArgs e)
        {

        }
    }
}