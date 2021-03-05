using System;

namespace _1._2._3._LOWERCASE
{
    class Program
    {
        static void Main(string[] args)
        {
			
			string str1 = Console.ReadLine();
			string[] words = str1.Split(new char[] { ' ', '.', ',', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
			int count = 0;
			for (int i = 0; i < words.Length; i++)
			{
				if (words[i] == words[i].ToLower())
				{
					count++;
				}
			}
			Console.WriteLine("Количество слов, начинающихся с маленькой буквы = {0}", count);

		}
    }
}
