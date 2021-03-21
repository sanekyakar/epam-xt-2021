using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Figure> figures = new List<Figure>();
			int button = -1;
			while (button != 0)
			{
				Console.WriteLine("Press the button to select a command:" +
					"\n1.Create new figure" +
					"\n2.Show all figures" +
					"\n3.Delete all figures" +
					"\n4.Exit");
				button = int.Parse(Console.ReadLine());
				switch (button)
				{
					case 1:
						{
							Console.WriteLine("\nPress the button to select a command:" +
							  "\n1.Line" +
							  "\n2.Circle" +
							  "\n3.Ring" +
							  "\n4.Rectangle" +
							  "\n5.Square" +
							  "\n6.Triangle" +
							  "\n");
							button = int.Parse(Console.ReadLine());
							switch (button)
							{
								case 1:
									{
										var line = LineCreator();
										figures.Add(line);
										Console.WriteLine("\nFigure \"Line\" added!\n");
									}
									break;
								case 2:
									{
										double cenX, cenY, rad;
										Console.WriteLine("Circle:" +
											"\nenter center X:");
										cenX = int.Parse(Console.ReadLine());
										Console.WriteLine("\nenter center Y:");
										cenY = int.Parse(Console.ReadLine());
										Console.WriteLine("\nenter radius:");
										rad = int.Parse(Console.ReadLine());
										var circle = new Circle(cenX, cenY, rad);
										figures.Add(circle);
										Console.WriteLine("\nFigure \"Circle\" added!\n");
									}
									break;
								case 3:
									{
										double cenX, cenY, rad, sRad;
										Console.WriteLine("Ring:" +
											"\nenter center X:");
										cenX = int.Parse(Console.ReadLine());
										Console.WriteLine("\nenter center Y:");
										cenY = int.Parse(Console.ReadLine());
										Console.WriteLine("\nenter big radius:");
										rad = int.Parse(Console.ReadLine());
										Console.WriteLine("\nenter small radius:");
										sRad = int.Parse(Console.ReadLine());
										var ring = new Ring(cenX, cenY, rad, sRad);
										figures.Add(ring);
										Console.WriteLine("\nFigure \"Ring\" added!\n");
									}
									break;
								case 4:
									{
										double cenX, cenY;
										Console.WriteLine("Rectangle:" +
												"\nenter center X:");
										cenX = int.Parse(Console.ReadLine());
										Console.WriteLine("\nenter center Y:");
										cenY = int.Parse(Console.ReadLine());

										var lineA = LineCreator();
										var lineB = LineCreator();

										var rectangle = new Rectangle(cenX, cenY, lineA, lineB);
										figures.Add(rectangle);
										Console.WriteLine("\nFigure \"Rectangle\" added!\n");
									}
									break;
								case 5:
									{
										double cenX, cenY;
										Console.WriteLine("Square:" +
												"\nenter center X:");
										cenX = int.Parse(Console.ReadLine());
										Console.WriteLine("\nenter center Y:");
										cenY = int.Parse(Console.ReadLine());

										var lineA = LineCreator();

										var square = new Square(cenX, cenY, lineA);
										figures.Add(square);
										Console.WriteLine("\nFigure \"Square\" added!\n");
									}
									break;
								case 6:
									{
										double cenX, cenY;
										Console.WriteLine("Triangle:" +
												"\nenter center X:");
										cenX = int.Parse(Console.ReadLine());
										Console.WriteLine("\nenter center Y:");
										cenY = int.Parse(Console.ReadLine());

										var lineA = LineCreator();
										var lineB = LineCreator();
										var lineC = LineCreator();

										var triangle = new Triangle(cenX, cenY, lineA, lineB, lineC);
										figures.Add(triangle);
										Console.WriteLine("\nFigure \"Triangle\" added!\n");
									}
									break;



								default:
									break;
							}

						}
						break;
					case 2:
						{
							if (figures.Count() > 0)
							{
								foreach (var item in figures)
								{
									item.Show();
								}
							}
							else
							{
								Console.WriteLine("\nLIST IS EMPTY!\n");
							}
						}
						break;
					case 3:
						{
							if (figures.Count() > 0)
							{
								figures = new List<Figure>();
								Console.WriteLine("\nALL FIGURES DELETED!\n");
							}
							else
							{
								Console.WriteLine("\nLIST IS EMPTY!\n");
							}
						}
						break;
					default:
						button = 0;
						break;
				}
			}
		}
		public static Line LineCreator()
		{
			double bX, bY, eX, eY;
			Console.WriteLine("\nenter initial X:");
			bX = double.Parse(Console.ReadLine());
			Console.WriteLine("\nenter initial Y:");
			bY = double.Parse(Console.ReadLine());
			Console.WriteLine("\nenter the final X:");
			eX = double.Parse(Console.ReadLine());
			Console.WriteLine("\nenter the final Y:");
			eY = double.Parse(Console.ReadLine());
			return new Line(bX, bY, eX, eY);
		}
	}
}
