using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PluginSDK
{
    public class Account
    {
        public string Server { get; private set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Domain { get; set; }
        public string OwnerID { get; private set; }

        public Account(string server, string ownerID)
        {
            Server = server;
            OwnerID = ownerID;
        }

        public bool canLog()
        {
            if (Username.Length != 0 && Password.Length != 0 && Domain.Length != 0)
                return true;
            else
                return false;
        }
    }
}
