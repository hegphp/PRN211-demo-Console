using System;
using System.Collections.Generic;

namespace Factories_Design_Pattern {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("***Factory Method Pattern Demo.***\n");
            //Create a list AnimalFactory included TigerFactory and LionFactory
            List<AnimalFactory> animalFactoryList = new List<AnimalFactory> {
                new TigerFactory(), new LionFactory()
            };
            foreach (var animal in animalFactoryList) { 
                animal.CreateAnimal().AboutMe();
            }
            Console.ReadLine();
        }
    }
}
