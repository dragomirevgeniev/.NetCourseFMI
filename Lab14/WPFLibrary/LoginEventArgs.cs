using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLibrary
{
    public delegate void LoginEventHandler(object sender, LoginEventArgs args);

    public class LoginEventArgs : EventArgs
    {
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public LoginEventArgs(string un, string pwd)
        {
            UserName = un;
            Password = pwd;
        }
    }
}
