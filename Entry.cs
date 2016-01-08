using System;
using System.Collections.Generic;

namespace PluginSDK
{
    public delegate void EntrySavedEventHandler(Entry sender);

    /// <summary>
    ///  All journal entries should extend this class.
    /// </summary>
    public class Entry
    {
        /// <summary>
        /// Property for the unique identification for this journal entry.
        /// </summary>
        /// <returns>Returns the unique identification of this journal entry.</returns>
        public string UID { get; private set; }

        /// <summary>
        /// Property for the subject for this journal entry.
        /// </summary>
        /// <returns>Returns the subject of this journal entry.</returns>
        public string Subject { get; set; }

        /// <summary>
        /// Property for the context for this journal entry.
        /// </summary>
        /// <returns>Returns the context of this journal entry.</returns>
        public string Context { get; set; }

        /// <summary>
        /// Property for the timestamp of when this journal entry is created.
        /// </summary>
        /// <returns>Returns the timestamp of when this journal entry is created.</returns>
        /// <remarks>This is used to be sorted in a journal in the order of the first created entry first and the last created entry last.</remarks>
        public DateTime DateCreated { get; private set; }

        /// <summary>
        /// Property for the timestamp of when this journal entry is modified.
        /// </summary>
        /// <returns>Returns the timestamp of when this journal entry is modified.</returns>
        public DateTime DateModified { get; set; }

        /// <summary>
        /// Property for the tags associated to this journal entry.
        /// </summary>
        /// <returns>Returns the tags associated to this journal entry.</returns>
        /// <remarks>This list is used to search for entry other than by its subject.</remarks>
        public List<string> Tags { get; private set; }

        /// <summary>
        /// An event that must be triggered whenever this entry has been modified and saved.
        /// </summary>
        public event EntrySavedEventHandler EntrySaved;

        public Entry(string uid, DateTime dateCreated)
        {
            UID = uid;
            DateCreated = dateCreated;
            Tags = new List<string>();
        }

        public virtual void save()
        {
            if (EntrySaved != null)
            {
                EntrySavedEventHandler temp = EntrySaved;
                temp(this);
            }
        }
    }
}
