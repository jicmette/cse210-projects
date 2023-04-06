using System;
using System.Collections.Generic;
using System.IO;

public abstract class Goals
{
    protected string _name;
    protected string _description;
    protected int _points;
    public Goals(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract string GetName();

    public abstract string GetDescription();
    public abstract string GetPoints();

    

}






