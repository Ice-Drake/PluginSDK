using System;
using System.Collections.Generic;

namespace PluginSDK
{
    /// <summary>
    /// A delegate type for hooking up ITask change notifications.
    /// </summary>
    public delegate void ITaskHandler(IProjDatabase sender, ITask task, StatusArgs e);

    /// <summary>
    /// All task management plugins should implement this interface and ITask.
    /// </summary>
    public interface IProjDatabase : IDatabasePlugin
    {
        /// <returns>Returns the list of tasks indexed by ID.</returns>
        SortedList<uint, ITask> ITaskList { get; }
        
        /// <summary>
        /// An event that must be triggered whenever ITask is added, removed, or modified.
        /// </summary>
        event ITaskHandler DatabaseChanged;
    }
}
