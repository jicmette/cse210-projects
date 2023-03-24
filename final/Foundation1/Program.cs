using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Youtube Videos");
        Console.WriteLine();

        Console.WriteLine("VIDEO 1");
        Video _v1 = new Video("You're reading wrong! 5 tips to become a better reader", "Ruri Ohama", 8.51);
        Console.WriteLine(_v1.DisplayVideo());
        Console.WriteLine();
        Comments _c1 = new Comments();
        Console.WriteLine("COMMENTS");
        _c1.DisplayComments();
        Console.WriteLine("--------------------------------------------------");

        Console.WriteLine("VIDEO 2");
        Video _v2 = new Video("9 self-help books that changed my life", "Matt D'Avella", 12.29);
        Console.WriteLine(_v2.DisplayVideo());
        Console.WriteLine();
        Comments _c2 = new Comments();
        Console.WriteLine("COMMENTS");
        _c2.DisplayComments2();
        Console.WriteLine("---------------------------------------------------");

        Console.WriteLine("VIDEO 3");
        Video _v3 = new Video("Simplify Your Inbox: Digital Minimalism 01", "Nathaniel Drew", 9.15);
        Console.WriteLine(_v3.DisplayVideo());
        Console.WriteLine();
        Comments _c3 = new Comments();
        Console.WriteLine("COMMENTS");
        _c3.DisplayComments3();
        Console.WriteLine("---------------------------------------------------");
    }
}