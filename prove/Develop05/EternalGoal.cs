using System;

public class EternalGoal : Goals
{
    private string _name;
    private string _description;
    private int _points;

    private List<Goals> _eternalGoal;

    public EternalGoal(string name, string description, int points) : base(name, description)
    {
        _name = name;
        _description = description;
        _points = points;
        _eternalGoal = new List<Goals>();

    }

public void ListSimpleGoal()
{   
    // _simpleGoals = new List<Goals>();
    // _simpleGoals.Add(name);
    // _simpleGoals.Add(description);
    // _simpleGoals.Add(points);
}

public string GetEternalListText()
{
    return _eternalGoal.ToString();
}


}


