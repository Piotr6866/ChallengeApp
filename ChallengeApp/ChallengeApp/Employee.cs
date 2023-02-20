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
        this.Grades.Add(number);
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

