using System;

class Video 
{
    private string _name;
    private string _author;
    private double _length;

    public Video(string name, string author, double length)
    {
        _name = name;
        _author = author;
        _length = length;
    }

    public string DisplayVideo()
    {
        return $"NAME: {_name} AUTHOR: {_author} LENGTH: {_length} mins";
    }


}