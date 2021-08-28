using System;

namespace AdditionalTask
{
    public delegate decimal MyDelegate(int a, int b, int c);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate average = (a, b, c) => (a + b + c) / 3;
            Console.WriteLine($"Average: {average(5, 10, 15)}");
        }
    }
}
