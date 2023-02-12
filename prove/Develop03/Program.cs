using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Scripture Memorizer");
        Console.WriteLine();

        
        Reference reference1 = new Reference("Eter", 12, 4);
        Scripture scripture1 = new Scripture("Wherefore, whoso believeth in God might with surety hope for a better world, yea, even a place at the right hand of God, which hope cometh of faith, maketh an anchor to the souls of men, which would make them sure and steadfast, always abounding in good works, being led to glorify God.");
        Word words = new Word("Wherefore, whoso believeth in God might with surety hope for a better world, yea, even a place at the right hand of God, which hope cometh of faith, maketh an anchor to the souls of men, which would make them sure and steadfast, always abounding in good works, being led to glorify God.", "___");
        
    

        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        string userInput = Console.ReadLine();


        do
        {
            userInput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(reference1.GetReferenceText1());
            Console.WriteLine(words.GetListText());
            Console.WriteLine(words.HideWord());
        }
            
        while (userInput != "quit");

    }
}

