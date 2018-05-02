/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 27/02/2017
 * Time: 13:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace House_Price
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter the area of the smallest room in your apartment: ");
			double small = double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the area of the kitchen in your apartment: ");
			double kitchen = double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the price per suare meter: ");
			double price = double.Parse(Console.ReadLine());
			
			double bath = 0.50*small;
			double second = (small+0.10*small);
			double third = (second+0.10*second);
			double sum = small+kitchen+second+third+bath;
			double corridor = 0.050*sum;
			double area = Math.Round(corridor+sum,2);
			double priceArea = Math.Round(area*price,2);
			Console.WriteLine("The price for an apartment with {0} square meters area is {1}",area,priceArea);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}