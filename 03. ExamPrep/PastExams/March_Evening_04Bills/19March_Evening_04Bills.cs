/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 23/03/2017
 * Time: 11:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace March_Evening_04Bills
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter number of months: ");
			int monthsNum = int.Parse(Console.ReadLine());
			double electricity,internet,water,sumElectricity,sumWater,other,sumOther,sumInternet,sumAvg,totalSum;
			water = 20;
			internet = 15;
			sumElectricity=0;
			sumInternet=0;
			sumWater=0;
			sumOther=0;
			for (int i = 0; i <monthsNum; i++) {
				
				electricity = double.Parse(Console.ReadLine());
				sumElectricity+=electricity;
				//totalSum = sumInternet+sumElectricity+sumWater;
				//taxes = 0.20*totalSum;
				other = internet+electricity+water+0.20*(internet+electricity+water);
				sumOther = sumOther + other;
			}
			sumWater = monthsNum*water;
			sumInternet = monthsNum*internet;
			sumAvg = (sumElectricity+sumInternet+sumWater+sumOther)/monthsNum;
			Console.WriteLine("Electricity: {0:f2} lv\nWater: {1:f2} lv\nInternet: {2:f2} lv\nOther: {3:f2} lv\nAverage: {4:f2} lv",sumElectricity,sumWater,sumInternet,sumOther,sumAvg);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}