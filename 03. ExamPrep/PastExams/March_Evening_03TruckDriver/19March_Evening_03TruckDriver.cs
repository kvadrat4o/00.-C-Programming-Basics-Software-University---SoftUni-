/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 23/03/2017
 * Time: 11:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace March_Evening_03TruckDriver
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("enter season: ");
			string season = Console.ReadLine().ToLower();
			//Console.WriteLine("enter kilometers per month: ");
			double kmPerMonth = double.Parse(Console.ReadLine());
			double price,salary,taxes,finalSum;
			
			if (kmPerMonth<=5000) {
				switch (season) {
					case "summer":
						price = 0.90;
						salary = (kmPerMonth*price)*4;
						taxes = 0.10*salary;
						finalSum = salary-taxes;
						Console.WriteLine("{0:f2}",finalSum);
						break;
					case "winter":
						price = 1.05;
						salary = (kmPerMonth*price)*4;
						taxes = 0.10*salary;
						finalSum = salary-taxes;
						Console.WriteLine("{0:f2}",finalSum);
						break;
					case "autumn":
						price = 0.75;
						salary = (kmPerMonth*price)*4;
						taxes = 0.10*salary;
						finalSum = salary-taxes;
						Console.WriteLine("{0:f2}",finalSum);
						break;
					case "spring":
						price = 0.75;
						salary = (kmPerMonth*price)*4;
						taxes = 0.10*salary;
						finalSum = salary-taxes;
						Console.WriteLine("{0:f2}",finalSum);
						break;
					default:
						break;
				}
			}
			else if (kmPerMonth>5000&&kmPerMonth<=10000) {
				switch (season) {
					case "summer":
						price = 1.10;
						salary = (kmPerMonth*price)*4;
						taxes = 0.10*salary;
						finalSum = salary-taxes;
						Console.WriteLine("{0:f2}",finalSum);
						break;
					case "winter":
						price = 1.25;
						salary = (kmPerMonth*price)*4;
						taxes = 0.10*salary;
						finalSum = salary-taxes;
						Console.WriteLine("{0:f2}",finalSum);
						break;
					case "autumn":
						price = 0.95;
						salary = (kmPerMonth*price)*4;
						taxes = 0.10*salary;
						finalSum = salary-taxes;
						Console.WriteLine("{0:f2}",finalSum);
						break;
					case "spring":
						price = 0.95;
						salary = (kmPerMonth*price)*4;
						taxes = 0.10*salary;
						finalSum = salary-taxes;
						Console.WriteLine("{0:f2}",finalSum);
						break;
					default:
						break;
				}
			}
			else if (kmPerMonth>10000&&kmPerMonth<=20000) {
				switch (season) {
					case "summer":
						price = 1.45;
						salary = (kmPerMonth*price)*4;
						taxes = 0.10*salary;
						finalSum = salary-taxes;
						Console.WriteLine("{0:f2}",finalSum);
						break;
					case "winter":
						price = 1.45;
						salary = (kmPerMonth*price)*4;
						taxes = 0.10*salary;
						finalSum = salary-taxes;
						Console.WriteLine("{0:f2}",finalSum);
						break;
					case "autumn":
						price = 1.45;
						salary = (kmPerMonth*price)*4;
						taxes = 0.10*salary;
						finalSum = salary-taxes;
						Console.WriteLine("{0:f2}",finalSum);
						break;
					case "spring":
						price = 1.45;
						salary = (kmPerMonth*price)*4;
						taxes = 0.10*salary;
						finalSum = salary-taxes;
						Console.WriteLine("{0:f2}",finalSum);
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