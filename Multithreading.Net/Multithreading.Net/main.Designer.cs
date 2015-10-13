namespace Multithreading.Net
{
    partial class main
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
            this.startThreadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startThreadsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.startProcessesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startThreadsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.AutoSizeChanged += new System.EventHandler(this.menuStrip1_Resize);
            this.menuStrip1.Resize += new System.EventHandler(this.menuStrip1_Resize);
            // 
            // startThreadsToolStripMenuItem
            // 
            this.startThreadsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startThreadsToolStripMenuItem1,
            this.startProcessesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.startThreadsToolStripMenuItem.Name = "startThreadsToolStripMenuItem";
            this.startThreadsToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.startThreadsToolStripMenuItem.Text = "File";
            // 
            // startThreadsToolStripMenuItem1
            // 
            this.startThreadsToolStripMenuItem1.Name = "startThreadsToolStripMenuItem1";
            this.startThreadsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.startThreadsToolStripMenuItem1.Text = "Start Threads";
            this.startThreadsToolStripMenuItem1.Click += new System.EventHandler(this.startThreadsToolStripMenuItem1_Click);
            // 
            // startProcessesToolStripMenuItem
            // 
            this.startProcessesToolStripMenuItem.Name = "startProcessesToolStripMenuItem";
            this.startProcessesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startProcessesToolStripMenuItem.Text = "Start Processes";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "Calvin Truong Lab03 - Multithreading";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startThreadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startThreadsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem startProcessesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

