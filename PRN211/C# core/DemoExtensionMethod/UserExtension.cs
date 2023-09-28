using PRN211;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExtensionMethod {
    internal static class UserExtension {
        //Tu khoa this cho phep syntax ko truyen input, ma chay u.Diplay()
        public static void Display(this User u) {
            if (u != null)
                Console.WriteLine(u.ToString());
            else
                Console.WriteLine("Object Rong!");
        }

        public static void Display(this User u, string label) {
            if (u != null)
                Console.WriteLine(label + u.ToString());
            else
                Console.WriteLine("Object Rong!");
        }
    }
}
