using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e) {}
        private void pictureBox2_Click(object sender, EventArgs e) {}
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
                pictureBox2.Image = new Bitmap(filename);
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
    }
}
