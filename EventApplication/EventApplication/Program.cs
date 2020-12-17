using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            myEvent me = new myEvent();

            while (true)
            {
                ConsoleKeyInfo c = Console.ReadKey();

                if (c.Key == ConsoleKey.W)
                {
                    me.RaiseEvent();
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
