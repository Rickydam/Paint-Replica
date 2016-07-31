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
        public Bitmap canvas;
        public Graphics g;
        public Color currentColor;
        private Point lastPoint = Point.Empty;
        private bool isMouseDown = new Boolean();
        
        // Constructor
        public Form1()
        {
            InitializeComponent();

            canvas = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            pictureBox2.Image = canvas;
            g = Graphics.FromImage(pictureBox2.Image);
        }

        // Actions to be performed on load
        private void Form1_Load_1(object sender, EventArgs e)
        {
            currentColor = Color.Black;
            // currentColorBox.BackColor = currentColor;
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
                    Pen p = new Pen(currentColor);
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.DrawLine(p, lastPoint, e.Location);
                    lastPoint = e.Location;
                    p.Dispose();
                }
            }
            pictureBox2.Invalidate();
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
            isMouseDown = false;
        }

        // Actions to be performed when the PictureBox is clicked
        private void pictureBox2_Click(object sender, EventArgs e) {}

        // Actions to be performed when menu strip is clicked
        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {}

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
                pictureBox2.Image = bitmap;
                // Set the PictureBox's Height to be the same as the selected image's Height
                pictureBox2.Height = img.Height;
                // Set the PictureBox's Width to be the same as the selected image's Width
                pictureBox2.Width = img.Width;
            }
        }

        // Function to be executed when the menu item "File > Draw" is clicked
        private void drawToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
