using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._2.SUPER_STRING
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string inputString = Console.ReadLine();
            SuperString str = new SuperString(inputString);
            Console.ReadLine();
        }
    }
}
