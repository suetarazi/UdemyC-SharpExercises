using interface_exercise.Classes;
using System;
using System.Dynamic;

namespace interface_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Workflow workflow = new Workflow();
            workflow.Add(new Upload());
            workflow.Add(new CallWebService());
            workflow.Add(new ChangeDbStatus());
            workflow.Add(new SendEmail());

            var engine = new WorkflowEngine();
            engine.Run(workflow);

            Console.ReadLine();
        }

        public void Run(IWorkflow workflow)
        {
            foreach(IExecute task in workflow)
            {
                IExecute(task);
            }
        }
    }
}
