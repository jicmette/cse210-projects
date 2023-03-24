using System;

public class CheckListGoal : Goals
{
    private string _name;
    private string _description;
    private int _points;

    private List<Goals> _checklistGoal;

    public CheckListGoal(string name, string description, int points) : base(name, description)
    {
        _name = name;
        _description = description;
        _points = points;
        _checklistGoal = new List<Goals>();

    }

public void ListSimpleGoal()
{   
    // _simpleGoals = new List<Goals>();
    // _simpleGoals.Add(name);
    // _simpleGoals.Add(description);
    // _simpleGoals.Add(points);
}

public string GetCheckListText()
{
    return _checklistGoal.ToString();
}


}


