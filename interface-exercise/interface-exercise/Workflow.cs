using System;
using System.Collections.Generic;
using System.Text;

namespace interface_exercise
{
    class Workflow : IWorkflow
    {
        private List<IExecute> _task;

        public void WorkflowEngine()
        {
            _task = new List<IExecute>();
        }

        public void Add(IExecute task)
        {
            _task.Add(task);
        }

        public void Remove(IExecute task)
        {
            _task.Remove(task);
        }

        public IEnumerable<IExecute> GetTasks()
        {
            return _task;
        }
    }
}
