using System.Diagnostics;

namespace ChallengeApp;

public class Employee
{
    public string Name { get; private set; }
    public string Surname { get; private set; }
    private List<float> Grades = new List<float>();

    public Employee(string name, string surname)
    {
        this.Name = name;
        this.Surname = surname;
    }
    public void AddGrade(float number)
    {
        if (number >= 0 && number <= 100)
        {
            this.Grades.Add(number);
        }
        else
        {
            Console.WriteLine(number + " - Invalid grade value");
        }
    }

    public void AddGrade(string grade)
    {
        if (float.TryParse(grade, out float result))
        {
            this.AddGrade(result);
        }
        else
        {
            Console.WriteLine(grade + " - String is not float");
        }
    }
   
    public void AddGrade(double grade)
    {
        float valueInFloat = (float)grade;
        this.AddGrade(valueInFloat);
    }

    public float Result
    {
        get
        {
            return this.Grades.Sum();
        }
    }

    public Statistics GetStatistics()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;

        foreach (var grade in this.Grades)
        {
            statistics.Average += grade;
            statistics.Max = Math.Max(statistics.Max, grade);
            statistics.Min = Math.Min(statistics.Min, grade);
        }

        statistics.Average /= this.Grades.Count;
        return statistics;
    }
}

