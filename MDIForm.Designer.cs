namespace FracMaster
{
    partial class MDIForm
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
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mandelbrotFractalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juliaFractalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newtonFractalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFractalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(668, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator3,
            this.loadFractalToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mandelbrotFractalToolStripMenuItem,
            this.toolStripSeparator1,
            this.juliaFractalToolStripMenuItem,
            this.toolStripSeparator2,
            this.newtonFractalToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New Fractal";
            // 
            // mandelbrotFractalToolStripMenuItem
            // 
            this.mandelbrotFractalToolStripMenuItem.Name = "mandelbrotFractalToolStripMenuItem";
            this.mandelbrotFractalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mandelbrotFractalToolStripMenuItem.Text = "Type 1";
            this.mandelbrotFractalToolStripMenuItem.Click += new System.EventHandler(this.mandelbrotFractalToolStripMenuItem_Click);
            // 
            // juliaFractalToolStripMenuItem
            // 
            this.juliaFractalToolStripMenuItem.Name = "juliaFractalToolStripMenuItem";
            this.juliaFractalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.juliaFractalToolStripMenuItem.Text = "Type 2";
            this.juliaFractalToolStripMenuItem.Click += new System.EventHandler(this.juliaFractalToolStripMenuItem_Click);
            // 
            // newtonFractalToolStripMenuItem
            // 
            this.newtonFractalToolStripMenuItem.Name = "newtonFractalToolStripMenuItem";
            this.newtonFractalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newtonFractalToolStripMenuItem.Text = "Type 3";
            this.newtonFractalToolStripMenuItem.Click += new System.EventHandler(this.newtonFractalToolStripMenuItem_Click);
            // 
            // loadFractalToolStripMenuItem
            // 
            this.loadFractalToolStripMenuItem.Name = "loadFractalToolStripMenuItem";
            this.loadFractalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadFractalToolStripMenuItem.Text = "Load Fractal";
            this.loadFractalToolStripMenuItem.Click += new System.EventHandler(this.loadFractalToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrangeToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // arrangeToolStripMenuItem
            // 
            this.arrangeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadedToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.tileVerticalToolStripMenuItem});
            this.arrangeToolStripMenuItem.Name = "arrangeToolStripMenuItem";
            this.arrangeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.arrangeToolStripMenuItem.Text = "Arrange";
            // 
            // cascadedToolStripMenuItem
            // 
            this.cascadedToolStripMenuItem.Name = "cascadedToolStripMenuItem";
            this.cascadedToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cascadedToolStripMenuItem.Text = "Cascade";
            this.cascadedToolStripMenuItem.Click += new System.EventHandler(this.cascadedToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Tile Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.tileHorizontalToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tileVerticalToolStripMenuItem.Text = "Tile Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 434);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MDIForm";
            this.Text = "Fractal Graphics";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mandelbrotFractalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juliaFractalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFractalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newtonFractalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

    }
}

