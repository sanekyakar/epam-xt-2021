using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _3._3._2.SUPER_STRING
{
    class SuperString
    {
        public SuperString(string str)
        {
            if (str == null || str == "")
            {
                throw new ArgumentNullException();
            }
            else 
            {
                CheckString(str);
            }
        }

        private void CheckString(string str)
        {
            Regex RussianRegex = new Regex(@"[a-z]|[0-9]|([.?#$%^&*()_+\-=&!,\\|\/№;:])", RegexOptions.IgnoreCase);
            Regex EngRegex = new Regex(@"[а-я]|[0-9]|([.?#$%^&*()_+\-=&!,\\|\/№;:])", RegexOptions.IgnoreCase);
            Regex NumRegex = new Regex(@"[а-я]|[a-z]|([.?#$%^&*()_+\-=&!,\\|\/№;:])", RegexOptions.IgnoreCase);

            MatchCollection RuMatches = RussianRegex.Matches(str);
            MatchCollection EngMatches = EngRegex.Matches(str);
            MatchCollection NumMatches = NumRegex.Matches(str);

            if (RuMatches.Count == 0)
            {
                Console.WriteLine("\nRussian Text");
            }
            else if (EngMatches.Count == 0)
            {
                Console.WriteLine("\nEnglish Text");
            }
            else if (NumMatches.Count == 0)
            {
                Console.WriteLine("\nNumber Text");
            }
            else
            {
                Console.WriteLine("\nMixed");
            }
        }
    }
}
