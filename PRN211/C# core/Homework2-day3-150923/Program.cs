// See https://aka.ms/new-console-template for more information
using Homework2_day3_150923;

Order newOrder = new Order();
int choice;
string filepath = @"E:\Study\Coding\PRN211\C# core\newOrder.txt";
//Run program until user choice exit
while (true) {
    //Display menu
    displayMenu();
    //Get user choice
    choice = Convert.ToInt32(Console.ReadLine());
    //Run function depends on User's Choice
    switch (choice) {
        //Option 1: display data
        case 1:
            //check file
            newOrder = FileManagement.ReadOrderFromFile(filepath);
            
            break;
        //Option 2: Add a product
        case 2:
            FileManagement.AddProduct(newOrder, filepath);
            break;
        //option 3: Delete a product
        case 3:
            FileManagement.DeleteProduct(filepath);
            break;
        //option 4: Update a product
        case 4:
            FileManagement.UpdateProduct(filepath);
            break;
        //Default: Exit
        default:
            System.Environment.Exit(0);
            break;
    }
}

void displayMenu() {
    Console.WriteLine("Choose an option: \n" +
        "1. Display order\n" +
        "2. Add product\n" +
        "3. Delete product\n" +
        "4. Update product\n");
}

//Order newOrder = FileManagement.ReadOrderFromFile(@"E:\Study\Coding\PRN211\C# core\newOrder.txt");
//FileManagement.displayOrder(newOrder);
