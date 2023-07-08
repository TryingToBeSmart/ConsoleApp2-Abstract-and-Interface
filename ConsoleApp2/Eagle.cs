using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // Eagle class
    class Eagle : Animal, IFlyable
    {
        // Feathers method implementation from IFlyable interface
        public void Feathers()
        {
            Console.WriteLine("Eagle Flying");
        }
    }
}
