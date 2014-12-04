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
        public Thread mainThread, thread1, thread2;

        // Set message to hold Thread.CurrentThread.Name
        private string message;

        public string Message
        {
            get { return message = Thread.CurrentThread.Name; }
            set { message = value; }
        }
        

        // Print method  that prints the names of the threads + and int
        public void PrintMessage(int numberOfTimes)
        {
            for (int i = 0; i < 10; i++)
            {
                message = Message;
                Thread.Sleep(200);

                Console.WriteLine("Hello World - " + message + " - " + numberOfTimes);
                
                
            }
                        
        }

        // Made Join Work

        public void ThreadProc()
        {

            try
            {
                if (Thread.CurrentThread.Name == "Thread1" 
                    && thread2.ThreadState != ThreadState.Unstarted)
                
                    thread2.Join();
                    Thread.Sleep(200);

                    Console.WriteLine("\nCurrent thread: {0}", Thread.CurrentThread.Name);
                    Console.WriteLine("Thread1: {0}", thread1.ThreadState);
                    Console.WriteLine("Thread2: {0}\n", thread2.ThreadState);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
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
