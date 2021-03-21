using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._1
{
	class Item : GameObject
	{
		private int positionX;
		private int positionY;
		private int wight;
		private int height;
		Random rng = new Random();
		public Item(int wight, int height)
		{
			positionX = rng.Next(1, wight-2);
			positionY = rng.Next(1, height-2);
			this.wight = wight;
			this.height = height;
		}
		public void NewPosition()
		{
			positionX = rng.Next(1, wight - 2);
			positionY = rng.Next(1, height - 2);
		}
		public int ShowPositionX() => positionX;
		public int ShowPositionY() => positionY;
	}
}
