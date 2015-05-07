using System;
using System.Collections.Generic;
using System.Text;

namespace PluginSDK
{
    public interface ITask
    {
        string Summary { get; set; }
        DateTime StartDate { get; set; }
        DateTime DueDate { get; set; }
        bool Complete { get; set; }
    }
}
