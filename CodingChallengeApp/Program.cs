using System;
using System.IO;
using System.Reflection;

public class Program
{
    public static string bye = "Good bye";
    public static void Main(string[] args)
    {
        Console.WriteLine("Do you want to see all Patients list?");
        string answer = Console.ReadLine();
        Console.Clear();

        RetPatientData rp = new RetPatientData();

        //if (answer.ToLower() == "yes")
        if (IsYes(answer))
        {
            rp.Main2();
        }
        else
        {
            Console.WriteLine(bye);
        }

        Console.WriteLine("Do you want to get average age of all patients in our database?");
        string answer2 = Console.ReadLine();
        Console.Clear();
        GetAverageAge ga = new GetAverageAge();
        if (answer2.ToLower() == "yes")
        {
            ga.Main3();
        }
        else
        {
            Console.WriteLine(bye);
        }

        Console.WriteLine("Do you want to get only a male customers?");
        string answer3 = Console.ReadLine();
        Console.Clear();

        GetMalePatients mp = new GetMalePatients();

        if (answer3.ToLower() == "yes")
        {
            mp.Main4();
        }
        else
        {
            Console.WriteLine(bye);
        }

        Console.WriteLine("Do you want to get only a customer disease?");
        string answer4 = Console.ReadLine();
        Console.Clear();

        GetPatientsWithDiagnosis pd = new GetPatientsWithDiagnosis();

        if (answer4.ToLower() == "yes")
        {
            pd.Main5();
        }
        else
        {
            Console.WriteLine(bye);
        }

        Console.WriteLine("Do you want to get a customer with min/max age?");
        string answer5 = Console.ReadLine();
        Console.Clear();

        GetPatientsByAgeRange minMaxAge = new GetPatientsByAgeRange();

        if (answer5.ToLower() == "yes")
        {
            minMaxAge.Main6();
        }
        else
        {
            Console.WriteLine(bye);
        }
    }

    
        public static bool IsYes(string answer)
        {
            return answer != null && answer.Trim().ToLower() == "yes";
        }





















    

}






