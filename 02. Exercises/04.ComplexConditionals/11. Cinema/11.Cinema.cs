/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 14/03/2017
 * Time: 11:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Cinema
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter type cinema: ");
			string typeCinema = Console.ReadLine().ToLower();
			Console.WriteLine("Enter count rows: ");
			double r = double.Parse(Console.ReadLine());
			Console.WriteLine("Enter count columns: ");
			double c = double.Parse(Console.ReadLine());
			double price = -1;
			switch (typeCinema)
            {
				case "premiere":
					price = 12.00*r*c;
					Console.WriteLine("{0}\n {1}",Math.Round(price,2),"leva");
					break;
				case "normal":
					price = 7.50*r*c;
					Console.WriteLine("{0}\n {1}",Math.Round(price,2),"leva");
					break;
				case "discount":
					price = 5.00*r*c;
					Console.WriteLine("{0}\n {1}",Math.Round(price,2),"leva");
					break;
				default:
					Console.WriteLine("Default case");
					break;
			}
		}
	}
}