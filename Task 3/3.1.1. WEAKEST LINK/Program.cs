using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1._1.WEAKEST_LINK
{
    class Program
    {
        static List<Human> createList(int count)
        {           
            List<Human> list = new List<Human>();
            for (int i = 0; i < count; ++i)
            { 
                list.Add(new Human(Console.ReadLine()));
            }
            return list;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество игроков:");
            int count;
            string input = Console.ReadLine();
            bool result = int.TryParse(input, out count);
            if (result)
            { }
            else
            {
                Console.WriteLine("Invalid value entered");
            }
            Console.WriteLine("Введите номер игрока, который будет вычеркиваться:");
            int index;
            input = Console.ReadLine();
            result = int.TryParse(input, out index);
            if (result)
            { }
            else
            {
                Console.WriteLine("Invalid value entered");
            }
            Console.WriteLine("Введите имена игроков:");
            Logic game = new Logic(createList(count));
            game.Play(index);
            Console.ReadLine();
        }
    }
}
