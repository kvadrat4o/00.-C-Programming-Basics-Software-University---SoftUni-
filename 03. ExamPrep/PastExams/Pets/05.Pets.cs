/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 27/02/2017
 * Time: 15:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Pets
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter here the amount of days you are going to be away: ");
			int days = int.Parse(Console.ReadLine());
			Console.WriteLine("Please enter here the amount of petfood in kilograms: ");
			int leftFood = int.Parse(Console.ReadLine());
			Console.WriteLine("Please enter here the amount of dogfood for day in kilograms: ");
			double dogFood = double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter here the amount of catfood for day in kilograms: ");
			double catFood = double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter here the amount of turtlefood for day in grams: ");
			double turtleFood = double.Parse(Console.ReadLine());
			
			double totalDogFood = days*dogFood;
			double totalCatFood = days*catFood;
			double totalTurtleFood = (days*turtleFood)/1000;
			double totalFood = totalCatFood+totalDogFood+totalTurtleFood;
			double difference  = leftFood-totalFood;
			if (totalFood>leftFood) {
				difference = Math.Ceiling(totalFood-leftFood);
				Console.WriteLine("{0} more kilos of food are needed.",difference);
			}
			else {
				difference = Math.Floor(difference);
				Console.WriteLine("{0} kilos of food left.",difference);
			};
				
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}