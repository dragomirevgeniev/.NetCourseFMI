using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsrLibrary
{
    public partial class LoginControl : UserControl
    {
        /// 3. task to do
        // 3 declare event Login
        public event LoginEventHandler Login;

        public LoginControl()
        {
            InitializeComponent();
        }

        public string Username
        {
            get { 
            
                return txtUsername.Text;
            }
            set
            {
                txtUsername.Text = value;
            }
        }
        public string Password
        {
            get
            {
                return txtPassword.Text;
            }
            set
            {
                txtPassword.Text = value;
            }
        }
        /// <summary>
        /// 4. task to do
        /// </summary>
        /// <param name="sender"> a reference to the event source </param>
        /// <param name="e"> a reference to the event object</param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if(Login != null) // is any subscriber available
            {
                Login(this, new LoginEventArgs(txtUsername.Text, txtPassword.Text));
            }
        }
    }
}
