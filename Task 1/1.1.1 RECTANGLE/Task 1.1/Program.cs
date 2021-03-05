using System;

namespace Task_1._1
{
    class Program
    {
        static void Main(string[] args)

        {

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int result = Ploshad(a,b);
            Console.WriteLine(result);

        }

        public static int Ploshad(int a, int b)
        {

            return a * b;
        }


    }
}

