/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 24/03/2017
 * Time: 14:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CircleAreaLength
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("enter a radius: ");
			int r  = int.Parse(Console.ReadLine());
			double length,area;
			length = 2*r*Math.PI;
			area = r*r*Math.PI;
			Console.WriteLine("length - {0:f2}\nArea - {1:f2}", length,area);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}