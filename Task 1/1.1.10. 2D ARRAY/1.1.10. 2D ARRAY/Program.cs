using System;

namespace _1._1._10._2D_ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            int summ = 0;

            Random rand = new Random();

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(0, 3);
                   if( (i+j)%2== 0)
                    {
                        summ += arr[i, j];
                    }


                Console.Write($"arr[{i}, {j}]={arr[i, j]}" + "\t ");
            
                }
                Console.WriteLine();
               
            }
            Console.WriteLine(summ);
        }
    }
}

