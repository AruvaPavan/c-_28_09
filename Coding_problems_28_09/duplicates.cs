using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>
        {
            3, 7, 3, 9, 7, 1, 3
        };

        Dictionary<int, int> count = new Dictionary<int, int>();

        Console.Write("Numbers: ");

        foreach (int number in numbers)
        {
            Console.Write(number + " ");

            if (count.ContainsKey(number))
            {
                count[number]++;
            }
            else
            {
                count[number] = 1;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Duplicates:");

        foreach (var item in count)
        {
            if (item.Value > 1)
            {
                Console.WriteLine(
                    item.Key + " appears " + item.Value + " times"
                );
            }
        }
    }
}