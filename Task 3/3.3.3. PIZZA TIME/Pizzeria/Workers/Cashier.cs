using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._3.PIZZA_TIME
{
    class Cashier : AbstractWorker
    {
        protected readonly Queue<Order<TypePizze, Action<Func<AbstractPizza>>>> Order;

        public Cashier(Queue<Order<TypePizze, Action<Func<AbstractPizza>>>> order)
        {
            Order = order;
        }
        public bool TakeOrder(TypePizze menu, ref decimal customerMoney, ref decimal companyMoney, Action<Func<AbstractPizza>> CallBackPizza)
        {
            if (menu == TypePizze.None || CheckMoney(menu, ref customerMoney, ref companyMoney) == -1)
            {
                return false;
            }
            Order.Enqueue(new Order<TypePizze, Action<Func<AbstractPizza>>>(menu, CallBackPizza));

            return true;
        }
        private int CheckMoney(TypePizze menu, ref decimal customerMoney, ref decimal companyMoney)
        {
            if (((int)menu) <= customerMoney)
            {
                customerMoney -= (int)menu;
                companyMoney += (int)menu;

                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}

