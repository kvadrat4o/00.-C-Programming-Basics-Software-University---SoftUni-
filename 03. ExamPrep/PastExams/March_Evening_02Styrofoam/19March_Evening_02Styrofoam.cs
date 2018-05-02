/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 23/03/2017
 * Time: 11:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace March_Evening_02Styrofoam
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("enter budget: ");
			double budget = double.Parse(Console.ReadLine());
			//Console.WriteLine("enter house area: ");
			double houseArea = double.Parse(Console.ReadLine());
			//Console.WriteLine("enter num windows: ");
			double numWindows = double.Parse(Console.ReadLine());
			//Console.WriteLine("enter how many square meters are there in one packet styrofoam: ");
			double sqmPacket = double.Parse(Console.ReadLine());
			//Console.WriteLine("enter price for a packet of styropor: ");
			double styroPrice = double.Parse(Console.ReadLine());
			double winArea,losses,usefulArea,countPacks,totalArea,packPrice,diff,left;
			winArea = 2.4*numWindows;
			usefulArea = houseArea-2.4*numWindows;
			losses = 0.10*(houseArea-2.4*numWindows);
			totalArea = houseArea-2.4*numWindows+0.10*(houseArea-2.4*numWindows);
			countPacks = Math.Ceiling((houseArea-2.4*numWindows+0.10*(houseArea-2.4*numWindows))/sqmPacket);
			packPrice = countPacks*styroPrice;
			diff = Math.Abs(packPrice-budget);
			left = packPrice-diff;
			if (packPrice<budget) {
				Console.WriteLine("Spent: {0:f2}\nLeft: {1:f2}",packPrice,diff);
			}
			else {
				Console.WriteLine("Need more: {0:f2}",diff);
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}