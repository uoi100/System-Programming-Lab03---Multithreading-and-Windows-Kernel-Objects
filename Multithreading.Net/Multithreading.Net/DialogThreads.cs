using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multithreading.Net
{
    public partial class DialogThreads : Form
    {
        public DialogThreads()
        {
            InitializeComponent();
        }

        public int Threads
        {
            get { return int.Parse(num_Threads.Value.ToString()); }
        }

        public int Seconds
        {
            get { return int.Parse(num_Time.Value.ToString()); }
        }
    }
}
