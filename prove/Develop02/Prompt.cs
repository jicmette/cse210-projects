using System;
using System.IO;
using System.Text;


class Prompt
{
    
    Random rnd = new Random();
    string[] questions =
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
        };

    public void DisplayQuestion()
    {
        int index = rnd.Next(0, 5);
        Console.WriteLine(questions[index]);
        string entry1 = Console.ReadLine();

    }
}
