using Lab1;
using System.Globalization;

List<Product> productList = new List<Product>();
ProductManager manage = new ProductManager();
DateTime dateInput = DateTime.Now;
try {
    //Get product List data
    using (StreamReader reader = new StreamReader(@"E:\Study\Coding\PRN211\Data\productList.txt")) {
        string? line;
        string[] contents;
        //Read file in the begining
        while ((line = reader.ReadLine()) != null) {
            contents = line.Split(",");
            //get id attribute
            int id = int.Parse(contents[0]);
            //get name attribute
            string name = contents[1];
            //get category attribute
            string category = contents[2];
            //get Price attribute
            double price = double.Parse(contents[3]);
            //get expDate attribute
            DateTime date;
            DateTime.TryParseExact(contents[4], "dd/MM/yyyy", null, DateTimeStyles.None, out date);
            productList.Add(new Product(id, name, category, price, date));
        }
    }
}
catch (FormatException formatEx) {
    Console.WriteLine("The File can be corrupt, please fix that file");
}
//Loop until user choose exit
while (true) {
    //Display menu
    DisplayMenu();
    //Get User choice
    int choice = GetUserChoiceInt(1, 6);
    //Run function depends on user's choice
    switch (choice) {
        //Option 1: Display products By Id
        case 1:
            //User input an id
            int id = GetInt("Input a number: ");
            //display product by id
            manage.DisplayProductsById(productList, id);
            break;
        //Option 2: Display products By Name that contains a string
        case 2:
            //User input a name
            Console.Write("Enter a name: ");
            manage.DisplayProductsByName(productList, Console.ReadLine());
            break;
        //Option 3: Display products by price in a range
        case 3:
            int min = GetInt("Input the min value: ");
            int max = GetInt("Input the max value: ");
            manage.DisplayProductsInRange(productList, min, max);
            break;
        //Option 4: Display products that has expdate before a date
        case 4:
            dateInput = GetDate("Type date(dd/MM/yyyy): ");
            manage.DisplayProductsBeforeDate(productList, dateInput);
            break;
        //Option 5: Display products by category and expDate
        case 5:
            //Get user input
            string category = GetString("Type Category: ");
            dateInput = GetDate("Type date(dd/MM/yyyy): ");
            manage.DisplayProductsByCategoryExpDate(productList, category, dateInput);
            break;
        //Exit program
        case 6:
            System.Environment.Exit(0);
            break;
    }
}

int GetUserChoiceInt(int min, int max) {
    while (true) {
        Console.Write("Input a number (1-6):");
        string input = Console.ReadLine();
        try {
            int choice = Convert.ToInt32(input);
            //Check if a choice is in a range or not
            if (choice < min || choice > max)
                throw new Exception($"Error: you must type a number in range of {min} to {max}");
            return choice;
        }
        catch (FormatException formatEx) {
            Console.WriteLine("Format error, please type again!");
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }
}

int GetInt(string message) {
    while (true) {
        Console.Write(message);
        string input = Console.ReadLine();
        try {
            int choice = Convert.ToInt32(input);
            return choice;
        }
        catch (FormatException formatEx) {
            Console.WriteLine("Format error, please type again!");
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }
}

DateTime GetDate(String message) {
    //Loop until user typed valid date
    while (true) {
        try {
            Console.Write(message);
            string input = Console.ReadLine();
            return DateTime.ParseExact(input, "dd/MM/yyyy", null, DateTimeStyles.None);
        }catch(FormatException formatEx) {
            Console.WriteLine("Format Error, please type again!");
        }catch(Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }
}

string GetString(string message) {
    Console.Write(message);
    string input = Console.ReadLine();
    return input;
}

void DisplayMenu() {
    Console.WriteLine("1. Find Products By Id\n" +
        "2. Find Products contains Name\n" +
        "3. Find Products in a range\n" +
        "4. Find Products has expDate before...\n" +
        "5. Find Products by category and expDate\n" +
        "6. Exit the program");
}