using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<string> amitSkills = new HashSet<string>
        {
            "C#", "SQL", "Python"
        };

        HashSet<string> rahulSkills = new HashSet<string>
        {
            "C#", "SQL", "React", "Azure"
        };

        HashSet<string> shared = new HashSet<string>(amitSkills);
        shared.IntersectWith(rahulSkills);

        HashSet<string> onlyAmit = new HashSet<string>(amitSkills);
        onlyAmit.ExceptWith(rahulSkills);

        HashSet<string> allSkills = new HashSet<string>(amitSkills);
        allSkills.UnionWith(rahulSkills);

        Console.WriteLine("Shared: " + string.Join(", ", shared));
        Console.WriteLine("Only Amit: " + string.Join(", ", onlyAmit));
        Console.WriteLine("All skills: " + string.Join(", ", allSkills));
    }
}