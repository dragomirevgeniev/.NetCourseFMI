using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsrLibrary
{
    /// <summary>
    /// 1. Event object definition
    /// </summary>
    public class LoginEventArgs: EventArgs

    {
        public string Username { get; set; }
        public string  Password { get; set; }
        public LoginEventArgs(string u, string p)
        {
            Username = u;
            Password = p;

        }
    }

    // 2. Delegate for the event handling 
    public delegate void LoginEventHandler(object senderf, LoginEventArgs args);

}
