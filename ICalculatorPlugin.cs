using System;
using System.Windows.Controls;

namespace PluginSDK
{
    /// <summary>
    ///  All calculator plugins should implement this abstract class.
    /// </summary>
    public abstract class ICalculatorPlugin : UserControl, IPlugin
    {
        /// <summary>
        /// Property for plugin tab name.
        /// </summary>
        /// <returns>Returns the tab name of the plugin.</returns>
        public abstract string TabName { get; }

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

        /// <summary>
        /// Shared data with the calculator and all its plugin.
        /// </summary>
        protected SharedData sharedData;
    }
}
