using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Administrative Assitant";
        job1._company = "Blag Media";
        job1._startYear = 2018;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Information Technology Technical Support";
        job2._company = "Nexbitek IT Services";
        job2._startYear = 2021;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Israel Carmona";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayJobDetails();
    }




}