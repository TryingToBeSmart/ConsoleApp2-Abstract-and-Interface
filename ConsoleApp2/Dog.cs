using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // Dog class inherits from Animal class and implements IDomesticated interface
    class Dog : Animal, IDomesticated
    {
        // Constructor for Dog class
        public Dog()
        {
            Console.WriteLine("Dog constructor. Good dog");
        }

        // Overrides the Talk method from the Animal class
        public new void Talk()
        {
            Console.WriteLine("Bark");
        }

        // Overrides the Sing method from the Animal class
        public override void Sing()
        {
            Console.WriteLine("Dog Sing");
        }

        // Custom method for fetching things
        public void Fetch(string thing)
        {
            Console.WriteLine($"Oh boy, here's your {thing}");
        }

        // Implementation of the PetMe method from the IDomesticated interface
        public void PetMe()
        {
            Console.WriteLine("Pet");
        }

        // Implementation of the FeedMe method from the IDomesticated interface
        public void FeedMe()
        {
            Console.WriteLine("I'm hungry");
        }
    }
}
