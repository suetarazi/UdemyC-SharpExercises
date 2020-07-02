using System;
using System.Collections.Generic;
using System.Text;

namespace interface_exercise.Classes
{
    class SendEmail : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("Sending an email");
        }
    }
}
