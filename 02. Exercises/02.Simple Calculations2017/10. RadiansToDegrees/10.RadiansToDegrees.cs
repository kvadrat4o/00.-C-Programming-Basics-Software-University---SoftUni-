/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 09/03/2017
 * Time: 11:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace RadiansToDegrees
{
	class Program
	{
		public static void Main(string[] args)
		{
			double radians = double.Parse(Console.ReadLine());
			double degrees = radians*180/Math.PI;
			Console.WriteLine("{0}",Math.Round(degrees));
		}
	}
}