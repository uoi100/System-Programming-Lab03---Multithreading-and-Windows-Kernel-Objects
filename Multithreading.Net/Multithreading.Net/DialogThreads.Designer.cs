namespace Multithreading.Net
{
    partial class DialogThreads
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_Threads = new System.Windows.Forms.NumericUpDown();
            this.num_Time = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_Threads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Time)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Threads:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time to Run (seconds):";
            // 
            // num_Threads
            // 
            this.num_Threads.Location = new System.Drawing.Point(153, 25);
            this.num_Threads.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.num_Threads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Threads.Name = "num_Threads";
            this.num_Threads.Size = new System.Drawing.Size(120, 20);
            this.num_Threads.TabIndex = 2;
            this.num_Threads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // num_Time
            // 
            this.num_Time.Location = new System.Drawing.Point(153, 57);
            this.num_Time.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Time.Name = "num_Time";
            this.num_Time.Size = new System.Drawing.Size(120, 20);
            this.num_Time.TabIndex = 3;
            this.num_Time.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(16, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(197, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DialogThreads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 168);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.num_Time);
            this.Controls.Add(this.num_Threads);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DialogThreads";
            this.Text = "DialogThreads";
            ((System.ComponentModel.ISupportInitialize)(this.num_Threads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Time)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_Threads;
        private System.Windows.Forms.NumericUpDown num_Time;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}