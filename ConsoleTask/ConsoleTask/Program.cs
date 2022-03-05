using System;

namespace ConsoleTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int cem = 0;
                Console.Write("Eded 1 : ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Eded 2 : ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                for (int i = num1; i <= num2; i++)
                {
                    if (i % 3 == 0)
                    {
                        cem += i;
                    }
                }
                Console.WriteLine("Ededlerin Cemi " + cem);
            }
            Console.ReadKey();
        }

    }
}
