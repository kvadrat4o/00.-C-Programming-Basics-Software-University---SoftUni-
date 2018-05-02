/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 09/03/2017
 * Time: 10:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CircleAreaAndPerimeter
{
	class Program
	{
		public static void Main(string[] args)
		{
			double radius = double.Parse(Console.ReadLine());
			double area = Math.PI*(radius*radius);
			double perimeter = 2*Math.PI*radius;
			Console.WriteLine("Area = {0}",area);
			Console.WriteLine("Perimeter = {0}",perimeter);
		}
	}
}