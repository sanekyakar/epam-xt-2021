using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2._2._1
{
	class World
	{
		private Player player = new Player();
		private List<Item> items = new List<Item>();
		private List<Enemy> enemys = new List<Enemy>();
		private Char[,] place;
		private int width;
		private int height;
		private int score = 0;
		private Random rng = new Random();

		public World(int wid, int heig)
		{
			width = wid;
			height = heig;
			place = new char[height, width];
			SpaceFilling();
			CreateItems();
			CreateEnemy();
		}
		public World()
		{
			width = 20;
			height = 20;
			place = new char[height, width];
			SpaceFilling();
			CreateItems();
			CreateEnemy();
		}
		private void SpaceFilling()
		{
			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					if ((i == 0 || i == height - 1) || (j == 0 || j == width - 1))
					{
						place[i, j] = '#';
					}
					else if (i == player.ShowPositionY() && j == player.ShowPositionX())
					{
						place[i, j] = 'P';
					}
					else if (place[i, j] != 'L' && place[i, j] != 'E')
					{
						place[i, j] = ' ';
					}

				}
			}

			for (int i = 0; i < items.Count; i++)
			{

				if (place[items[i].ShowPositionY(), items[i].ShowPositionX()] == 'P')
				{
					score++;
					bool chek = false;
					while (!chek)
					{
						items[i].NewPosition();
						if (place[items[i].ShowPositionY(), items[i].ShowPositionX()] == ' ')
						{
							place[items[i].ShowPositionY(), items[i].ShowPositionX()] = 'L';
							chek = true;
						}
					}
				}
			}
			for (int i = 0; i < enemys.Count; i++)
			{
				if (place[enemys[i].ShowPositionY(), enemys[i].ShowPositionX()] == 'P')
				{
					player.TakeDamage();
					bool chek = false;
					while (!chek)
					{
						enemys[i].NewPosition();
						if (place[enemys[i].ShowPositionY(), enemys[i].ShowPositionX()] == ' ')
						{
							place[enemys[i].ShowPositionY(), enemys[i].ShowPositionX()] = 'E';
							chek = true;
						}
					}
				}
			}
		}
		public void Draw()
		{
			while (GameOverChecking() && WinChecking())
			{
				SpaceFilling();
				EnemyMove();
				Console.SetCursorPosition(0, 0);
				for (int i = 0; i < height; i++)
				{
					for (int j = 0; j < width; j++)
					{
						Console.Write(place[i, j]);
					}
					Console.WriteLine();
				}
				Console.WriteLine($"\nHP:{player.ShowHealth()}" +
					$"\nSCORE:{score}\n" +
					"\nP-player" +
					"\n#-wall" +
					"\nL-loot" +
					"\nE-enemy");
				Thread.Sleep(100);
			}
			if (!GameOverChecking())
			{
				GameOver();
			}
			else if (!WinChecking())
			{
				Win();
			}
			Console.ReadLine();
		}
		private void EnemyMove()
		{
			for (int i = 0; i < enemys.Count; i++)
			{
				bool check = false;
				while (!check)
				{
					int rn = rng.Next(1, 5);
					switch (rn)
					{
						case 1:
							{
								if (place[enemys[i].ShowPositionY(), enemys[i].ShowPositionX() - 1] == ' ' || place[enemys[i].ShowPositionY(), enemys[i].ShowPositionX() - 1] == 'P')
								{
									place[enemys[i].ShowPositionY(), enemys[i].ShowPositionX() - 1] = 'E';
									place[enemys[i].ShowPositionY(), enemys[i].ShowPositionX()] =' ' ;
									enemys[i].MoveLeft();
									check = true;
								}
								break;
							}
						case 2:
							{
								if (place[enemys[i].ShowPositionY() - 1, enemys[i].ShowPositionX()] == ' ' || place[enemys[i].ShowPositionY() - 1, enemys[i].ShowPositionX()] == 'P')
								{
									place[enemys[i].ShowPositionY() - 1, enemys[i].ShowPositionX()] = 'E';
									place[enemys[i].ShowPositionY(), enemys[i].ShowPositionX()] = ' ';
									enemys[i].MoveUp();
									check = true;
								}
								break;
							}
						case 3:
							{
								if (place[enemys[i].ShowPositionY(), enemys[i].ShowPositionX() + 1] == ' ' || place[enemys[i].ShowPositionY(), enemys[i].ShowPositionX() + 1] == 'P')
								{
									place[enemys[i].ShowPositionY(), enemys[i].ShowPositionX() + 1] = 'E';
									place[enemys[i].ShowPositionY(), enemys[i].ShowPositionX()] = ' ';
									enemys[i].MoveRight();
									check = true;
								}
								break;
							}
						case 4:
							{
								if (place[enemys[i].ShowPositionY() + 1, enemys[i].ShowPositionX()] == ' ' || place[enemys[i].ShowPositionY() + 1, enemys[i].ShowPositionX()] == 'P')
								{
									place[enemys[i].ShowPositionY() + 1, enemys[i].ShowPositionX()] = 'E';
									place[enemys[i].ShowPositionY(), enemys[i].ShowPositionX()] = ' ';
									enemys[i].MoveDown();
									check = true;
								}
								break;
							}

						default:
							break;
					}
				}
			}
		}
		public void PlayerMove()
		{
			player.Move(height, width);
		}
		private void CreateEnemy()
		{
			bool check = false;
			int rn = rng.Next(5, 10);
			for (int i = 0; i < rn; i++)
			{
				enemys.Add(new Enemy(width, height));
			}
			for (int i = 0; i < enemys.Count; i++)
			{
				check = false;
				while (!check)
				{
					if (place[enemys[i].ShowPositionY(), enemys[i].ShowPositionX()] == ' ')
					{
						place[enemys[i].ShowPositionY(), enemys[i].ShowPositionX()] = 'E';
						check = true;
					}
					else
					{
						enemys[i].NewPosition();
					}
				}
			}
		}
		private void CreateItems()
		{
			bool check = false;
			int rn = rng.Next(2, 6);
			for (int i = 0; i < rn; i++)
			{
				items.Add(new Item(width, height));
			}
			for (int i = 0; i < items.Count; i++)
			{
				check = false;
				while (!check)
				{
					if (place[items[i].ShowPositionY(), items[i].ShowPositionX()] == ' ')
					{
						place[items[i].ShowPositionY(), items[i].ShowPositionX()] = 'L';
						check = true;
					}
					else
					{
						items[i].NewPosition();
					}
				}
			}
		}
		public bool WinChecking()
		{
			if (score < 10)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public void Win()
		{
			Console.SetCursorPosition(width / 4 - 2, 2);
			Console.Write(" # # ### # # ");
			Console.SetCursorPosition(width / 4 - 2, 3);
			Console.Write("  #  # # # # ");
			Console.SetCursorPosition(width / 4 - 2, 4);
			Console.Write("  #  # # # # ");
			Console.SetCursorPosition(width / 4 - 2, 5);
			Console.Write("  #  ### ### ");
			Console.SetCursorPosition(width / 4 - 2, 7);
			Console.Write("  # # # #  # ");
			Console.SetCursorPosition(width / 4 - 2, 8);
			Console.Write("  # #   ## # ");
			Console.SetCursorPosition(width / 4 - 2, 9);
			Console.Write("  ### # # ## ");
			Console.SetCursorPosition(width / 4 - 2, 10);
			Console.Write("  # # # #  # ");
		}
		public bool GameOverChecking()
		{
			if (player.ShowHealth() > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public void GameOver()
		{
			Console.SetCursorPosition(width / 4 - 2, 2);
			Console.Write(" ####  #  #   # ### ");
			Console.SetCursorPosition(width / 4 - 2, 3);
			Console.Write(" #    ### ## ## #   ");
			Console.SetCursorPosition(width / 4 - 2, 4);
			Console.Write(" # ## # # # # # ### ");
			Console.SetCursorPosition(width / 4 - 2, 5);
			Console.Write(" #  # ### #   # #   ");
			Console.SetCursorPosition(width / 4 - 2, 6);
			Console.Write(" #### # # #   # ### ");
			Console.SetCursorPosition(width / 4 - 2, 8);
			Console.Write(" ### # # ### ### ");
			Console.SetCursorPosition(width / 4 - 2, 9);
			Console.Write(" # # # # #   # # ");
			Console.SetCursorPosition(width / 4 - 2, 10);
			Console.Write(" # # # # ### # # ");
			Console.SetCursorPosition(width / 4 - 2, 11);
			Console.Write(" # # ### #   ##  ");
			Console.SetCursorPosition(width / 4 - 2, 12);
			Console.Write(" ###  #  ### # # ");
		}

	}
}
