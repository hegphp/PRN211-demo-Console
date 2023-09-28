using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Animal //không thể sử dụng seal hay static cho Abstract
    {
        //abstract method
        public abstract void animalSound();
        //virtual method
        public virtual void eat()
        {
            Console.WriteLine("Ăn cỏ");
        }
        //normal method
        public void run()
        {
            Console.WriteLine("Chạy bằng 4 chân");
        }
    }
}
