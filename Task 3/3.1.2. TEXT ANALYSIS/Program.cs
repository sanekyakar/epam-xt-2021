using System;
using System.IO;

namespace _3._1._2._TEXT_ANALYSIS
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/Vlad/source/EPAM/Task_3/3.1.2. TEXT ANALYSIS/fileIn.txt";
            using (StreamReader fileIn = new StreamReader(path))
            {
                string str = fileIn.ReadToEnd();
                Console.WriteLine("Текст из файла проанализирован...\n");
                Analyzer analiz = new Analyzer(str);

            }
            Console.ReadLine();
        }
    }
}
