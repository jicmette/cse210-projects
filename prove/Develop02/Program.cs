using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)

    {
        Menu menu = new Menu();
        menu.DisplayMenu();

        Entry entries = new Entry();
        entries.EntryCWR();
    }
}


