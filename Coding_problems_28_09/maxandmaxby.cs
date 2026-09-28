using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
    public string Course { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Amit", Marks = 78, Course = "CSE" },
            new Student { Name = "Priya", Marks = 92, Course = "CSE" },
            new Student { Name = "Rahul", Marks = 65, Course = "ECE" },
            new Student { Name = "Meera", Marks = 88, Course = "ECE" }
        };

        var a = students.Where(s => s.Marks >= 75).Select(s => s.Name);
        var b = students.Count(s => s.Course == "CSE");
        var c = students.Average(s => s.Marks);

        Console.WriteLine(string.Join(", ", a));
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}