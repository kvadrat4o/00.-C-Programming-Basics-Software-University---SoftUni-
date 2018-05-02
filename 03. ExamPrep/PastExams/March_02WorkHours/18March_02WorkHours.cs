/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 21/03/2017
 * Time: 12:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace March_02WorkHours
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("enter requested hours: ");
			int reqHours = int.Parse(Console.ReadLine());
			//Console.WriteLine("enter number of workers: ");
			int numWorkers = int.Parse(Console.ReadLine());
			//Console.WriteLine("enter working days number: ");
			int workDays = int.Parse(Console.ReadLine());
			// TODO: Implement Functionality Here
			int penalties,hours,diff;
			hours = numWorkers*workDays*8;
			diff = Math.Abs(reqHours-hours);
			penalties = diff*workDays;
			if (hours>reqHours) {
					Console.WriteLine("{0} hours left",diff);
			}
			else {
					Console.WriteLine("{0} overtime \nPenalties: {1}",diff,penalties);
				}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}