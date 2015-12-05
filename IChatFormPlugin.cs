using System;
using System.Drawing;
using System.Windows.Forms;

namespace PluginSDK
{
    public abstract class IChatFormPlugin : IChatFormControl, IPlugin
    {
        #region Methods from the IPlugin interface

        /// <summary>
        /// Property for plugin author's name.
        /// </summary>
        /// <returns>Returns the name of the author who created the plugin.</returns>
        public abstract string AuthorName { get; }

        /// <summary>
        /// Property for plugin name.
        /// </summary>
        /// <returns>Returns the name of the plugin.</returns>
        public abstract string PluginName { get; }

        /// <summary>
        /// Property for plugin version.
        /// </summary>
        /// <returns>Returns the version of the plugin.</returns>
        public abstract string PluginVersion { get; }

        #endregion
    }
}
