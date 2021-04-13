using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2._1.DYNAMIC_ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            //тесты
            int[] mass = new int[] { 1, 2, 5, 4, 3, 6, 8, 8, 10, 7 };
            int[] masss = new int[] { 10, 32, 56 };
            Dynamic_Array<int> arr = new Dynamic_Array<int>(mass);
            int a = arr.Capacity;
            Console.WriteLine(a);
            int b= arr.Length;
            Console.WriteLine(b);
            
            foreach (var item in arr)
            {
                Console.Write($" '{item}' ");
            }
            
            Console.WriteLine();
            arr.Add(156);
            a = arr.Capacity;
            Console.WriteLine(a);
            b = arr.Length;
            Console.WriteLine(b);
            arr.Capacity = 15;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($" '{arr[i]}' ");
            }
            Console.WriteLine();
            
            Console.ReadLine();
        }
    }
}
