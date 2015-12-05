using System;
using System.ComponentModel;
using System.Drawing;

namespace PluginSDK
{
    public delegate void IncomingMessageEventHandler(IChatSource sender, string user, string message);

    public enum ChatStatus { Available, Away, Busy, Offline };

    /// <summary>
    ///  All chat source plugins will indirectly implement this interface.
    /// </summary>
    public interface IChatSource
    {
        /// <summary>
        /// Property for chat source name.
        /// </summary>
        /// <returns>Returns the name for the chat source.</returns>
        /// <remarks>This name will be used as the name of tab item generated.</remarks>
        string SourceName { get; }

        /// <summary>
        /// Property for the text color used for contents from this chat source in ALL tab.
        /// </summary>
        /// <returns>Returns the text color used for contents from this chat source in ALL tab.</returns>
        /// <remarks>This text color will be used for contents from this chat source in ALL tab.</remarks>
        Color TextColor { get; }

        /// <summary>
        /// Property for the muting contents from this chat source from the ALL tab.
        /// </summary>
        /// <returns>Returns whether contents from this chat source is muted from the ALL tab.</returns>
        /// <remarks>This mute option will be determined whether contents from this chat source will be updated in ALL tab.</remarks>
        bool Muted { get; }

        /// <summary>
        /// Property for the user status on this chat source.
        /// </summary>
        /// <returns>Returns the current user status on this chat source.</returns>
        /// <remarks>This will notify other users of its current status.</remarks>
        ChatStatus Status { get; }

        /// <summary>
        /// An event that is triggered when there is a new incoming message from this chat source.
        /// </summary>
        event IncomingMessageEventHandler IncomingMessage;

        /// <summary>
        /// An event that must be triggered whenever TextColor is changed.
        /// </summary>
        event PropertyChangedEventHandler TextColorChanged;

        /// <summary>
        /// An event that must be triggered whenever Status is changed.
        /// </summary>
        event PropertyChangedEventHandler StatusChanged;

        /// <summary>
        /// Send the message to this chat source.
        /// </summary>
        /// <param name="message">Message to be send.</param>
        /// <param name="userID">User whose message is originated from.</param>
        void chat(string message, string userID);

        /// <summary>
        /// Connect to this chat source.
        /// </summary>
        bool connect();

        /// <summary>
        /// Disconnect from this chat source.
        /// </summary>
        bool disconnect();

        /// <summary>
        /// Setup the account to be used for this chat source.
        /// </summary>
        /// <param name="account">Account to be used for connecting and discconnecting to this chat source.</param>
        void setup(Account account);
    }
}
