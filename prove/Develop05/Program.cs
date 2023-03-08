using System;

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
                Goals _goals = new Goals();
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
        // 1. Create New Goal


        // 2. List Goals
        //Example of list display: 1. [X] Give a talk (Speak in sacrament meeting when asked) Add a x after completed
        //Example checlist goal display: [] Attend the temple (Attend and perform any ordinances) -- Currently completed: 0/3


        // 3. Save Goals
        //prompt: What is the filename for the goal file? goals.txt


        // 4. Load Goals
        //What is the filename for the goal file? goals.txt (after loading a file, it needs to display the goals.)


        // 5. Record Event
        //Prompt: Which goal did you accomplish?
        //Congratulations! You have earned 50 points!
        //You have now 50 points.
        //back the menu


        //:PRompt: The goals are: 
        //1. Give a talk
        //2. Study the scriptures
        //3. Attend the temple
        //Option to select the nmber of the goal


        // 6. Quit


        //Console.Write("Select a choice from the menu: ");



}