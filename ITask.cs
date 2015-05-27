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
        /// <returns>Returns the ID of the task.</returns>
        uint ID { get; }

        /// <returns>Returns the summary of the task.</returns>
        string Summary { get; }

        /// <returns>Returns the start date of the task.</returns>
        DateTime StartDate { get; }

        /// <returns>Returns the due date of the task.</returns>
        DateTime DueDate { get; }

        /// <summary>
        /// Property for task status
        /// </summary>
        bool Complete { get; set; }
    }
}