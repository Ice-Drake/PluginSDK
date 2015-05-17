using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PluginSDK
{
    /// <summary>
    ///  All plugins must implement this interface.
    ///  <para>All properties in this interface will be called and used by the About box.</para> 
    /// </summary>
    public interface IPlugin
    {
        /// <returns>Returns the name of the author who created the plugin.</returns>
        string AuthorName { get; }

        /// <returns>Returns the name of the plugin.</returns>
        string PluginName { get; }

        /// <returns>Returns the version of the plugin.</returns>
        string PluginVersion { get; }
    }
}
