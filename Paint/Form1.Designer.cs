namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theCanvas = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.positionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.colourTable = new System.Windows.Forms.TableLayoutPanel();
            this.blackColour = new System.Windows.Forms.PictureBox();
            this.grayColour = new System.Windows.Forms.PictureBox();
            this.blueColour = new System.Windows.Forms.PictureBox();
            this.aquaColour = new System.Windows.Forms.PictureBox();
            this.greenColour = new System.Windows.Forms.PictureBox();
            this.yellowColour = new System.Windows.Forms.PictureBox();
            this.redColour = new System.Windows.Forms.PictureBox();
            this.orangeColour = new System.Windows.Forms.PictureBox();
            this.purpleColour = new System.Windows.Forms.PictureBox();
            this.pinkColour = new System.Windows.Forms.PictureBox();
            this.Colors = new System.Windows.Forms.GroupBox();
            this.thicknessDD = new System.Windows.Forms.ComboBox();
            this.thicknessLabel = new System.Windows.Forms.Label();
            this.selectedLabel = new System.Windows.Forms.Label();
            this.selectedColour = new System.Windows.Forms.PictureBox();
            this.rainbowColour = new System.Windows.Forms.PictureBox();
            this.customLabel = new System.Windows.Forms.Label();
            this.colourLabel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.brush = new System.Windows.Forms.PictureBox();
            this.bucket = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theCanvas)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.colourTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blackColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aquaColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purpleColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainbowColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucket)).BeginInit();
            this.SuspendLayout();
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.saveMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openMenuItem.Text = "Open Image";
            this.openMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveMenuItem.Text = "Save";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(603, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip2";
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 20);
            this.editMenu.Text = "Edit";
            // 
            // clearMenuItem
            // 
            this.clearMenuItem.Name = "clearMenuItem";
            this.clearMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearMenuItem.Text = "Clear";
            this.clearMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // theCanvas
            // 
            this.theCanvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.theCanvas.Location = new System.Drawing.Point(15, 77);
            this.theCanvas.Name = "theCanvas";
            this.theCanvas.Size = new System.Drawing.Size(500, 500);
            this.theCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.theCanvas.TabIndex = 1;
            this.theCanvas.TabStop = false;
            this.theCanvas.Click += new System.EventHandler(this.theCanvas_Click);
            this.theCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.theCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.theCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.positionLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 585);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(603, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // positionLabel
            // 
            this.positionLabel.BackColor = System.Drawing.Color.Transparent;
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(74, 17);
            this.positionLabel.Text = "Position: 0, 0";
            // 
            // colourTable
            // 
            this.colourTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.colourTable.ColumnCount = 10;
            this.colourTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.colourTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.colourTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.colourTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.colourTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.colourTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.colourTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.colourTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.colourTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.colourTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.colourTable.Controls.Add(this.blackColour, 0, 0);
            this.colourTable.Controls.Add(this.grayColour, 1, 0);
            this.colourTable.Controls.Add(this.blueColour, 7, 0);
            this.colourTable.Controls.Add(this.aquaColour, 6, 0);
            this.colourTable.Controls.Add(this.greenColour, 5, 0);
            this.colourTable.Controls.Add(this.yellowColour, 4, 0);
            this.colourTable.Controls.Add(this.redColour, 2, 0);
            this.colourTable.Controls.Add(this.orangeColour, 3, 0);
            this.colourTable.Controls.Add(this.purpleColour, 9, 0);
            this.colourTable.Controls.Add(this.pinkColour, 8, 0);
            this.colourTable.Location = new System.Drawing.Point(15, 37);
            this.colourTable.Name = "colourTable";
            this.colourTable.RowCount = 1;
            this.colourTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.colourTable.Size = new System.Drawing.Size(314, 34);
            this.colourTable.TabIndex = 0;
            // 
            // blackColour
            // 
            this.blackColour.BackColor = System.Drawing.Color.Black;
            this.blackColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blackColour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blackColour.Location = new System.Drawing.Point(4, 4);
            this.blackColour.Name = "blackColour";
            this.blackColour.Size = new System.Drawing.Size(24, 24);
            this.blackColour.TabIndex = 0;
            this.blackColour.TabStop = false;
            this.blackColour.Click += new System.EventHandler(this.blackColour_Click);
            // 
            // grayColour
            // 
            this.grayColour.BackColor = System.Drawing.Color.Gray;
            this.grayColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grayColour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grayColour.Location = new System.Drawing.Point(35, 4);
            this.grayColour.Name = "grayColour";
            this.grayColour.Size = new System.Drawing.Size(24, 24);
            this.grayColour.TabIndex = 1;
            this.grayColour.TabStop = false;
            this.grayColour.Click += new System.EventHandler(this.grayColour_Click);
            // 
            // blueColour
            // 
            this.blueColour.BackColor = System.Drawing.Color.RoyalBlue;
            this.blueColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blueColour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blueColour.Location = new System.Drawing.Point(221, 4);
            this.blueColour.Name = "blueColour";
            this.blueColour.Size = new System.Drawing.Size(24, 24);
            this.blueColour.TabIndex = 6;
            this.blueColour.TabStop = false;
            this.blueColour.Click += new System.EventHandler(this.blueColour_Click);
            // 
            // aquaColour
            // 
            this.aquaColour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.aquaColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aquaColour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aquaColour.Location = new System.Drawing.Point(190, 4);
            this.aquaColour.Name = "aquaColour";
            this.aquaColour.Size = new System.Drawing.Size(24, 24);
            this.aquaColour.TabIndex = 5;
            this.aquaColour.TabStop = false;
            this.aquaColour.Click += new System.EventHandler(this.aquaColour_Click);
            // 
            // greenColour
            // 
            this.greenColour.BackColor = System.Drawing.Color.ForestGreen;
            this.greenColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.greenColour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.greenColour.Location = new System.Drawing.Point(159, 4);
            this.greenColour.Name = "greenColour";
            this.greenColour.Size = new System.Drawing.Size(24, 24);
            this.greenColour.TabIndex = 4;
            this.greenColour.TabStop = false;
            this.greenColour.Click += new System.EventHandler(this.greenColour_Click);
            // 
            // yellowColour
            // 
            this.yellowColour.BackColor = System.Drawing.Color.Yellow;
            this.yellowColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yellowColour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yellowColour.Location = new System.Drawing.Point(128, 4);
            this.yellowColour.Name = "yellowColour";
            this.yellowColour.Size = new System.Drawing.Size(24, 24);
            this.yellowColour.TabIndex = 3;
            this.yellowColour.TabStop = false;
            this.yellowColour.Click += new System.EventHandler(this.yellowColour_Click);
            // 
            // redColour
            // 
            this.redColour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.redColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redColour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redColour.Location = new System.Drawing.Point(66, 4);
            this.redColour.Name = "redColour";
            this.redColour.Size = new System.Drawing.Size(24, 24);
            this.redColour.TabIndex = 9;
            this.redColour.TabStop = false;
            this.redColour.Click += new System.EventHandler(this.redColour_Click);
            // 
            // orangeColour
            // 
            this.orangeColour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orangeColour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orangeColour.Location = new System.Drawing.Point(97, 4);
            this.orangeColour.Name = "orangeColour";
            this.orangeColour.Size = new System.Drawing.Size(24, 24);
            this.orangeColour.TabIndex = 2;
            this.orangeColour.TabStop = false;
            this.orangeColour.Click += new System.EventHandler(this.orangeColour_Click);
            // 
            // purpleColour
            // 
            this.purpleColour.BackColor = System.Drawing.Color.Purple;
            this.purpleColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purpleColour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purpleColour.Location = new System.Drawing.Point(283, 4);
            this.purpleColour.Name = "purpleColour";
            this.purpleColour.Size = new System.Drawing.Size(24, 24);
            this.purpleColour.TabIndex = 7;
            this.purpleColour.TabStop = false;
            this.purpleColour.Click += new System.EventHandler(this.purpleColour_Click);
            // 
            // pinkColour
            // 
            this.pinkColour.BackColor = System.Drawing.Color.Violet;
            this.pinkColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pinkColour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pinkColour.Location = new System.Drawing.Point(252, 4);
            this.pinkColour.Name = "pinkColour";
            this.pinkColour.Size = new System.Drawing.Size(24, 24);
            this.pinkColour.TabIndex = 10;
            this.pinkColour.TabStop = false;
            this.pinkColour.Click += new System.EventHandler(this.pinkColour_Click);
            // 
            // Colors
            // 
            this.Colors.Location = new System.Drawing.Point(15, 31);
            this.Colors.Name = "Colors";
            this.Colors.Size = new System.Drawing.Size(314, 40);
            this.Colors.TabIndex = 3;
            this.Colors.TabStop = false;
            // 
            // thicknessDD
            // 
            this.thicknessDD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thicknessDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.thicknessDD.FormattingEnabled = true;
            this.thicknessDD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.thicknessDD.Location = new System.Drawing.Point(432, 44);
            this.thicknessDD.Name = "thicknessDD";
            this.thicknessDD.Size = new System.Drawing.Size(53, 21);
            this.thicknessDD.TabIndex = 4;
            // 
            // thicknessLabel
            // 
            this.thicknessLabel.AutoSize = true;
            this.thicknessLabel.Location = new System.Drawing.Point(429, 31);
            this.thicknessLabel.Name = "thicknessLabel";
            this.thicknessLabel.Size = new System.Drawing.Size(56, 13);
            this.thicknessLabel.TabIndex = 5;
            this.thicknessLabel.Text = "Thickness";
            // 
            // selectedLabel
            // 
            this.selectedLabel.AutoSize = true;
            this.selectedLabel.Location = new System.Drawing.Point(516, 37);
            this.selectedLabel.Name = "selectedLabel";
            this.selectedLabel.Size = new System.Drawing.Size(82, 13);
            this.selectedLabel.TabIndex = 6;
            this.selectedLabel.Text = "Selected Colour";
            // 
            // selectedColour
            // 
            this.selectedColour.BackColor = System.Drawing.Color.Black;
            this.selectedColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedColour.Location = new System.Drawing.Point(530, 53);
            this.selectedColour.Name = "selectedColour";
            this.selectedColour.Size = new System.Drawing.Size(53, 51);
            this.selectedColour.TabIndex = 7;
            this.selectedColour.TabStop = false;
            // 
            // rainbowColour
            // 
            this.rainbowColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rainbowColour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rainbowColour.Image = ((System.Drawing.Image)(resources.GetObject("rainbowColour.Image")));
            this.rainbowColour.Location = new System.Drawing.Point(378, 40);
            this.rainbowColour.Name = "rainbowColour";
            this.rainbowColour.Size = new System.Drawing.Size(25, 25);
            this.rainbowColour.TabIndex = 10;
            this.rainbowColour.TabStop = false;
            this.rainbowColour.Click += new System.EventHandler(this.rainbowColour_Click);
            // 
            // customLabel
            // 
            this.customLabel.AutoSize = true;
            this.customLabel.Location = new System.Drawing.Point(335, 41);
            this.customLabel.Name = "customLabel";
            this.customLabel.Size = new System.Drawing.Size(42, 13);
            this.customLabel.TabIndex = 9;
            this.customLabel.Text = "Custom";
            // 
            // colourLabel
            // 
            this.colourLabel.AutoSize = true;
            this.colourLabel.Location = new System.Drawing.Point(335, 53);
            this.colourLabel.Name = "colourLabel";
            this.colourLabel.Size = new System.Drawing.Size(37, 13);
            this.colourLabel.TabIndex = 11;
            this.colourLabel.Text = "Colour";
            // 
            // brush
            // 
            this.brush.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.brush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brush.Image = ((System.Drawing.Image)(resources.GetObject("brush.Image")));
            this.brush.Location = new System.Drawing.Point(525, 130);
            this.brush.Name = "brush";
            this.brush.Size = new System.Drawing.Size(30, 30);
            this.brush.TabIndex = 12;
            this.brush.TabStop = false;
            this.brush.Click += new System.EventHandler(this.brush_Click);
            // 
            // bucket
            // 
            this.bucket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bucket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bucket.Image = ((System.Drawing.Image)(resources.GetObject("bucket.Image")));
            this.bucket.Location = new System.Drawing.Point(561, 130);
            this.bucket.Name = "bucket";
            this.bucket.Size = new System.Drawing.Size(30, 30);
            this.bucket.TabIndex = 13;
            this.bucket.TabStop = false;
            this.bucket.Click += new System.EventHandler(this.bucket_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(519, 180);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 35);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Bucket fill is not implemented yet.";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(603, 607);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bucket);
            this.Controls.Add(this.brush);
            this.Controls.Add(this.colourLabel);
            this.Controls.Add(this.colourTable);
            this.Controls.Add(this.customLabel);
            this.Controls.Add(this.selectedColour);
            this.Controls.Add(this.selectedLabel);
            this.Controls.Add(this.thicknessLabel);
            this.Controls.Add(this.thicknessDD);
            this.Controls.Add(this.Colors);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.theCanvas);
            this.Controls.Add(this.rainbowColour);
            this.Controls.Add(this.menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Paint Replica";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theCanvas)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.colourTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.blackColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aquaColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purpleColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainbowColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.PictureBox theCanvas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel positionLabel;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem clearMenuItem;
        private System.Windows.Forms.TableLayoutPanel colourTable;
        private System.Windows.Forms.GroupBox Colors;
        private System.Windows.Forms.PictureBox blackColour;
        private System.Windows.Forms.PictureBox grayColour;
        private System.Windows.Forms.PictureBox purpleColour;
        private System.Windows.Forms.PictureBox blueColour;
        private System.Windows.Forms.PictureBox aquaColour;
        private System.Windows.Forms.PictureBox greenColour;
        private System.Windows.Forms.PictureBox yellowColour;
        private System.Windows.Forms.PictureBox redColour;
        private System.Windows.Forms.PictureBox orangeColour;
        private System.Windows.Forms.ComboBox thicknessDD;
        private System.Windows.Forms.Label thicknessLabel;
        private System.Windows.Forms.Label selectedLabel;
        private System.Windows.Forms.PictureBox selectedColour;
        private System.Windows.Forms.PictureBox rainbowColour;
        private System.Windows.Forms.Label customLabel;
        private System.Windows.Forms.PictureBox pinkColour;
        private System.Windows.Forms.Label colourLabel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.PictureBox brush;
        private System.Windows.Forms.PictureBox bucket;
        private System.Windows.Forms.TextBox textBox1;
    }
}

