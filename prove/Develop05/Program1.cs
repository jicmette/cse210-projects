using System;
using System.Collections.Generic;

class Program
{
    
    static void Main(string[] args)
    {
        int _choice = 0;

        do
        {
            Console.WriteLine("Welcome to the Eternal Quest Program!");
            Console.WriteLine("");
            Console.WriteLine("You have 0 points.");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");

            List<string> _goalsMenu = new List<string>()
            {
            "1. Create Goal",
            "2. List Goals",
            "3. Save Goals",
            "4. Load Goals",
            "5. Record Event",
            
            "6. Quit"
            };

            for (int i = 0; i < _goalsMenu.Count; i++)
                Console.WriteLine(_goalsMenu[i]);

            Console.Write("Select a choice from the menu: ");
            string _inputUser = Console.ReadLine();
            _choice = int.Parse(_inputUser);

            if (_choice == 1)
            {
                Goals _goals = new Goals("", "");
                _goals.MenuTypesGoal();
            }

            else if (_choice == 2)
            {


            }


            else if (_choice == 3)
            {



            }

            else if (_choice == 4)
            {



            }

            else if (_choice == 5)
            {



            }

            else
            {
                Console.WriteLine("Thanks for using the Eternal Quest! Comeback soon!");
            }

        } while (_choice != 6);

    }


}