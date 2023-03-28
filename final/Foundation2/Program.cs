using System;

class Program
{
    static void Main(string[] args)
    {
        //FIRST ORDER
        Console.WriteLine("ONLINE ORDERING");
        Console.WriteLine("===================================");

        Address _a1 = new Address("Plaza de Armas 159", "Saltillo", "Coahuila", "Mexico");

        Product _p1 = new Product("", "", 0, 0);
        Console.WriteLine("YOUR PRODUCTS:");
        Console.WriteLine();

        Order _o1 = new Order();
        _o1.CreateListOrder1();
        Console.WriteLine("===================================");
        Console.WriteLine($"ORDER SUMMARY");
        Console.WriteLine();
        _o1.GetTotalQuantity();
        Console.WriteLine($"SUBTOTAL: ${_o1.GetTotalProducts()} dlls");
        Console.WriteLine($"SHIPMENT: ${_a1.USAOrNot()} dlls");
        int _et1 = _o1.GetTotalProducts() + _a1.USAOrNot();
        Console.WriteLine($"ESTIMATED TOTAL: $ {_et1} dlls");
        
        Console.WriteLine("===================================");

        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine();
        Console.WriteLine("ORDER 00001");

        Customer _c1 = new Customer("Israel Carmona");
        Console.WriteLine($"CUSTOMER: " + _c1.GetNameCustomer());
        Console.WriteLine("ADDRESS: " + _a1.GetAddress());
        Console.WriteLine("===================================");
        Console.WriteLine("PACKING LABEL");
        Console.WriteLine();
        _o1.PackingLabel();

        Console.WriteLine("............................................................");
        
        //SECOND ORDER
        Console.WriteLine("ONLINE ORDERING");
        Console.WriteLine("===================================");

        Address _a2 = new Address("Abraham Lincoln 676", "Chicago", "Illinois", "USA");

        Product _p2 = new Product("", "", 0, 0);
        Console.WriteLine("YOUR PRODUCTS:");
        Console.WriteLine();

        Order _o2 = new Order();
        _o2.CreateListOrder2();
        Console.WriteLine("===================================");
        Console.WriteLine($"ORDER SUMMARY");
        Console.WriteLine();
        _o2.GetTotalQuantity();
        Console.WriteLine($"SUBTOTAL: ${_o2.GetTotalProducts()} dlls");
        Console.WriteLine($"SHIPMENT: ${_a2.USAOrNot()} dlls");
        int _et2 = _o2.GetTotalProducts() + _a2.USAOrNot();
        Console.WriteLine($"ESTIMATED TOTAL: ${_et2} dlls");
        Console.WriteLine("===================================");

        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine();
        Console.WriteLine("ORDER 00002");
        
        Customer _c2 = new Customer("Michael Jordan");
        Console.WriteLine($"CUSTOMER: " + _c2.GetNameCustomer());
        Console.WriteLine("ADDRESS: " + _a2.GetAddress());
        Console.WriteLine("===================================");

        Console.WriteLine("PACKING LABEL");
        Console.WriteLine();
        _o2.PackingLabel();
    }
}