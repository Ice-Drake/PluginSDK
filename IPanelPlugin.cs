using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PluginSDK
{
    public interface IPanelPlugin : IPlugin
    {
        string PanelName { get; }
        void showPanel();
        void hidePanel();
        event FormClosingEventHandler PanelClosing;
    }
}
