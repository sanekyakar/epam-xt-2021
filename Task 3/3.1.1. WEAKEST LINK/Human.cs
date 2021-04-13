using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1._1.WEAKEST_LINK
{
    class Human
    {
        public string firstName { get; set; }

        public Human(string name)
        {
            firstName = name;
        }
        public override string ToString()
        {
            return $"{firstName}";
        }

    }
}
