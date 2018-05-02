/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 27/02/2017
 * Time: 14:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace FlowerShop
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter the amount of magnolias: ");
			double magnolias = double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the amount of zumbules: ");
			double zumbules = double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the amount of roses: ");
			double roses = double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the amount of cactuses: ");
			double cactuses = double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the gift price: ");
			double price = double.Parse(Console.ReadLine());
			
			double countMagnolias = magnolias*3.25;
			double countZumbules = zumbules*4;
			double countRoses = roses*3.50;
			double countCactuses = cactuses*8;
			double sum = countCactuses+countMagnolias+countRoses+countZumbules;
			double finalSum = sum-0.05*sum;
			double difference = price-finalSum;
			if(finalSum>price) {
				difference = finalSum-price;
				difference = Math.Floor(difference);
				Console.WriteLine("She is left with {0} leva.",difference);
			}
			else {
				difference = (Math.Ceiling(difference));
				Console.WriteLine("She will have to borrow {0} leva.",difference);
			};
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}