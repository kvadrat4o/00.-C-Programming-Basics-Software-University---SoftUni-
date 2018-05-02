/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 19/04/2017
 * Time: 09:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace August_01DailyProfit
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("enter working days:");
			double workDays = double.Parse(Console.ReadLine());
			//Console.WriteLine("enter money per day:");
			double moneyPerDay = double.Parse(Console.ReadLine());
			//Console.WriteLine("enter USD?BGN exchange rate:");
			double exchangeRate = double.Parse(Console.ReadLine());
			double yearSalary,tax,clearProfit,profitPerDay;
			yearSalary = (workDays*moneyPerDay)*12+(workDays*moneyPerDay)*2.50;
			tax = yearSalary*0.25;
			clearProfit = (yearSalary-tax)*exchangeRate;
			profitPerDay = clearProfit/365.00;
			Console.WriteLine("{0:F2}",profitPerDay);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}