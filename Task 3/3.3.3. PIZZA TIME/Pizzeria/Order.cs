using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._3.PIZZA_TIME
{
    internal class Order<T, U>
    {
        public T Menu;
        public U CallBackPizza;

        public Order(T menu, U callBackPizza)
        {
            Menu = menu;
            CallBackPizza = callBackPizza;
        }
    }
}
