using System;

namespace _2._1._2
{
	public class Circle : Figure, IAreaFigure
	{
		protected double radius;

		public Circle(double cenX, double cenY, double rad)
		{
			centreX = cenX;
			centreY = cenY;
			radius = rad;
		}

		public double Circumference() => 2 * Math.PI * radius;
		public double Area() => Math.PI * Math.Pow(radius, 2);

		public override void Show()
		{
			Console.WriteLine("type: Circle" +
				$"\nCentre: {centreX},{centreY}" +
				$"\nRadius: {radius}" +
				$"\nCircumference: {Math.Round(Circumference(), 2)}" +
				$"\nArea: {Math.Round(Area(), 2)}" +
				$"\n"); ;
		}
	}
}
