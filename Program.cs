using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstThread
{
    public class Program
    {
        
       
        public static void Main(string[] args)
        {

            // Part one of the assignment Add a print method an call it from the class
            //Threading th = new Threading();

            //th.PrintMessage();
            //th.PrintMessage();
            //th.PrintMessage();
            //th.PrintMessage();

            //-------------------------------------------------------------

            // Part 2 of the assignment Add Threads

            //Threading th = new Threading();
            //Thread t = new Thread(th.PrintMessage);
            //Thread t2 = new Thread(th.PrintMessage);
            //Thread t3 = new Thread(th.PrintMessage);
            //Thread t4 = new Thread(th.PrintMessage);

            //t.Start();
            //t2.Start();
            //t3.Start();
            //t4.Start();
            
            //--------------------------------------------------------------

            // Part 3 of the assignment Add lambda expressions

            //Threading th = new Threading();
            //Thread t1 = new Thread(() => th.PrintMessage("S1"));
            //Thread t2 = new Thread(() => th.PrintMessage("S2"));
            //Thread t3 = new Thread(() => th.PrintMessage("s3"));
            //Thread t4 = new Thread(() => th.PrintMessage("s4"));

            //t1.Start();
            //t2.Start();
            //t3.Start();
            //t4.Start();

            //---------------------------------------------------------------

            // Part 3 of the assignment add numberOfTimes (Probably not done correctly)

            //Threading th = new Threading();
            //Thread t1 = new Thread(() => th.PrintMessage("S1", 1));
            //Thread t2 = new Thread(() => th.PrintMessage("S2", 2));
            //Thread t3 = new Thread(() => th.PrintMessage("s3", 3));
            //Thread t4 = new Thread(() => th.PrintMessage("s4", 4));

            //t1.Start();
            //t2.Start();
            //t3.Start();
            //t4.Start();

            //------------------------------------------------------------------

            // Part 4 and 5 of the assignment add names to threads and print them and add thread.sleep

            

            //Threading th = new Threading();
            //Thread t1 = new Thread(() => th.PrintMessage("S1", 1));
            //Thread t2 = new Thread(() => th.PrintMessage("S2", 2));
            //Thread t3 = new Thread(() => th.PrintMessage("s3", 3));
            //Thread t4 = new Thread(() => th.PrintMessage("s4", 4));

            //t1.Name = "John";
            //t2.Name = "Ole";
            //t3.Name = "Kaj";
            //t4.Name = "Bob";



            //t1.Start();
            //t2.Start();
            //t3.Start();
            //t4.Start();

            //----------------------------------------------------------------
            
            // Part 6 of the assignement Thread.join

            Threading th = new Threading();


            th.mainThread = Thread.CurrentThread;
            th.thread1 = new Thread(th.ThreadProc);
            th.thread1.Name = "Thread1";
            th.thread1.Start();


            th.thread2 = new Thread(th.ThreadProc);
            th.thread2.Name = "Thread2";
            th.thread2.Start();
            
           

            
            
          
            
        }

        
   
    
    }
}
