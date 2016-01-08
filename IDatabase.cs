using System;

namespace PluginSDK
{
    /// <summary>
    ///  All plugins that use a significantly large database should implement this interface.
    /// </summary>
    public interface IDatabase
    {
        /// <summary>
        /// Load the database associated to the plugin.
        /// </summary>
        /// <remarks>This will be called during the program startup after the plugins are loaded or constructed.</remarks>
        void loadDatabase();
    }
}