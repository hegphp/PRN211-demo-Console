using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise1_130923 {
    internal class Order {
        private int id;
        private DateTime orderDate = System.DateTime.Now;
        private List<Item> listItem = new List<Item>();

        public Order() { 
        }

        public Order(int id) {
            this.Id = id;
            this.OrderDate = System.DateTime.Now;
        }

        public int Id { get => id; set => id = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        internal List<Item> ListItem { get => listItem; set => listItem = value; }

        internal void AddNewItem() {
            Item item = new Item();
            item.Input();
            ListItem.Add(item);
            Console.WriteLine("Added Sucessfully!");
        }

        internal void AddNewProduct() {
            Product product = new Product();
            product.Input();
            listItem.Add(product);
            Console.WriteLine("Added Sucessfully!");
        }

        internal void AddNewService() {
            Service service = new Service();
            service.Input();
            listItem.Add(service);
            Console.WriteLine("Added Successfullt");
        }

        internal void DisplayAllItem() {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Item list: ");
            int? sum = 0;
            foreach (Item item in listItem) {
                item.Display();
                sum += item.Price;
            }
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("----------------------------------------------------");
        }

        internal int GetIntInput() {
            String input;
            while (true) {
                Console.Write("Input choice: ");
                try {
                    input = Console.ReadLine();
                    return Convert.ToInt32(input);
                }
                catch (FormatException formatEx) {
                    Console.WriteLine(formatEx.Message);
                    continue;
                }
                catch (OverflowException overflowEx) {
                    Console.WriteLine("The number you typed is too large or small, please type again!");
                    continue;
                }
                catch (Exception ex) {
                    Console.WriteLine("There is an unexpected error, please type again!");
                    continue;
                }
                finally { Console.WriteLine("Run Finally block"); }
            }
        }
    }
}
