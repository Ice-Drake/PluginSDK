using System;
using System.Collections.Generic;
using System.Text;

namespace PluginSDK
{
    /// <summary>
    /// All task management plugins should implement this interface and IProjDatabase.
    /// </summary>
    public interface ITask
    {
        /// <summary>
        /// Property for task ID.
        /// </summary>
        /// <returns>Returns the ID of the task.</returns>
        uint ID { get; }

        /// <summary>
        /// Property for task summary.
        /// </summary>
        /// <returns>Returns the summary of the task.</returns>
        string Summary { get; }

        /// <summary>
        /// Property for task start date.
        /// </summary>
        /// <returns>Returns the start date of the task.</returns>
        DateTime StartDate { get; }

        /// <summary>
        /// Property for task due date.
        /// </summary>
        /// <returns>Returns the due date of the task.</returns>
        DateTime DueDate { get; }

        /// <summary>
        /// Property for task status.
        /// </summary>
        bool Complete { get; set; }
    }
}