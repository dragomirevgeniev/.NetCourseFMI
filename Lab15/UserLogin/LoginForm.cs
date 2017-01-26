using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserLogin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ServiceReference1.LoginWSClient client = new ServiceReference1.LoginWSClient();
            string result = "";
            if (client.IsValid(txtUsername.Text, txtPassword.Text))
            {
                result = "Valid user";
            }
            else
            {
                result = "Invalid user";
            }

            MessageBox.Show(result + "!");
        }
    }
}
