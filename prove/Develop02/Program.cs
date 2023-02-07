using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)

    {

        int choice1 = 0;
        Prompt prompts = new Prompt();

        do
        {
            Console.WriteLine("Please select one of the following choices:");

            List<string> listOptions = new List<string>()
            {
            "1. Write", "2. Display", "3. Quit"
            };

            for (int i = 0; i < listOptions.Count; i++)
                Console.WriteLine(listOptions[i]);

            Console.WriteLine("What would you like to do? (Choose a number from 1 to 3): ");
            string choiceInput = Console.ReadLine();
            choice1 = int.Parse(choiceInput);

            if (choice1 == 1)
            {
                prompts.DisplayQuestion();
                prompts.FileWriter();
            }

            else if (choice1 == 2)
            {
                Console.WriteLine("These are your entries:");
                prompts.FileReader();
                Console.WriteLine();
            } 
            
            else
            {
                Console.WriteLine("See you soon!");
            }


        } while (choice1 != 3);
    }
}


