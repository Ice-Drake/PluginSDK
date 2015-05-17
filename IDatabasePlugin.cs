﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PluginSDK
{
    /// <summary>
    ///  All panel plugins that use a significantly large database should implement this interface.
    /// </summary>
    public interface IDatabasePlugin : IPanelPlugin
    {
        /// <summary>
        /// Load the database associated to the plugin.
        /// </summary>
        /// <remarks>This will be called during the program startup after the plugins are loaded or constructed.</remarks>
        void loadDatabase();
    }
}
