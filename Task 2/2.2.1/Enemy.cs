using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._1
{
	class Enemy : GameObject
	{
		private int positionX;
		private int positionY;
		private int wight;
		private int height;
		Random rng = new Random();
		public Enemy(int wigh, int heigh)
		{
			positionX = rng.Next(2, wigh - 2);
			positionY = rng.Next(2, heigh - 2);
			wight = wigh;
			height = heigh;
		}
		public void NewPosition()
		{
			positionX = rng.Next(2, wight - 2);
			positionY = rng.Next(2, height - 2);
		}
		public void MoveUp()
		{
			positionY--;
		}
		public void MoveDown()
		{
			positionY++;
		}
		public void MoveLeft()
		{
			positionX--;
		}
		public void MoveRight()
		{
			positionX++;
		}
		public int ShowPositionX() => positionX;
		public int ShowPositionY() => positionY;
	}
}
