using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstThread
{
    public class Threading
    {

        public void PrintMessage()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello World");
            }

            
        }

    }
}
