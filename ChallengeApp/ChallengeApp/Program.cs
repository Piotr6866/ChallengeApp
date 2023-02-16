using ChallengeApp; 


Employee employee1 = new Employee("Adam", "Nowak", 35);
employee1.AddScore(3);
employee1.AddScore(5);
employee1.AddScore(7);
employee1.AddScore(9);
employee1.AddScore(10);

Employee employee2 = new Employee("Wojciech", "Fibak", 58);
employee2.AddScore(2);
employee2.AddScore(7);
employee2.AddScore(7);
employee2.AddScore(8);
employee2.AddScore(8);

Employee employee3 = new Employee("Luke", "Skywalker", 20);
employee3.AddScore(4);
employee3.AddScore(5);
employee3.AddScore(7);
employee3.AddScore(10);
employee3.AddScore(10);

List<Employee> Employees = new List<Employee>()
{
    employee1,employee2,employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in Employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}

Console.WriteLine("Pracownik z najwyższym wynikiem: " + employeeWithMaxResult.Name +
    " " + employeeWithMaxResult.LastName + ", lat: " + employeeWithMaxResult.Age);
Console.WriteLine("Wynik: " + employeeWithMaxResult.Result);