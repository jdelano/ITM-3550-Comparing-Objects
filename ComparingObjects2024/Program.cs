namespace ComparingObjects2024;

class Program
{
    static void Main(string[] args)
    {
        int x = 5;
        int y = 5;
        if (x == y)
        {
            Console.WriteLine("x and y are equal.");
        }

        string s1 = "hello";
        string s2 = "hello";
        if (s1 == s2)
        {
            Console.WriteLine("s1 is equal to s2.");
        }

        Person p1 = new Person { Name = "John", Age = 30 };
        Person p2 = new Person { Name = "John", Age = 30 };
        if (p1 == p2) //(p1.Equals(s1))
        {
            Console.WriteLine("Person objects are EQUAL.");
        }
        else
        {
            Console.WriteLine("Person objects are DIFFERENT!");
        }
    }
}

