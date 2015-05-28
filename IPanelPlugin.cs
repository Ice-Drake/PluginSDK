using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PluginSDK
{
    /// <summary>
    ///  All panel plugins must implement this interface.
    /// </summary>
    public interface IPanelPlugin : IPlugin
    {
        /// <summary>
        /// Property for panel plugin name.
        /// </summary>
        /// <returns>Returns the name for the panel of the plugin.</returns>
        /// <remarks>This name will be used as the name of menu item generated for this plugin.</remarks>
        string PanelName { get; }
        
        /// <summary>
        /// Show the panel of the plugin.
        /// </summary>
        /// <remarks>This will be called when the menu item associated to this plugin is checked.</remarks>
        void showPanel();

        /// <summary>
        /// Hide the panel of the plugin.
        /// </summary>
        /// <remarks>This will be called when the menu item associated to this plugin is unchecked.</remarks>
        void hidePanel();

        /// <summary>
        /// An event that must be triggered if the panel of the plugin is closed or hidden away via the X button.
        /// </summary>
        /// <remarks>This will call hidePanel() and uncheck the menu item associated to this plugin.</remarks>
        event FormClosingEventHandler PanelClosing;
    }
}
