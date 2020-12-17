using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventApplication
{
    //Step 1
    public delegate void PrintDelegate();
    class myEvent
    {
        //step 2
        event PrintDelegate print;

        //step 3
        void show()
        {
            Console.WriteLine("Print Event has been raised.");
            Console.WriteLine("This is a handler Method.");
        }

        //Creating a Constructor in which we assign event its handler
        public myEvent()
        {
            print += show;
        }

        public void RaiseEvent()
        {
            //Raising the event named print
            print();
        }
    }
}
