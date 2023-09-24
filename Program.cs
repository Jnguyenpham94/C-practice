
using System;
class MyClass
{
    public static void Main(string[] args)
    {
        //Write a C# Sharp program that takes as many numbers as input to calculate and print the average.
        Console.WriteLine("Enter a string of numbers separated by commas for their average: ");

        string? input = Console.ReadLine();
        if (input == null)
        {
            Console.WriteLine("unexpected number. FAIL");
        }
        else
        {
            string[] subs = input.Split(",");

            List<int> result = new List<int>(Array.ConvertAll(subs, int.Parse));
            Console.WriteLine(result.Average());
            Console.WriteLine(result.Sum());
        }
    }
}

