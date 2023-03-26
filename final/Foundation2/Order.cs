using System;

class Order
{
    protected List<Product> _order;
    public void CreateListOrder1()
    {
        _order = new List<Product>();
        _order.Add(new Product("Pixel 6a 128GB Charcoal (Unlocked)", "PX678", 299, 2));
        _order.Add(new Product("Cover Pixel 6A", "CVRPX678", 45, 2));
        _order.Add(new Product("Google Pixel Buds Pro Charcoal", "PXBUDSPRO345", 150, 1));
        foreach (Product p in _order)
        {
            Console.WriteLine($"Product Name: " + p.GetName());
            Console.WriteLine($"Qty: " + p.GetQuantity());
            Console.WriteLine($"Price: ${p.GetPriceProduct()} dlls");
            Console.WriteLine();
        }
    }

    public void CreateListOrder2()
    {
        _order = new List<Product>();
        _order.Add(new Product("Legion 7i Gen 7 Intel (16') with RTX 3070 Ti", "LL256", 2000, 1));
        _order.Add(new Product("ThinkPad P16 (16' Intel) Mobile Workstation", "TL6478", 1475, 2));
        _order.Add(new Product("Philips Hue White and Color Ambiance Go Table Lamp", "PHW6589", 90, 5));
        foreach (Product p in _order)
        {
            Console.WriteLine($"Product Name: " + p.GetName());
            Console.WriteLine($"Qty: " + p.GetQuantity());
            Console.WriteLine($"Price: ${p.GetPriceProduct()} dlls");
            Console.WriteLine();
        }
    }

    
    public void GetTotalProducts()
    {
        int subtotal = 0;
        foreach (Product p in _order)
        {
            subtotal += p.GetPriceProduct();
        }
        Console.WriteLine($"SUBTOTAL: ${subtotal} dlls");

        
    }
    public void GetTotalQuantity()
    {
        int totalp = 0;
        foreach (Product p in _order)
        {
            totalp += p.GetQuantity();
        }
        Console.WriteLine($"CART ({totalp} items)");
    }
    public void PackingLabel()
    {
        foreach (Product p in _order)
        {
            Console.WriteLine($"Product: " + p.GetName());
            Console.WriteLine($"ID: " + p.GetProductID());
            Console.WriteLine();
        }
    }





}