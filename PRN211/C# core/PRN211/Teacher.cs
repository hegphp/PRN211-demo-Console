using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211 {
    internal class Teacher:User {
        public String[] Skills { get; set; }

        public Teacher() { }

        public Teacher(int id, String name):base(id, name) {
            
        }

        public override void Input() {
            base.Input();
            Console.WriteLine("Skills");
            string? skills = Console.ReadLine();//Format: Java;Php;C;.Net
            Skills = skills.Split(";");
        }

        public override string ToString() {
            string s = base.ToString();
            s += $"{Environment.NewLine}List of Skills: ";
            foreach (string skill in Skills) {
                s += $"{skill} {Environment.NewLine}";

            }
            return s;
        }

        public override void Display() {
            base.Display();
        }
    }
}
