using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PluginSDK
{
    public interface IPlugin
    {
        string AuthorName { get; }
        string PluginName { get; }
        string PluginVersion { get; }
    }
}
