using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise1_130923 {
    internal class Item {
        public int Code { get; set; }
        public string? Name { get; set; }
        public int? Price { get; set; }

        public Item() {
        }

        public Item(int code, string? name, int? price) {
            Code = code;
            Name = name;
            Price = price;
        }

        public virtual void Input() {
            Console.Write("Input Item code: ");
            Code = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Item name: ");
            Name = Console.ReadLine();
            Console.Write("Input item price: ");
            Price = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void Display() {
            Console.WriteLine($"Code: {Code},Name: {Name},Price: {Price}");
        }

        public override string ToString() {
            return $"Code: {Code},Name: {Name},Price: {Price}";
        }
    }
}
