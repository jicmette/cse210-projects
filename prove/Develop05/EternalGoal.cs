using System;

public class EternalGoal : Goals
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override string GetName()
    {
        _name = Console.ReadLine();
        return _name;
    }

    public override string GetDescription()
    {
        _description = Console.ReadLine();
        return _description;
    }

    public override string GetPoints()
    {
        string _pointString = Console.ReadLine();
        _points = Convert.ToInt32(_pointString);
        return _pointString;
    }


}


