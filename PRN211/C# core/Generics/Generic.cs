using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Generic<T> {
        private List<T> items;

        public Generic() { 
            items = new List<T>();
        }
        internal protected void add(T input) { 
            items.Add(input);
        }
        internal protected void remove(T input) { 
            items.Remove(input);
        }
        internal protected void displayList() { 
            for (int i = 0; i < items.Count; i++) {
                //check if the elements is the first one
                if (i == 0) {
                    Console.Write(items[i].ToString());
                    continue;
                }
                Console.Write(" "+items[i].ToString());
            }
        }
    }
}
