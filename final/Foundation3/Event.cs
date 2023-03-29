using System;

public class Event 
{
    private string _nameEvent;
    private string _typeEvent;
    private string _description;
    private int _time;

    public Event (string nameEvent, string typeEvent, string description, int time)
    {
        _nameEvent = nameEvent;
        _typeEvent = typeEvent;
        _description = description;
        _time = time;
    }

    public void DisplayEvent()
    {
        
        Console.WriteLine($"EVENT: {_nameEvent}");
        Console.WriteLine($"TYPE: {_typeEvent}");
        Console.WriteLine($"DESCRIPTION: {_description}");
        Console.WriteLine($"TIME: {_time} PM");
   
    }


}