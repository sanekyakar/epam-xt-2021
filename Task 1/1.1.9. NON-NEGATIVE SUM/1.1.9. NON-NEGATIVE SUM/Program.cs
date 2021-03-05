using System;

namespace _1._1._9._NON_NEGATIVE_SUM
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int sum = 0;
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-100, 100);

                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}


