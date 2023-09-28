using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Dog:Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("bark bark");
        }

        public override void eat()
        {
            Console.WriteLine("yummy yummy doggo!");
        }
    }
}
