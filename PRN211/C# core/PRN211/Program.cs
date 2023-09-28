using PRN211;
using System;
using System.Collections;

namespace MyApp {
    internal class Program { //internal: phạm vi trong một khối hợp ngữ (Assembly) / Project đã được biên dịch (package = namespace != project)
        //public : toàn bộ solution
        // mặc định: phạm vi nhỏ nhất
        static void Main(String[] args) {
            /*            User u = new User();
                        u.Id = 12;
                        Console.WriteLine(u.Id);*/
            User u = new User();
            /*u.Input();
            u.Display();*/

            /*            Student student = new Student(123,"asdas","asdas");

                        student.Input();
                        Console.WriteLine(student.ToString());*/
/*
            Teacher teacher = new Teacher();
            teacher.Input();
            Console.WriteLine(teacher.ToString());
*/
            DemoArrayList();
        }

        public static void DemoArrayList() { 
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("abc");
            list.Add(new User(1,"asda"));

            Console.WriteLine($"Capacity: {list.Capacity}, Count: {list.Count}");

            /*((User)list[2]).Input();*/

            foreach (var item in list) {
                Console.WriteLine(item);
            }
        }

        public static void DemoList() { 
            List<User> UserList = new List<User>();
            UserList.Add(new User(1, "ABC"));
            UserList.Add(new Student(2, "BCD", "SE"));
            //UserList.Add(2); //Complie err
            UserList[0].Input();
        }
    }
}