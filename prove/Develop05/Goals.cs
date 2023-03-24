using System;
using System.Collections.Generic;
using System.IO;

public class Goals
{

    private string _name;
    private string _description;

    private List<string> _goals;

    public Goals(string name, string description)
    {
        _name = name;
        _description = description;
        _goals = new List<string>();

    }


    public void MenuTypesGoal()
    {   
        Console.WriteLine();
        Console.WriteLine("The types of goals are:");

        List<string> _typesGoals = new List<string>()
        {
            "1. Simple Goal", 
            "2. Eternal Goal", 
            "3. Checklist Goal"
        };

        for (int l = 0; l < _typesGoals.Count; l++)
            Console.WriteLine(_typesGoals[l]);
            Console.Write("Which type of goal would you like to create? ");
            string _choiceUser = Console.ReadLine();
            int _choiceUSerInt = int.Parse(_choiceUser);
            Console.WriteLine();

            if (_choiceUSerInt == 1)
            {
                QuestionsGoals();
                // _goals = new SimpleGoal(name, description, points);
            }

            else if (_choiceUSerInt == 2)
            {
                QuestionsGoals();
            }

            else if (_choiceUSerInt == 3)
            {
                QuestionsGoals();
                QuestionsGoalChecklist();
            }

    }

    public void QuestionsGoals()
    {
        Console.WriteLine("What is the name of your goal?");
        string _name = Console.ReadLine();
        Console.WriteLine("What is a short description of it?");
        string _description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        string _pointString = Console.ReadLine();
        int _points = int.Parse(_pointString);
        
    }
    public void QuestionsGoalChecklist()
    {
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
        string _times = Console.ReadLine();
        int _timesAccom = int.Parse(_times);
        Console.WriteLine("What is the bonus for accomplishing it that many times?");
        string _bonus = Console.ReadLine();
        int _bonusAdded = int.Parse(_bonus);
        
        

    }


}






