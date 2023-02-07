using System;
using System.IO;
using System.Text;
using System.Collections.Generic;


public class Files
{



    public void FileCreation()
    {

        Prompt entriesUser = new Prompt();

        

        string fileName = "journal.txt.";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {

            foreach (string entry in entriesUser.entries)
            {
                outputFile.WriteLine($"{entry} - SAVED");
            
            }


        }
    }



}