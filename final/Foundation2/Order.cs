class Order
{
    private List<Product> _products = new();
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public float GetTotal()
    {
        float total = 0;

        foreach (Product product in _products)
        {
            total += product.CalculatePrice();
        }
        
        if (_customer.CheckInUS())
        {
            return total + 5;
        }

        return total + 35;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in _products)
        {
            packingLabel = $"{packingLabel}\n{product.GetName()} (x{product.GetQuantity()}) ProdID: {product.GetId()}";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetDisplay()}";
    }
}