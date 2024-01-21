using ConsoleApp21;

uint productLimit;
do {
    Console.Write("Enter product limit: ");
} while (!uint.TryParse(Console.ReadLine(), out productLimit));

Market market = new Market(productLimit);

string? option;
do {
    ShowMenu();
    option = Console.ReadLine();
    switch (option) {
        case "1":
            string? name;
            do {
                Console.WriteLine("Enter product name: ");
                name = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(name));

            double price;
            do {
                Console.WriteLine("Enter product price: ");
            } while(!double.TryParse(Console.ReadLine(), out price) || price < 0);

            uint count;
            do {
                Console.WriteLine("Enter product count: ");
            } while (!uint.TryParse(Console.ReadLine(), out count) || count < 0);

            Product product = new Product(name, price, count);

            market.AddProduct(product);
            break;
        case "2":
            string? nameToSell;
            do {
                Console.WriteLine("Enter product name to sell: ");
                nameToSell = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(nameToSell));
            market.SellProduct(nameToSell);
            break;
        case "3":
            ShowProducts(market);
            break;
        case "0":
            Console.WriteLine("Good bye");
            break;
        default:
            Console.WriteLine("Invalid input");
            break;
    }
} while (option != "0");



static void ShowMenu() {
    Console.WriteLine("1. Add product");
    Console.WriteLine("2. Sell product");
    Console.WriteLine("3. Show products");
    Console.WriteLine("0. Exit");
    Console.Write("Select: ");
}

static void ShowProducts(Market market) {
    Console.WriteLine("Products:");
    foreach (var item in market.Products) {
        Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Count: {item.Count}");
    }
}