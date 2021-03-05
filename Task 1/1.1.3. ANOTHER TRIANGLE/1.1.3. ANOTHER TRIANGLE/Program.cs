using System;

namespace _1._1._3._ANOTHER_TRIANGLE
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    for (int k = a; k > j; k--)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k <= j * 2; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }


        }
    }
}

