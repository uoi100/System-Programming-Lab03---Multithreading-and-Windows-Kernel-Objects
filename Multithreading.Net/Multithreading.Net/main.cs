using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Multithreading.Net
{

    public partial class main : Form
    {
        private Thread controller;
        private Thread[] workers;
        private TextBox[] textBoxes;
        private volatile bool abort;

        public main()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void startThreadsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogThreads dlg = new DialogThreads();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (textBoxes != null)
                {
                    if (textBoxes.Count<TextBox>() > 0)
                    {
                        for (int i = 0; i < textBoxes.Count<TextBox>(); i++)
                            this.Controls.Remove(textBoxes[i]);
                    }
                }

                // Create an array of Textboxes
                textBoxes = new TextBox[dlg.Threads + 1];

                int textWidth = Width / (dlg.Threads + 1);

                for (int i = 0; i < dlg.Threads + 1; i++)
                {
                    textBoxes[i] = new TextBox();
                    textBoxes[i].Height = ClientRectangle.Height - menuStrip1.Height;
                    textBoxes[i].Width = textWidth;
                    textBoxes[i].Location = new System.Drawing.Point(textWidth * i, menuStrip1.Height);
                    textBoxes[i].Multiline = true;
                    textBoxes[i].Text = string.Empty;
                    textBoxes[i].ScrollBars = ScrollBars.Vertical;
                    textBoxes[i].Enabled = false;

                    this.Controls.Add(textBoxes[i]);
                }

                abort = false;
                controller = new Thread(()=> controllerThread(0, dlg.Seconds));
                controller.Start();

                int index = 1;
                workers = new Thread[dlg.Threads];
                for(int i = 0; i < dlg.Threads; i++)
                    workers[i] = new Thread(()=> counterThread(index++));

                for (int i = 0; i < dlg.Threads; i++)
                    workers[i].Start();
            }
        }

        void controllerThread(int index, int seconds)
        {
            SetText(index, "Thread started at: " + DateTime.Now);

            try
            {
                Thread.Sleep(seconds * 1000);
            }
            catch (Exception e)
            {
                abort = true;
            }
            finally
            {
                abort = true;

                SetText(index, "Thread ended at: " + DateTime.Now);
            }
        }


        void counterThread(int index)
        {
            int counter = 0;

            while(!abort)
            {
                SetText(index, counter.ToString());
                counter++;
            }
        }

        void SetText(int index, String value)
        {
            try {
                if (InvokeRequired)
                {
                    Invoke(new Action<int, String>(SetText), new object[] { index, value });
                    return;
                }

                textBoxes[index].AppendText(value + "\r\n");
                Application.DoEvents();
            } catch (Exception e)
            {
                Application.Exit();
            }
        }

        private void menuStrip1_Resize(object sender, EventArgs e)
        {
            if(textBoxes != null)
            {
                int textWidth = Width / (textBoxes.Count<TextBox>());

                for (int i = 0; i < textBoxes.Count<TextBox>(); i++)
                {
                    textBoxes[i].Height = ClientRectangle.Height - menuStrip1.Height;
                    textBoxes[i].Width = textWidth;
                    textBoxes[i].Location = new System.Drawing.Point(textWidth * i, menuStrip1.Height);
                }

                Refresh();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            abort = true;
            controller.Abort();

            base.OnFormClosing(e);
        }
        // End of function
    }
}
