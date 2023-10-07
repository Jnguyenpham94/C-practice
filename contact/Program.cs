
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

factorial(25);
MyClass stuff = new MyClass();
Console.WriteLine(@"adding 10+5: {0}
subtracting 10-5 : {1}
multiplying 10*5: {2}
dividing 10/5: {3}", stuff.add(10, 5), stuff.subtract(10, 5), stuff.multiply(10,5), stuff.divide(10,5));


void factorial(int number)
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
        return value1/value2;
    }
}

