using System;

class Program
{
    static void Main(string[] args)
    {
        //Calls the functions
        DisplayWelcome();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();

        int squareN = SquareNumber(favNumber);
        DisplayResult(userName, squareN);
    }

    //Displays the welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    //Asks the users name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    //Asks the users favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }

    //Square function
    static int SquareNumber(int favNumber)
    {
        int squareN = favNumber * favNumber;

        return squareN;
    }

    //Displays the name and the square number of the user
    static void DisplayResult(string userName, int squareN)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareN}");
    }
}
