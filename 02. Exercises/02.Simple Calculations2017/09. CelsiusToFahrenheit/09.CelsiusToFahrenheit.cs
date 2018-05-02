/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 09/03/2017
 * Time: 11:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CelsiusToFahrenheit
{
	class Program
	{
		public static void Main(string[] args)
		{
			double celsius = double.Parse(Console.ReadLine());
			double fahrenheit = (celsius * 1.8) + 32;
			Console.WriteLine("{0}",Math.Round(fahrenheit,2));
		}
	}
}