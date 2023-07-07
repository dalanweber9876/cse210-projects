public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public string GetCost()
    {
        double cost = 0;
        foreach (Product product in _products)
        {
            cost += product.GetPrice();
        }
        if (_customer.LivesInUsa() == true)
        {
            cost += 5;
        }
        else
        {
            cost += 35;
        }
        return String.Format("{0:0.00}", cost);
    }

    public void GetPackingLabel()
    {
        foreach(Product product in _products)
        {
            Console.Write($"{product.GetProductName()} ({product.GetQuantity()}) - ");
            Console.WriteLine(product.GetProductId());
        }
    }

    public void GetShippingLabel()
    {
        Console.WriteLine($"{_customer.GetName()}");
        Console.WriteLine(_customer.GetAddress());
    }

}