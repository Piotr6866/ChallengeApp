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
            //Console.WriteLine(number + " - Invalid grade value");
            throw new Exception("Invalid grade value");
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

    public void AddGrade(char letter)
    {
        switch (letter)
        {
            case 'a':
            case 'A':
                this.Grades.Add(100);
                break;
            case 'b':
            case 'B':
                this.Grades.Add(80);
                break;
            case 'c':
            case 'C':
                this.Grades.Add(60);
                break;
            case 'd':
            case 'D':
                this.Grades.Add(40);
                break;
            case 'e':
            case 'E':
                this.Grades.Add(20);
                break;
            default:
                throw new Exception("Wrong letter");
                //this.Grades.Add(0);
                //break;
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

    public Statistics GetStatistics()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;
        var index = 0;

        foreach (var grade in this.Grades)
        {
            statistics.Average += grade;
            statistics.Max = Math.Max(statistics.Max, grade);
            statistics.Min = Math.Min(statistics.Min, grade);
        }

        statistics.Average /= this.Grades.Count;

        switch (statistics.Average)
        {
            //// UWAGA wartość z wykładu >=80 nie wydaje się logiczna, bo przy dwóch ocenach B (=80), średnia wychodziłaby A
            case var average when average >= 90:
                statistics.AverageLetter = 'A';
                break;
            case var average when average >= 70:
                statistics.AverageLetter = 'B';
                break;
            case var average when average >= 50:
                statistics.AverageLetter = 'C';
                break;
            case var average when average >= 30:
                statistics.AverageLetter = 'D';
                break;
            case var average when average >= 10:
                statistics.AverageLetter = 'E';
                break;
            default:
                statistics.AverageLetter = 'F';
                break;
        }
        return statistics;
    }
}

