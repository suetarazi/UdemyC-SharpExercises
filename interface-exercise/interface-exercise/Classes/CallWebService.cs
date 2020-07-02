using System;
using System.Collections.Generic;
using System.Text;

namespace interface_exercise.Classes
{
    class CallWebService : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("Calling web service");
        }
    }
}
