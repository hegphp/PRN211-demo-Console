using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRN211;

namespace DemoSystemIO {
    internal class UserManager {
        private List<User> users;

        public UserManager() {
            this.users = new List<User>();
        }

        public void ReadFromFile(string fileName) { 
            StreamReader reader = new StreamReader(fileName);
            string? line;
            while((line = reader.ReadLine()) != null) {
                string[] items = line.Split(';');
                User u = new User(
                        Convert.ToInt32(items[0]), items[1]
                    );
                users.Add(u);
            }
            //read
            reader.Close();
        }

        public void WriteToFile(string fileName) { 
        
        } 
    }
}
