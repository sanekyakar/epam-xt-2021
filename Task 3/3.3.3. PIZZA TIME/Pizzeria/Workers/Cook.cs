using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _3._3._3.PIZZA_TIME
{
    class Cook : AbstractWorker
    {
        protected static object CloseOrder = new object();

        protected readonly Queue<Order<TypePizze, Action<Func<AbstractPizza>>>> Order;

        public event Action<Func<AbstractPizza>> EventOrderCompleted = new Action<Func<AbstractPizza>>((i) => { });
        public Cook(Queue<Order<TypePizze, Action<Func<AbstractPizza>>>> order)
        {
            Order = order;

            new Thread(MonitorOrder).Start();
        }

        protected void MonitorOrder()
        {
            Order<TypePizze, Action<Func<AbstractPizza>>> order;

            while (true)
            {
                lock (CloseOrder)
                {
                    if (Order.Count > 0)
                    {
                        order = Order.Dequeue();

                        EventOrderCompleted += order.CallBackPizza;


                        CompleteOrder(() => FactoryPizza(order.Menu));
                    }

                }
            }
        }

        protected void CompleteOrder(Func<AbstractPizza> CallBackPizza)
        {
            EventOrderCompleted.Invoke(CallBackPizza);
        }
        protected AbstractPizza FactoryPizza(TypePizze menu)
        {
            switch (menu)
            {
                case TypePizze.CheesePizze: return new CheesePizze();
                case TypePizze.HawaiianPizza: return new HawaiianPizza();
                case TypePizze.MeatPizza: return new MeatPizza();
                case TypePizze.PepperoniPizza: return new PepperoniPizza();
                default: return null;
            }
        }
    }
}
