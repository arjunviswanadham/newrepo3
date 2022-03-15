using System;

namespace Iterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number");
            n=Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine("{0} x {1}= {2}", n, i, n * i);
            }

        }
    }
}