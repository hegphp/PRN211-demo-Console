// See https://aka.ms/new-console-template for more information
using Excercise1_130923;

namespace MyExercises {
    internal class Program {
        //Tạo một Console App
        //Nhập thông tin 1 đơn hàng, gồm nhiều Product, Service
        //In lại thông tin đơn hàng, cùng tổng tiền
        public static void Main(string[] args) {
/*            Dictionary<String, Order> dictionary = new Dictionary<string, Order>();
            ItemManagement manage = new ItemManagement();*/
            Order order = new Order();
            //Loop until user choose Exit    
            while (true) {
                //Display menu
                displayMenu();
                //User insert an integer number as choice
                int choice = order.GetIntInput();
                //Run function depends on User's choice
                switch (choice) {
                    //Option 1: Add item
                    case 1:
                        order.AddNewItem();
                        break;
                    //Option 2: Add Product
                    case 2:
                        order.AddNewProduct();
                        break;
                    //Option 3: Add new Service
                    case 3:
                        order.AddNewService();
                        break;
                    //Option 4: Display all the Item user have
                    case 4:
                        order.DisplayAllItem();
                        break;
                    //Default: Exit
                    default:
                        System.Environment.Exit(0);
                        break;

                }
            }
        }

        public static void displayMenu() {
            Console.WriteLine("Choose option: ");
            Console.WriteLine("1. Add new Item");
            Console.WriteLine("2. Add new Product");
            Console.WriteLine("3. Add new Service");
            Console.WriteLine("4. Display all items");
        }
    }

}
