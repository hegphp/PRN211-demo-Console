using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Car newCar = new Car();
            //Console.WriteLine("Type model - color - year for Car");

            //newCar.Model = Console.ReadLine();
            //newCar.Color = Console.ReadLine();
            //try
            //{
            //    newCar.Year = int.Parse(Console.ReadLine());
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
            ////output
            //Console.WriteLine("The car you type:\nhas model:{0}\nhas color:{1}\nmanufactured in:{2}", newCar.Model, newCar.Color, newCar.Year);

            //newCar.honk();

            //newCar.displayInfo();


            //MyCar myNewCar = new MyCar();
            //myNewCar.Model = Console.ReadLine();
            //myNewCar.Color = Console.ReadLine();
            //try
            //{
            //    myNewCar.Year = int.Parse(Console.ReadLine());
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}

            //Console.WriteLine("Type year - month - and day");
            //try
            //{
            //    myNewCar.Warranty = new DateTime(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}

            //myNewCar.displayInfo();
            //myNewCar.honk();

            Dog dog = new Dog();
            dog.animalSound();
            dog.eat();
            dog.run();

        }

        private static void displayMenu()
        {
            throw new NotImplementedException();
        }
    }
}
