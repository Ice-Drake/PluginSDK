using System;
using System.Collections.Generic;

namespace PluginSDK
{
    public delegate void NewFollowerEventHandler(IChatSource sender, IFollower follower);

    /// <summary>
    ///  All chat source plugins that allows follower involvement can implement this interface.
    /// </summary>
    public interface IChatSourceForFollower
    {
        /// <summary>
        /// Property for a list of followers.
        /// </summary>
        /// <returns>Returns the list of followers in the chat system.</returns>
        /// <remarks>This list will be used to notify followers of each other.</remarks>
        List<IFollower> Followers { get; }

        /// <summary>
        /// An event that is triggered when there is a new follower added to this chat source.
        /// </summary>
        event NewFollowerEventHandler NewFollowerAdded;

        /// <summary>
        /// Add a follower to the chat system.
        /// </summary>
        /// <param name="follower">Follower added to chat system.</param>
        /// <remarks>This method will trigger NewFollowerAdded event.</remarks>
        void addFollower(IFollower follower);
    }
}
