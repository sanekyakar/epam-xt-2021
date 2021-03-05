using System;

namespace _1._1._7._ARRAY_PROCESSING
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            Random rand = new Random();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100);
                

            }
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                Console.WriteLine(arr[i]);
            }

        }
        }
    }


        
