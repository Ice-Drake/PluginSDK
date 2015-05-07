using System;
using System.Collections.Generic;
using System.Text;

namespace PluginSDK
{
    public class TaskArgs : EventArgs
    {
        private ITask m_task;
        private bool m_checked;

        public ITask Task
        {
            get
            {
                return m_task;
            }
        }

        public bool Checked
        {
            get
            {
                return m_checked;
            }
        }

        public TaskArgs(ITask task, bool check)
        {
            m_task = task;
            m_checked = check;
        }
    }
}
