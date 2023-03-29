using System;

public class Receptions : Event
{
    private string _email;

    public Receptions(string nameEvent, string typeEvent, string description, int time, string email) : base(nameEvent, typeEvent, description, time)
    {
        _email = email;
    }

    public string GetEmail()
    {
        return _email;
    }

    

}