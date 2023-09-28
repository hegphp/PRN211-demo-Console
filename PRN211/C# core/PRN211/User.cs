using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211 {
    public class User {
        //private fields
        int id;
/*        string name;*/
        //Name la mot public property get set du lieu tren mot field ngầm định của .NET, tên field là gì không cần biết
        public string Name {  get; set; }

        public User() {
            Console.WriteLine("Ham tao khong tham so class User");
        }

        public User(int id, string name) {
            this.Id = id;
            this.Name = name;
            Console.WriteLine("Ham tao hai tham so class User");
        }
        //property

        public int Id { //public property
            get { return id;  } //getter
            set { id = value; } //setter
        }

        /*        public String Name { get { return name; } set {  name = value; } }*/

        public virtual void Input() {
            Console.WriteLine("Nhap thong tin User: ");
            Console.Write("Id: ");
            //Convert Int32, tra ve exception neu khong parse duoc
            Id = Convert.ToInt32(Console.ReadLine());
            //Khac nhau trong truong hop khong convert duoc, tra ve gia tri mac dinh neu khong parse duoc
            /*Int32.Parse(Console.ReadLine());*/
            Console.Write("Name: ");
            //gach chan mau xanh: tiem tang loi
            Name = Console.ReadLine();
        }

        public virtual void Display() {
            //Console.WriteLine("User: "+Id.ToString()+", "+Name);
            //Console.WriteLine(String.Format("User: {0}, {1}", Id, Name));
            Console.WriteLine($"User: {Id}, {Name}");
        }

        public override string ToString() {
            return $"User: {Id}, {Name}";
        }
        //Dinh nghia so sanh 2 object voi nhau
        public override bool Equals(object? obj) {
            return obj is User user &&
                   Name == user.Name &&
                   Id == user.Id;
        }
    }
}
