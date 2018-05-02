/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 13/03/2017
 * Time: 18:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SmallShop
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Please Choose product: ");
			string product = Console.ReadLine();
			product = product.ToLower();
			//Console.WriteLine("Please Choose City: ");
			string city = Console.ReadLine();
			city = city.ToLower();
			//Console.WriteLine("Please Choose quantity: ");
			double quantity = double.Parse(Console.ReadLine());
			double price = 0;
			if (city=="sofia")
            {
				switch (product)
                {
				case "coffee":
					price=0.50*quantity;
					Console.WriteLine(price);
				break;
				case "water":
					price=0.80*quantity;
					Console.WriteLine(price);
				break;
				case "beer":
					price=1.20*quantity;
					Console.WriteLine(price);
				break;
				case "peanuts":
					price=1.60*quantity;
					Console.WriteLine(price);
				break;
				case "sweets":
					price=1.45*quantity;
					Console.WriteLine(price);
				break;
				default:Console.WriteLine("Default case");
				break;
				}
			}
			else if(city=="plovdiv")
            {
				switch (product)
                {
				case "coffee":
					price=0.40*quantity;
					Console.WriteLine(price);
				break;
				case "water":
					price=0.70*quantity;
					Console.WriteLine(price);
				break;
				case "beer":
					price=1.15*quantity;
					Console.WriteLine(price);
				break;
				case "peanuts":
					price=1.50*quantity;
					Console.WriteLine(price);
				break;
				case "sweets":
					price=1.30*quantity;
					Console.WriteLine(price);
				break;
				default:Console.WriteLine("Default case");
				break;
				}
			}
			else if(city=="varna")
            {
				switch (product)
                {
				case "coffee":
					price=0.45*quantity;
					Console.WriteLine(price);
				break;
				case "water":
					price=0.70*quantity;
					Console.WriteLine(price);
				break;
				case "beer":
					price=1.10*quantity;
					Console.WriteLine(price);
				break;
				case "peanuts":
					price=1.55*quantity;
					Console.WriteLine(price);
				break;
				case "sweets":
					price=1.35*quantity;
					Console.WriteLine(price);
				break;
				default:Console.WriteLine("Default case");
				break;
				}
			}
		}
	}
}