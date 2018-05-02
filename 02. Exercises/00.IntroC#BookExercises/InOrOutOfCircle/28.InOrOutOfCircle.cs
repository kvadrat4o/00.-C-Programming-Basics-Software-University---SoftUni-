/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 1/30/2017
 * Time: 1:11 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace InOrOutOfCircle
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
			if (sum<25) {
				Console.WriteLine("Your point A({0};{1}) is inside a circle with radius R = 5 and center with coordinates (0;0).",x,y);
			}
			else if (sum==25) {
				Console.WriteLine("Your point A({0};{1}) is on a circle with radius R = 5 and center with coordinates (0;0).",x,y);
			}
			else {
				Console.WriteLine("Your point A({0};{1}) is outside a circle with radius R = 5 and center with coordinates (0;0).",x,y);
			};
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}