using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise1_130923 {
    internal class Service : Item {
        private int duration;

        public int Duration { get => duration; set => duration = value; }
        public Service():base() { }

        public Service(int code, string? name, int? price, int duration) : base(code, name, price) {
            Duration = duration;
        }

        public override string ToString() {
            return base.ToString() + $"{Environment.NewLine}Duration "+Duration;
        }

        public override void Display() {
            base.Display();
            Console.WriteLine("Duration: " + Duration);
        }

        public override void Input() {
            base.Input();
            Console.Write("Input Duration: ");
            Convert.ToInt32(Console.ReadLine());
        }
    }
}
