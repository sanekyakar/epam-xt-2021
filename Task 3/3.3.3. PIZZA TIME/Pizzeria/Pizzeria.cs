using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._3.PIZZA_TIME
{
    internal class Pizzeria
    {
        protected decimal Money;
        protected Queue<Order<TypePizze, Action<Func<AbstractPizza>>>> Order;
        protected event Action<Func<AbstractPizza>> EventOrderCompleted;
        protected List<AbstractWorker> Worker;

        public Pizzeria(decimal money)
        {
            Money = money;

            Order = new Queue<Order<TypePizze, Action<Func<AbstractPizza>>>>();
            EventOrderCompleted = new Action<Func<AbstractPizza>>((d) => { });
            Worker = new List<AbstractWorker>() { new Cashier(Order), new Cook(Order), new Cook(Order) };
        }

        public bool OrderTo(TypePizze menu, ref decimal money, Action<Func<AbstractPizza>> CallBackPizza)
        {
            Cashier cashier = null;

            foreach (var item in Worker)
            {
                if (item is Cashier)
                {
                    cashier = (Cashier)item;
                }
            }

            if (cashier != null)
            {
                return cashier.TakeOrder(menu, ref money, ref Money, CallBackPizza);
            }

            return false;
        }
    }
}
