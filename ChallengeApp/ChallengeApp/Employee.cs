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
        var index = 0;
        //do
        // {
        //     statistics.Average += this.Grades[index];
        //     statistics.Max = Math.Max(statistics.Max, this.Grades[index]);
        //     statistics.Min = Math.Min(statistics.Min, this.Grades[index]);
        //     index++;
        // } while (index < this.Grades.Count);

        foreach (var grade in this.Grades)
        {
            statistics.Average += grade;
            statistics.Max = Math.Max(statistics.Max, grade);
            statistics.Min = Math.Min(statistics.Min, grade);
        }

        statistics.Average /= this.Grades.Count;
        return statistics;
    }
    public Statistics GetStatisticsWithForEach()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;

        foreach (var grade in this.Grades)
        {
            statistics.Max = Math.Max(statistics.Max, grade);
            statistics.Min = Math.Min(statistics.Min, grade);
            statistics.Average += grade;
        }

        statistics.Average /= this.Grades.Count;
        return statistics;
    }

    public Statistics GetStatisticsWithFor()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;

        for (var index = 0; index < this.Grades.Count; index++)
        {
            statistics.Max = Math.Max(statistics.Max, this.Grades[index]);
            statistics.Min = Math.Min(statistics.Min, this.Grades[index]);
            statistics.Average += this.Grades[index];
        }

        statistics.Average /= this.Grades.Count;
        return statistics;
    }

    public Statistics GetStatisticsWithWhile()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;
        var index = 0;

        while (index < this.Grades.Count)
        {
            statistics.Max = Math.Max(statistics.Max, this.Grades[index]);
            statistics.Min = Math.Min(statistics.Min, this.Grades[index]);
            statistics.Average += this.Grades[index];
            index++;
        }

        statistics.Average /= this.Grades.Count;
        return statistics;
    }

    public Statistics GetStatisticsWithDoWhile()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;

        var index = 0;

        do
        {
            statistics.Max = Math.Max(statistics.Max, this.Grades[index]);
            statistics.Min = Math.Min(statistics.Min, this.Grades[index]);
            statistics.Average += this.Grades[index];
            index++;
        } while (index < this.Grades.Count);

        statistics.Average /= this.Grades.Count;
        return statistics;

    }
}

