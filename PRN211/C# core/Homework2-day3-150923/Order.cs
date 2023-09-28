using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_day3_150923 {
    internal class Order {
        private List<Product> listOfProducts;
        private DateTime orderDate;
        public string OrderId { get; set; }
        internal List<Product> ListOfProducts { get => listOfProducts; set => listOfProducts = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }

        public Order() {
            listOfProducts = new List<Product>();
        }

        internal void Display() {
            Console.WriteLine(OrderId);
            Console.WriteLine($"{OrderDate:dd/MM/yyyy}");
            //Display all product in an order
            for(int i = 0; i < listOfProducts.Count; i++) {
                Console.WriteLine(listOfProducts[i].Code + ";" + listOfProducts[i].Name + ";" + listOfProducts[i].Price + ";" + $"{listOfProducts[i].ExpDate:dd/MM/yyyy}") ;
            }
        }
    }
}
