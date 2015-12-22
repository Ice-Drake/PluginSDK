using System;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;

namespace PluginSDK
{
    public delegate void OutgoingMessageEventHandler(IFollower sender, IChatSource source);

    /// <summary>
    ///  All follower plugins will implement this interface indirectly through IFollowerPlugin.
    /// </summary>
    public interface IFollower
    {
        /// <summary>
        /// Property for the font color used for contents in this chat source.
        /// </summary>
        /// <returns>Returns the font color used for contents in this chat source.</returns>
        /// <remarks>This font color will be used for contents in this chat source.</remarks>
        Color FontColor { get; }

        /// <summary>
        /// Property for the list of keywords that can be used as reference to this follower in a conversation.
        /// </summary>
        /// <returns>Returns the list of reference keywords.</returns>
        /// <remarks>This list will be used as the references to this follower in a conversation;
        /// thus, its count must be at least one and the first item must be its name.</remarks>
        List<string> Names { get; }

        /// <summary>
        /// Property for the status of the follower plugin.
        /// </summary>
        /// <returns>Returns the name of the follower plugin.</returns>
        /// <remarks>This name will be used as the reference to this follower in a conversation.</remarks>
        ChatStatus Status { get; }

        /// <summary>
        /// Interpret a line of user speech of its meaning.
        /// </summary>
        /// <param name="line">A line of speech to follower.</param>
        /// <param name="userID">The user whose speech is originating from.</param>
        /// <param name="source">The chat source of where speech is originating from.</param>
        /// <remarks>This will be called when the conversation is directed to this follower.
        /// Note that the default program user ID is "User".</remarks>
        void interpret(string line, string userID, IChatSource source);

        /// <summary>
        /// Join a chat source.
        /// </summary>
        /// <param name="source">The chat source of whom is joining in.</param>
        /// <remarks>This must be called by IChatSource before this follower can initiate a conversation.</remarks>
        void join(IChatSource source);

        /// <summary>
        /// Something that the follower must say either in response to the user question, or not.
        /// </summary>
        /// <param name="source">The chat source of who is saying in.</param>
        /// <remarks>This will be called when the OutgoingSpeech event is triggered.</remarks>
        string say(IChatSource source);

        /// <summary>
        /// Start up the follower.
        /// </summary>
        void start();

        /// <summary>
        /// An event that is triggered when the follower has something to say.
        /// </summary>
        /// <remarks>This will call say() associated to this plugin.</remarks>
        event OutgoingMessageEventHandler OutgoingSpeech;

        /// <summary>
        /// An event that is triggered when Status property is changed.
        /// </summary>
        event PropertyChangedEventHandler StatusChanged;
    }
}
