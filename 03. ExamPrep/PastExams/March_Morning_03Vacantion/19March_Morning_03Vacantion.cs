/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 23/03/2017
 * Time: 10:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace March_Morning_03Vacantion
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("enter budget: ");
			double budget = double.Parse(Console.ReadLine());
			//Console.WriteLine("enter season: ");
			string season = Console.ReadLine().ToLower();
			string settlement,place;
			double price = 0;
			if (budget<=1000) {
				settlement = "Camp";
				switch (season) {
					case "summer":
						place = "Alaska";
						price = budget*0.65;
						Console.WriteLine("{0} - {1} - {2:f2}",place,settlement,price);
						break;
					case "winter":
						place = "Morocco";
						price = budget*0.45;
						Console.WriteLine("{0} - {1} - {2:f2}",place,settlement,price);
						break;
					default:
						break;
				}
			}
			else if (budget>=1000&&budget<=3000) {
				settlement = "Hut";
				switch (season) {
					case "summer":
						place = "Alaska";
						price = budget*0.80;
						Console.WriteLine("{0} - {1} - {2:f2}",place,settlement,price);
						break;
					case "winter":
						place = "Morocco";
						price = budget*0.60;
						Console.WriteLine("{0} - {1} - {2:f2}",place,settlement,price);
						break;
					default:
						break;
				}
			}
			else if (budget>3000) {
				settlement = "Hotel";
				switch (season) {
					case "summer":
						place = "Alaska";
						price = budget*0.90;
						Console.WriteLine("{0} - {1} - {2:f2}",place,settlement,price);
						break;
					case "winter":
						place = "Morocco";
						price = budget*0.90;
						Console.WriteLine("{0} - {1} - {2:f2}",place,settlement,price);
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