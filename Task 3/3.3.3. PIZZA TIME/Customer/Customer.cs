using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _3._3._3.PIZZA_TIME
{
    internal class Customer
    {
        public string Name { get; }
        protected decimal Money;
        public AbstractPizza Pizza { get; protected set; }

        public Customer(string name, decimal money)
        {
            Name = name;
            Money = money;
        }

        public bool OrderPizza(Pizzeria pizzeria, TypePizze pizza)
        {
            return pizzeria.OrderTo(pizza, ref Money, GetPizza);
        }
        protected void GetPizza(Func<AbstractPizza> CallBack)
        {
            Pizza = CallBack();
        }
        
    }
}
