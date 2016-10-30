using System;

namespace PluginSDK
{
    /// <summary>
    ///  All modules must implement this interface in order to be properly utilized by MultiDesktop.
    /// </summary>
    public interface IModule
    {
        /// <summary>
        /// Activate the module.
        /// </summary>
        void activate();

        /// <summary>
        /// Attach a plugin to this module.
        /// </summary>
        /// <param name="plugin">Plugin to be attached.</param>
        /// <remarks>This will do nothing if the supplied plugin is not a part of this module.</remarks>
        void attachPlugin(object plugin);

        /// <summary>
        /// Check if a type is a valid plugin of this module.
        /// </summary>
        /// <param name="type">Type to be verified.</param>
        /// <returns>Returns true if the supplied type is a valid type of this module; otherwise, returns false.</returns>
        bool checkValidPlugin(Type type);
    }
}
