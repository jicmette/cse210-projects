using System.Collections.Generic;

class Word
{
    Random random = new Random();
    private string _content;

    private string _underscore;


    public Word(string content, string underscore)
    {
        _content = content;
        _underscore = underscore;
    }


    public string GetListText()
    {
        List<string> wordList = new List<string>();
        wordList = _content.Split(null).ToList();
        string content2 = String.Join(" ", wordList);
        return content2;

    }

    public string HideWord()
    {
        string underscore = "____";
        int index = random.Next(0, 54);
        
        return underscore;

    }

}