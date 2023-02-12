using System.Collections.Generic;
class Scripture
{
    private string _text;
    private string _text2;

    public Scripture(string text)
    {
        _text = text;

    }

    public string GetDisplayText()
    {
        _text2 = $"{_text}";
        return _text2;
    }

    public bool isCompletelyHidden()
    {
        //figure out if all the words are hidden, if so, return true, if not return false.

        return false;
    }

}