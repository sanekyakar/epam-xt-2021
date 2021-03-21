using System;

namespace _2._1._2
{
	public class Ring : Circle, IAreaFigure
	{
		private double smallRadius;
		public Ring(double cenX, double cenY, double rad, double sRad) : base(cenX, cenY, rad)
		{
			smallRadius = sRad;
		}
		public new double Area() => Math.PI * (Math.Pow(radius, 2) - Math.Pow(smallRadius, 2));
		public double TotalCircumference() => (2 * Math.PI * radius) + (2 * Math.PI * smallRadius);
		public override void Show()
		{
			Console.WriteLine("type: Ring" +
				$"\nCentre: {centreX},{centreY}" +
				$"\nMain radius: {radius}" +
				$"\nSmall radius: {smallRadius}" +
				$"\nTotal circumference: {Math.Round(TotalCircumference(), 2)}" +
				$"\nArea: {Math.Round(Area(), 2)}" +
				$"\n"); ;
		}
	}
}
