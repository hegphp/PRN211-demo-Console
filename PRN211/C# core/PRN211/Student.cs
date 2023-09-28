using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211 {
    //Ke thua User
    internal class Student:User {
        public string? Major { get; set; }

        public Student() {
            Console.WriteLine("Ham tao khong tham so Student");
        }

        //Goi ham ta.o / goi hang binh thuonng
        public Student(int id, string name, string major) : base(id, name) {
            Console.WriteLine("Ham tao ba tham so class Student");
            Major = major;
        }

        public override void Input() { 
            base.Input();
            Console.Write("Major: ");
            Major = Console.ReadLine();
        }

        public override void Display() { 
            base.Display();
            Console.WriteLine($"Major: {Major}");
        }

        public override string ToString() {
            return base.ToString() + " " + Major;
        }
    }
}
