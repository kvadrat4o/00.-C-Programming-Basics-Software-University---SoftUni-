/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 04/04/2017
 * Time: 10:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace March16_TransportPrice
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("enter num kms: ");
			int km = int.Parse(Console.ReadLine());
			Console.WriteLine("enter day time: ");	
			string dayTime = Console.ReadLine().ToLower();
			double price = 0;
			double tax = 0.70;
			double total = 0;
			if (km<20) {
				switch (dayTime) {
					case "day":
						price = km*0.79;
						total = price+tax;
						Console.WriteLine(total);
						break;
					case "night":
						price = km*0.90;
						total = price+tax;
						Console.WriteLine(total);
						break;
					default:
						
						break;
				}
			}
			else if (km>20&&km<100) {
				switch (dayTime) {
					case "day":
						price = km*0.09;
						total = price;
						Console.WriteLine(total);
						break;
					case "night":
						price = km*0.09;
						total = price;
						Console.WriteLine(total);
						break;
					default:
						
						break;
				}
			}
			else if (km>100) {
				switch (dayTime) {
					case "day":
						price = km*0.06;
						total = price;
						Console.WriteLine(total);
						break;
					case "night":
						price = km*0.06;
						total = price;
						Console.WriteLine(total);
						break;
					default:
						
						break;
				}
			}
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}