
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
            Console.WriteLine("3. Reverse word order");
            Console.WriteLine("4. Reverse word order with join");
            Console.WriteLine("5. Palindrome");
            Console.WriteLine("6. Substring in String");
            Console.WriteLine("7. Is Prime");
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
                case "4":
                    {
                        ReverseWordOrderJoin();
                        break;
                    }
                case "5":
                    {
                        IsPalindrome();
                        break;
                    }
                case "6":
                    {
                        Console.WriteLine(SubstringInString());
                        break;
                    }
                case "7":
                    {
                        Console.WriteLine(IsPrime());
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
        if (input != null)
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
        if (input != null)
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
            Console.WriteLine($"Reverse with method : {new string(chars)}");
        }
    }

    public static void ReverseWordOrder()
    {
        Console.Write("Enter a sentence to reverse: ");
        string? input = Console.ReadLine();
        if (input != null)
        {
            string[] subs = input.Split();
            string result = "";
            for (int i = subs.Length - (1); i >= 0; i--)
            {
                result += subs[i] + " ";
            }
            Console.WriteLine(result);
        }
    }

    public static void ReverseWordOrderJoin()
    {
        Console.Write("Enter a sentence to reverse: ");
        string? input = Console.ReadLine();
        if (input != null)
        {
            string[] subs = input.Split();
            Array.Reverse(subs);
            string result = String.Join(" ", subs);
            Console.WriteLine(result);
        }
    }

    public static void IsPalindrome()
    {
        Console.Write("Enter a word to check if it is a palindrome: ");
        string? input = Console.ReadLine();
        if (input != null)
        {
            //for loop method
            string reverse = "";
            for (int i = input.Length - (1); i >= 0; i--)
            {
                reverse += input[i];
            }
            if (input == reverse)
            {
                Console.WriteLine($"{input} is a palindrome!");
            }
            else
            {
                Console.WriteLine($"{input} is NOT a palindrome!");
            }
        }
    }

    public static string SubstringInString()
    {
        Console.WriteLine("Enter a string: ");
        string? input = Console.ReadLine();
        Console.WriteLine("Enter the string to find: ");
        string? find = Console.ReadLine();
        if (input != null && find != null)
        {
            bool b = input.Contains(find);
            return b ? $"'{find}' is in the string '{input}': {b}" : $"'{find}' is not the string '{input}': {b}";
        }
        return "value was null";
    }

    public static bool IsPrime()
    {
        Console.WriteLine("Enter a positive value: ");
        string? input = Console.ReadLine();
        if (input != null)
        {
            int value = Convert.ToInt32(input);
            if (value == 1) return false;
            if (value == 2) return true;
            if (value % 2 == 0) return false;
            var squareRoot = (int)Math.Floor(Math.Sqrt(value));
            for (int i = 3; i <= squareRoot; i += 2)
            {
                if (value % i == 0) return false;
            }
            return true;
        }
        return false;
    }
}

