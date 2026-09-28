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

        var p = students
            .OrderBy(s => s.Course)
            .ThenByDescending(s => s.Marks);

        var q = students
            .OrderBy(s => s.Course)
            .OrderByDescending(s => s.Marks);

        foreach (Student student in p)
        {
            Console.WriteLine(
                student.Name + " " +
                student.Marks + " " +
                student.Course
            );
        }

        Console.WriteLine();

        foreach (Student student in q)
        {
            Console.WriteLine(
                student.Name + " " +
                student.Marks + " " +
                student.Course
            );
        }
    }
}