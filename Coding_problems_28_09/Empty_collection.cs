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
        List<Student> empty = new List<Student>();

        try
        {
            var a = empty.First();
            Console.WriteLine(a);
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("First(): Exception");
        }

        var b = empty.FirstOrDefault();
        Console.WriteLine(
            b == null ? "FirstOrDefault(): null" : b.Name
        );

        try
        {
            var c = empty.Average(s => s.Marks);
            Console.WriteLine(c);
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("Average(): Exception");
        }

        var d = empty.Sum(s => s.Marks);
        Console.WriteLine("Sum(): " + d);

        var e = empty.All(s => s.Marks > 1000);
        Console.WriteLine("All(): " + e);
    }
}