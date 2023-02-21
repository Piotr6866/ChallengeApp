using ChallengeApp; 

Employee employee1 = new Employee("Adam", "Nowak");
employee1.AddGrade("Piotr");
employee1.AddGrade("444");
employee1.AddGrade(7);
employee1.AddGrade(9);
employee1.AddGrade(10);

///Console.WriteLine(long.MaxValue + " ");
employee1.AddGrade(long.MaxValue);
///Console.WriteLine(double.MaxValue+" ");
employee1.AddGrade(double.MaxValue);
var statistics1=employee1.GetStatistics();

Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
