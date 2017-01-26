using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFLibrary
{
    /// <summary>
    /// Interaction logic for WPFLoginControl.xaml
    /// </summary>
    public partial class WPFLoginControl : UserControl
    {
        public event LoginEventHandler Login;

        public WPFLoginControl()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (Login != null)
            {
               Login(this, new LoginEventArgs(txtUserName.Text, txtPassword.Text));
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            txtUserName.Text = string.Empty; 
        }
    }
}
