using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a List of numbers, type 0 when finished");

        int numberUser = 0;

        //Asks the user to enter some numbers
        do
        {
            Console.Write("Enter a number: ");
            numberUser = int.Parse(Console.ReadLine());

            if (numberUser != 0)
            {
                numbers.Add(numberUser);
            }

        } while (numberUser != 0);


        //Sums all the numbers entered by the user
        int total = 0;

        foreach (int number in numbers)
        {
            total += number;
        }

        Console.WriteLine($"The sum is {total}");


        // Finds the average
        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        //Finds he largest number
        int largest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine($"The largest number is {largest}");

    }

}