using System;

public class GetPatientsByAgeRange
{
    RetPatientData diagnosis = new RetPatientData();

    public void Main6()
	{
        string fileContent = File.ReadAllText(diagnosis.dataFile);
        List<string> diseaseResultsMinAgePatient = new List<string>();
        List<string> diseaseResultsMaxAgePatient = new List<string>();
        List<string> diseaseResultsAveAgePatient = new List<string>();
        string[] rows = fileContent.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string row in rows)
        {
            string[] rowValues = row.Split(',');

            if (rowValues.Length > 2)
            {
                if (int.TryParse(rowValues[2], out int age))
                {
                    if (age <= 21)
                    {
                        diseaseResultsMinAgePatient.Add(row);
                    }
                    else if (age >= 21 && age <= 70)
                    {
                        diseaseResultsAveAgePatient.Add(row);
                    }
                    else if (age >= 70)
                    {
                        diseaseResultsMaxAgePatient.Add(row);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid age for the patient");
                }
            }
        }

        Console.WriteLine("Please enter the  age of the patient");
        string stringAnswer = Console.ReadLine();

        if (int.TryParse(stringAnswer, out int intAnswer))
        {
            if (intAnswer <= 21)
            {
                Console.WriteLine("Patients in the Min age range:");
                foreach (string result in diseaseResultsMinAgePatient)
                {
                    Console.WriteLine(result);
                }
            }
            else if (intAnswer >= 70)
            {
                Console.WriteLine("Patients in the Max age range:");
                foreach (string result in diseaseResultsMaxAgePatient)
                {
                    Console.WriteLine(result);
                }
            }
            else if (intAnswer >= 21 && intAnswer <= 70)
            {
                Console.WriteLine("Patients in the Average age range:");
                foreach (string result in diseaseResultsAveAgePatient)
                {
                    Console.WriteLine(result);
                }
            }
            else
            {
                Console.WriteLine("the age you have entered is invalid");
            }

        }

        else
        {
            Console.WriteLine("Invalid age input.");
        }





        }
}
