using System;
using System.Collections.Generic;

class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public int Salary { get; set; }

    public Employee(string name, string department, int salary)
    {
        Name = name;
        Department = department;
        Salary = salary;
    }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee("Amit", "IT", 100000),
            new Employee("Rahul", "IT", 95000),
            new Employee("Priya", "HR", 85000),
            new Employee("Sneha", "Sales", 70000),
            new Employee("Arjun", "Sales", 50000)
        };

        Dictionary<string, int> departmentSalary =
            new Dictionary<string, int>();

        foreach (Employee employee in employees)
        {
            if (departmentSalary.ContainsKey(employee.Department))
            {
                departmentSalary[employee.Department] += employee.Salary;
            }
            else
            {
                departmentSalary[employee.Department] = employee.Salary;
            }
        }

        string highestDepartment = "";
        int highestSalary = 0;

        foreach (var item in departmentSalary)
        {
            Console.WriteLine(item.Key + ": " + item.Value);

            if (item.Value > highestSalary)
            {
                highestSalary = item.Value;
                highestDepartment = item.Key;
            }
        }

        Console.WriteLine("Highest paying: " + highestDepartment);
    }
}