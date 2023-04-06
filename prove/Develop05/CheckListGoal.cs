using System;

public class CheckListGoal : Goals
{
    private int _desiredAmount;
    private int _amountCompleted;
    private int _bonusAmount;
    public CheckListGoal(string name, string description, int points, int desiredAmount, int amountCompleted, int bonusAmount) : base(name, description, points)
    {
        _desiredAmount = desiredAmount;
        _amountCompleted = amountCompleted;
        _bonusAmount = bonusAmount;
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

    public int GetDesiredAmount()
    {   
        string _desiredAmountstring = Console.ReadLine();
        _desiredAmount = Convert.ToInt32(_desiredAmountstring);
        return _desiredAmount;
    }

    public int GetBonus()
    {
        string _bonusAmountstring = Console.ReadLine();
        _bonusAmount = Convert.ToInt32(_bonusAmountstring);
        return _bonusAmount;
    }

}


