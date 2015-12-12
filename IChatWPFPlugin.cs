using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Controls;

namespace PluginSDK
{
    public abstract class IChatWPFPlugin : UserControl, IChatSource, IPlugin
    {
        private Color textColor;

        public IChatWPFPlugin()
        {
            Muted = false;
            Status = ChatStatus.Offline;
        }

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

        #region Method from the IChatSource interface

        /// <summary>
        /// Property for chat source name.
        /// </summary>
        /// <returns>Returns the name for the chat source.</returns>
        /// <remarks>This name will be used as the name of tab item generated.</remarks>
        public abstract string SourceName { get; }

        /// <summary>
        /// Property for the text color used for contents from this chat source in ALL tab.
        /// </summary>
        /// <returns>Returns the text color used for contents from this chat source in ALL tab.</returns>
        /// <remarks>This text color will be used for contents from this chat source in ALL tab.</remarks>
        public Color TextColor
        {
            get
            {
                return textColor;
            }
            set
            {
                textColor = value;
                if (TextColorChanged != null)
                    TextColorChanged(this, new PropertyChangedEventArgs("TextColor"));
            }
        }

        /// <summary>
        /// Property for the muting contents from this chat source from the ALL tab.
        /// </summary>
        /// <returns>Returns whether contents from this chat source is muted from the ALL tab.</returns>
        /// <remarks>This mute option will be determined whether contents from this chat source will be updated in ALL tab.</remarks>
        public bool Muted { get; set; }

        /// <summary>
        /// Property for the user status on this chat source.
        /// </summary>
        /// <returns>Returns the current user status on this chat source.</returns>
        /// <remarks>This will notify other users of its current status.</remarks>
        public ChatStatus Status { get; set; }

        /// <summary>
        /// An event that is triggered when there is a new incoming message from this chat source.
        /// </summary>
        public abstract event IncomingMessageEventHandler IncomingMessage;

        /// <summary>
        /// An event that must be triggered whenever TextColor is changed.
        /// </summary>
        public event PropertyChangedEventHandler TextColorChanged;

        /// <summary>
        /// An event that must be triggered whenever Status is changed.
        /// </summary>
        public abstract event PropertyChangedEventHandler StatusChanged;

        /// <summary>
        /// Send the message to this chat source.
        /// </summary>
        /// <param name="message">Message to be send.</param>
        /// <param name="userID">User whose message is originated from.</param>
        public abstract void chat(string message, string userID);

        #endregion

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
