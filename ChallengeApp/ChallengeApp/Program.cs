using ChallengeApp;

Employee employee = new Employee("Adam", "Nowak");
employee.AddGrade("Piotr");
employee.AddGrade("444");
employee.AddGrade(4f);
employee.AddGrade(7.5);
employee.AddGrade(9);
employee.AddGrade(10);

///Console.WriteLine(long.MaxValue + " ");
employee.AddGrade(long.MaxValue);
///Console.WriteLine(double.MaxValue+" ");
employee.AddGrade(double.MaxValue);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine();

var statistics1 = employee.GetStatisticsWithForEach();
Console.WriteLine("Statistics for loop foreach:");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine();

var statistics2 = employee.GetStatisticsWithFor();
Console.WriteLine("Statistics for loop for:");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine();

var statistics3 = employee.GetStatisticsWithWhile();
Console.WriteLine("Statistics for loop While:");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine();

var statistics4 = employee.GetStatisticsWithDoWhile();
Console.WriteLine("Statistics for loop DoWhile:");
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");