namespace ImageProcessing
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.frmImage = new System.Windows.Forms.PictureBox();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplasianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplasianToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imageSmoothingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filtersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(603, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.frmImage);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 509);
            this.panel1.TabIndex = 2;
            // 
            // frmImage
            // 
            this.frmImage.Location = new System.Drawing.Point(3, 3);
            this.frmImage.Name = "frmImage";
            this.frmImage.Size = new System.Drawing.Size(535, 470);
            this.frmImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.frmImage.TabIndex = 1;
            this.frmImage.TabStop = false;
            this.frmImage.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.frmImage_LoadCompleted);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laplasianToolStripMenuItem,
            this.laplasianToolStripMenuItem1,
            this.imageSmoothingToolStripMenuItem,
            this.inverseToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // laplasianToolStripMenuItem
            // 
            this.laplasianToolStripMenuItem.Name = "laplasianToolStripMenuItem";
            this.laplasianToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.laplasianToolStripMenuItem.Text = "GrayScale";
            this.laplasianToolStripMenuItem.Click += new System.EventHandler(this.laplasianToolStripMenuItem_Click);
            // 
            // laplasianToolStripMenuItem1
            // 
            this.laplasianToolStripMenuItem1.Name = "laplasianToolStripMenuItem1";
            this.laplasianToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.laplasianToolStripMenuItem1.Text = "Laplasian";
            this.laplasianToolStripMenuItem1.Click += new System.EventHandler(this.laplasianToolStripMenuItem1_Click);
            // 
            // imageSmoothingToolStripMenuItem
            // 
            this.imageSmoothingToolStripMenuItem.Name = "imageSmoothingToolStripMenuItem";
            this.imageSmoothingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imageSmoothingToolStripMenuItem.Text = "Image Smoothing";
            this.imageSmoothingToolStripMenuItem.Click += new System.EventHandler(this.imageSmoothingToolStripMenuItem_Click);
            // 
            // inverseToolStripMenuItem
            // 
            this.inverseToolStripMenuItem.Name = "inverseToolStripMenuItem";
            this.inverseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inverseToolStripMenuItem.Text = "Inverse";
            this.inverseToolStripMenuItem.Click += new System.EventHandler(this.inverseToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Image Processing App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox frmImage;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplasianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplasianToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem imageSmoothingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inverseToolStripMenuItem;
    }
}

