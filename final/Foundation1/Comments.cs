using System;
using System.Collections.Generic;

class Comments
{
 private List<string> _listComments = new List<string>
    {
        "Draxtor: Thank you Ruri! I am a fast obsessive reader who tries to convince people to read DEEPER and SLOWER.", 
        "Konstantinos Kyfonidis: Good luck to everyone else who is taking an exam or has an exam coming up around this time! Happy studying!",
        "Ali Khudayar: You are amazing Ruri"
    };

    public void DisplayComments()
    {
        foreach(string comment in _listComments)
        {   
            Console.WriteLine($"{comment}");
        }
    }

    private List<string> _listComments2 = new List<string>
    {
        "Pegasus: 'The Expectation Effect' is one of my favorites! Teaches us that our mind CONTROLS reality! Fascinating concept check it out :)",
        "Rodney Cuthbertson: 'So Good They Can't Ignore You: Why Skills Trump Passion in the Quest for Work You Love' by Cal Newport. Had a big impact on me when I was going through one of my first career changes.",
        "Patty Clark: 'Seven Habits of Highly Effective People' - hands down. I'm 62. I read it in my 20's, and again every 10 years or so. It had a profound impact on my work life, but also helped me keep myself headed in my own direction."
    };

    public void DisplayComments2()
    {
        foreach(string comment in _listComments2)
        {   
            Console.WriteLine($"{comment}");
        }
    }

    private List<string> _listComments3 = new List<string>
    {
        "Alexis M: Your content is so good and your videos are so professional.",
        "Laura Overstreet: I have done folders for a while now, but this is leveling up in a big way.  Thank you!",
        "Tathiane Acioli: Amazing content! Love your channel, so truthful!"
    };

    public void DisplayComments3()
    {
        foreach(string comment in _listComments3)
        {   
            Console.WriteLine($"{comment}");
        }
    }
}