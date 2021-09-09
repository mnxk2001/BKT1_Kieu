
namespace BTKT1_MaiNguyenXuanKieu_1954052044
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bTKT1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bai10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bai13ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bTKT1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bTKT1ToolStripMenuItem
            // 
            this.bTKT1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bai10ToolStripMenuItem,
            this.bai13ToolStripMenuItem});
            this.bTKT1ToolStripMenuItem.Name = "bTKT1ToolStripMenuItem";
            this.bTKT1ToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.bTKT1ToolStripMenuItem.Text = "BTKT1";
            // 
            // bai10ToolStripMenuItem
            // 
            this.bai10ToolStripMenuItem.Name = "bai10ToolStripMenuItem";
            this.bai10ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bai10ToolStripMenuItem.Text = "Bài 10";
            this.bai10ToolStripMenuItem.Click += new System.EventHandler(this.bai10ToolStripMenuItem_Click);
            // 
            // bai13ToolStripMenuItem
            // 
            this.bai13ToolStripMenuItem.Name = "bai13ToolStripMenuItem";
            this.bai13ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bai13ToolStripMenuItem.Text = "Bài 13";
            this.bai13ToolStripMenuItem.Click += new System.EventHandler(this.bai13ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "HomePage - BTKT1 - Mai Nguyễn Xuân Kiều - 1954052044";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bTKT1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bai10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bai13ToolStripMenuItem;
    }
}

