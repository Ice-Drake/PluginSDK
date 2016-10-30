using System;

namespace PluginSDK
{
    /// <summary>
    ///  All modules and plugins must apply this attribute in order to be properly detected by MultiDesktop.
    ///  <para>All properties in this attribute will be called and used by the About box.</para> 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class PluginAttribute : Attribute
    {
        /// <summary>
        /// Property for plugin author's name.
        /// </summary>
        /// <returns>Returns the name of the author who created the plugin.</returns>
        public string AuthorName { get; set; }

        /// <summary>
        /// Property for plugin name.
        /// </summary>
        /// <returns>Returns the name of the plugin.</returns>
        public string PluginName { get; set; }

        /// <summary>
        /// Property for plugin version.
        /// </summary>
        /// <returns>Returns the version of the plugin.</returns>
        public string PluginVersion { get; set; }

        public PluginAttribute()
        {
            AuthorName = "Anonymous";
            PluginName = "Unknown";
            PluginVersion = "1.0";
        }
    }
}