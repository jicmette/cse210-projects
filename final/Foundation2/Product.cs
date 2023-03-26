using System;

class Product
{
    private string _name;
    private string _productID;
    private int _price;
    private int _quantity = 0;

    public Product(string name, string productID, int price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    public string GetProductID()
    {
        return _productID;
    }
    public string GetName()
    {
        return _name;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public int GetPrice()
    {
        return _price;
    }
    public int GetPriceProduct()
    {
        int totalProduct = _price * _quantity;
        return totalProduct;
    }








}