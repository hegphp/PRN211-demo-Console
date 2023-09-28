// See https://aka.ms/new-console-template for more information
using DemoExtensionMethod;
using PRN211;

User u = new User(1, "A", new DateTime(2003, 12, 12));
u.Display();
u.Display("Thong tin user: ");

UserList list = new UserList();
list.List.Display();


Console.WriteLine("Demo truy van du lieu: ");
list.getUserById(10).Display();

list.GetUsersByName("B").Display();

list.GetUserByYearNameOnly(1999);