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

        // Actions to be performed when the status label is clicked
        private void toolStripStatusLabel1_Click(object sender, EventArgs e) {}

        // Clear the drawing the "Edit > Clear" is clicked
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            pictureBox2.Image = canvas;
            g = Graphics.FromImage(pictureBox2.Image);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            currentColor = pictureBox1.BackColor;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            currentColor = pictureBox3.BackColor;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            currentColor = pictureBox11.BackColor;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {currentColor = pictureBox3.BackColor;
            currentColor = pictureBox4.BackColor;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            currentColor = pictureBox5.BackColor;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            currentColor = pictureBox6.BackColor;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            currentColor = pictureBox7.BackColor;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            currentColor = pictureBox8.BackColor;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            currentColor = pictureBox9.BackColor;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            currentColor = pictureBox10.BackColor;
        }
    }
}
