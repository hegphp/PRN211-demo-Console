using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Generic<int> generic = new Generic<int>();
            generic.add(1);
            generic.add(2);
            generic.add(3);

            generic.displayList();

            Generic<bool> generic1 = new Generic<bool>();
            generic1.add(true);
            generic1.add(false);

            Console.WriteLine();
            generic1.displayList();
        }


    }
}
