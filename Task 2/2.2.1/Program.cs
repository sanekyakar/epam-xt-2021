using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2._2._1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.CursorVisible = false;
			const int width = 50;
			const int height = 20;
			var world = new World(width, height);
			Thread Move = new Thread(new ThreadStart(world.PlayerMove));
			Move.Start();
			world.Draw();

		}
	}
}
