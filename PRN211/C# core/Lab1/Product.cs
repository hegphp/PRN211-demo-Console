using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1 {
    internal class Product {
        private int id;
        private string name;
        private string category;
        private double price;
        private DateTime expdate;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Category { get => category; set => category = value; }
        public double Price { get => price; set => price = value; }
        public DateTime Expdate { get => expdate; set => expdate = value; }

        public Product(int id, string name, string category, double price, DateTime expdate) {
            this.Id = id;
            this.Name = name;
            this.Category = category;
            this.Price = price;
            this.Expdate = expdate;
        }

        public Product() { 
        
        }

        public override string? ToString() {
            return $"{Id},{Name},{Category},{Price},{Expdate:dd/MM/yyyy}";
        }
    }
}
