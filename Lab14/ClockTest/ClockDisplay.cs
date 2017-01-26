using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockTest
{
    public partial class ClockDisplay : Form
    {
        public ClockDisplay()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            clockAnimationUsingThread1.Resume();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            clockAnimationUsingThread1.Stop();
        }
    }
}
