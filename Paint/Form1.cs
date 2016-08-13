using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Paint
{
    public partial class Form1 : Form
    {
        private Bitmap canvas;
        private Graphics g;
        private Color currentColor;
        private Point lastPoint = Point.Empty;
        private bool isMouseDown = new Boolean();
        public Pen p;

        // Constructor
        public Form1()
        {
            InitializeComponent();

            canvas = new Bitmap(theCanvas.Width, theCanvas.Height);
            theCanvas.Image = canvas;
            g = Graphics.FromImage(theCanvas.Image);
        }

        // Actions to be performed on load
        private void Form1_Load_1(object sender, EventArgs e)
        {
            currentColor = Color.Black;
            brush.BackColor = Color.White;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
            isMouseDown = true;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            positionLabel.Text = "Position: " + e.X + ", " + e.Y;
            if (isMouseDown == true)
            {
                if (lastPoint != null)
                {
                    p = new Pen(currentColor);
                    p.StartCap = LineCap.Round;
                    p.EndCap = LineCap.Round;

                    if (!thicknessDD.Text.Equals(""))
                    {
                        p.Width = float.Parse(thicknessDD.Text);
                    }

                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.DrawLine(p, lastPoint, e.Location);
                    lastPoint = e.Location;
                    p.Dispose();
                }
            }
            theCanvas.Invalidate();
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
            isMouseDown = false;
        }

        // Function to be executed when the menu item "File > Open" is clicked
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog object
            OpenFileDialog ofd = new OpenFileDialog();
            // Only allow image file types
            ofd.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            // Check to make sure the user picked something
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                // Create a String to store the path and filename. (ex, C:\Users\RickyDam\Desktop\NewFolder\Gnar.png)
                String filename = ofd.FileName;
                // Create an Image object from the selected file
                Image img = Image.FromFile(filename);
                // Set the PictureBox image to a bitmap of the selected file
                Bitmap bitmap = new Bitmap(filename);
                theCanvas.Image = bitmap;
                // Set the PictureBox's Height to be the same as the selected image's Height
                theCanvas.Height = img.Height;
                // Set the PictureBox's Width to be the same as the selected image's Width
                theCanvas.Width = img.Width;
            }
        }

        // Clear the drawing the "Edit > Clear" is clicked
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas = new Bitmap(theCanvas.Width, theCanvas.Height);
            theCanvas.Image = canvas;
            g = Graphics.FromImage(theCanvas.Image);
        }

        private void blackColour_Click(object sender, EventArgs e)
        {
            currentColor = blackColour.BackColor;
            selectedColour.BackColor = currentColor;
        }

        private void grayColour_Click(object sender, EventArgs e)
        {
            currentColor = grayColour.BackColor;
            selectedColour.BackColor = currentColor;
        }

        private void redColour_Click(object sender, EventArgs e)
        {
            currentColor = redColour.BackColor;
            selectedColour.BackColor = currentColor;
        }

        private void orangeColour_Click(object sender, EventArgs e)
        {
            currentColor = orangeColour.BackColor;
            selectedColour.BackColor = currentColor;
        }

        private void yellowColour_Click(object sender, EventArgs e)
        {
            currentColor = yellowColour.BackColor;
            selectedColour.BackColor = currentColor;
        }

        private void greenColour_Click(object sender, EventArgs e)
        {
            currentColor = greenColour.BackColor;
            selectedColour.BackColor = currentColor;
        }

        private void aquaColour_Click(object sender, EventArgs e)
        {
            currentColor = aquaColour.BackColor;
            selectedColour.BackColor = currentColor;
        }

        private void blueColour_Click(object sender, EventArgs e)
        {
            currentColor = blueColour.BackColor;
            selectedColour.BackColor = currentColor;
        }

        private void purpleColour_Click(object sender, EventArgs e)
        {
            currentColor = purpleColour.BackColor;
            selectedColour.BackColor = currentColor;
        }

        private void pinkColour_Click(object sender, EventArgs e)
        {
            currentColor = pinkColour.BackColor;
            selectedColour.BackColor = currentColor;
        }

        private void rainbowColour_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            currentColor = colorDialog1.Color;
            selectedColour.BackColor = currentColor;
        }

        private void brush_Click(object sender, EventArgs e)
        {
            brush.BackColor = Color.White;
            bucket.BackColor = BackColor;
        }

        private void bucket_Click(object sender, EventArgs e)
        {
            bucket.BackColor = Color.White;
            brush.BackColor = BackColor;
        }

        private bool ColorMatch(Color colour1, Color colour2)
        {
            return (colour1.ToArgb() & 0xFFFFFF) == (colour2.ToArgb() & 0xFFFFFF);
        }

        private void floodFill(Bitmap bmp, Point pt, Color oldColour, Color newColour)
        {
            Queue<Point> theQueue = new Queue<Point>();
            theQueue.Enqueue(pt);
            while (theQueue.Count > 0)
            {
                Point up = theQueue.Dequeue();
                if (!ColorMatch(bmp.GetPixel(up.X, up.Y), newColour))
                {
                    continue;
                }
                Point left = up;
                Point right = new Point((up.X) + 1, up.Y);
                while ((left.X >= 0) && ColorMatch(bmp.GetPixel(left.X, (left.Y) - 1), oldColour))
                {
                    bmp.SetPixel(left.X, left.Y, newColour);
                    if((left.Y > 0) && ColorMatch(bmp.GetPixel(left.X, left.Y - 1), oldColour))
                    {
                        theQueue.Enqueue(new Point(left.X, left.Y - 1));
                    }
                    if ((left.Y > bmp.Height - 1) && ColorMatch(bmp.GetPixel(left.X, left.Y + 1), oldColour))
                    {
                        theQueue.Enqueue(new Point(left.X, left.Y + 1));
                    }
                    left.X--;
                }
                while ((right.X <= bmp.Width - 1) && ColorMatch(bmp.GetPixel(right.X, right.Y), oldColour))
                {
                    bmp.SetPixel(right.X, right.Y, newColour);
                    if ((right.Y > 0) && ColorMatch(bmp.GetPixel(right.X, right.Y - 1), oldColour))
                    {
                        theQueue.Enqueue(new Point(right.X, right.Y - 1));
                    }
                    if ((right.Y > bmp.Height - 1) && ColorMatch(bmp.GetPixel(right.X, right.Y + 1), oldColour))
                    {
                        theQueue.Enqueue(new Point(right.X, right.Y + 1));
                    }
                    right.X++;
                }
            }
        }

        private void theCanvas_Click(object sender, EventArgs e)
        {
            //Console.Write(MousePosition.X);
            //Console.Write(" " + MousePosition.Y);
            //Console.WriteLine();
            //floodFill(canvas, new Point(MousePosition.X, MousePosition.Y), Color.White, Color.Black);
        }
    }
}
