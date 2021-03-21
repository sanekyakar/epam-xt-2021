using System;

namespace _2._1._2
{
	public class Line : Figure
	{
		private double beginX;
		private double beginY;
		private double endX;
		private double endY;
		public double Length { get; }
		public Line(double bX, double bY, double eX, double eY)
		{
			beginX = bX;
			beginY = bY;
			endX = eX;
			endY = eY;
			Length = Math.Sqrt(Math.Pow(endX - beginX, 2) + Math.Pow(endY - beginY, 2));
		}
		public override void Show()
		{
			Console.WriteLine($"Type: Line" +
				$"\nLength: {Math.Round(Length, 2)}" +
				$"\n");
		}
	}
}
