using System.Collections.Generic;

namespace PluginSDK
{
    /// <summary>
    ///  To support interoperability, all modules should implement this abstract class along with ICommand.
    /// </summary>
    public abstract class CommandHandler
    {
        private static List<CommandHandler> handlers;
        private string type;

        /// <summary>
        /// Construct a command handler of the supplied type name. Add itself to collection of handlers.
        /// </summary>
        /// <param name="type">Type</param>
        /// <remarks>The type name is used to distinguish one CommandHandler from another.</remarks>
        public CommandHandler(string type)
        {
            this.type = type;
            if (handlers == null)
                handlers = new List<CommandHandler>();
            handlers.Add(this);
        }

        /// <summary>
        /// Attempt to create the command given that the supplied command and type are valid.
        /// </summary>
        /// <param name="command">Command to create.</param>
        /// <param name="type">Type of command to create.</param>
        /// <returns>Returns the command if successful. Otherwise, returns null.</returns>
        public static ICommand create(string command, string type)
        {
            foreach (CommandHandler handler in handlers)
            {
                if (handler.type.Equals(type))
                    return handler.create(command);
            }
            return null;
        }

        /// <summary>
        /// Enqueue the command to be executed.
        /// </summary>
        /// <param name="command">Command to be enqueued.</param>
        /// <returns>Returns true if the command is successfully enqueued to be executed. Otherwise, returns false.</returns>
        public static bool enqueue(ICommand command)
        {
            foreach (CommandHandler handler in handlers)
            {
                if (handler.execute(command))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Create the command given that the supplied command name is valid according to this handler.
        /// </summary>
        /// <param name="command">Name of the command to be created.</param>
        /// <returns>Returns the command if supported by this handler. Otherwise, returns null.</returns>
        public abstract ICommand create(string command);

        /// <summary>
        /// Attempt to execute this command.
        /// </summary>
        /// <param name="command">Command to execute.</param>
        /// <returns>Returns true if the command can be successfully executed by this handler. Otherwise, returns false.</returns>
        /// <remarks>This will do nothing if the command can not be handled by this handler.</remarks>
        public abstract bool execute(ICommand command);
    }
}
