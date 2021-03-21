using System;

namespace _2._1._2
{
	public class Triangle : Figure, IAreaFigure
	{
		private Line sideA;
		private Line sideB;
		private Line sideC;
		private double area;
		private double perimeter;

		public Triangle(double cenX, double cenY, Line A, Line B, Line C)
		{
			centreX = cenX;
			centreY = cenY;
			sideA = A;
			sideB = B;
			sideC = C;
			area = Math.Sqrt((Perimeter() / 2) * ((Perimeter() / 2) - sideA.Length) * ((Perimeter() / 2) - sideB.Length) * ((Perimeter() / 2) - sideC.Length));
			perimeter = sideA.Length + sideB.Length + sideC.Length;
		}
		public Triangle()
		{
			centreX = 0;
			centreY = 0;
			sideA = new Line(0, 0, 0, 0);
			sideB = new Line(0, 0, 0, 0);
			sideC = new Line(0, 0, 0, 0);
		}

		public double Perimeter() => perimeter;
		public double Area() => area;

		public override void Show()
		{
			Console.WriteLine($"type: Triangle" +
				$"\nCentre: {centreX},{centreY}" +
				$"\nSide a: {Math.Round(sideA.Length, 2)}" +
				$"\nSide b: {Math.Round(sideB.Length, 2)}" +
				$"\nSide c: {Math.Round(sideC.Length, 2)}" +
				$"\nArea: {Math.Round(Area(), 2)}" +
				$"\nPerimeter: {Math.Round(Perimeter(), 2)}" +
				$"\n");
		}
	}
}
