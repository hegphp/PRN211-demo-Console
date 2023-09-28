using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSystemIO {
    internal class DemoDirectoryInfo {
        public static void ReadDirectoryInfo(String path) {
            DirectoryInfo directory = new DirectoryInfo(path);
            DirectoryInfo[] dirInfo = directory.GetDirectories(); //khong phai method static, nho hoi 
            foreach(DirectoryInfo d in dirInfo) {
                Console.WriteLine($"{d.FullName}, {d.Attributes}, {d.CreationTime}");
                string[] files = Directory.GetFiles(d.FullName,"*",SearchOption.AllDirectories);
                Console.WriteLine($"Sum of files: "+files.Length);
            }
        }
    }
}
