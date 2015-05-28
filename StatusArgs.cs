using System;

namespace PluginSDK
{
    public enum ITaskStatus
    {
        Added,
        Removed,
        Modified,
    }

    public class StatusArgs : EventArgs
    {
        public ITaskStatus Status { get; set; }

        public StatusArgs(ITaskStatus status)
        {
            Status = status;
        }
    }
}
