using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // Abstract class representing an animal
    abstract class Animal
    {
        // Constructor for the Animal class
        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }

        // Method for greeting
        public void Greet()
        {
            Console.WriteLine("Animal says Hello");
        }

        // Method for talking
        public void Talk()
        {
            Console.WriteLine("Animal Talking");
        }

        // Virtual method for singing (can be overridden by derived classes)
        public virtual void Sing()
        {
            Console.WriteLine("Animal song");
        }

    }
}
