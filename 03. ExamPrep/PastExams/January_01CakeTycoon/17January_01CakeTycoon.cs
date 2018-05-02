/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 28/03/2017
 * Time: 16:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace January_01CakeTycoon
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Enter number of wanted cakes: ");
			int n = int.Parse(Console.ReadLine());
			//Console.WriteLine("Enter number of kgs flouer per cake: ");
			double c = double.Parse(Console.ReadLine());
			//Console.WriteLine("Enter number of available kgs flouer: ");
			double f = double.Parse(Console.ReadLine());
			//Console.WriteLine("Enter number of amount of truffeles available: ");
			int t = int.Parse(Console.ReadLine());
			//Console.WriteLine("Enter price of one truffel: ");
			int p = int.Parse(Console.ReadLine());
			double cakes,totalFlouer,price,truffCost,reqFlouer;
			// TODO: Implement Functionality Here
			cakes = Math.Floor(f/c);
			totalFlouer = n*c;
			reqFlouer = totalFlouer-f;
			truffCost = t*p;
			price = (truffCost/n)*1.25;
			if (cakes>n) {
				
				Console.WriteLine("All products available, price of a cake: {0:f2}",price);
			}
			else {
				Console.WriteLine("Can make only {0:f2} cakes, need {1:f2} kg more flour",cakes,reqFlouer);
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}