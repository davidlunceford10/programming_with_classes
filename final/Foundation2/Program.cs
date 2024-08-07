using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        Address address1 = new Address("308 Negra Arroyo Lane", "Albuquerque", "New Mexico", "USA");
        Customer customer1 = new Customer("Walter White", address1);
        Product cm1Product1 = new Product("Beans", 127564, 1.50, 1000);
        Product cm1Product2 = new Product("Pizza", 378123, 12.50, 12);
        order1.AddProduct(cm1Product1);
        order1.AddProduct(cm1Product2);
        Console.WriteLine("--------------------------------\n");
        Console.WriteLine("Order #1\n");
        order1.ReturnShippingLabel(customer1);
        order1.ReturnPackingLabel();
        string order1TotalCost = order1.CalculateTotalCost(address1);
        Console.WriteLine($"\n{order1TotalCost}");
        Console.WriteLine("--------------------------------\n");

        Order order2 = new Order();
        Address address2 = new Address("124 Conch Street", "Bikini Bottom", "Pacific Ocean", "Country n.a.");
        Customer customer2 = new Customer("SpongeBob Squarepants", address2);
        Product cm2Product1 = new Product("Snail Food", 198234, 3.50, 3);
        Product cm2Product2 = new Product("Amphibious Vehicle", 578345, 3500, 1);
        order2.AddProduct(cm2Product1);
        order2.AddProduct(cm2Product2);
        Console.WriteLine("Order #2\n");
        order2.ReturnShippingLabel(customer2);
        order2.ReturnPackingLabel();
        string order2TotalCost = order2.CalculateTotalCost(address2);
        Console.WriteLine($"\n{order2TotalCost}");
        Console.WriteLine("--------------------------------\n");

        Order order3 = new Order();
        Address address3 = new Address("1440 TwoKay Street", "Ft. Worth", "Texas", "United States");
        Customer customer3 = new Customer("Bill Murray", address3);
        Product cm3Product1 = new Product("RTX 4090 Graphics Card", 777777, 2000, 1);
        Product cm3Product2 = new Product("Honda CRF 350 Dual Sport Dirt Bike", 475335, 5000, 1);
        Product cm3Product3 = new Product("64GB DDR5 4200 MHz RAM", 573985, 225, 1);
        Product cm3Product4 = new Product("Monster Energy Drink", 998567, 3, 10000);
        order3.AddProduct(cm3Product1);
        order3.AddProduct(cm3Product2);
        order3.AddProduct(cm3Product3);
        order3.AddProduct(cm3Product4);
        Console.WriteLine("Order #3\n");
        order3.ReturnShippingLabel(customer3);
        order3.ReturnPackingLabel();
        string order3TotalCost = order3.CalculateTotalCost(address3);
        Console.WriteLine($"\n{order3TotalCost}");
        Console.WriteLine("--------------------------------\n");
    }
}

//ChatGPT helped with this project but I wrote most of the code.