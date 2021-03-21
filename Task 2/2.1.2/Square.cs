using System;

namespace _2._1._2
{
	public class Square : Rectangle
	{
		public Square(double cenX, double cenY, Line A)
		{
			centreX = cenX;
			centreY = cenY;
			sideA = A;
			sideB = A;
		}
		public Square() : base()
		{

		}
		public override void Show()
		{
			Console.WriteLine($"type: Square" +
				$"\nCentre: {centreX},{centreY}" +
				$"\nSide a: {Math.Round(sideA.Length, 2)}" +
				$"\nArea: {Math.Round(Area(), 2)}" +
				$"\nPerimeter: {Math.Round(Perimeter(), 2)}" +
				$"\n");
		}
	}
}
