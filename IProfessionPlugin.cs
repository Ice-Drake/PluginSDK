using System;
using System.Collections.Generic;

namespace PluginSDK
{
    /// <summary>
    ///  All professional character plugins must implement this interface.
    /// </summary>
    public interface IProfessionPlugin : IDatabasePlugin
    {
        /// <summary>
        /// Property for the list of keywords that can be used as reference to this character plugin in a conversation.
        /// </summary>
        /// <returns>Returns the list of reference keywords.</returns>
        /// <remarks>This list will be used as the references to this character plugin in a conversation.</remarks>
        List<string> Keywords { get; }

        /// <summary>
        /// Property for the name of the character plugin.
        /// </summary>
        /// <returns>Returns the name of the character plugin.</returns>
        /// <remarks>This name will be used as the reference to this character plugin in a conversation.</remarks>
        string Name { get; }

        /// <summary>
        /// Interpret a line of user speech of its meaning.
        /// </summary>
        /// <param name="line">A line of user speech to character.</param>
        /// <remarks>This will be called when the menu item associated to this plugin is unchecked.</remarks>
        void interpret(string line);

        /// <summary>
        /// Something that the character must say either in response to the user question, or not.
        /// </summary>
        /// <remarks>This will be called when the OutgoingSpeech event is triggered.</remarks>
        string say();

        /// <summary>
        /// An event that is triggered when the character has something to say.
        /// </summary>
        /// <remarks>This will call say() associated to this plugin.</remarks>
        event EventHandler OutgoingSpeech;
    }
}
