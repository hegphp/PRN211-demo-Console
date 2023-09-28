using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise1_130923 {
    internal class Product:Item {
        private DateTime expDate;

        public DateTime ExpDate { get => expDate; set => expDate = value; }

        public Product():base() { }

        public Product(int code, string? name, int? price, DateTime ExpDate) : base(code, name, price) {
            this.ExpDate = ExpDate;
        }

        public override void Input() { 
            base.Input();
            Console.Write("Input Expired Date: ");
            string input = Console.ReadLine();
            string pattern = "dd/MM/yyyy";
            try {
                DateTime.TryParseExact(input, pattern, null, DateTimeStyles.None, out this.expDate);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public override void Display() {
            base.Display();
            Console.WriteLine($"Expired Date: {this.expDate:dd/MM/yyyy}");
        }

        public override string ToString() {
            return base.ToString() + $"{Environment.NewLine}Expired Date: {this.expDate:dd/MM/yyyy}";

        }
    }
}
