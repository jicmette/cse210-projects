using System;

class Customer
{
    private string _customer;
    public Customer(string customer)
    {
        _customer = customer;
    }
    public string GetNameCustomer()
    {
        return _customer;
    }
}
