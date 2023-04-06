// using System;

// public class FileManage : Goals
// {
//     public FileManage(string name, string description, int points) : base(name, description, points)
//     {

//     }

//     public override string GetName()
//     {
//         return "hola";
//     }

//     public override string GetDescription()
//     {
//         return "hola 2";
//     }

//     public override string GetPoints()
//     {
//         return "hola 3";
//     }

//     string fileName = "EternalQuest.txt";
//     public void FileWriter()
//     {

//         using (StreamWriter outputFile = new StreamWriter(fileName))
//         {

//             foreach (Goals g in _goals)
//             {
//                 outputFile.WriteLine($"{_goals}");


//             }

//             outputFile.Close();

//         }

//     }

//     public void FileReader()
//     {
//         _listGoals = File.ReadAllLines(fileName).ToList();
//         using (StreamWriter outputFile = new StreamWriter(fileName))
//         {

//             foreach (string goal in _listGoals)
//             {
//                 Console.WriteLine($"{goal}");

//             }

//             outputFile.Close();

//         }
//     }
// }