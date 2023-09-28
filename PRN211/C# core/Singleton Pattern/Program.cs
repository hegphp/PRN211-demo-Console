using System;

namespace Singleton_Pattern {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("#1. Trying to get a Singleton instance, called firstInstance.");
            Singleton firstInstance = Singleton.GetInstance;
            Console.WriteLine("--Invoke Print() method: ");
            firstInstance.Print();
            Console.WriteLine("#2. Trying to get another Singleton instance, called secondInstance");
            Singleton secondInstance = Singleton.GetInstance;
            Console.WriteLine($"--Number of instances:{secondInstance.GetTotalInstaces}");
            Console.WriteLine("--Invoke Print() method");
            secondInstance.Print();
            if (firstInstance.Equals(secondInstance)) {
                Console.WriteLine("=> The firstInstance and secondInstance are the same");
            }
            else {
                Console.WriteLine("=> Different instances exit.");
            }
            Console.Read();
        }
    }
}
