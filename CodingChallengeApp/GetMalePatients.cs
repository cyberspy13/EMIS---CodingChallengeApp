using System;
using System.IO;
using System.Reflection;
public class GetMalePatients
{
	RetPatientData malePatients = new RetPatientData();
	public void Main4()
	{
        string fileContent = File.ReadAllText(malePatients.dataFile);

        string[] rows = fileContent.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

        int rowCount = rows.Length;

        List <string> maleResults = new List<string>();

        foreach (string row in rows)
        {
            string[] rowValues = row.Split(",");

            if (rowValues.Length > 3 && rowValues[3].Trim().Equals("Male", StringComparison.OrdinalIgnoreCase))

            {
                maleResults.Add(row);
            }
        }
        Console.WriteLine("Male records are:");
        foreach (string maleResult in maleResults)
        {
            Console.WriteLine(maleResult);
        }


    }
}
