using System;

public class Address 
{
    private string _address;


    public Address(string address)
    {
        _address = address;
    }

    public void GetAddressLecture()
    {
        Console.WriteLine("ADDRESS: Nova3 7046 Hollywood Boulevard Los Angeles, CA 90028 United States");
    }

    public void GetAddressReception()
    {
        Console.WriteLine("ADDRESS: Blvd. Emilio Arizpe de la Maza 1899, Rancho el Mimbre, 25080 Saltillo, Coah. Mexico.");
    }

    public void GetAddressOutdoor()
    {
        Console.WriteLine("ADDRESS: Avenida Fundidora and Adolfo Prieto W/N, Obrera, 64010 Monterrey, N.L.");
    }

}