using System;
using System.Drawing;
using System.Windows.Forms;

namespace PluginSDK
{
    public abstract class IChatFormPlugin : IChatFormControl, IPlugin
    {
        /// <summary>
        /// Connect to this chat source.
        /// </summary>
        public abstract bool connect();

        /// <summary>
        /// Disconnect from this chat source.
        /// </summary>
        public abstract bool disconnect();

        /// <summary>
        /// Setup the account to be used for this chat source.
        /// </summary>
        /// <param name="account">Account to be used for connecting and discconnecting to this chat source.</param>
        /// <returns>True if successful.</returns>
        public abstract bool setup(Account account);

        #region Methods from the IPlugin interface

        /// <summary>
        /// Property for plugin author's name.
        /// </summary>
        /// <returns>Returns the name of the author who created the plugin.</returns>
        public abstract string AuthorName { get; protected set; }

        /// <summary>
        /// Property for plugin name.
        /// </summary>
        /// <returns>Returns the name of the plugin.</returns>
        public abstract string PluginName { get; protected set; }

        /// <summary>
        /// Property for plugin version.
        /// </summary>
        /// <returns>Returns the version of the plugin.</returns>
        public abstract string PluginVersion { get; protected set; }

        #endregion
    }
}
