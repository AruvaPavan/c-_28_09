using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> logs = new List<int>
        {
            101, 102, 103, 101, 104, 105, 102, 103
        };

        HashSet<int> visitors = new HashSet<int>();

        foreach (int userId in logs)
        {
            visitors.Add(userId);
        }

        int repeatEntries = logs.Count - visitors.Count;

        Console.WriteLine("Log entries: " + logs.Count);
        Console.WriteLine("Unique visitors: " + visitors.Count);
        Console.WriteLine("Repeat entries: " + repeatEntries);
    }
}