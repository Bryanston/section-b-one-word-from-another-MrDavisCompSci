// Console template
using System;
class Program
{
    static void Main()
    {
        Console.Clear();

        Console.Write("Enter first word: ");
        string first = Console.ReadLine();
        Console.Write("Enter second word: ");
        string second = Console.ReadLine();

        bool canBeDone = true;

        List<char> secondList = new List<char> ();
        foreach(char c in second)
        {
            secondList.Add(c);
        }

        foreach(char c in first)
        {
            if (secondList.Contains(c))
            {
                secondList.Remove(c);
            }
            else
            {
                canBeDone = false;
            }
        }

        if(canBeDone)
        {
            Console.WriteLine($"{first} can be made from {second}");
        }
        else
        {
            Console.WriteLine($"{first} cannot be made from {second}");
        }
    }
}
