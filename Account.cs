using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PluginSDK
{
    public class Account
    {
        public string Username { get; private set; }
        public string Password { get; set; }
        public string Domain { get; private set; }
        public string Owner { get; private set; }

        Account(string username, string password, string domain, string owner)
        {
            Username = username;
            Password = password;
            Domain = domain;
            Owner = owner;
        }
    }
}
