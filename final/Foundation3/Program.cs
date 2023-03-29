using System;

class Program
{
    static void Main(string[] args)
    {
        //EVENT LECTURE
        Console.WriteLine("EVENT PLANNING");
        Console.WriteLine();

        Console.WriteLine("EVENT DETAILS");
        Console.WriteLine();

        Address _a = new Address("");

        Lectures _l1 = new Lectures
        (
            "WEB3 WEDS | Weekly Happy Hour | Speaker Series", 
            "Speaker Event", 
            "Join our live audience and become a part of LA's Web3 community. Have a chance to network with some of LA's most brilliant minds while learning from a wide variety of experts across Web3. Set to the backdrop of a world-class, state-of-the-art venue, Web3 Wednesdays guarantees to be a memorable & informative evening. Introduce yourself to others in the Web3 community & share ideas through an open forum.",
            600, 
            "Robert. W. Karston", 
            600
        );
        
        _l1.DisplayEvent();
        _a.GetAddressLecture();
        Console.WriteLine(_l1.GetSpeaker());
        Console.WriteLine($"CAPACITY: {_l1.GetCapacity()}");

        Console.WriteLine("==================================");

        //EVENT RECEPTIONS
        Console.WriteLine("EVENT PLANNING");
        Console.WriteLine();

        Console.WriteLine("EVENT DETAILS");
        Console.WriteLine();

        Receptions _r1 = new Receptions
        (
            "Mary & Joe Wedding", 
            "Reception", 
            "A wedding in an ancient ranch in the north of Mexico",
            2000, 
            "jicmettesc@gmail.com"
            
        );
        
        _r1.DisplayEvent();
        _a.GetAddressReception();
        Console.WriteLine($"EMAIL RSVP: {_r1.GetEmail()}");

        Console.WriteLine("==================================");

        //EVENT OUTDOOR

        Console.WriteLine("EVENT PLANNING");
        Console.WriteLine();

        Console.WriteLine("EVENT DETAILS");
        Console.WriteLine();

        Outdoor _o1 = new Outdoor
        (
            "The Killers Tour",
            "Outdoor",
            "The Killers Tour - Monterrey",
            2200,
            "Windy"
        );

        _o1.DisplayEvent();
        _a.GetAddressOutdoor();
        Console.WriteLine($"WEATHER: {_o1.GetWeather()}");
        Console.WriteLine();

    }
}