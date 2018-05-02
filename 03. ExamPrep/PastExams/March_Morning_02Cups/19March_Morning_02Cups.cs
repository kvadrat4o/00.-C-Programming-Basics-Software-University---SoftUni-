/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 23/03/2017
 * Time: 09:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace March_Morning_02Cups
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("enter count cups: ");
			double countCups = double.Parse(Console.ReadLine());
			//Console.WriteLine("enter count workers: ");
			double workers = double.Parse(Console.ReadLine());
			//Console.WriteLine("enter work days: ");
			double workDays = double.Parse(Console.ReadLine());
			double money,diff,madeCups,hours,price,priceDiff;
			hours = workDays*workers*8;
			madeCups = Math.Floor(hours/5);
			price = 4.20*madeCups;
			money = countCups*4.20;
			diff = Math.Abs(countCups-madeCups);
			priceDiff = diff*4.20;
			if (countCups<=madeCups) {
				Console.WriteLine("{0:f2} extra money",priceDiff);
			}
			else {
				Console.WriteLine("Loses: {0:f2}",priceDiff);
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}