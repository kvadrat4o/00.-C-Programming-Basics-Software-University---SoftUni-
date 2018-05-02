/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 21/03/2017
 * Time: 14:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace March_03CarToGo
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("enter budget amount: ");
			double budget = double.Parse(Console.ReadLine());
			//Console.WriteLine("enter season name: ");
			string season = Console.ReadLine().ToLower();
			string car = "Jeep";
			string carClass = "No class";
			double price = double.MinValue;
			if (budget<=100) {
				carClass = "Economy class";
				switch (season) {
					case "summer":
						price = 0.35*budget;
						car = "Cabrio";
						Console.WriteLine("{0}\n{1} - {2:f2}",carClass,car,price);
						break;
					case "winter":
						price = 0.65*budget;
						car = "Jeep";
						Console.WriteLine("{0}\n{1} - {2:f2}",carClass,car,price);
						break;
					default:
						break;
				}
			}
			else if (budget>100&&budget<=500) {
				carClass = "Compact class";
				switch (season) {
					case "summer":
						price = 0.45*budget;
						car = "Cabrio";
						Console.WriteLine("{0}\n{1} - {2:f2}",carClass,car,price);
						break;
					case "winter":
						price = 0.80*budget;
						car = "Jeep";
						Console.WriteLine("{0}\n{1} - {2:f2}",carClass,car,price);
						break;
					default:
						break;
				}
			
			}
			else if (budget>500) {
				carClass = "Luxury class";
				switch (season) {
					case "summer":
						price = 0.90*budget;
						car = "Jeep";
						Console.WriteLine("{0}\n{1} - {2:f2}",carClass,car,price);
						break;
					case "winter":
						price = 0.90*budget;
						car = "Jeep";
						Console.WriteLine("{0}\n{1} - {2:f2}",carClass,car,price);
						break;
					default:
						break;
				}
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}