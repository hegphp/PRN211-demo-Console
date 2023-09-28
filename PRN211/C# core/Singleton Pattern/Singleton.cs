using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern {
    //sealed class: this class cannot be inherited
    public sealed class Singleton {
        //readonly: Biến chỉ đọc (Runtime constant): được xác định lần đầu khi chương trình chạy và sau đó không thay đổi giá trị nữa
        private static readonly Singleton Instance;
        private static int TotalInstances = 0;
        /*
            Private constructor is used to prevent
            creation of instances with 'new' keyword outside this class
         */
        private Singleton() => Console.WriteLine("--Private constructor is called");
        //Using static Constructor
        static Singleton() {
            //Printing some messages before create the instance
            Console.WriteLine("--staic constructor is called");
            Instance = new Singleton();
            TotalInstances++;
            Console.WriteLine($"--Singleton instance is created. Number of instances:{TotalInstances}");
            Console.WriteLine("--Exit from static constructor.");
        }
        public static Singleton GetInstance => Instance;
        public int GetTotalInstaces => TotalInstances;
        public void Print() => Console.WriteLine("Hello World");
    }
}
