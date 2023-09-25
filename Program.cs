
using System;
class MyClass
{


    public static void Main(string[] args)
    {
        bool go = true;

        do
        {
            //menu options
            Console.WriteLine("1. Average");
            Console.WriteLine("2. Reverse String");
            Console.WriteLine("2. Reverse word order");
            Console.WriteLine("exit");
            string? input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("unexpected number. FAIL");
            }
            switch (input)
            {
                case "1":
                    {
                        Avg();
                        break;
                    }
                case "2":
                    {
                        ReverseString();
                        break;
                    }
                case "3":
                    {
                        ReverseWordOrder();
                        break;
                    }
                case "exit":
                    {
                        go = false;
                        break;
                    }
                default:
                    break;
            }

        } while (go);
        
    }

    public static void Avg()
    {
        //Write a C# Sharp program that takes as many numbers as input to calculate and print the average.
        Console.WriteLine("Enter a string of numbers separated by commas for their average: ");
        List<int> result = new List<int>();
        string? input = Console.ReadLine();
        if (input == null)
        {
            Console.WriteLine("unexpected number. FAIL");
        }
        else
        {
            string[] subs = input.Split(",");

            result = new List<int>(Array.ConvertAll(subs, int.Parse));
            Console.WriteLine(result.Average());
            Console.WriteLine(result.Sum());
        }
    }

    public static void ReverseString()
    {
        Console.Write("Enter a string to reverse: ");
        string? input = Console.ReadLine();
        if (input == null)
        {
            Console.WriteLine("unexpected number. FAIL");
        }
        else
        {
            //for loop method
            string reverse = "";
            for (int i = input.Length - (1); i >= 0; i--)
            {
                reverse += input[i];
            }
            Console.WriteLine($"Reverse using for loop: {reverse}");
            //using built-in System.Array.Reverse
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine($"Reverse with method : {new string (chars)}");    
        }
    }

    public static void ReverseWordOrder()
    {
        Console.Write("Enter a sentence to reverse: ");
        string? input = Console.ReadLine();
        if (input == null)
        {
            Console.WriteLine("unexpected number. FAIL");
        }
        else
        {

        }

    }
}

