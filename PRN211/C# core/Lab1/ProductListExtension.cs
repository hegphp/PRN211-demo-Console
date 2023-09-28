using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1 {
    internal static class ProductListExtension {
        public static void Display(this List<Product> productList) { 
            Console.WriteLine("\n======================================================================================================================");
            Console.WriteLine($"Founded {productList.Count} products: ");
            //Access every value in the list
            foreach(var  product in productList) {
                Console.WriteLine("|{0,2}|{1,10}|{2,15}|{3,10}|{4:dd/MM/yyyy}|", product.Id, product.Name, product.Category, product.Price, product.Expdate);
            }
            Console.WriteLine("\n======================================================================================================================");
        }
    }
}
