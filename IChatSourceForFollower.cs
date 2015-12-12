namespace PluginSDK
{
    /// <summary>
    ///  All chat source plugins that allows follower involvement can implement this interface.
    /// </summary>
    public interface IChatSourceForFollower
    {
        /// <summary>
        /// Add a follower to the chat system.
        /// </summary>
        /// <param name="follower">Follower added to chat system.</param>
        void addFollower(IFollower follower);
    }
}
