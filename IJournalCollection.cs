using System;
using System.Collections.Generic;

namespace PluginSDK
{
    public interface IJournalCollection
    {
        /// <summary>
        /// Property for a list of journals.
        /// </summary>
        /// <returns>Returns the list of journals in this collection.</returns>
        List<IJournal> Journals { get; }
    }
}
