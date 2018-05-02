/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 14/03/2017
 * Time: 09:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace FruitShop
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Enter fruit type: ");
			string fruit = Console.ReadLine().ToLower();
			//Console.WriteLine("Enter day of the week: ");
			string weekDay = Console.ReadLine().ToLower();
			//Console.WriteLine("Enter quantity: ");
			double quantity = double.Parse(Console.ReadLine());
			double price = -1.0;
			if ((weekDay=="monday")||(weekDay=="tuesday")||(weekDay=="wednesday")||(weekDay=="thursday")||(weekDay=="friday")) {
				switch (fruit)
                {
					case "banana":
						price = 2.50*quantity;
						Console.WriteLine(Math.Round(price,2));
					break;
					case "apple":
						price = 1.20*quantity;
						Console.WriteLine(Math.Round(price,2));
					break;
					case "orange":
						price = 0.85*quantity;
						Console.WriteLine(Math.Round(price,2));
					break;
					case "grapefruit":
						price = 1.45*quantity;
						Console.WriteLine(Math.Round(price,2));
					break;
					case "kiwi":
						price = 2.70*quantity;
						Console.WriteLine(Math.Round(price,2));
					break;
					case "grapes":
						price = 3.85*quantity;
						Console.WriteLine(Math.Round(price,2));
					break;
					case "pineapple":
						price = 5.50*quantity;
						Console.WriteLine(Math.Round(price,2));
					break;
					default:
						Console.WriteLine("error");
					break;
				}
			}
			else if ((weekDay=="saturday")||(weekDay=="sunday"))
            {
				switch (fruit)
                {
					case "banana":
						price = 2.70*quantity;
						Console.WriteLine(Math.Round(price,2));
					break;
					case "apple":
						price = 1.25*quantity;
						Console.WriteLine(Math.Round(price,2));
					break;
					case "orange":
						price = 0.90*quantity;
						Console.WriteLine(Math.Round(price,2));
					break;
					case "grapefruit":
						price = 1.60*quantity;
						Console.WriteLine(Math.Round(price,2));
					break;
					case "kiwi":
						price = 3.00*quantity;
						Console.WriteLine(Math.Round(price,2));
					break;
					case "grapes":
						price = 4.20*quantity;
						Console.WriteLine(Math.Round(price,2));
					break;
					case "pineapple":
						price = 5.60*quantity;
						Console.WriteLine(Math.Round(price,2));
					break;
					default:
						Console.WriteLine("error");
					break;
				}
			}
			else
            {
				Console.WriteLine("error");
			}
		}
	}
}