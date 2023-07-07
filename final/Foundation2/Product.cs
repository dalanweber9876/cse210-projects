public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;
    private double _totalPrice;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _quantity = quantity;
        _price = price;
    }

    private void SetPrice()
    {
        _totalPrice = Math.Round(_price * _quantity, 2);
    }

    public double GetPrice()
    {
        SetPrice();
        return Math.Round(_totalPrice, 2);
    }

    public string GetProductId()
    {
        return _productId;
    }

    public string GetProductName()
    {
        return _name;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}
