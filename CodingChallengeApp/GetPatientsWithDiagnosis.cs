using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Markup;

public class GetPatientsWithDiagnosis
{
    RetPatientData diagnosis = new RetPatientData();
    public void Main5()
    {
        string fileContent = File.ReadAllText(diagnosis.dataFile);

        Console.WriteLine("Please enter the diagnose you are looking for:");
        string answer5 = Console.ReadLine();
        List<string> diseaseResults = new List<string>();
        string[] rows = fileContent.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string row in rows)
        {
            string[] rowValues = row.Split(",");
            
            if (rowValues.Length > 4 && rowValues[4].Contains(answer5, StringComparison.OrdinalIgnoreCase))
            {
                diseaseResults.Add(row);
            }
        }
        if (diseaseResults.Any())
        {
            Console.WriteLine("Patients with the specified diagnosis:");
            foreach (string result in diseaseResults)
            {
                Console.WriteLine(result);
            }
        }
        else
        {
            Console.WriteLine("No patients found with the specified diagnosis.");
        }

    }
}
    



