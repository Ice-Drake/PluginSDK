using System.Collections.Generic;
using System.Runtime.InteropServices;
using System;

namespace PluginSDK
{
    /// <summary>
    ///  It is recommended to implement this abstract class for debugging and logging purpose.
    /// </summary>
    public abstract class MessageLogger
    {
        private static List<MessageLogger> loggers;

        public MessageLogger()
        {
            if (loggers == null)
                loggers = new List<MessageLogger>();
            loggers.Add(this);
        }

        [DllImport("kernel32.dll")]
        private static extern uint GetCurrentThreadId();

        /// <summary>
        /// Log the message.
        /// </summary>
        /// <param name="message">Content to be logged.</param>
        /// <param name="type">Message type.</param>
        public static void log(string message, MessageType type = MessageType.ERROR)
        {
            if (loggers != null)
            {
                DateTime timeLogged = DateTime.Now;
                uint threadID = GetCurrentThreadId();

                foreach (MessageLogger logger in loggers)
                {
                    logger.write(new LogMessage(message, type, timeLogged, threadID));
                }
            }
        }

        /// <summary>
        /// Write the logged message out.
        /// </summary>
        /// <param name="message">Message to be logged</param>
        public abstract void write(LogMessage message);
    }
}
