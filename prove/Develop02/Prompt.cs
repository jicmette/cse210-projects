using System;
using System.IO;
using System.Text;
using System.Collections.Generic;


public class Prompt
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

    public List<string> entries = new List<string>();

    public void DisplayQuestion()
    {

        int index = rnd.Next(0, 5);
        Console.WriteLine(questions[index]);
        string entry1 = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        entries.Add($"Date: {dateText} - {entry1}");
        Console.WriteLine("Entry Saved!");
        Console.WriteLine();

    }

    string fileName = "journal.txt.";
    public void FileWriter()
    {

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {

            foreach (string entry in entries)
            {
                outputFile.WriteLine($"{entry}");


            }
           
            outputFile.Close();

        }

    }

    public void FileReader()
    {
        entries = File.ReadAllLines(fileName).ToList();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {

            foreach (string entry in entries)
            {
                Console.WriteLine($"{entry}");

            }

            outputFile.Close();

        }

    }
}