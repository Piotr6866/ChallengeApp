using ChallengeApp;
using System.Diagnostics;

Console.WriteLine("Witamy w Programie autorstwa Piotra do oceny Pracowników");
Console.WriteLine("========================================================");
Console.WriteLine();

var employee = new Employee("Gall", "Anonim");
while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input.Length == 1)
    {
        if (input == "q")
        {
            break;
        }
        ///char valueInChar = input[0];
        /// string jest tablicą elementów char
        
        ///employee.AddGrade(input[0]);
        try
        {
            employee.AddGrade(input[0]);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }
    }
    else
    {
        ///employee.AddGrade(input);
        try
        {
            employee.AddGrade(input);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }
    }

}

var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");


Console.WriteLine();
