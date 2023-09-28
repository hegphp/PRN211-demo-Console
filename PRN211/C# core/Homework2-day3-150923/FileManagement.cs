using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_day3_150923 {
    internal class FileManagement {
        static string filepath = @"E:\Study\Coding\PRN211\C# core\newOrder.txt";
        public static Order ReadOrderFromFile(string path) {
            try {
                StreamReader reader = new StreamReader(path);
                string? line;
                string?[] content;
                Order newOrder = new Order();
                int count = 0;
                string datePattern = "dd/MM/yyyy";
                DateTime tempDate;
                //Product variable
                int code = 0;
                float price = 0;
                string name = "";
                DateTime expDate = new DateTime(2003, 03, 24);

                //Scan until the end of the file
                while ((line = reader.ReadLine()) != null) {
                    count++;
                    //Read first line
                    if (count == 1) {
                        newOrder.OrderId = line;
                    }
                    //Read second line
                    else if (count == 2) {
                        try {
                            DateTime.TryParseExact(line, datePattern, null, DateTimeStyles.None, out tempDate);
                            newOrder.OrderDate = tempDate;
                        }
                        catch (Exception ex) {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else {
                        //content of a line
                        content = line.Split(";");
                        for (int i = 0; i < content.Length; i++) {
                            //Saving code
                            if (i == 0) {
                                code = Convert.ToInt32(content[i]);
                            }
                            //Saving productName
                            if (i == 1) {
                                name = content[i];
                            }
                            //Saving product Price
                            if (i == 2) {
                                price = Convert.ToSingle(content[i]);
                            }
                            //Saving date
                            if (i == 3) {
                                try {
                                    DateTime.TryParseExact(content[i], datePattern, null, DateTimeStyles.None, out tempDate);
                                    expDate = tempDate;
                                }
                                catch (Exception ex) {
                                    Console.WriteLine(ex.Message);
                                }
                            }
                        }
                        newOrder.ListOfProducts.Add(new Product(code, name, price, expDate));
                    }
                }
                reader.Close();
                newOrder.Display();
                return newOrder;
            }
            catch (FileNotFoundException fileEx) {
                Console.WriteLine(fileEx.Message);
                return null;
            }
        }

        internal static void AddProduct(Order order, string filepath) {
            Product newProduct = new Product();
            try {
                //check if a file is exist or not
                using (StreamReader reader = new StreamReader(filepath)) {
                    //Check if the file is empty or not
                    if (reader.ReadLine() == null)
                        throw new FileNotFoundException(filepath);
                }
            }
            catch (FileNotFoundException fileEx) {
                Console.WriteLine("File not Found or Empty!, creating a new file");
                using (StreamWriter streamWriter = new StreamWriter(filepath)) {
                    streamWriter.WriteLine("01234\n" +
                        $"{DateTime.Now:dd/MM/yyyy}");
                    streamWriter.Close();
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            //Add new product
            Console.Write("Input product code: ");
            newProduct.Code = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input product name: ");
            newProduct.Name = Console.ReadLine();
            Console.Write("Input product price: ");
            newProduct.Price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input ExpDate:");
            try {
                DateTime output;
                DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, DateTimeStyles.None, out output);
                newProduct.ExpDate = output;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            using (StreamWriter streamWriter = new StreamWriter(filepath, true)) {
                streamWriter.WriteLine(newProduct.Code + ";" + newProduct.Name + ";" + newProduct.Price + ";" + $"{newProduct.ExpDate:dd/MM/yyyy}");
                streamWriter.Close();
            }
        }

        internal static void DeleteProduct(String filepath) {
            try {
                //lay du lieu
                Order newOrder = ReadOrderFromFile(filepath);
                if (newOrder == null) {
                    throw new FileNotFoundException("Error: the data is null!");
                }
                //User input the product code to erase
                int code = Convert.ToInt32(Console.ReadLine());
                Product deleteProduct = new Product();
                //Find product Id By code
                for (int i = 0; i < newOrder.ListOfProducts.Count; i++) {
                    if (newOrder.ListOfProducts[i].Code == code)
                        deleteProduct = newOrder.ListOfProducts[i];
                }
                var linesToKeep = new List<string>();
                int lineSkipped = 0;
                var tempFile = Path.GetTempFileName();
                //Access every line from 3th one except the line user selected 
                foreach (var line in File.ReadLines(filepath).Where(l => !l.StartsWith($"{code}"))) {
                    //Check if the line is the one user select to remove or not from 3th line
                    if (lineSkipped < 2 || !line.StartsWith($"{code}")) {
                        linesToKeep.Add(line);
                    }
                    else {
                        lineSkipped++;
                    }
                }

                using (StreamWriter streamWriter = new StreamWriter(tempFile)) {
                    foreach (var line in linesToKeep) {
                        streamWriter.WriteLine(line);
                    }
                }
                File.WriteAllLines(tempFile, linesToKeep);
                File.Delete(filepath);
                File.Move(tempFile, filepath);
                newOrder.ListOfProducts.Remove(deleteProduct);
            }
            catch (FileNotFoundException fileEx) {
                Console.WriteLine(fileEx.Message);
                return;
            }
        }

        internal static void displayOrder(Order newOrder) {
            newOrder.Display();
        }

        internal static void UpdateProduct(string filepath) {
            try {
                var updatedLine = new List<string>();
                var skippedLine = 0;
                //Get order info
                Order newOrder = ReadOrderFromFile(filepath);
                if (newOrder == null) {
                    throw new FileNotFoundException("Error: the data is null!");
                    return;
                }
                //User insert id to update
                int code = Convert.ToInt32(Console.ReadLine());
                //access every line in the datafile
                foreach(var line in File.ReadLines(filepath)) {
                    if (skippedLine < 2) {
                        updatedLine.Add(line);
                        skippedLine++;
                        continue;
                    }
                    else {
                        if (line.StartsWith($"{code}")) {
                            Product newPro = new Product();
                            Console.Write("Insert new Name: ");
                            newPro.Name = Console.ReadLine();
                            Console.Write("");
                            newPro.Price = Convert.ToInt32(Console.ReadLine());
                            Console.Write("insert new date:");
                            DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime date);
                            newPro.ExpDate = date;
                            updatedLine.Add($"{code};{newPro.Name};{newPro.Price};{newPro.ExpDate:dd/MM/yyyy}");
                        }
                        else {
                            updatedLine.Add(line);
                        }
                    }
                }
                File.WriteAllLines(filepath, updatedLine);
            }
            catch(FileNotFoundException fileEx) {
                Console.WriteLine(fileEx.Message);
            }
        }
    }
}
