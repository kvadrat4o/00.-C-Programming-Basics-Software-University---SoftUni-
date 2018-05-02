/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 1/30/2017
 * Time: 1:25 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace InsideaCircleOutsideaRectangle
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter 'x' coordinate of point A: ");
			double x = double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter 'y' coordinate of point A: ");
			double y = double.Parse(Console.ReadLine());
			double sum = (x*x+y*y);
			if (sum<=25) {
				if (y<1) {
					Console.WriteLine("Your point A({0};{1}) is inside a circle with radius R = 5 and center with coordinates (0;0), but outside a rectangle with coordinates A(-1;1), B(5;1), C(5;5), D(-1;5).",x,y);
				}
				else {
					Console.WriteLine("Your point A({0};{1}) is inside a circle with radius R = 5 and center with coordinates (0;0), and inside a rectangle with coordinates A(-1;1), B(5;1), C(5;5), D(-1;5).",x,y);
				};
				Console.WriteLine("Your point A({0};{1}) is inside a circle with radius R = 5 and center with coordinates (0;0).",x,y);
			}
			else {
				Console.WriteLine("Your point A({0};{1}) is outside a circle with radius R = 5 and center with coordinates (0;0) and may be inside a rectangle with coordinates A(-1;1), B(5;1), C(5;5), D(-1;5).",x,y);
			};
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}