using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)

    {

        int choice1 = 0;
        Prompt prompts = new Prompt();
        Files filePath = new Files();

        do
        {
            Console.WriteLine("Please select one of the following choices:");

            List<string> listOptions = new List<string>()
            {
            "1. Write", "2. Display", "3. Load", "4. Save", "5. Quit"
            };

            for (int i = 0; i < listOptions.Count; i++)
                Console.WriteLine(listOptions[i]);

            Console.WriteLine("What would you like to do? (Choose a number between 1 to 5): ");
            string choiceInput = Console.ReadLine();
            choice1 = int.Parse(choiceInput);

            if (choice1 == 1)
            {
                prompts.DisplayQuestion();
                filePath.FileCreation();
            }

            else if (choice1 == 2)
            {
                Console.WriteLine("Display");
            }

            else if (choice1 == 3)
            {
                Console.WriteLine("Load");
            }

            else if (choice1 == 4)
            {
                Console.WriteLine("Save");
            }
            else
            {
                Console.WriteLine("See you soon!");
            }


        } while (choice1 != 5);
    }
}


