using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2._2._1
{
	class Player : GameObject
	{
		private int positionX;
		private int positionY;
		private int health;

		public Player(int posX, int posY)
		{
			positionX = posX;
			positionY = posY;
			health = 5;
		}
		public Player()
		{
			positionX = 2;
			positionY = 2;
			health = 5;
		}
		public void Move(int height, int width)
		{
			while (health>0)
			{
				var key = Console.ReadKey();
				
				Console.Clear();
				Thread.Sleep(100);
				switch (key.Key)
				{
					case ConsoleKey.UpArrow:
						{
							if (positionY>1)
							{
								positionY--;
							}
						}
						break;
					case ConsoleKey.DownArrow:
						{
							if (positionY < height-2)
							{
								positionY++;
							}
						}
						break;
					case ConsoleKey.LeftArrow:
						{
							if (positionX > 1)
							{
								positionX--;
							}
						}
						break;
					case ConsoleKey.RightArrow:
						{
							if (positionX < width-2)
							{
								positionX++;
							}
						}
						break;
					default:
						break;
				}
			}
		}
		public int ShowPositionX() => positionX;
		public int ShowPositionY() => positionY;
		public int ShowHealth() => health;
		public void TakeDamage()
		{
			health--;
		}
	}
}
