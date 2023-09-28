using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_day3_150923 {
    internal class Product {
        public int Code { get; set; }

        public string Name { get; set; }
        public float Price { get; set; }

        public DateTime ExpDate {get; set;}

        public Product() { }

        public Product(int code, string name, float price, DateTime expDate) {
            Code = code;
            Name = name;
            Price = price;
            ExpDate = expDate;
        }
    }
}
