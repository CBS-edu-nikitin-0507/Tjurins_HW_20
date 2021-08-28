using System;

namespace Task2
{
    public delegate decimal MyDelegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            decimal result;

            MyDelegate Add = (a,b) => a + b;
            MyDelegate Sub = (a, b) => a - b;
            MyDelegate Mul = (a, b) => a * b;
            MyDelegate Div = (a, b) => b == 0 ? b = 1 : a / b;

            a = SetNumbers();
            b = SetNumbers();

            result = ChooseOperation() switch
            {
                "+" => Add(a, b),
                "-" => Sub(a, b),
                "*" => Mul(a, b),
                "/" => Div(a, b),
                _ => throw new NotImplementedException(),
            };

            Console.WriteLine(result);
        }

        public static string ChooseOperation()
        {
            Console.WriteLine("Enter operation +, -, *, / :");
            return Console.ReadLine();
        }

        public static int SetNumbers()
        {
            Console.WriteLine("Enter operand:");
            return int.Parse(Console.ReadLine());
        }

    }
}
