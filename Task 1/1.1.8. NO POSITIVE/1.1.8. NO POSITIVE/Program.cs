using System;

namespace _1._1._8._NO_POSITIVE
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] arr = new int[4, 4, 4];
            Random rand = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i, j, k] = rand.Next(-40, 40);
                        if (arr[i, j, k] > 0) arr[i, j, k] = 0;
                        
                            Console.Write(arr[i, j, k] + " \t ");
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
