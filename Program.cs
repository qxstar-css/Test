using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 30;
            int b = 20;
            b = a;
            a = 10;
            Console.WriteLine(a);
            Console.WriteLine(a / b);
        }
    }
}
