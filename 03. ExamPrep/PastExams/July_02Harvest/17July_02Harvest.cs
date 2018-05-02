/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 10/04/2017
 * Time: 10:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace July_02Harvest
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("enter sq meters:");
			double sqmt = double.Parse(Console.ReadLine());
			//Console.WriteLine("enter sq meters:");
			double graPersqmt = double.Parse(Console.ReadLine());
			//Console.WriteLine("enter sq meters:");
			double leterWine = double.Parse(Console.ReadLine());
			//Console.WriteLine("enter sq meters:");
			double numWorkers = double.Parse(Console.ReadLine());
			double wine = ((sqmt*graPersqmt)*0.40)/2.50;
			double diff  = Math.Abs(wine-leterWine);
			double winePerWorker = diff/numWorkers;
			if (wine>=leterWine) {
				Console.WriteLine("Good harvest this year! Total wine: {0} liters.\n{1} liters left -> {2} liters per person.",Math.Floor(wine),Math.Ceiling(diff),Math.Ceiling(winePerWorker));
			}
			else {
				Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",Math.Floor(diff));
			}
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}