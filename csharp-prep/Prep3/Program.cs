using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int numberUser = 0;
        int timesTried = 0;
        string answer = "";

        do
        {
            Console.Write("What is the magic number? ");
            numberUser = int.Parse(Console.ReadLine());

            timesTried++;
            if (numberUser < number)
            {
                Console.WriteLine("Higher");

            }
            else if (numberUser > number)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine($"You guessed it! You have tried {timesTried} times!");
                Console.WriteLine("Do you want to play again? (yes/no)");
                answer = Console.ReadLine();

            }

        } while (numberUser != number || answer == "yes");

    }
}