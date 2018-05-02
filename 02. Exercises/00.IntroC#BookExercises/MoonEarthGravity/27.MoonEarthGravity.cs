/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 1/30/2017
 * Time: 12:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace MoonEarthGravity
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter your weight on Earth (in kg): ");
			double  earthKg = double.Parse(Console.ReadLine());
			double  percentage = 0.17;
			double moonKg = (percentage*earthKg);
			Console.WriteLine("A person with weight on Eart {0} kg will have weight on the Moon - {1} kg.",earthKg,moonKg);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}