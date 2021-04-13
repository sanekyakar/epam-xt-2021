using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._3.PIZZA_TIME
{
    class AbstractPizza
    {
        private string Name;
        private decimal Price;

        protected string GetName => Name;
        protected decimal GetPrice => Price;
    }
}
