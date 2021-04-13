using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1._1.WEAKEST_LINK
{
    class Logic
    {
        public List<Human> Players { get; set; }

        public Logic(List<Human> players)
        {
            if (players == null)
                throw new ArgumentNullException();

            if (players.Count == 0)
                throw new ArgumentException();

            Players = new List<Human>(players.Count());

            foreach (Human item in players)
            {
                Players.Add(item);
            }
        }

        public void Show()
        {
            if (Players.Count() == 0)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                foreach (var item in Players)
                {
                    Console.WriteLine($"{item}" );
                }
            }
        }

        public void Play(int number)
        {
            if (number > Players.Count())
            {
                throw new ArgumentException("number cannot be more than the number of players");
            }
            else if (number <= 1)
            {
                throw new ArgumentException();
            }
            else 
            {
                bool play = true;
                int countRnd = 1;

                while (play)
                {
                    for (int i = 0; i < Players.Count(); ++i)
                    {
                        if ((i + 1) % number == 0)
                        {
                            Console.WriteLine(new String('*', 25));
                            Console.WriteLine($"Раунд: {countRnd++} Выходит: {Players[i]} Игроков осталось {Players.Count()-1}");
                            Console.WriteLine(new String('*', 25));
                            Players.RemoveAt(i);
                            i--;
                            Show();
                        }
                        if (number > Players.Count())
                        {
                            play = false;
                            Console.WriteLine(new String('*', 25));
                            Console.WriteLine("Game over, winners: ");
                            Show();
                            Console.WriteLine(new String('*', 25));

                           // Show();

                            break;
                        }
                    }
                }
            }
        }
    }
}
