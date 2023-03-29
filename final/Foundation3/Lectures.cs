using System;

public class Lectures : Event
{
    private string _speaker;
    private int _capacity;

    public Lectures(string nameEvent, string typeEvent, string description, int time, string speaker, int capacity) : base(nameEvent, typeEvent, description, time)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetSpeaker()
    {
        return $"SPEAKER: {_speaker}";
    }

    public int GetCapacity()
    {
        return _capacity;
    }

}

