using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class MyCar:Car //inheritance using ":"
    {
        private DateTime warranty;

        public DateTime Warranty { get => warranty; set => warranty = value; }

        public MyCar()
        {
        }

        public MyCar(string model, string color, int year, DateTime warranty) : base(model, color, year)
        {
            this.warranty = warranty;
        }

        public void honk()
        {
            Console.WriteLine("Bro, my car is honk honk-ing");
        }

        public void displayInfo()
        {
            Console.WriteLine("Model - Color - Year - Warranty: {0} - {1} - {2} - {3}", base.Model, base.Color, base.Year, this.warranty);
        }
    }
}
