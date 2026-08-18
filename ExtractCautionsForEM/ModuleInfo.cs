using System;
using System.Collections.Generic;

public class ModuleInfo
{
    public string m_sTitle = "";
    public List<TaskInfo> m_lstTasks = new List<TaskInfo>();
    public ModuleInfo(string title, List<string> lsttasks)
    {
        m_sTitle = title;
        foreach (string s in lsttasks)
            m_lstTasks.Add(new TaskInfo(s));
    }
}
