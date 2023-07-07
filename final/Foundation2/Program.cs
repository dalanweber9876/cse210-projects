using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();
        //Order #1
        List<Product> order1 = new List<Product>();
        Address a1 = new Address("123 W 432 S", "Rexburg", "Idaho", "USA");
        Customer c1 = new Customer("Mason Weber", a1);
        Product o1p1 = new Product("Tennis Racket", "0001", 54.99, 1);
        Product o1p2 = new Product("Banana", "0230", .93, 7);
        Product o1p3 = new Product("Puzzle", "9080", 12.95, 2);
        order1.Add(o1p1);
        order1.Add(o1p2);
        order1.Add(o1p3);
        Order o1 = new Order(c1, order1);
        orders.Add(o1);

        //Order #2
        List<Product> order2 = new List<Product>();
        Address a2 = new Address("546 Scenic Drive", "Araruama", "Rio", "Brazil");
        Customer c2 = new Customer("Murilo Freire", a2);
        Product o2p1 = new Product("Monopoly", "9302", 32.25, 1);
        Product o2p2 = new Product("Colored Tie", "8001", 5, 3);
        Product o2p3 = new Product("Sandals", "4110", 54.32, 2);
        order2.Add(o2p1);
        order2.Add(o2p2);
        order2.Add(o2p3);
        Order o2 = new Order(c2, order2);
        orders.Add(o2);

        int count = 1;
        foreach (Order order in orders)
        {
            Console.WriteLine($"\nOrder {count}");

            Console.WriteLine("\nPacking Label:");
            order.GetPackingLabel();

            Console.WriteLine("\nShipping Label:");
            order.GetShippingLabel();
            

            Console.WriteLine("\nTotal Price:");
            Console.WriteLine($"${order.GetCost()}");
            Console.WriteLine();
            count += 1;
        }
    }
}