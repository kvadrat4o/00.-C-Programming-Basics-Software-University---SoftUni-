/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 14/03/2017
 * Time: 11:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Volleyball
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Enter type of the year: ");
			string typeYear = Console.ReadLine().ToLower();
			//Console.WriteLine("Enter number of holidays in the year: ");
			double p = double.Parse(Console.ReadLine());
			//Console.WriteLine("Enter number of weekends, that you traverl: ");
			double h = double.Parse(Console.ReadLine());
			double playedVolley = 0;
			double numWeekends = 48;
			double sofiaWeekends=numWeekends-h;
			double homeTownWeekends = numWeekends-sofiaWeekends;
			double holidayPlay = 0;
			double leaPercent = 0;
			double sum = 0;
			if (typeYear=="normal")
            {
				sofiaWeekends = (numWeekends-h)*3.0/4;
				holidayPlay = p*2.0/3;
				playedVolley = sofiaWeekends+holidayPlay+homeTownWeekends;
				Console.WriteLine(Math.Floor(Math.Round(playedVolley,2)));
			}
			else if (typeYear=="leap")
            {
				sofiaWeekends = (numWeekends-h)*3.0/4;
				holidayPlay = p*2.0/3;
				playedVolley = sofiaWeekends+holidayPlay+homeTownWeekends;
				leaPercent = (15*(sofiaWeekends+holidayPlay+homeTownWeekends+leaPercent))/100;
				sum = leaPercent+playedVolley;
				Console.WriteLine(Math.Floor(Math.Round(sum,2)));
			}
		}
	}
}