using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PluginSDK
{
    public class IProjectManager
    {
        public DataTable ITaskTable { get; private set; }
        public SortedList<string, ITask> ITaskList { get; private set; }
        private List<ITaskManagementPlugin> projDBList;
        
        public IProjectManager()
        {
            ITaskList = new SortedList<string, ITask>();
            projDBList = new List<ITaskManagementPlugin>();
            
            ITaskTable = new DataTable();
            ITaskTable.TableName = "ITask Table";
            ITaskTable.Columns.Add("UID", typeof(string));
            ITaskTable.Columns.Add("Summary", typeof(string));
            ITaskTable.Columns.Add("Start", typeof(DateTime));
            ITaskTable.Columns.Add("Due", typeof(DateTime));
            ITaskTable.Columns.Add("Complete", typeof(bool));
        }

        public bool addDatabase(ITaskManagementPlugin projDatabase)
        {
            if (projDBList.Contains(projDatabase))
                return false;
            projDBList.Add(projDatabase);

            return true;
        }

        public void loadDatabase()
        {
            for (int i = 0; i < projDBList.Count; i++)
            {
                ITaskManagementPlugin projDatabase = projDBList[i];

                foreach (uint taskID in projDatabase.ITaskList.Keys)
                {
                    ITask task = projDatabase.ITaskList[taskID];
                    string newTaskID = taskID.ToString().Insert(0, i.ToString());
                    ITaskList.Add(newTaskID, task);
                    addITask(task, newTaskID);
                }

                projDatabase.ITaskAdded += new ITaskHandler(projDBManager_TaskAdded);
                projDatabase.ITaskRemoved += new ITaskHandler(projDBManager_TaskRemoved);
                projDatabase.ITaskModified += new ITaskHandler(projDBManager_TaskModified);
            }
        }

        public bool completeITask(string uid)
        {
            if (!ITaskList.ContainsKey(uid))
                return false;

            ITaskList[uid].Complete = true;

            // Find the corresponding Task row in the table
            DataRow existingRow = ITaskTable.Select(String.Format("UID = {0}", uid))[0];
            existingRow["Complete"] = true;

            return true;
        }

        // Add ITask to the ITaskTable
        private void addITask(ITask newTask, string uid)
        {
            DataRow newRow = ITaskTable.NewRow();
            newRow["UID"] = uid;
            newRow["Summary"] = newTask.Summary;
            newRow["Start"] = newTask.StartDate.ToShortDateString();
            newRow["Due"] = newTask.DueDate.ToShortDateString();
            newRow["Complete"] = newTask.Complete;
            ITaskTable.Rows.Add(newRow);
        }

        private void projDBManager_TaskAdded(ITaskManagementPlugin sender, ITask task)
        {
            uint taskID = sender.ITaskList.Keys[sender.ITaskList.IndexOfValue(task)];
            string uid = taskID.ToString().Insert(0, projDBList.IndexOf(sender).ToString());
            ITaskList.Add(uid, task);
            addITask(task, uid);
        }

        private void projDBManager_TaskRemoved(ITaskManagementPlugin sender, ITask task)
        {
            string uid = ITaskList.Keys[ITaskList.IndexOfValue(task)];

            // Find the corresponding Task row in the table
            int rowID = ITaskTable.Rows.IndexOf(ITaskTable.Select(String.Format("UID = {0}", uid))[0]);

            ITaskList.Remove(uid);
            ITaskTable.Rows.RemoveAt(rowID);
        }

        private void projDBManager_TaskModified(ITaskManagementPlugin sender, ITask task)
        {
            string uid = ITaskList.Keys[ITaskList.IndexOfValue(task)];

            // Find the corresponding Task row in the table
            int rowID = ITaskTable.Rows.IndexOf(ITaskTable.Select(String.Format("UID = {0}", uid))[0]);

            DataRow existingRow = ITaskTable.Rows[rowID];
            existingRow["Summary"] = task.Summary;
            existingRow["Start"] = task.StartDate.ToShortDateString();
            existingRow["Due"] = task.DueDate.ToShortDateString();
            existingRow["Complete"] = task.Complete;
        }
    }
}