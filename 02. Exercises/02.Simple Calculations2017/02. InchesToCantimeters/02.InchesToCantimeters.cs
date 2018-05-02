/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 09/03/2017
 * Time: 09:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace InchesToCantimeters
{
	class Program
	{
		public static void Main(string[] args)
		{
			double inches = double.Parse(Console.ReadLine());
			double centimeters = inches*2.54;
			Console.WriteLine("Centimeters - {0} ",centimeters);
		}
	}
}