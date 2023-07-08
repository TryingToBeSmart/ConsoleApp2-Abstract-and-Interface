using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // Robin class inherits from Animal class and implements IFlyable interface
    class Robin : Animal, IFlyable
    {
        // Method specific to Robin for flying
        public void Feathers()
        {
            Console.WriteLine("Robin Flying");
        }

        // Overrides the Sing method from the Animal class
        public virtual void Sing()
        {
            Console.WriteLine("Chirp");
        }
    }
}
