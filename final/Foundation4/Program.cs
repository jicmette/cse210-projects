using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("EXERCISE TRACKING");
        Console.WriteLine("SUMMARY");

        List<Activity> _activities = new List<Activity>();

        Running _ra = new Running("30 March 2023", "Running", 30.00, 4.8);
        _activities.Add(_ra);

        Cycling _ca = new Cycling("04 April 2023", "Cycling", 60.00, 25.60);
        _activities.Add(_ca);

        Swimming _sa = new Swimming("23 March 2023", "Swimming", 20.50, 5);
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

