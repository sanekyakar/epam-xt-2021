using System;

namespace _1._1._2._TRIANGLE
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = Convert.ToInt32(Console.ReadLine());


            Stars(a);
        }

        private static void Stars(int a)
        {
            for (int i = 0; i < a; ++i)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }
        }
    }
}
