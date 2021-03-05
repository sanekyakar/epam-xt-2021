using System;

namespace _1._2._2._DOUBLER
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строки");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string str3 = Console.ReadLine();

            foreach( char ch in str1)
                if (!str1.Contains(ch))
                   str3 += ch;          
            else
            {
                    str3 += ch;
                    str3 += ch;

            }
            Console.WriteLine("Результат = {0}", str3);



        }
    }
}
