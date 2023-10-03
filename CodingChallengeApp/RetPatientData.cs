using System;
using System.IO;
using System.Reflection;

public class RetPatientData
{

    public string dataFile = @"C:\Users\mihail.lecari\source\repos\CodingChallengeApp\CodingChallengeApp\StaticData.txt";
    public string str;
    public string space = ".......................................................................";
    public string recordsList = "List of the objects in our Database:";
    public void Main2()
    {
            str = File.ReadAllText(dataFile);
            Console.WriteLine(recordsList);
            Console.WriteLine(space);
            Console.WriteLine(str);
    }
        
   
}
