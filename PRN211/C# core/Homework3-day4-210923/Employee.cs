using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_day4_210923 {
    internal class Employee {
        private int id;
        private string name;
        private string position;
        double monthlySalary;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Position { get => position; set => position = value; }
        public double MonthlySalary { get => monthlySalary; set => monthlySalary = value; }

        public Employee(int id, string name, string position, double monthlySalary) {
            this.Id = id;
            this.Name = name;
            this.Position = position;
            this.MonthlySalary = monthlySalary;
        }

        public Employee() {
        }


    }
}
