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
        public ITaskStatus Status { get; private set; }

        public StatusArgs(ITaskStatus status)
        {
            Status = status;
        }
    }
}
