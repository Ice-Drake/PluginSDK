using System;

namespace PluginSDK
{
    public class IProfessionArgs : EventArgs
    {
        public IProfessionPlugin Profession { get; private set; }

        public IProfessionArgs(IProfessionPlugin profession)
        {
            Profession = profession;
        }
    }
}
