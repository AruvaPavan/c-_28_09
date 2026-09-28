using System;
using System.Collections.Generic;

class Program
{
    static bool IsBalanced(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char ch in input)
        {
            if (ch == '(' || ch == '{' || ch == '[')
            {
                stack.Push(ch);
            }
            else if (ch == ')' || ch == '}' || ch == ']')
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                char top = stack.Pop();

                if (ch == ')' && top != '(')
                {
                    return false;
                }

                if (ch == '}' && top != '{')
                {
                    return false;
                }

                if (ch == ']' && top != '[')
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }

    static void Main()
    {
        string[] inputs =
        {
            "{[()]}",
            "{[(])}",
            "(("
        };

        foreach (string input in inputs)
        {
            if (IsBalanced(input))
            {
                Console.WriteLine(input + " -> balanced");
            }
            else
            {
                Console.WriteLine(input + " -> not balanced");
            }
        }
    }
}