using System;

namespace PluginSDK
{
    public class IFollowerArgs : EventArgs
    {
        public IFollower Follower { get; private set; }

        public IFollowerArgs(IFollower follower)
        {
            Follower = follower;
        }
    }
}
