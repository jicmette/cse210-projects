using System;
class Menu
{
    public void DisplayMenu()
    {
        Prompt prompts = new Prompt();

        Console.WriteLine("Please select one of the following choices:");
        List<string> listOptions = new List<string>()
        {
            "1. Write", "2. Display", "3. Load", "4. Save", "5. Quit"

        };

        for (int i = 0; i < listOptions.Count; i++)
            Console.WriteLine(listOptions[i]);

        Console.WriteLine("What would you like to do? (Choose a number between 1 to 5): ");
        string choiceInput = Console.ReadLine();
        int choice = int.Parse(choiceInput);

        if (choice == 1)
        {
            prompts.DisplayQuestion();
        }


        else if (choice == 2)
        {
            Console.Write("Display");
        }

        else if (choice == 3)
        {
            Console.Write("Load");
        }

        else if (choice == 4)
        {
            Console.Write("Save");
        } else

        {
            Console.Write("See you soon!");
        }

    }

}




