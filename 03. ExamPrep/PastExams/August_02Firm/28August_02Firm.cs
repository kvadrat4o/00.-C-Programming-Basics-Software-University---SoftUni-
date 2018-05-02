/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 19/04/2017
 * Time: 09:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace August_02Firm
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("enter required days");
			double hours = double.Parse(Console.ReadLine());
			//Console.WriteLine("enter num days");
			double days = double.Parse(Console.ReadLine());
			//Console.WriteLine("enter num workers in the firm");
			double numworkers = double.Parse(Console.ReadLine());
			// TODO: Implement Functionality Here
			double learnings,totalhours,extraWork,totalH,diff;
			learnings = days*0.10;
			totalhours = (days - days*0.10)*8.00;
			extraWork = 2*days*numworkers;
			totalH = Math.Floor(extraWork+totalhours);
			diff = Math.Abs(totalH-hours);
			if (totalH>=hours) {
				Console.WriteLine("Yes!{0} hours left.",diff);
			}
			else {
				Console.WriteLine("Not enough time!{0} hours needed.",diff);
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}