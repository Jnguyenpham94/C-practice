﻿
//class Group
//{
//    private string name;

//    public Group(string name)
//    {
//        this.name = name;
//    }

//}

//class Contact
//{
//    private string name { get; set; }
//    private string phonenumber { get; set; }
//    Group Group { get; set; }


//    public Contact(string name, string phonenumber, Group group)
//    {
//        this.name = name;
//        this.phonenumber = phonenumber;
//        this.Group = group;
//    }

//}

////(Max, 99999999)
////Toshiba:
////(Jeff, 111111)
////   Support:
////(Lam, 2222)
////In law:
////	(Dad, 333)

//m

//Contact max = new("Max", "99999999", new Group("no group"));
//Contact jeff = new("Jeff", "111111", new Group("Toshiba"));
//Contact lam = new("Lam", "222", new Group("Toshiba"));
//Contact dad = new("Dad", "333", new Group("Toshiba"

//7!=5040

class MainClass
{
    public static void Main(string[] args)
    {
        factorial(25);

        Console.WriteLine("Interface stuff below\n");
        MyClass stuff = new MyClass();
        Console.WriteLine(@"adding 10+5: {0}
subtracting 10-5 : {1}
multiplying 10*5: {2}
dividing 10/5: {3}", stuff.add(10, 5), stuff.subtract(10, 5), stuff.multiply(10, 5), stuff.divide(10, 5));

        Middle mid = new Middle();
        
        Console.WriteLine(mid.P());

        Point point = new Point(10, 5);
        Console.WriteLine(point.Distance);

    }

    interface IPoint
    {
        // Property signatures:
        int X { get; set; }

        int Y { get; set; }

        double Distance { get; }
    }

    class Point : IPoint
    {
        // Constructor:
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Property implementation:
        public int X { get; set; }

        public int Y { get; set; }

        // Property implementation
        public double Distance =>
           Math.Sqrt(X * X + Y * Y);
    }

    interface ILeft
    {
        int P { get; }
    }
    interface IRight
    {
        int P();
    }

    class Middle : ILeft, IRight
    {
        public int P() { return 0; }
        int ILeft.P { get { return 0; } }
    }

    static void factorial(int number)
    {
        int value = 1;
        for (int i = 1; i <= number; i++)
        {
            value *= i;
        }
        Console.WriteLine(value);
        string result = Convert.ToString(value);
        char[] answer = result.ToCharArray();
        int count = 0;
        for (int i = answer.Length; i-- > 0;)
        {
            if (answer[i].Equals('0'))
            {
                count++;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(count);

    }

    interface MyInterface
    {
        int add(int val, int val2);
        int subtract(int val, int val2);

        int multiply(int val, int val2);

        int divide(int val, int val2);
    }

    //implementing class must match the method signatures of the interface!!
    class MyClass : MyInterface
    {
        public int add(int value1, int value2)
        {
            return value1 + value2;
        }

        public int subtract(int value1, int value2)
        {
            return value1 - value2;
        }

        public int multiply(int value1, int value2)
        {
            return value1 * value2;
        }

        public int divide(int value1, int value2)
        {
            return value1 / value2;
        }
    }
}

