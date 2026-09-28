using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3 };

        var query = numbers.Where(n => n > 1);

        numbers.Add(4);

        Console.WriteLine(string.Join(" ", query));
    }
}