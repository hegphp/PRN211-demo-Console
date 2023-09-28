using PRN211;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExtensionMethod {
    internal static class ListExtension {
        public static void Display(this List<User> users) {
            if (users == null) {
                Console.WriteLine("Danh sach rong");
            }
            else {
                Console.WriteLine("Danh sach gom {0} user", users.Count);
                foreach (var user in users) {
                    Console.WriteLine(user);
                }
            }
        }
/*
        public static void Display(this List<User> users) { 
            list.        
        }*/
    }
}
