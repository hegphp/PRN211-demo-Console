using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Car
    {
        //encapsulation
        private String model;
        private String color;
        private int year;
        public Car() { }

        public Car(string model, string color, int year)
        {
            this.model = model;
            this.color = color;
            this.year = year;
        }

        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public int Year { get => year; set => year = value; }

        public void honk()
        {
            Console.WriteLine("Honk honk honk honk!");
        }

        public void displayInfo()
        { 
            Console.WriteLine("Model - Color - Year: {0} - {1} - {2}",this.model,this.color,this.year);
        }
    }
}
