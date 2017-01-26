using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LoginWebServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class LoginWS : ILoginWS
    {
        private Dictionary<string, string> users = new Dictionary<string, string>()
        {
            { "Ivan", "1"},
            { "Peter", "2"},
            { "Gosho", "3"},
            { "Bobi", "4"}
        };

        public bool IsValid(string username, string pwd)
        {
            if (!users.ContainsKey(username) || username == null)
            {
                return false;
            }

            return users[username].Equals(pwd);
        }
    }
}
