using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // Horse class
    class Horse : Animal, IRidable, IDomesticated
    {
        // Sing method override
        public override void Sing()
        {
            Console.WriteLine("Horse sing");
        }

        // FeedMe method implementation from IDomesticated interface
        public void FeedMe()
        {
            Console.WriteLine("Horse Eats");
        }

        // Go method implementation from IRidable interface
        public void Go()
        {
            Console.WriteLine("Go Horse");
        }

        // PetMe method implementation from IDomesticated interface
        public void PetMe()
        {
            Console.WriteLine("Horse pet");
        }

        // Stop method implementation from IRidable interface
        public void Stop()
        {
            Console.WriteLine("Horse Stopping");
        }
    }
}
