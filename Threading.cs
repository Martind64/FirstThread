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

        private string message;

        public string Message
        {
            get { return message = Thread.CurrentThread.Name; }
            set { message = value; }
        }
        

        
        public void PrintMessage(int numberOfTimes)
        {
            for (int i = 0; i < 10; i++)
            {
                Message = message;
                message = Thread.CurrentThread.Name;
                Thread.Sleep(200);

                Console.WriteLine("Hello World - " + message + " - " + numberOfTimes);
                
            }
                        
        }

        public void ThreadProc(Thread thread)
        {
            if (Thread.CurrentThread.Name == "Thread1" && thread.ThreadState != ThreadState.Unstarted)
            {
                thread.Join();
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
