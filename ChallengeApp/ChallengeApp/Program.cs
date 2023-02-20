using ChallengeApp; 

Employee employee1 = new Employee("Adam", "Nowak");
employee1.AddGrade(3);
employee1.AddGrade(5);
employee1.AddGrade(7);
employee1.AddGrade(9);
employee1.AddGrade(10);
var statistics1=employee1.GetStatistics();

Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
