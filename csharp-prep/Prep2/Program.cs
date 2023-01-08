using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string percentEntered = Console.ReadLine();
        int percent = int.Parse(percentEntered);

        string letter = "";
        string signMinus = "-";
        string signPlus = "+";

        //Assigns the a grade.
        if (percent >= 90)
        {
            letter = "A";
        }

        else if (percent >= 80)
        {
            letter = "B";
        }

        else if (percent >= 70)
        {
            letter = "C";
        }

        else if (percent >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        // Prints the grade and detects the last digit to assign the - or + sign to the grade.
        int signAdded = percent % 10;

        if (percent >= 90 && signAdded >= 7) 
        {
            Console.WriteLine($"Your grade is {letter}");
        }

        else if (percent >= 60 && signAdded >=7)
        {
            Console.WriteLine($"Your grade is {letter}{signPlus}");
        }

        else if (percent >= 60 && signAdded < 3)
        {
            Console.WriteLine($"Your grade is {letter}{signMinus}");
        }

        else if (percent < 60 && signAdded >=7)
        {
            Console.WriteLine($"Your grade is {letter}");
        }
        
        else 
        {
            Console.WriteLine($"Your grade is {letter}");
        }

        // Prints the last message.
        if (percent >= 70)
        {
            Console.Write("Congratulations, you passed!");
        }

        else 
        {
            Console.WriteLine("Try harder the next time to get a better grade!");
        }
    }
}