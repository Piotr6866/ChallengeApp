using ChalengeApp;

Employee Employee1 = new Employee("Adam", "Nowak", 35);
Employee1.AddScore(3);
Employee1.AddScore(5);
Employee1.AddScore(7);
Employee1.AddScore(9);
Employee1.AddScore(10);

Employee Employee2 = new Employee("Wojciech", "Fibak", 58);
Employee2.AddScore(2);
Employee2.AddScore(7);
Employee2.AddScore(7);
Employee2.AddScore(8);
Employee2.AddScore(8);

Employee Employee3 = new Employee("Luke", "Skywalker", 20);
Employee3.AddScore(4);
Employee3.AddScore(5);
Employee3.AddScore(7);
Employee3.AddScore(10);
Employee3.AddScore(10);

List<Employee> Employees = new List<Employee>()
{
    Employee1,Employee2,Employee3
};

int maxResult = -1;
Employee EmployeeWithMaxResult = null;

foreach (var Employee in Employees)
{
    if (Employee.Result > maxResult)
    {
        EmployeeWithMaxResult = Employee;
        maxResult = Employee.Result;
    }
}

Console.WriteLine("Pracownik z najwyższym wynikiem: " + EmployeeWithMaxResult.Name + 
    " " + EmployeeWithMaxResult.LastName + ", lat: " + EmployeeWithMaxResult.Age);
Console.WriteLine("Wynik: " + EmployeeWithMaxResult.Result);