using System;
using System.IO;
using System.Text;

class Entry
{

    public void EntryCWR()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        string path = @"C:\Users\jicmS\OneDrive - BYU-Idaho\Israel\BYU-I\8th Semester\CSE210 Programming with Classes\cse210-projects\prove\Develop02\journal.txt";
        using (StreamWriter file1 = File.CreateText(path));
        
        string appendText = $"Date {theCurrentTime}" + Environment.NewLine;
        File.AppendAllText(path, appendText);

        // Open the file to read from.
        string readText = File.ReadAllText(path);
        Console.WriteLine(readText);




    }




}