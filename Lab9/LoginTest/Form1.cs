using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginControl1_Login(object senderf, UsrLibrary.LoginEventArgs args)
        {
            MessageBox.Show(args.Username + " " + args.Password);
            loginControl1.Username = "";


        }
    }
}
