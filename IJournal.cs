using System;
using System.Collections.Generic;

namespace PluginSDK
{
    public delegate void IJournalModifiedEventHandler(IJournal sender);

    /// <summary>
    ///  All journals must implement this interface.
    /// </summary>
    public interface IJournal
    {
        /// <summary>
        /// Property for the unique identification for this journal.
        /// </summary>
        /// <returns>Returns the unique identification of this journal.</returns>
        string UID { get; }

        /// <summary>
        /// Property for the name for this journal.
        /// </summary>
        /// <returns>Returns the name of this journal.</returns>
        string Name { get; set; }

        /// <summary>
        /// Property for the filename of where this journal is stored.
        /// </summary>
        /// <returns>Returns the filename of where this journal is stored.</returns>
        string Filename { get; }

        /// <summary>
        /// Property of whether or not this journal is enabled.
        /// </summary>
        /// <returns>Returns true if this journal is enabled.</returns>
        /// <remarks>This returns true by default unless it is password protected. In that case,
        /// it returns true only if it is unlocked with the correct password; otherwise, it returns false.</remarks>
        bool Enabled { get; }

        /// <summary>
        /// Property of whether or not this journal is password protected.
        /// </summary>
        /// <returns>Returns true if this journal is password protected.</returns>
        /// <remarks>This returns false by default unless it is locked with a password.</remarks>
        bool Private { get; }

        /// <summary>
        /// An event that must be triggered whenever this entry has been modified.
        /// </summary>
        event IJournalModifiedEventHandler JournalModify;

        /// <summary>
        /// Add an entry to this journal.
        /// </summary>
        /// <param name="newEntry">Entry to be added.</param>
        void addEntry(Entry newEntry);

        /// <summary>
        /// Get the first entry in this journal.
        /// </summary>
        /// <returns>Returns the first entry in this journal.</returns>
        Entry getFirstEntry();

        /// <summary>
        /// Get the next entry in this journal.
        /// </summary>
        /// <returns>Returns the next entry in this journal.</returns>
        Entry getNextEntry();

        /// <summary>
        /// Get the last entry in this journal.
        /// </summary>
        /// <returns>Returns the last entry in this journal.</returns>
        Entry getLastEntry();

        /// <summary>
        /// Get the number of entries in this journal.
        /// </summary>
        /// <returns>Returns the number of entries in this journal.</returns>
        int getEntrySize();

        /// <summary>
        /// Remove the supplied entry from this journal.
        /// </summary>
        /// <param name="existingEntry">Entry to be removed.</param>
        /// <returns>Returns whether or not the entry removal is successful.</returns>
        bool removeEntry(Entry existingEntry);

        /// <summary>
        /// Search for entries in this journal that match up with the supplied tag.
        /// </summary>
        /// <param name="tag">Tag used for searching.</param>
        /// <returns>Returns the list of entries that has tags match with the supplied tag.</returns>
        List<Entry> searchEntry(string tag);

        /// <summary>
        /// Secure this journal with the supplied password only if it is enabled.
        /// </summary>
        /// <param name="password">Password used to lock this journal with.</param>
        /// <remarks>Only if this journal is enabled can it be secured with the supplied password.
        /// If this journal already has a password defined, then this will update the password.
        /// If this journal has no password defined yet, this will change the private property to true.</remarks>
        void secure(string password);

        /// <summary>
        /// Try to unlock this journal with the supplied password.
        /// </summary>
        /// <param name="password">Password used to unlock this journal with.</param>
        /// <remarks>Only if the supplied password matches with the password of this journal will this journal
        /// be enabled.</remarks>
        void unlock(string password);
    }
}
