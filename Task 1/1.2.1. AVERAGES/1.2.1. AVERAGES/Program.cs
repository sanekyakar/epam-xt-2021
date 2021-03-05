using System;
using System.Linq;

namespace _1._2._1._AVERAGES
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку - ");
            string str = Console.ReadLine();

            string[] words = str.Split(new[] { ' ', '1', '?', ':', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

            int[] strLenght = new int[words.Length];
            for(int i = 0; i < words.Length; i++)
            {
                strLenght[i] = words[i].Length;
            }
            Console.WriteLine("Сердняя длина  = {0}", Math.Round(strLenght.Average()));

              
            }
           

        }
    }


