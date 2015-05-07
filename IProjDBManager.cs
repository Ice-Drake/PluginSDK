using System;
using System.Collections.Generic;

namespace PluginSDK
{
    // A delegate type for hooking up change notifications.
    public delegate void ITaskHandler(IProjDBManager sender, ITask task, StatusArgs e);

    public interface IProjDBManager : IPanelPlugin
    {
        void loadDatabase();
        SortedList<uint, ITask> ITaskList { get; }
        
        // Fire when ITask is added, removed, or modified
        event ITaskHandler DatabaseChanged;
    }
}
