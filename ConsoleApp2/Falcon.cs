using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // Falcon class
    class Falcon : Animal, IFlyable
    {
        // Feathers method implementation from IFlyable interface
        public void Feathers()
        {
            Console.WriteLine("Falcon fly");
        }
    }
}
