using System;
using System.Collections.Generic;

namespace PluginSDK
{
    /// <summary>
    /// A delegate type for hooking up ITask change notifications.
    /// </summary>
    public delegate void ITaskHandler(ITaskManagementPlugin sender, ITask task);

    /// <summary>
    /// All task management plugins should implement this interface and ITask.
    /// </summary>
    public interface ITaskManagementPlugin : IDatabase, IPanelPlugin
    {
        /// <returns>Returns the list of tasks indexed by ID.</returns>
        SortedList<uint, ITask> ITaskList { get; }
        
        /// <summary>
        /// An event that must be triggered whenever ITask is added.
        /// </summary>
        event ITaskHandler ITaskAdded;

        /// <summary>
        /// An event that must be triggered whenever ITask is removed.
        /// </summary>
        event ITaskHandler ITaskRemoved;

        /// <summary>
        /// An event that must be triggered whenever ITask is modified.
        /// </summary>
        event ITaskHandler ITaskModified;
    }
}
