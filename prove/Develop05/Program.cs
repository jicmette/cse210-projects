using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Eternal Quest");
        Console.WriteLine();

        
        // int _points = 0;

        MainMenu();

        static void MainMenu()
        {
            int _choice = 0;

            do
            {


                Console.WriteLine("Menu Options:");
                Console.WriteLine();

                List<string> _goalsMenu = new List<string>()
            {
            "1. Create Goal",
            "2. List Goals",
            "3. Save Goals",
            "4. Load Goals",
            "5. Record Event",

            "6. Quit"
            };

                foreach (string i in _goalsMenu)
                {
                    Console.WriteLine(i);
                }


                Console.Write("Select a choice from the menu: ");
                string _inputUser = Console.ReadLine();
                _choice = int.Parse(_inputUser);

                if (_choice == 1)
                {
                    MenuTypesGoal();
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

    static void MenuTypesGoal()
    {
        Console.WriteLine();
        Console.WriteLine("The types of goals are:");

        List<Goals> _goals = new List<Goals>();


        List<string> _typesGoals = new List<string>()
        {
            "1. Simple Goal",
            "2. Eternal Goal",
            "3. Checklist Goal"
        };

        foreach (string a in _typesGoals)
        {
            Console.WriteLine(a);
        }
        Console.Write("Which type of goal would you like to create? ");
        string _choiceUser = Console.ReadLine();
        int _choiceUSerInt = int.Parse(_choiceUser);
        Console.WriteLine();

        if (_choiceUSerInt == 1)
        {
            SimpleGoal _sg = new SimpleGoal("", "", 0);

            Console.WriteLine("SIMPLE GOAL");

            Console.WriteLine("What is the name of your goal?");
            _sg.GetName();

            Console.WriteLine();

            Console.WriteLine("What is a short description of it?");

            _sg.GetDescription();

            Console.WriteLine();

            Console.WriteLine("What is the amount of points associated with this goal?");
            _sg.GetPoints();

            _goals.Add(_sg);

            Console.WriteLine();

        }

        else if (_choiceUSerInt == 2)
        {
            EternalGoal _eg = new EternalGoal("", "", 0);

            Console.WriteLine("ETERNAL GOAL");

            Console.WriteLine("What is the name of your goal?");
            _eg.GetName();

            Console.WriteLine();

            Console.WriteLine("What is a short description of it?");

            _eg.GetDescription();

            Console.WriteLine();

            Console.WriteLine("What is the amount of points associated with this goal?");
            _eg.GetPoints();

            

            Console.WriteLine();
        }

        else if (_choiceUSerInt == 3)
        {
            CheckListGoal _ckg = new CheckListGoal("", "", 0, 0, 0, 0);

            Console.WriteLine("CHECKLIST GOAL");

            Console.WriteLine("What is the name of your goal?");
            _ckg.GetName();

            Console.WriteLine();

            Console.WriteLine("What is a short description of it?");

            _ckg.GetDescription();

            Console.WriteLine();

            Console.WriteLine("What is the amount of points associated with this goal?");
            _ckg.GetPoints();

            Console.WriteLine();

            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
            _ckg.GetDesiredAmount();

            Console.WriteLine();

            Console.WriteLine("What is the bonus for accomplishing it that many times?");
            _ckg.GetBonus();

            _goals.Add(_ckg);

            Console.WriteLine();
        }
    }
}

