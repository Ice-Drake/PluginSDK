using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PluginSDK
{
    public delegate void OutgoingMessageEventHandler(object sender);

    /// <summary>
    ///  All follower plugins will implement this interface indirectly through IFollowerPlugin.
    /// </summary>
    public interface IFollower
    {
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
        /// <remarks>This will be called when the conversation is directed to this follower.
        /// Note that the default program user ID is "User".</remarks>
        void interpret(string line, string userID);

        /// <summary>
        /// Something that the follower must say either in response to the user question, or not.
        /// </summary>
        /// <remarks>This will be called when the OutgoingSpeech event is triggered.</remarks>
        string say();

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
