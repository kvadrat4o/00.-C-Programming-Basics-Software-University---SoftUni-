/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 28/02/2017
 * Time: 12:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BikeRace
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter the count of people in juniors group: ");
			int juniors = int.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the number of people in seniors group: ");
			int seniors = int.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the trace type here: ");
			string trace = Console.ReadLine();
			double trailCost,crosscountryCost,downhillCost,roadCost,totalCost;
			switch (trace)
            {
                case "trail":
					trailCost = (juniors*5.50) + (seniors*7);
					double taxTrail = trailCost*0.05;
					totalCost = Math.Round(trailCost-taxTrail,2);
                    Console.WriteLine("Your winnings are: {0}",totalCost);
                    break;
                case "cross-country":
                    crosscountryCost = (juniors*8) + (seniors*9.50);
                    double taxCrossCountry = crosscountryCost*0.05;
                    totalCost = Math.Round(crosscountryCost-taxCrossCountry,2);
                    Console.WriteLine("Your winnings are: {0}",totalCost);
                    break;
                    case "downhill":
                    downhillCost = (juniors*12.25) + (seniors*13.75);
                    double taxDownhill = downhillCost*0.05;
                    totalCost = Math.Round(downhillCost-taxDownhill,2);
                    Console.WriteLine("Your winnings are: {0}",totalCost);
                    break;
                    case "road":
                    roadCost = (juniors*20) + (seniors*21.50);
                    double taxRoad = roadCost*0.05;
                    totalCost = Math.Round(roadCost-taxRoad,2);
                    Console.WriteLine("Your winnings are: {0}",totalCost);
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
			};
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}