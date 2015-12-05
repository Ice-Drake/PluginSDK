using System;
using System.Collections.Generic;

namespace PluginSDK
{
    /// <summary>
    ///  All follower plugins must implement this interface.
    /// </summary>
    public interface IFollowerPlugin : IFollower, IDatabase, IPlugin
    {
        
    }
}
