using Lab1;

internal class ProductManager {
    internal void DisplayProductsBeforeDate(List<Product> productList, DateTime date) {
        var output = productList.Where(p => p.Expdate < date).OrderBy(p => p.Expdate).ToList();
        //Check if the output is empty or not
        if (output.Count == 0) {
            Console.WriteLine("Not Found!");
        }
        else
            output.Display();
    }

    //Display product by category and expDate befor a date
    internal void DisplayProductsByCategoryExpDate(List<Product> productList, string category, DateTime date) {
        var output = productList.Where(p => p.Category == category && DateTime.Compare(p.Expdate,date) < 0).OrderBy(p => p.Expdate).ToList();
        //Check if the output is empty or not
        if(output.Count == 0) {
            Console.WriteLine("Not found!");
        }else
            output.Display();
    }

    //Display product by Id
    internal void DisplayProductsById(List<Product> productList, int id) {
        var product = productList.FirstOrDefault(u => u.Id == id);
        //Check if the product is null or not
        if (product != null) {
            Console.WriteLine("\n======================================");
            Console.WriteLine("Product Founded: " + product);
            Console.WriteLine("\n======================================");
        }
        else {
            Console.WriteLine("Not found!");
        }
    }

    //Find product contains name
    internal void DisplayProductsByName(List<Product> productList, string name) {
        var output = productList.Where(p => p.Name.Contains(name)).OrderBy(p => p.Expdate).ToList();
        //Check if the output is empty or not
        if(output.Count == 0) {
            Console.WriteLine("Not Found!");
        }else
            output.Display();
    }

    //Find product in price range
    internal void DisplayProductsInRange(List<Product> productList, int min, int max) {
        var output = productList.Where(u => u.Price >= min && u.Price <= max).OrderBy(u => u.Expdate).ToList();
        //Check if the product is empty or not
        if(output.Count == 0)
            Console.WriteLine("Not found!");
        else
            output.Display();
    }
}