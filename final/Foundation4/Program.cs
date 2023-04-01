using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("EXERCISE TRACKING");
        Console.WriteLine("SUMMARY");

        List<Activity> _activities = new List<Activity>();

        Running _ra = new Running("26 January 2018", "Running", 30.00, 4.8);
        _activities.Add(_ra);

        Cycling _ca = new Cycling("03 November 1991", "Cycling", 4.90, 90.50);
        _activities.Add(_ca);

        Swimming _sa = new Swimming("23 March 2023", "Swimming", 14.22, 5);
        _activities.Add(_sa);

        Console.WriteLine();

        foreach (Activity a in _activities)
        {
            string _na = a.GetNameActivity();
            Console.WriteLine(_na.ToUpper());
            double distance = a.GetDistance();
            double speed = a.GetSpeed();
            double pace = a.GetPace();
            Console.WriteLine($"{a.GetDate()} - {a.GetNameActivity()} ({a.GetTime()} min) - Distance: {a.GetDistance()} km - Speed: {a.GetSpeed()} kph - Pace: {a.GetPace()} min per km");
            Console.WriteLine();
        }
    }
}

