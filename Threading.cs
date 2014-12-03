using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstThread
{
    public class Threading
    {

        public void PrintMessage(string message, int numberOfTimes )
        {
            for (int i = 0; i < 10; i++)
            {
                message = Thread.CurrentThread.Name;
                Console.WriteLine("Hello World - " + message + " - " + numberOfTimes);
            }
                        
        }


        public void PrintMessagetwo(string message)
        {
            for (int i = 0; i < 10; i++)
            {
               

                Console.WriteLine(message);
            }
        }

    }
}
