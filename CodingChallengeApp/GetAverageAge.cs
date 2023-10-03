using System;
using System.IO;
using System.Reflection;

public class GetAverageAge
{
    RetPatientData aveAge = new RetPatientData();
    
    

    public void Main3()
    {
        string fileContent = File.ReadAllText(aveAge.dataFile);
 
        string[] rows = fileContent.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

        int rowCount = rows.Length;
        double sum = 0;

        foreach (string row in rows)
        {
            string[] rowValues = row.Split(",");

            if (rowValues.Length > 2) 
            
            {
                if (double.TryParse(rowValues[2], out double value))
                {
                    sum += value;
                }
            }
        }
        double average = sum / rowCount;

        Console.WriteLine("The average patients age is: " + average);



    }
    


}
