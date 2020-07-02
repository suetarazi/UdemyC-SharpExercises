using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Sources;

namespace interface_exercise
{
    interface IWorkflow
    {
        void Add(IExecute task);
        void Remove(IExecute task);
        IEnumerable<IExecute> GetTasks();
    }
}
