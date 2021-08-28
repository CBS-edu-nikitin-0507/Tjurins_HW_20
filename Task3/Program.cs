using System;

namespace Task3
{
    public delegate int RandDelegate();
    public delegate decimal AverageDelegate(RandDelegate[] del);
    class Program
    {
        static void Main(string[] args)
        {
            RandDelegate rand = () => new Random().Next(0, 100);
            RandDelegate[] randArr = { rand, rand, rand };

            AverageDelegate avg = randDelegate =>
            {
                decimal result = 0;
                foreach (dynamic x in randDelegate)
                    result += x.Invoke();

                return result/randDelegate.Length;
            };

            decimal x = avg(randArr);
            Console.WriteLine(x);

        }

        
    }
}
