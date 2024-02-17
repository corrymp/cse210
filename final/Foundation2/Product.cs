class Product
{
    private string _name;
    private int _id;
    private float _price;
    private int _quantity;

    public Product(string name, int id, float price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }
    
    public int GetId()
    {
        return _id;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public float CalculatePrice()
    {
        return _quantity * _price;
    }
}