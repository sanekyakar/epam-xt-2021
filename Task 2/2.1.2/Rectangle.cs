using System;

namespace _2._1._2
{
	public class Rectangle : Figure, IAreaFigure
	{
		protected Line sideA;
		protected Line sideB;
		public Rectangle(double cenX, double cenY, Line A, Line B)
		{
			centreX = cenX;
			centreY = cenY;
			sideA = A;
			sideB = B;
		}
		public Rectangle()
		{
			centreX = 0;
			centreY = 0;
			sideA = new Line(0, 0, 0, 0);
			sideB = new Line(0, 0, 0, 0);
		}
		public double Area() => sideA.Length * sideB.Length;

		public virtual double Perimeter() => sideA.Length * 2 + sideB.Length * 2;

		public override void Show()
		{
			Console.WriteLine($"type: Rectangle" +
				$"\nCentre: {centreX},{centreY}" +
				$"\nSide a: {Math.Round(sideA.Length, 2)}" +
				$"\nSide b: {Math.Round(sideB.Length, 2)}" +
				$"\nArea: {Math.Round(Area(), 2)}" +
				$"\nPerimeter: {Math.Round(Perimeter(), 2)}" +
				$"\n");
		}
	}
}
