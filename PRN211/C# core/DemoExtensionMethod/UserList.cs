using PRN211;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExtensionMethod {
    internal class UserList {
        List<User> list;

        public UserList() {
            List = new List<User> {
                new User(10, "A", new DateTime(1999,12,23)),
            new User(11, "B", new DateTime(1999, 12, 23)),
            new User(12, "B", new DateTime(1999, 12, 23)),
            new User(13, "B", new DateTime(1999, 12, 23)) 
            };
        }

        public List<User> List { get => list; set => list = value; }

        public User getUserById(int id) {
            return list.FirstOrDefault(u => u.Id == id);
        }

        public List<User> GetUsersByName(string name) {
            return list.Where(u => u.Name.Contains(name)).ToList();
        }

        public List<User> GetUsersByNameDOBYear(string name, int year) {
            return list.Where(u => u.Name.Contains(name) && u.Dob.Year == year).OrderBy(u => u.Dob).ThenByDescending(u => u.Name).ToList();
        }

        public void GetUserByYearNameOnly(int year) {
            var result = list.Where(x => x.Dob.Year == year).Select(x => new {Code = x.Id, FullName = x.Name }).ToList(); 
            Console.WriteLine("List of name of the user");
            foreach(var user in result) Console.WriteLine(user.Code+"-"+user.FullName);
        }

    }
}
