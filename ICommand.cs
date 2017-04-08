namespace PluginSDK
{
    public enum CommandStatus { CREATED, INITIALED, PENDING, COMPLETED, FAILED };

    /// <summary>
    ///  To support interoperability, all modules should implement this interface along with CommandHandler.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Property for the status of this command.
        /// </summary>
        CommandStatus Status { get; set; }

        /// <summary>
        /// Setup this command with the supplied parmeters while checking if the parameters are of valid types and of amount.
        /// </summary>
        /// <param name="parameters">Parameters to setup with.</param>
        /// <returns>Returns true if parameters supplied are of valid types and of amount. Otherwise, returns false.</returns>
        bool setup(string[] parameters);
    }
}
