using System;
using System.Collections.Generic;
using System.Text;

namespace interface_exercise.Classes
{
    class ChangeDbStatus : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("Changing Database status");
        }
    }
}
