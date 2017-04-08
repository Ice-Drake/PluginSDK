using System;

namespace PluginSDK
{
    public enum MessageType { DEBUG, VERBOSE, INFORMATION, WARNING, ERROR, CRITICAL };

    public class LogMessage
    {
        public string Message { get; private set; }

        public MessageType Type { get; private set; }

        public DateTime Time { get; private set; }

        public uint ThreadID { get; private set; }

        public LogMessage(string message, MessageType type, DateTime time, uint threadID)
        {
            Message = message;
            Type = type;
            Time = time;
            ThreadID = threadID;
        }
    }
}
