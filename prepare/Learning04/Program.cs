using System;

class Program
{
    static void Main(string[] args)
    {
        
        Assignment assignmentDefault = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignmentDefault.GetSummary());

        MathAssignment mathAssign1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssign1.GetSummary());
        Console.WriteLine(mathAssign1.GetHomeworkList());

        WritingAssignment writing1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());

        
    }
}