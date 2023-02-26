using System;

using System.Collections.Generic;

public class ListingActivity : BreathingActivity
{
    public ListingActivity(string activity, string text, string question) : base(activity, text, question)
    {

    }
    public void Activity3()
    {
        Random _random = new Random();

        List<string> _questionsList = new List<string>
        {
            "---Who are people that you appreciate?---",
            "---What are personal strengths of yours?---",
            "---Who are people that you have helped this week?---",
            "---When have you felt the Holy Ghost this month?---",
            "---Who are some of your personal heroes?---",
        };

        Console.WriteLine("List as many responses you can to the following prompt (Type 'quit' to exit):");

        int index = _random.Next(0, 5);
        Console.WriteLine(_questionsList[index]);
        string _entryUser = Console.ReadLine();

        List<string> entriesUser = new List<string>
        {

        };

        do
        {
            entriesUser.Add(_entryUser);
            _entryUser = Console.ReadLine();
        } while (_entryUser != "quit");

        Console.WriteLine($"You listed {entriesUser.Count} items!!!");









    }

}

