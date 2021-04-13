using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._1._2._TEXT_ANALYSIS
{
    class Analyzer
    {
        private Dictionary<string, int> words;
        public Analyzer(string str)
        {
            if (str == null || str == "")
            {
                throw new ArgumentNullException();
            }
            else
            {
                words = new Dictionary<string, int>();
                CheckWords(str);
                SetStatus();
                Counter();
            }
        }

        private void CheckWords(string str)
        {
            char[] separators = new char[] { ' ', '.', ',', '!', '?', '»', '«', ':' };
            string[] array = str.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in array)
            {
                if (words.ContainsKey(item))
                {
                    words[item]++;
                }
                else
                {
                    words[item] = 1;
                }
            }
        }
        private void SetStatus()
        {
            double count = words.Sum(d => d.Value);

            if (count / words.Count <= 1.16)
            {
                Console.WriteLine(new String('*', 25));
                Console.WriteLine("Ваша речь разнообразна");
                Console.WriteLine(new String('*', 25));
            }
            else if (count / words.Count > 1.16)
            {
                Console.WriteLine(new String('*', 25));
                Console.WriteLine("В данном тексте много повторений");
                Console.WriteLine(new String('*', 25));
            }
            if (words.Count == 0)
            {
                Console.WriteLine(new String('*', 25));
                Console.WriteLine("Вы не ввели текст");
                Console.WriteLine(new String('*', 25));
            }
        }

        private  void Counter()
        {
            foreach (var item in words)
            {
                Console.WriteLine($"{item.Key} ({item.Value})");
            }
        }
    }
}
